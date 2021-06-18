using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ConsoleApp.Object;
using ConsoleApp.Structure;
using ConsoleApp.ExternalFileManipulation;

namespace WindowsApp.Forms
{
    public partial class Form5 : Form
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
        public Form5(CsvFile csvFile, AVLTree<string> names, AVLTree<long> cpfs, AVLTree<DateTime> datesBirth, List<Person> people, Form2 previousForm)
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
        private void Form5_Load(object sender, EventArgs e)
        {
            btnRemovePerson.Enabled = false;
            outputMessageOk.Text = string.Empty;
            outputMessageError.Text = string.Empty;
        }

        /// <summary>
        /// Ação executada ao alterar o valor do compo CPF.
        /// </summary>
        private void inputPersonCpf_TextChanged(object sender, EventArgs e)
        {
            var longValidate = Person.FormatCpfToLong(inputPersonCpf.Text);

            if (longValidate == 0)
            {
                btnRemovePerson.Enabled = false;
                outputMessageOk.Text = string.Empty;
                outputMessageError.Text = "Erro! Formato inválido para o CPF!";
            }
            else
            {
                var cpfJaCadastrado = Cpfs.FindNode(new ElementData<long>(longValidate));
                if (cpfJaCadastrado == null)
                {
                    btnRemovePerson.Enabled = false;
                    outputMessageOk.Text = string.Empty;
                    outputMessageError.Text = "Erro! Nenhuma pessoa encontrada para o CPF informado!";
                }
                else
                {
                    btnRemovePerson.Enabled = true;
                    outputMessageOk.Text = "CPF encontrado!";
                    outputMessageError.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// Ação ao clicar no botão 'Remover'<br/>
        /// (Remove o usuário cujo CPF tenha o valor informado e <br/>
        ///chama o Form do menu principal)
        /// </summary>
        private void btnRemovePerson_Click(object sender, EventArgs e)
        {
            var cpf = Person.FormatCpfToLong(inputPersonCpf.Text);

            var node = Cpfs.FindNode(new ElementData<long>(cpf));
            if(node != null && node.Element != null)
            {
                var person = node.Element.PersonReference;

                Names.DeleteNode(new ElementData<string>(person.Name));
                Cpfs.DeleteNode(new ElementData<long>(person.Cpf));
                DatesBirth.DeleteNode(new ElementData<DateTime>(person.DateBirthday));
                People.Remove(person);

                outputMessageOk.Text = "Pessoa deletada com sucesso!";
            }
            else
            {
                outputMessageError.Text = "Erro! Não foi possível encotrar a pessoa cujo CPF tem o valor informado!";
                return;
            }

            // Fechando o Formulário atual
            System.Threading.Thread.Sleep(200);
            outputMessageOk.Text = string.Empty;
            Hide();

            // Voltando para o Form2
            PreviousForm.Names = this.Names;
            PreviousForm.Cpfs = this.Cpfs;
            PreviousForm.DatesBirth = this.DatesBirth;
            PreviousForm.People = this.People;
            PreviousForm.Show();
        }

        /// <summary>
        /// Ação ao clicar o botão Voltar.
        /// </summary>
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Fechando o Formulário atual
            System.Threading.Thread.Sleep(200);
            outputMessageOk.Text = string.Empty;
            Hide();

            PreviousForm.Show();
        }
    }
}
