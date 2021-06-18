using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ConsoleApp.Object;
using ConsoleApp.Structure;
using ConsoleApp.ExternalFileManipulation;
using System.Linq;

namespace WindowsApp.Forms
{
    public partial class Form3 : Form
    {
        #region Atributes
        public Form2 PreviousForm { get; private set; }

        public CsvFile CsvFile { get; set; }
        public AVLTree<string> Names { get; set; }
        public AVLTree<long> Cpfs { get; set; }
        public AVLTree<DateTime> DatesBirth { get; set; }
        public List<Person> People { get; set; }
        #endregion

        /// <summary>
        /// Construtor do Form2.
        /// </summary>
        public Form3(CsvFile csvFile, AVLTree<string> names, AVLTree<long> cpfs, AVLTree<DateTime> datesBirth, List<Person> people, Form2 previousForm)
        {
            InitializeComponent();
            this.CsvFile = csvFile;
            this.Names = names;
            this.Cpfs = cpfs;
            this.DatesBirth = datesBirth;
            this.People = people;
            this.PreviousForm = previousForm;
        }

        /// <summary>
        /// Método para executar os dados de carregamento do Form<br/>
        /// (não utilizado)
        /// </summary>
        private void Form3_Load(object sender, EventArgs e)
        {
            btnConfirmAddPerson.Enabled = false;
            outputMessageOk.Text = string.Empty;
            outputMessageError.Text = string.Empty;
        }

        /// <summary>
        /// Ação executada ao alterar o valor do campo Nome.
        /// </summary>
        private void inputPersonName_TextChanged(object sender, EventArgs e)
        {
            ValidateRequiredFields();
        }

        /// <summary>
        /// Método para validar a entrada do usuário para o valor de CPF
        /// </summary>
        private void inputPersonCpf_TextChanged(object sender, EventArgs e)
        {
            var longValidate = Person.FormatCpfToLong(inputPersonCpf.Text);

            if (longValidate == 0)
            {
                inputPersonRg.Enabled = false;
                inputPersonDateBirth.Enabled = false;
                inputPersonCityBirth.Enabled = false;
                btnConfirmAddPerson.Enabled = false;
                outputMessageError.Text = "Erro! Formato inválido para o CPF informado!";
            }
            else
            {
                var cpfJaCadastrado = Cpfs.FindNode(new ElementData<long>(longValidate));
                if(cpfJaCadastrado != null)
                {
                    inputPersonRg.Enabled = false;
                    inputPersonDateBirth.Enabled = false;
                    inputPersonCityBirth.Enabled = false;
                    btnConfirmAddPerson.Enabled = false;
                    outputMessageError.Text = "Erro! CPF já cadastrado no sistema!";
                }
                else
                {
                    inputPersonRg.Enabled = true;
                    inputPersonDateBirth.Enabled = true;
                    inputPersonCityBirth.Enabled = true;
                    outputMessageError.Text = string.Empty;
                }
            }

            ValidateRequiredFields();
        }

        /// <summary>
        /// Método para validar a entrada do usuário para o valor de RG
        /// </summary>
        private void inputPersonRg_TextChanged(object sender, EventArgs e)
        {
            var longValidate = Person.FormatRgToLong(inputPersonRg.Text);

            if (longValidate == 0)
            {
                inputPersonDateBirth.Enabled = false;
                inputPersonCityBirth.Enabled = false;
                btnConfirmAddPerson.Enabled = false;
                outputMessageError.Text = "Erro! Formato inválido para o RG informado!";
            }
            else
            {
                inputPersonDateBirth.Enabled = true;
                inputPersonCityBirth.Enabled = true;
                outputMessageError.Text = string.Empty;
            }

            ValidateRequiredFields();
        }

        /// <summary>
        /// Método para formatar e validar a entrada do usuário para o valor de DateBirth
        /// </summary>
        private void inputPersonDateBirth_TextChanged(object sender, EventArgs e)
        {
            var text = inputPersonDateBirth.Text;
            if(text.Length == 8 && text.Count(c => c == '/') == 0)
            {
                text = text.Substring(0, 2) + "/" + text.Substring(2, 2) + "/" + text.Substring(4, 4);
                inputPersonDateBirth.Text = text;
            }
            else if((text.Length == 3 || text.Length == 6) && text.Substring(text.Length - 1) != "/")
            {
                text = text.Substring(0, text.Length - 1) + "/" + text.Substring(text.Length - 1);
                inputPersonDateBirth.Text = text;
                inputPersonDateBirth.Select(inputPersonDateBirth.Text.Length, 0);
            }
            else
            {
                if(text.Length != 10)
                {
                    inputPersonCityBirth.Enabled = false;
                    btnConfirmAddPerson.Enabled = false;
                    outputMessageError.Text = "Erro! Formato inválido para a data de nascimento!";
                }
                else
                {
                    var dateValidate = Person.FormatStringToDateTime(text);

                    if (dateValidate == DateTime.MinValue || dateValidate > DateTime.Now)
                    {
                        inputPersonCityBirth.Enabled = false;
                        btnConfirmAddPerson.Enabled = false;
                        outputMessageError.Text = "Erro! Data de nascimento inválida!";
                    }
                    else
                    {
                        inputPersonCityBirth.Enabled = true;
                        outputMessageError.Text = string.Empty;
                    }
                }
            }

            ValidateRequiredFields();
        }

        /// <summary>
        /// Ação executada ao alterar o valor do campo Cidade de Nascimento.
        /// </summary>
        private void inputPersonCityBirth_TextChanged(object sender, EventArgs e)
        {
            ValidateRequiredFields();
        }

        /// <summary>
        /// Validar se os campos foram preenchidos.
        /// </summary>
        private void ValidateRequiredFields()
        {
           if(string.IsNullOrWhiteSpace(inputPersonName.Text) 
                || string.IsNullOrWhiteSpace(inputPersonCpf.Text) 
                || string.IsNullOrWhiteSpace(inputPersonRg.Text) 
                || string.IsNullOrWhiteSpace(inputPersonDateBirth.Text) 
                || string.IsNullOrWhiteSpace(inputPersonCityBirth.Text)
                || outputMessageError.Text != string.Empty)
            {
                outputMessageOk.Text = string.Empty;
                btnConfirmAddPerson.Enabled = false;
            }
            else
            {
                outputMessageOk.Text = "Dados obrigatórios preenchidos com sucesso!";
                btnConfirmAddPerson.Enabled = true;
            }
        }

        /// <summary>
        /// Método para Salvar a nova pessoa e voltar ao Menu Principal.
        /// </summary>
        private void btnConfirmAddPerson_Click(object sender, EventArgs e)
        {
            // Criando a Pessoa
            Person person = new Person();
            person.SetName(inputPersonName.Text.Trim());
            person.SetCpf(Person.FormatCpfToLong(inputPersonCpf.Text.Trim()));
            person.SetRg(Person.FormatRgToLong(inputPersonRg.Text.Trim()));
            person.SetDateBirthday(Person.FormatStringToDateTime(inputPersonDateBirth.Text.Trim()));
            person.SetCityBirth(inputPersonCityBirth.Text.Trim());

            // Adicionando a pessoa nas listas/árvores
            Names.InsertNode(new ElementData<string>(person.Name, person));
            Cpfs.InsertNode(new ElementData<long>(person.Cpf, person));
            DatesBirth.InsertNode(new ElementData<DateTime>(person.DateBirthday, person));
            People.Add(person);

            // Fechando o Formulário Atual
            System.Threading.Thread.Sleep(200);
            Hide();

            // Voltando para o Menu Principal
            PreviousForm.Names = this.Names;
            PreviousForm.Cpfs = this.Cpfs;
            PreviousForm.DatesBirth = this.DatesBirth;
            PreviousForm.People = this.People;
            PreviousForm.Show();
        }
    }
}
