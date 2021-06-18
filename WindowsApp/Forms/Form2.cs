using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ConsoleApp.Object;
using ConsoleApp.Structure;
using ConsoleApp.ExternalFileManipulation;

namespace WindowsApp.Forms
{
    public partial class Form2 : Form
    {
        #region Atributes
        public CsvFile CsvFile { get; set; }
        public AVLTree<string> Names { get; set; }
        public AVLTree<long> Cpfs { get; set; }
        public AVLTree<DateTime> DatesBirth { get; set; }
        public List<Person> People { get; set; }
        #endregion

        /// <summary>
        /// Construtor do Form2.
        /// </summary>
        public Form2(CsvFile csvFile, AVLTree<string> names, AVLTree<long> cpfs, AVLTree<DateTime> datesBirth, List<Person> people)
        {
            InitializeComponent();
            this.CsvFile = csvFile;
            this.Names = names;
            this.Cpfs = cpfs;
            this.DatesBirth = datesBirth;
            this.People = people;
        }

        /// <summary>
        /// Método para executar os dados de carregamento do Form<br/>
        /// (não utilizado)
        /// </summary>
        private void Form2_Load(object sender, EventArgs e)
        {
            // No Action!
        }

        /// <summary>
        /// Ação ao clicar no botão 'Avançar'<br/>
        /// (Chama o Form do menu correspondente)
        /// </summary>
        private void btnNextToExecuteAction_Click(object sender, EventArgs e)
        {
            if (rdBtnAddPerson.Checked) // Adicionar pessoa (Form3)
            {
                CloseCurrentForm();
                Form3 _f3 = new Form3(CsvFile, Names, Cpfs, DatesBirth, People, this);
                _f3.Show();
            }
            else if (rdBtnFindPerson.Checked) // Buscar pessoa (Form4)
            {
                CloseCurrentForm();
                Form4 _f4 = new Form4(CsvFile, Names, Cpfs, DatesBirth, People, this);
                _f4.Show();
            }
            else if (rdBtnDeletePerson.Checked) // Deletar pessoa (Form5)
            {
                CloseCurrentForm();
                Form5 _f5 = new Form5(CsvFile, Names, Cpfs, DatesBirth, People, this);
                _f5.Show();
            }
            else if (rdBtnPrintTree.Checked) // Imprimir a árvore (Form6)
            {
                CloseCurrentForm();
                Form6 _f6 = new Form6(CsvFile, Names, Cpfs, DatesBirth, People);
                _f6.Show();
            }
            else // Fechar a aplicação
            {
                EndApplication();
            }
        }

        #region Métodos Auxiliares

        /// <summary>
        /// Fechar a janela atual, quando a aplicação irá para uma outra janela.
        /// </summary>
        private void CloseCurrentForm()
        {
            System.Threading.Thread.Sleep(200);
            Hide();
        }

        /// <summary>
        /// Finalizar a execução da aplicação.
        /// </summary>
        private void EndApplication()
        {
            string content = null;
            foreach (Person person in People)
            {
                content += Person.FormatCpfToString(person.Cpf) + ";";
                content += Person.FormatRgToString(person.Rg) + ";";
                content += person.Name + ";";
                content += Person.FormatDateTimeToString(person.DateBirthday) + ";";
                content += person.CityBirth + ";";
            }

            CsvFile.Writer(content, Person.TOT_PROPERTIES);           
            System.Threading.Thread.Sleep(200);
            Application.Exit();
        }

        #endregion
    }
}
