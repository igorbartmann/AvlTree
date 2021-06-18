using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ConsoleApp.Object;
using ConsoleApp.Structure;
using ConsoleApp.ExternalFileManipulation;
using System.Linq;

namespace WindowsApp.Forms
{
    public partial class Form4 : Form
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
        public Form4(CsvFile csvFile, AVLTree<string> names, AVLTree<long> cpfs, AVLTree<DateTime> datesBirth, List<Person> people, Form2 previousForm)
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
        private void Form4_Load(object sender, EventArgs e)
        {
            inputCpfToFind.Hide();
            inputInitialDateToFind.Hide();
            labelBetweenDates.Hide();
            inputFinalDateToFind.Hide();

            outputMessageOk.Text = string.Empty;
            outputMessageError.Text = string.Empty;
        }

        /// <summary>
        /// Ação a ser executada ao selecionar o radio-button 'Buscar por Nome'
        /// </summary>
        private void rdBtnFindByName_CheckedChanged(object sender, EventArgs e)
        {
            inputNameToFind.Show();

            inputCpfToFind.Clear();
            inputCpfToFind.Hide();

            inputInitialDateToFind.Clear();
            inputInitialDateToFind.Hide();
            labelBetweenDates.Hide();
            inputFinalDateToFind.Clear();
            inputFinalDateToFind.Hide();

            btnConfirmFindPerson.Enabled = true;
        }

        /// <summary>
        /// Ação a ser executada ao selecionar o radio-button 'Buscar por CPF'
        /// </summary>
        private void rdBtnFindByCpf_CheckedChanged(object sender, EventArgs e)
        {
            inputNameToFind.Clear();
            inputNameToFind.Hide();

            inputCpfToFind.Show();

            inputInitialDateToFind.Clear();
            inputInitialDateToFind.Hide();
            labelBetweenDates.Hide();
            inputFinalDateToFind.Clear();
            inputFinalDateToFind.Hide();

            btnConfirmFindPerson.Enabled = false;
        }

        /// <summary>
        /// Ação a ser executada ao selecionar o radio-button 'Buscar por Data de Nascimento'
        /// </summary>
        private void rdBtnFindByDateBirth_CheckedChanged(object sender, EventArgs e)
        {
            inputNameToFind.Clear();
            inputNameToFind.Hide();

            inputCpfToFind.Clear();
            inputCpfToFind.Hide();

            inputInitialDateToFind.Show();
            labelBetweenDates.Show();
            inputFinalDateToFind.Show();

            btnConfirmFindPerson.Enabled = false;
        }

        /// <summary>
        /// Validação do Cpf informado.
        /// </summary>
        private void inputCpfToFind_TextChanged(object sender, EventArgs e)
        {
            var longValidate = Person.FormatCpfToLong(inputCpfToFind.Text);

            if (longValidate == 0)
            {
                outputMessageOk.Text = string.Empty;
                outputMessageError.Text = "Erro! Formato inválido para o CPF informado!";
                btnConfirmFindPerson.Enabled = false;
            }
            else
            {
                var cpfJaCadastrado = Cpfs.FindNode(new ElementData<long>(longValidate));
                if (cpfJaCadastrado == null)
                {
                    outputMessageOk.Text = string.Empty;
                    outputMessageError.Text = "Erro! CPF não cadastrado no sistema!";
                    btnConfirmFindPerson.Enabled = false;
                }
                else
                {
                    outputMessageOk.Text = "CPF encontrado!";
                    outputMessageError.Text = string.Empty;
                    btnConfirmFindPerson.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Validação e Formatação da Data Inicial.
        /// </summary>
        private void inputInitialDateToFind_TextChanged(object sender, EventArgs e)
        {
            var text = inputInitialDateToFind.Text;
            if (text.Length == 8 && text.Count(c => c == '/') == 0)
            {
                text = text.Substring(0, 2) + "/" + text.Substring(2, 2) + "/" + text.Substring(4, 4);
                inputInitialDateToFind.Text = text;
            }
            else if ((text.Length == 3 || text.Length == 6) && text.Substring(text.Length - 1) != "/")
            {
                text = text.Substring(0, text.Length - 1) + "/" + text.Substring(text.Length - 1);
                inputInitialDateToFind.Text = text;
                inputInitialDateToFind.Select(inputInitialDateToFind.Text.Length, 0);
            }
            else
            {
                if (Person.FormatStringToDateTime(text) != DateTime.MinValue
                    && text.Length == 10)
                {
                    inputFinalDateToFind.Enabled = true;
                    outputMessageError.Text = string.Empty;
                }
                else
                {
                    inputFinalDateToFind.Clear();
                    inputFinalDateToFind.Enabled = false;

                    outputMessageOk.Text = string.Empty;
                    outputMessageError.Text = "Erro! Data de nascimento inválida!";
                }
                btnConfirmFindPerson.Enabled = false;
            }
        }

        /// <summary>
        /// Validação e Formatação da Data Final.
        /// </summary>
        private void inputFinalDateToFind_TextChanged(object sender, EventArgs e)
        {
            var text = inputFinalDateToFind.Text;
            if (text.Length == 8 && text.Count(c => c == '/') == 0)
            {
                text = text.Substring(0, 2) + "/" + text.Substring(2, 2) + "/" + text.Substring(4, 4);
                inputFinalDateToFind.Text = text;
            }
            else if ((text.Length == 3 || text.Length == 6) && text.Substring(text.Length - 1) != "/")
            {
                text = text.Substring(0, text.Length - 1) + "/" + text.Substring(text.Length - 1);
                inputFinalDateToFind.Text = text;
                inputFinalDateToFind.Select(inputFinalDateToFind.Text.Length, 0);
            }
            else
            {
                if(Person.FormatStringToDateTime(text) != DateTime.MinValue
                    && text.Length == 10
                    && Person.FormatStringToDateTime(inputInitialDateToFind.Text) <= Person.FormatStringToDateTime(text))
                {
                    btnConfirmFindPerson.Enabled = true;

                    outputMessageOk.Text = "Datas informadas corretamente.";
                    outputMessageError.Text = string.Empty;
                }
                else
                {
                    btnConfirmFindPerson.Enabled = false;
                    outputMessageOk.Text = string.Empty;
                    outputMessageError.Text = (
                        (Person.FormatStringToDateTime(text) == DateTime.MinValue || text.Length != 10)
                        ? "Erro! Data de nascimento inválida!"
                        : "A data final deve ser maior do que a data inicial!");
                }
            }
        }

        /// <summary>
        /// Evento para realizar a busca através do filtro informado.
        /// </summary>
        private void btnConfirmFindPerson_Click(object sender, EventArgs e)
        {
            // Fechando o Form4Extra
            System.Threading.Thread.Sleep(200);
            Hide();

            var peopleFound = new List<Person>(); ;
            if (rdBtnFindByName.Checked)
            {
                var nodesFoundByName = Names.FindNodes(new ElementData<string>(inputNameToFind.Text.Trim()));

                foreach (var node in nodesFoundByName)
                {
                    if (node != null)
                    {
                        peopleFound.Add(node.Element.PersonReference);
                    }
                }
            }
            else if (rdBtnFindByCpf.Checked)
            {
                var nodeFoundByCpf = Cpfs.FindNode(new ElementData<long>(Person.FormatCpfToLong(inputCpfToFind.Text)));

                if (nodeFoundByCpf != null)
                {
                    peopleFound.Add(nodeFoundByCpf.Element.PersonReference);
                }
            }
            else // rdBtnFindByDateBirth.Checked
            {
                var nodesFoundByDateBirth = DatesBirth.FindNodes(new ElementData<DateTime>(
                    Person.FormatStringToDateTime(inputInitialDateToFind.Text), 
                    Person.FormatStringToDateTime(inputFinalDateToFind.Text)));

                foreach (var node in nodesFoundByDateBirth)
                {
                    if (node != null)
                    {
                        peopleFound.Add(node.Element.PersonReference);
                    }
                }
            }

            Form4Extra _f4Extra = new Form4Extra(CsvFile, Names, Cpfs, DatesBirth, People, peopleFound);
            _f4Extra.Show();
        }
    }
}
