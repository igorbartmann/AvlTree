using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ConsoleApp.Object;
using ConsoleApp.Structure;
using ConsoleApp.ExternalFileManipulation;

namespace WindowsApp.Forms
{
    public partial class Form6 : Form
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
        public Form6(CsvFile csvFile, AVLTree<string> names, AVLTree<long> cpfs, AVLTree<DateTime> datesBirth, List<Person> people)
        {
            InitializeComponent();
            this.CsvFile = csvFile;
            this.Names = names;
            this.Cpfs = cpfs;
            this.DatesBirth = datesBirth;
            this.People = people;
        }

        /// <summary>
        /// Ação executada ao carregar o Formulário.
        /// </summary>
        private void Form6_Load(object sender, EventArgs e)
        {
            // No Action!
        }

        /// <summary>
        /// Ação executada ao clicar em Avançar.
        /// </summary>
        private void btnNextToViewTree_Click(object sender, EventArgs e)
        {
            // Fechando o Formulário Atual
            System.Threading.Thread.Sleep(200);
            Hide();

            if (rdBtnPrintTreeByName.Checked)
            {
                Form6Extra _f6Extra = new Form6Extra(CsvFile , Names, Cpfs, DatesBirth, People, "name");
                _f6Extra.Show();
            }
            else if (rdBtnPrintTreeByCpf.Checked)
            {
                Form6Extra _f6Extra = new Form6Extra(CsvFile, Names, Cpfs, DatesBirth, People, "cpf");
                _f6Extra.Show();
            }
            else // rdBtnpPrintTreeByDateBirth.Checked
            {
                Form6Extra _f6Extra = new Form6Extra(CsvFile, Names, Cpfs, DatesBirth, People, "datebirth");
                _f6Extra.Show();
            }
        }
    }
}
