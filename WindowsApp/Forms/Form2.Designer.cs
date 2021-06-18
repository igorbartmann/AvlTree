
namespace WindowsApp.Forms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rdBtnAddPerson = new System.Windows.Forms.RadioButton();
            this.rdBtnFindPerson = new System.Windows.Forms.RadioButton();
            this.rdBtnDeletePerson = new System.Windows.Forms.RadioButton();
            this.rdBtnPrintTree = new System.Windows.Forms.RadioButton();
            this.rdBtnCloseApp = new System.Windows.Forms.RadioButton();
            this.btnNextToExecuteAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione a Opção Desejada";
            // 
            // rdBtnAddPerson
            // 
            this.rdBtnAddPerson.AutoSize = true;
            this.rdBtnAddPerson.Checked = true;
            this.rdBtnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnAddPerson.Location = new System.Drawing.Point(44, 123);
            this.rdBtnAddPerson.Name = "rdBtnAddPerson";
            this.rdBtnAddPerson.Padding = new System.Windows.Forms.Padding(10);
            this.rdBtnAddPerson.Size = new System.Drawing.Size(193, 40);
            this.rdBtnAddPerson.TabIndex = 1;
            this.rdBtnAddPerson.TabStop = true;
            this.rdBtnAddPerson.Text = "ADICIONAR PESSOA";
            this.rdBtnAddPerson.UseVisualStyleBackColor = true;
            // 
            // rdBtnFindPerson
            // 
            this.rdBtnFindPerson.AutoSize = true;
            this.rdBtnFindPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnFindPerson.Location = new System.Drawing.Point(44, 166);
            this.rdBtnFindPerson.Margin = new System.Windows.Forms.Padding(0);
            this.rdBtnFindPerson.Name = "rdBtnFindPerson";
            this.rdBtnFindPerson.Padding = new System.Windows.Forms.Padding(10);
            this.rdBtnFindPerson.Size = new System.Drawing.Size(173, 40);
            this.rdBtnFindPerson.TabIndex = 2;
            this.rdBtnFindPerson.Text = "BUSCAR PESSOA";
            this.rdBtnFindPerson.UseVisualStyleBackColor = true;
            // 
            // rdBtnDeletePerson
            // 
            this.rdBtnDeletePerson.AutoSize = true;
            this.rdBtnDeletePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnDeletePerson.Location = new System.Drawing.Point(44, 206);
            this.rdBtnDeletePerson.Margin = new System.Windows.Forms.Padding(0);
            this.rdBtnDeletePerson.Name = "rdBtnDeletePerson";
            this.rdBtnDeletePerson.Padding = new System.Windows.Forms.Padding(10);
            this.rdBtnDeletePerson.Size = new System.Drawing.Size(181, 40);
            this.rdBtnDeletePerson.TabIndex = 3;
            this.rdBtnDeletePerson.Text = "DELETAR PESSOA";
            this.rdBtnDeletePerson.UseVisualStyleBackColor = true;
            // 
            // rdBtnPrintTree
            // 
            this.rdBtnPrintTree.AutoSize = true;
            this.rdBtnPrintTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnPrintTree.Location = new System.Drawing.Point(44, 246);
            this.rdBtnPrintTree.Margin = new System.Windows.Forms.Padding(0);
            this.rdBtnPrintTree.Name = "rdBtnPrintTree";
            this.rdBtnPrintTree.Padding = new System.Windows.Forms.Padding(10);
            this.rdBtnPrintTree.Size = new System.Drawing.Size(195, 40);
            this.rdBtnPrintTree.TabIndex = 4;
            this.rdBtnPrintTree.Text = "IMPRIMIR A ÁRVORE";
            this.rdBtnPrintTree.UseVisualStyleBackColor = true;
            // 
            // rdBtnCloseApp
            // 
            this.rdBtnCloseApp.AutoSize = true;
            this.rdBtnCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnCloseApp.Location = new System.Drawing.Point(44, 286);
            this.rdBtnCloseApp.Margin = new System.Windows.Forms.Padding(0);
            this.rdBtnCloseApp.Name = "rdBtnCloseApp";
            this.rdBtnCloseApp.Padding = new System.Windows.Forms.Padding(10);
            this.rdBtnCloseApp.Size = new System.Drawing.Size(213, 40);
            this.rdBtnCloseApp.TabIndex = 5;
            this.rdBtnCloseApp.Text = "FECHAR O APLICATIVO";
            this.rdBtnCloseApp.UseVisualStyleBackColor = true;
            // 
            // btnNextToExecuteAction
            // 
            this.btnNextToExecuteAction.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNextToExecuteAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextToExecuteAction.Location = new System.Drawing.Point(576, 384);
            this.btnNextToExecuteAction.Name = "btnNextToExecuteAction";
            this.btnNextToExecuteAction.Size = new System.Drawing.Size(102, 41);
            this.btnNextToExecuteAction.TabIndex = 6;
            this.btnNextToExecuteAction.Text = "Avançar";
            this.btnNextToExecuteAction.UseVisualStyleBackColor = false;
            this.btnNextToExecuteAction.Click += new System.EventHandler(this.btnNextToExecuteAction_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 437);
            this.Controls.Add(this.btnNextToExecuteAction);
            this.Controls.Add(this.rdBtnCloseApp);
            this.Controls.Add(this.rdBtnPrintTree);
            this.Controls.Add(this.rdBtnDeletePerson);
            this.Controls.Add(this.rdBtnFindPerson);
            this.Controls.Add(this.rdBtnAddPerson);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBtnAddPerson;
        private System.Windows.Forms.RadioButton rdBtnFindPerson;
        private System.Windows.Forms.RadioButton rdBtnDeletePerson;
        private System.Windows.Forms.RadioButton rdBtnPrintTree;
        private System.Windows.Forms.RadioButton rdBtnCloseApp;
        private System.Windows.Forms.Button btnNextToExecuteAction;
    }
}