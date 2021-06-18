using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ConsoleApp.Object;
using ConsoleApp.Structure;
using ConsoleApp.ExternalFileManipulation;

namespace WindowsApp.Forms
{
    public partial class Form6Extra : Form
    {
        #region Atributes
        public CsvFile CsvFile { get; set; }
        public AVLTree<string> Names { get; set; }
        public AVLTree<long> Cpfs { get; set; }
        public AVLTree<DateTime> DatesBirth { get; set; }
        public List<Person> People { get; set; }

        private string _param { get; set; }
        #endregion

        /// <summary>
        /// Construtor do Form2.
        /// </summary>
        public Form6Extra(CsvFile csvFile, AVLTree<string> names, AVLTree<long> cpfs, AVLTree<DateTime> datesBirth, List<Person> people, string param)
        {
            InitializeComponent();
            this.CsvFile = csvFile;
            this.Names = names;
            this.Cpfs = cpfs;
            this.DatesBirth = datesBirth;
            this.People = people;
            this._param = param;
        }

        // Ação executada ao carregar o formulário.
        private void Form6Extra_Load(object sender, EventArgs e)
        {
            /*Observação: "\r\n" equivale a Environment.NewLine*/
            string content;
            switch (_param)
            {
                case "name":
                    content = "\tÁRVORE DE NOMES\r\n \r\n";
                    content += Names.GetPrintTree();
                    break;

                case "cpf":
                    content = "\tÁRVORE DE CPF\r\n \r\n";
                    content += Cpfs.GetPrintTree();
                    break;

                case "datebirth":
                    content = "\tÁRVORE DE NOMES\r\n \r\n";
                    content += DatesBirth.GetPrintTree();
                    break;

                default: // Erro não deve cair aqui!
                    content = "Erro! Contate o administrador do sistema.";
                    break;
            }

            outputPrintTree.Text = content;
            outputPrintTree.Select(outputPrintTree.Text.Length, 0);
        }

        /// <summary>
        /// Ação executada ao clicar no botão Voltar.
        /// </summary>
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Fechando o Formulário Atual
            System.Threading.Thread.Sleep(200);
            Hide();

            // Abrindo o Formulário do Menu Principal.
            Form2 _f2 = new Form2(CsvFile, Names, Cpfs, DatesBirth, People);
            _f2.Show();
        }
    }
}