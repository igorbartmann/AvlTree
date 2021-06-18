using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ConsoleApp.Object;
using ConsoleApp.Structure;
using ConsoleApp.ExternalFileManipulation;
using System.Linq;

namespace WindowsApp.Forms
{
    public partial class Form4Extra : Form
    {
        #region Atributes
        public CsvFile CsvFile { get; set; }
        public AVLTree<string> Names { get; set; }
        public AVLTree<long> Cpfs { get; set; }
        public AVLTree<DateTime> DatesBirth { get; set; }
        public List<Person> People { get; set; }
        public List<Person> _peopleFound { get; set; }

        #endregion

        public Form4Extra(CsvFile csvFile, AVLTree<string> names, AVLTree<long> cpfs, AVLTree<DateTime> datesBirth, List<Person> people, List<Person> peopleFound)
        {
            InitializeComponent();
            this.CsvFile = csvFile;
            this.Names = names;
            this.Cpfs = cpfs;
            this.DatesBirth = datesBirth;
            this.People = people;
            this._peopleFound = peopleFound;
        }

        /// <summary>
        /// Ação executada ao carregar o Formulário.
        /// </summary>
        private void Form4Extra_Load(object sender, EventArgs e)
        {
            string content = string.Empty;
            
            if (!_peopleFound.Any())
            {
                content = "Nenhuma pessoa foi encontrada para a propriedade informada!";
            }

            foreach (var person in _peopleFound)
            {
                content += (person.ToString() + Environment.NewLine); // Environment.NewLine equivale a "\r\n" no Windows
            }

            outputPeopleFound.Text = content;
            outputPeopleFound.Select(outputPeopleFound.Text.Length, 0);
        }

        /// <summary>
        /// Ação executada ao Clicar no botão Voltar
        /// </summary>
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Fechando o Form4Extra
            System.Threading.Thread.Sleep(200);
            Hide();

            Form2 _f2 = new Form2(CsvFile, Names, Cpfs, DatesBirth, People);
            _f2.Show();
        }
    }
}
