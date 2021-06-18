using System;
using System.Linq;
using System.Collections.Generic;
using ConsoleApp.Object;
using ConsoleApp.Structure;
using ConsoleApp.ExternalFileManipulation;

namespace ConsoleApp
{
    public class Principal
    {
        #region Constantes

        private const string GENERAL_ERROR = "Erro! Contate o administrador do sistema.";
        private const string FORMAT_MESSAGE_ERROR = "Erro! Formato de entrada inválido";
        private const string INVALID_DATE_MESSAGE_ERROR = "Erro! A data informada é inválida.";
        private const string NOT_FOUND_CPF_ERROR = "Nenhuma pessoa encontrada para o CPF informado!";
        private const string DUPLICATE_CPF_ERROR = "Erro! Identificamos que o CPF já está vinculado a uma pessoa do sistema.";

        #endregion

        public static void Main(string[] args)
        {
            #region Variáveis

            // Objeto de leitura e gravação em arquivos no formato CSV
            CsvFile csvFile = new CsvFile(false);

            // Árvores e Lista necessária para guardar a Pessoa, Nome, CPF e RG.
            AVLTree<string> names = new AVLTree<string>();
            AVLTree<long> cpfs = new AVLTree<long>();
            AVLTree<DateTime> datesBirth = new AVLTree<DateTime>();
            List<Person> people = new List<Person>();

            // Variáveis para tratar as escolhas do usuário.
            int option;

            #endregion

            Console.WriteLine(LoadDatas(csvFile, names, cpfs, datesBirth, people));
            System.Threading.Thread.Sleep(1500);

            bool executar = true;
            while (executar)
            {
                option = ShowInitMenu();
                ExecuteOptionSelected(option, names, cpfs, datesBirth, people, out executar);
            }

            Console.WriteLine("Salvando os dados...");
            Console.WriteLine(UnLoadDatas(csvFile, people));
            System.Threading.Thread.Sleep(1500);

            Console.WriteLine("Fechando o aplicativo...");
            System.Threading.Thread.Sleep(1000);
        }

        #region Menus

        /// <summary>
        /// Exibe o menu principal.
        /// </summary>
        /// <returns>Opção escolhida pelo usuário</returns>
        private static int ShowInitMenu()
        {
            Console.Clear();
            Console.WriteLine(("--- MENU-PRINCIPAL ---\n\n").PadLeft(45) +
                "[1] - ADICIONAR PESSOA\n" +
                "[2] - BUSCAR PESSOA\n" +
                "[3] - DELETAR PESSOA\n" +
                "[4] - IMPRIMIR A ÁRVORE\n" +
                "[0] - FECHAR O APLICATIVO\n");

            return ValidateOption("Digite o valor correspondente a opção desejada: ", 4, 0);
        }

        /// <summary>
        /// Exibe a tela relacionada à opção escolhida pelo usuário
        /// </summary>
        /// <param name="option">Opção selecinoada pelo usuário no Menu Principal (ShowInitMenu)</param>
        private static void ExecuteOptionSelected(
            int option, 
            AVLTree<string> names, 
            AVLTree<long> cpfs, 
            AVLTree<DateTime> datesBirth, 
            List<Person> people,
            out bool executar)
        {
            executar = true;

            Console.Clear();
            switch(option)
            {
                case 0: // Fechar o aplicativo
                    Console.WriteLine(("--- FECHANDO O APLICATIVO ---\n").PadLeft(45));
                    executar = false;
                    break;

                case 1: // Adicionar Pessoa
                    Console.WriteLine(("--- NOVA PESSOA ---\n").PadLeft(45));
                    Person personCreated = ShowCreatePersonMenu(cpfs);

                    if(personCreated == null)
                    {
                        Console.WriteLine(DUPLICATE_CPF_ERROR);
                        break;
                    }

                    names.InsertNode(new ElementData<string>(personCreated.Name, personCreated));
                    cpfs.InsertNode(new ElementData<long>(personCreated.Cpf, personCreated));
                    datesBirth.InsertNode(new ElementData<DateTime>(personCreated.DateBirthday, personCreated));
                    people.Add(personCreated);

                    Console.WriteLine($"Nova pessoa cadastrada com sucesso, veja abaixo:\n\n" +
                        $"{personCreated.ToString()}");
                    break;

                case 2: // Buscar Pessoa
                    Console.WriteLine(("--- BUSCAR PESSOA ---\n").PadLeft(45));
                    var peopleQuery = ShowQueryPersonMenu(names, cpfs, datesBirth);

                    Console.WriteLine((peopleQuery.Any() ? "Pessoas encontradas:" : "Nenhuma pessoa foi encontrada para a propriedade informada!") + "\n");
                    foreach (Person person in peopleQuery)
                    {
                        Console.WriteLine(person.ToString() + "\n");
                    }
                    break;

                case 3: // Deletar Pessoa
                    Console.WriteLine(("--- DELETAR PESSOA ---\n").PadLeft(45));
                    Person personDeleted = ShowDeletePersonMenu(cpfs);

                    if(personDeleted != null)
                    {
                        names.DeleteNode(new ElementData<string>(personDeleted.Name));
                        cpfs.DeleteNode(new ElementData<long>(personDeleted.Cpf));
                        datesBirth.DeleteNode(new ElementData<DateTime>(personDeleted.DateBirthday));
                        people.Remove(personDeleted);

                        Console.WriteLine($"Pessoa deleteda:\n\n{personDeleted.ToString()}");
                    }
                    else
                    {
                        Console.WriteLine(NOT_FOUND_CPF_ERROR);
                    }
                    break;

                case 4: // Imprimir a Árvore
                    Console.WriteLine(("--- ÁRVORE DE PESSOAS ---\n").PadLeft(45));
                    int filterSelected = ShowFiltersMenu();

                    switch (filterSelected)
                    {
                        case 1:
                            Console.WriteLine("Árvore de Nomes:");
                            names.PrintTree();
                            break;

                        case 2:
                            Console.WriteLine("Árvore de CPF:");
                            cpfs.PrintTree();
                            break;

                        case 3:
                            Console.WriteLine("Árvore de Datas de Nascimento:");
                            datesBirth.PrintTree();
                            break; ;

                        default: // Erro (não deve cair aqui)
                            Console.WriteLine(GENERAL_ERROR);
                            break;
                    }
                    break;

                default: // Erro (não deve cair aqui)
                    Console.WriteLine(($"--- {GENERAL_ERROR} ---\n").PadLeft(45));
                    break;
            }

            if(option != 0)
            {
                Console.Write("\nTecle enter para voltar ao menu principal...");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Exibe a tela de criação de pessoa.
        /// </summary>
        /// <returns></returns>
        private static Person ShowCreatePersonMenu(AVLTree<long> cpfs)
        {
            #region objetos e variáveis necessários
            Person person = new Person();
            string stringValidate;
            long longValidate;
            DateTime dateValidate;
            #endregion

            Console.Write("Digite o nome da pessoa: ");
            person.SetName(Console.ReadLine().Trim());

            do
            {
                Console.Write("Digite o CPF da pessoa: ");
                stringValidate = Console.ReadLine();
                longValidate = Person.FormatCpfToLong(stringValidate);

                if (longValidate == 0)
                {
                    Console.WriteLine(FORMAT_MESSAGE_ERROR);
                }
            } while (longValidate == 0);
            person.SetCpf(longValidate);

            // Validação para não permitir registro duplicado.
            var cpfCadastrado = cpfs.FindNode(new ElementData<long>(person.Cpf));
            if (cpfCadastrado != null)
            {
                return null;
            }

            do
            {
                Console.Write("Digite o RG da pessoa: ");
                stringValidate = Console.ReadLine();
                longValidate = Person.FormatRgToLong(stringValidate);

                if(longValidate == 0)
                {
                    Console.WriteLine(FORMAT_MESSAGE_ERROR);
                }
            } while (longValidate == 0);
            person.SetRg(longValidate);

            do
            {
                Console.Write("Digite a data de nascimento da pessoa [DD/MM/AAAA]: ");
                dateValidate = Person.FormatStringToDateTime(Console.ReadLine());

                if(dateValidate == DateTime.MinValue)
                {
                    Console.WriteLine(FORMAT_MESSAGE_ERROR);
                }
                else if(dateValidate > DateTime.Now)
                {
                    Console.WriteLine(INVALID_DATE_MESSAGE_ERROR);
                    dateValidate = DateTime.MinValue;
                }
            } while (dateValidate == DateTime.MinValue);
            person.SetDateBirthday(dateValidate);

            Console.Write("Digte o nome da cidade natal da pessoa: ");
            person.SetCityBirth(Console.ReadLine().Trim());

            return person;
        }

        /// <summary>
        /// Exibe o menu de formatos de consulta (Nome, CPF, Data de nascimento)
        /// e realiza a consulta pela propriedade escolhida.
        /// </summary>
        /// <returns>Lista de pessoas encontradas para a propriedade</returns>
        private static List<Person> ShowQueryPersonMenu(AVLTree<string> names, AVLTree<long> cpfs, AVLTree<DateTime> datesBirth)
        {
            var peopleFound = new List<Person>();
            int filterSelected = ShowFiltersMenu();

            Console.Clear();
            switch (filterSelected)
            {
                case 1: // Nome
                    Console.Write(("--- BUSCAR PESSOAS POR NOME ---\n\n").PadLeft(45) +
                        "Digite o nome da pessoa [deixe em branco para buscar todas]: ");

                    string name = Console.ReadLine().Trim();

                    var nodesFoundByName = names.FindNodes(new ElementData<string>(name));

                    foreach(var node in nodesFoundByName)
                    {
                        if(node != null)
                        {
                            peopleFound.Add(node.Element.PersonReference);
                        }
                    }

                    return peopleFound;

                case 2: // CPF
                    Console.WriteLine(("--- BUSCAR PESSOA POR CPF ---\n").PadLeft(45));

                    long cpf;
                    do
                    {
                        Console.Write("Digite o CPF da pessoa: ");
                        cpf = Person.FormatCpfToLong(Console.ReadLine());

                        if (cpf == 0)
                        {
                            Console.WriteLine(FORMAT_MESSAGE_ERROR);
                        }
                    } while (cpf == 0);

                    var nodeFoundByCpf = cpfs.FindNode(new ElementData<long>(cpf));

                    if(nodeFoundByCpf != null)
                    {
                        peopleFound.Add(nodeFoundByCpf.Element.PersonReference);
                    }

                    return peopleFound;

                case 3: // Data de Nascimento
                    Console.WriteLine(("BUSCAR PESSOAS POR NASCIMENTO").PadLeft(45));

                    DateTime minDate, maxDate;

                    do
                    {
                        Console.Write("Digite a data minima de nascimento para a busca: ");
                        minDate = Person.FormatStringToDateTime(Console.ReadLine());

                        if (minDate == DateTime.MinValue)
                        {
                            Console.WriteLine(FORMAT_MESSAGE_ERROR);
                        }
                    } while (minDate == DateTime.MinValue);

                    do
                    {
                        Console.Write("Digite a data máxima de nascimento para a busca: ");
                        maxDate = Person.FormatStringToDateTime(Console.ReadLine());

                        if (maxDate == DateTime.MinValue)
                        {
                            Console.WriteLine(FORMAT_MESSAGE_ERROR);
                        }
                    } while (maxDate == DateTime.MinValue);


                    var nodesFoundByDateBirth = datesBirth.FindNodes(new ElementData<DateTime>(minDate, maxDate));

                    foreach(var node in nodesFoundByDateBirth)
                    {
                        if(node != null)
                        {
                            peopleFound.Add(node.Element.PersonReference);
                        }
                    }

                    return peopleFound;

                default: // Erro (não deve cair aqui)
                    Console.WriteLine(($"--- {GENERAL_ERROR} ---").PadLeft(45));
                    return null;
            }
        }

        /// <summary>
        /// Exibe o menu de deleção de pessoa.
        /// </summary>
        /// <param name="cpfs">Valor do CPF da pessoa a ser deletada</param>
        /// <returns>Pessoa a ser deletada</returns>
        private static Person ShowDeletePersonMenu(AVLTree<long> cpfs)
        {
            long cpfValidate;
            do
            {
                Console.Write("Digite o CPF da pessoa a ser deletada: ");
                cpfValidate = Person.FormatCpfToLong(Console.ReadLine());

                if (cpfValidate == 0)
                {
                    Console.WriteLine(FORMAT_MESSAGE_ERROR);
                }
            } while (cpfValidate == 0);

            var peopleFound = cpfs.FindNode(new ElementData<long>(cpfValidate))?.Element.PersonReference;

            return peopleFound;
        }

        /// <summary>
        /// Exibe o menu de escolha dos tipos de filtros disponíveis.
        /// </summary>
        /// <returns>valor da opção escolhida</returns>
        private static int ShowFiltersMenu()
        {
            Console.WriteLine(
                "[1] - NOME\n" +
                "[2] - CPF\n" +
                "[3] - DATA DE NASCIMENTO\n");

            return ValidateOption("Escolha a opção de filtro para a consulta: ", 3, 1);
        }

        #endregion

        #region Métodos Auxiliares para validações e tratamentos.

        /// <summary>
        /// Validar a opção escolhida pelo usuario
        /// </summary>
        /// <param name="msg">Mensagem a ser exibida em tela</param>
        /// <param name="max">Valor máximo permitido</param>
        /// <param name="min">Valor mínimo permitido</param>
        /// <returns></returns>
        private static int ValidateOption(string msg, int max = 0, int min = 0)
        {
            int input, validator = min - 1;

            do
            {
                try
                {
                    Console.Write(msg);
                    input = Convert.ToInt32(Console.ReadLine());

                    if (min != max && (input < min || input > max))
                    {
                        throw new ArgumentException();
                    }
                }
                catch (FormatException)
                {
                    input = validator;
                    Console.WriteLine(FORMAT_MESSAGE_ERROR);
                }
                catch (ArgumentException)
                {
                    input = validator;
                    Console.WriteLine($"Opção inválida! Você deve digitar um valor entre {min} e {max}.");
                }
            } while (input == validator);

            return input;
        }

        #endregion

        #region Métodos para carregar e descarregar os dados do arquivo

        /// <summary>
        /// Carregar as informações através da leitura do arquivo disponibilizado.
        /// </summary>
        /// <returns>Mensagens de erro ou string vazia, para o caso de não ocorrerem erros</returns>
        private static string LoadDatas(
            CsvFile csvFile, 
            AVLTree<string> names,
            AVLTree<long> cpfs,
            AVLTree<DateTime> datesBirth,
            List<Person> people)
        {
            #region Bloco de Configurações do Arquivo
            Console.WriteLine(("CONFIGURAÇÕES DO ARQUIVO EXTERNO\n").PadLeft(40));

            Console.Write("Digite o caminho (path) do arquivo [ex.: C:\\Users\\Teste\\Documents\\]: ");
            csvFile.SetFilePath(Console.ReadLine().Trim());

            Console.Write("\nDigite o nome do arquivo [ex.: Arquivo]: ");
            csvFile.SetFileName(Console.ReadLine().Trim());

            Console.Write("\nDigite a extensão do arquivo [ex.: txt]: ");
            csvFile.SetFileExtension(Console.ReadLine().Trim());
            #endregion

            (string content, bool statusOk) = csvFile.Reader();
            if (!statusOk)
            {
                return content;
            }

            string[] contentSplit = content.Split(';');
            int position = 0;
            string cpf, rg, name, dateBirth, cityBirth;
            while(position < contentSplit.Length - 1)
            {
                cpf = contentSplit[position++];
                rg = contentSplit[position++];
                name = contentSplit[position++];
                dateBirth = contentSplit[position++];
                cityBirth = contentSplit[position++];

                Person person = new Person(cpf, rg, name, dateBirth, cityBirth);
                names.InsertNode(new ElementData<string>(name, person));
                cpfs.InsertNode(new ElementData<long>(Person.FormatCpfToLong(cpf), person));
                datesBirth.InsertNode(new ElementData<DateTime>(Person.FormatStringToDateTime(dateBirth), person));
                people.Add(person);                
            }

            return string.Empty;
        }

        /// <summary>
        /// Descarrega as informações através da gravação no arquivo disponibilizado.
        /// </summary>
        /// <returns>Mensagens de erro ou string vazia, para o caso de não ocorrerem erros</returns>
        private static string UnLoadDatas(
            CsvFile csvFile,
            List<Person> people)
        {
            string content = null;
            foreach(Person person in people)
            {
                content += Person.FormatCpfToString(person.Cpf) + ";";
                content += Person.FormatRgToString(person.Rg) + ";";
                content += person.Name + ";";
                content += Person.FormatDateTimeToString(person.DateBirthday) + ";";
                content += person.CityBirth + ";";
            }

            return csvFile.Writer(content, Person.TOT_PROPERTIES);
        }

        #endregion
    }
}