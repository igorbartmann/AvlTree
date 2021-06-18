using System;
using System.Collections.Generic;
using ConsoleApp.Object;
using ConsoleApp.Structure;
using ConsoleApp.ExternalFileManipulation;

namespace WindowsApp.Forms
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        #region Atributes
        public CsvFile CsvFile { get; set; }
        public AVLTree<string> Names { get; set; }
        public AVLTree<long> Cpfs { get; set; }
        public AVLTree<DateTime> DatesBirth { get; set; }
        public List<Person> People { get; set; }
        #endregion

        /// <summary>
        /// Construtor do Form1 (inicializador da aplicação).
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            CsvFile = new CsvFile();
            Names = new AVLTree<string>();
            Cpfs = new AVLTree<long>();
            DatesBirth = new AVLTree<DateTime>();
            People = new List<Person>();
        }

        /// <summary>
        /// Método para executar os dados de carregamento do Form<br/>
        /// (não utilizado)
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            btnNextToMenu.Enabled = false;
            outputMessageOk.Text = string.Empty;
            outputMessageError.Text = string.Empty;
        }

        /// <summary>
        /// Ação executada ao alterar o valor do campo FilePath.
        /// </summary>
        private void inputFilePath_TextChanged(object sender, EventArgs e)
        {
            /*Desabilitado*/
            return;

            //CsvFile.SetFilePath(inputFilePath.Text.Trim());
            //if (ValidateRequiredFields())
            //{
            //    ShowMessageFileFound();
            //}
            //else
            //{
            //    HideMessageFileFound();
            //}
        }

        /// <summary>
        /// Ação executada ao alterar o valor do campo FileName.
        /// </summary>
        private void inputFileName_TextChanged(object sender, EventArgs e)
        {
            CsvFile.SetFileName(inputFileName.Text.Trim());
            if (ValidateRequiredFields())
            {
                ShowMessageFileFound();
            }
            else
            {
                HideMessageFileFound();
            }
            
        }

        /// <summary>
        /// Ação executada ao carregar o Formulário.
        /// </summary>
        private void inputFileExtension_TextChanged(object sender, EventArgs e)
        {
            CsvFile.SetFileExtension(inputFileExtension.Text.Trim());
            if (ValidateRequiredFields())
            {
                ShowMessageFileFound();
            }
            else
            {
                HideMessageFileFound();
            }
        }

        /// <summary>
        /// Valida se o botão deve ser ativado.
        /// </summary>
        private bool ValidateRequiredFields()
        {
            bool status = false;
            if (string.IsNullOrWhiteSpace(inputFileName.Text) || string.IsNullOrWhiteSpace(inputFileExtension.Text))
            {
                btnNextToMenu.Enabled = false;
            }
            else
            {
                status = true;
                btnNextToMenu.Enabled = true;
            }
            return status;
        }

        /// <summary>
        /// Controla as mensgens de erro exibidas.
        /// </summary>
        private void ShowMessageFileFound()
        {
            var fileExists = CsvFile.ValideFileExist();
            if (fileExists)
            {
                outputMessageOk.Text = "Arquivo encotrado!";
                outputMessageError.Text = string.Empty;
            }
            else
            {
                outputMessageOk.Text = string.Empty;
                outputMessageError.Text = $"Erro! Arquivo não encotrado.{Environment.NewLine}" +
                    $"(Caso você avançar e salvar registros então será criado um arquivo com o nome informado.)";
            }
        }

        /// <summary>
        /// Oculta as mensagens de erro.
        /// </summary>
        private void HideMessageFileFound()
        {
            outputMessageOk.Text = string.Empty;
            outputMessageError.Text = string.Empty;
        }

        /// <summary>
        /// Ação ao clicar no botão 'Avançar'<br/>
        /// (Realiza a leitura do Arquivo de texto e avança para o Menu Principal)
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            (string content, _) = CsvFile.Reader();

            string[] contentSplit = content.Split(';');
            int position = 0;
            string cpf, rg, name, dateBirth, cityBirth;
            while (position < contentSplit.Length - 1)
            {
                cpf = contentSplit[position++];
                rg = contentSplit[position++];
                name = contentSplit[position++];
                dateBirth = contentSplit[position++];
                cityBirth = contentSplit[position++];

                Person person = new Person(cpf, rg, name, dateBirth, cityBirth);
                Names.InsertNode(new ElementData<string>(name, person));
                Cpfs.InsertNode(new ElementData<long>(Person.FormatCpfToLong(cpf), person));
                DatesBirth.InsertNode(new ElementData<DateTime>(Person.FormatStringToDateTime(dateBirth), person));
                People.Add(person);
            }

            // Fechando o Form1
            System.Threading.Thread.Sleep(200); // Apenas para dar um efeito de carregar
            outputMessageOk.Text = string.Empty;
            outputMessageError.Text = string.Empty;
            Hide();

            // Inicializando o Form2
            Form2 _f2 = new Form2(CsvFile, Names, Cpfs, DatesBirth, People);
            _f2.Show();
        }
    }
}
