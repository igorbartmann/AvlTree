
namespace WindowsApp.Forms
{
    partial class Form4
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
            this.rdBtnFindByDateBirth = new System.Windows.Forms.RadioButton();
            this.rdBtnFindByCpf = new System.Windows.Forms.RadioButton();
            this.rdBtnFindByName = new System.Windows.Forms.RadioButton();
            this.outputMessageOk = new System.Windows.Forms.TextBox();
            this.outputMessageError = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmFindPerson = new System.Windows.Forms.Button();
            this.inputNameToFind = new System.Windows.Forms.TextBox();
            this.inputCpfToFind = new System.Windows.Forms.TextBox();
            this.inputInitialDateToFind = new System.Windows.Forms.TextBox();
            this.inputFinalDateToFind = new System.Windows.Forms.TextBox();
            this.labelBetweenDates = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdBtnFindByDateBirth
            // 
            this.rdBtnFindByDateBirth.AutoSize = true;
            this.rdBtnFindByDateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnFindByDateBirth.Location = new System.Drawing.Point(55, 174);
            this.rdBtnFindByDateBirth.Margin = new System.Windows.Forms.Padding(0);
            this.rdBtnFindByDateBirth.Name = "rdBtnFindByDateBirth";
            this.rdBtnFindByDateBirth.Padding = new System.Windows.Forms.Padding(10);
            this.rdBtnFindByDateBirth.Size = new System.Drawing.Size(317, 40);
            this.rdBtnFindByDateBirth.TabIndex = 6;
            this.rdBtnFindByDateBirth.Text = "BUSCAR POR DATA DE NASCIMENTO";
            this.rdBtnFindByDateBirth.UseVisualStyleBackColor = true;
            this.rdBtnFindByDateBirth.CheckedChanged += new System.EventHandler(this.rdBtnFindByDateBirth_CheckedChanged);
            // 
            // rdBtnFindByCpf
            // 
            this.rdBtnFindByCpf.AutoSize = true;
            this.rdBtnFindByCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnFindByCpf.Location = new System.Drawing.Point(55, 134);
            this.rdBtnFindByCpf.Margin = new System.Windows.Forms.Padding(0);
            this.rdBtnFindByCpf.Name = "rdBtnFindByCpf";
            this.rdBtnFindByCpf.Padding = new System.Windows.Forms.Padding(10);
            this.rdBtnFindByCpf.Size = new System.Drawing.Size(177, 40);
            this.rdBtnFindByCpf.TabIndex = 5;
            this.rdBtnFindByCpf.Text = "BUSCAR POR CPF";
            this.rdBtnFindByCpf.UseVisualStyleBackColor = true;
            this.rdBtnFindByCpf.CheckedChanged += new System.EventHandler(this.rdBtnFindByCpf_CheckedChanged);
            // 
            // rdBtnFindByName
            // 
            this.rdBtnFindByName.AutoSize = true;
            this.rdBtnFindByName.Checked = true;
            this.rdBtnFindByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnFindByName.Location = new System.Drawing.Point(55, 91);
            this.rdBtnFindByName.Name = "rdBtnFindByName";
            this.rdBtnFindByName.Padding = new System.Windows.Forms.Padding(10);
            this.rdBtnFindByName.Size = new System.Drawing.Size(192, 40);
            this.rdBtnFindByName.TabIndex = 4;
            this.rdBtnFindByName.TabStop = true;
            this.rdBtnFindByName.Text = "BUSCAR POR NOME";
            this.rdBtnFindByName.UseVisualStyleBackColor = true;
            this.rdBtnFindByName.CheckedChanged += new System.EventHandler(this.rdBtnFindByName_CheckedChanged);
            // 
            // outputMessageOk
            // 
            this.outputMessageOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputMessageOk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputMessageOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMessageOk.ForeColor = System.Drawing.Color.DarkGreen;
            this.outputMessageOk.Location = new System.Drawing.Point(55, 329);
            this.outputMessageOk.Multiline = true;
            this.outputMessageOk.Name = "outputMessageOk";
            this.outputMessageOk.ReadOnly = true;
            this.outputMessageOk.Size = new System.Drawing.Size(251, 39);
            this.outputMessageOk.TabIndex = 11;
            this.outputMessageOk.Text = "AcceptedMessage";
            // 
            // outputMessageError
            // 
            this.outputMessageError.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputMessageError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputMessageError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMessageError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.outputMessageError.Location = new System.Drawing.Point(55, 286);
            this.outputMessageError.Multiline = true;
            this.outputMessageError.Name = "outputMessageError";
            this.outputMessageError.ReadOnly = true;
            this.outputMessageError.Size = new System.Drawing.Size(251, 37);
            this.outputMessageError.TabIndex = 10;
            this.outputMessageError.Text = "ErrorMessage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecione a Opção Desejada:";
            // 
            // btnConfirmFindPerson
            // 
            this.btnConfirmFindPerson.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnConfirmFindPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmFindPerson.Location = new System.Drawing.Point(576, 384);
            this.btnConfirmFindPerson.Name = "btnConfirmFindPerson";
            this.btnConfirmFindPerson.Size = new System.Drawing.Size(102, 41);
            this.btnConfirmFindPerson.TabIndex = 12;
            this.btnConfirmFindPerson.Text = "Avançar";
            this.btnConfirmFindPerson.UseVisualStyleBackColor = false;
            this.btnConfirmFindPerson.Click += new System.EventHandler(this.btnConfirmFindPerson_Click);
            // 
            // inputNameToFind
            // 
            this.inputNameToFind.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputNameToFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNameToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNameToFind.Location = new System.Drawing.Point(255, 100);
            this.inputNameToFind.Name = "inputNameToFind";
            this.inputNameToFind.Size = new System.Drawing.Size(222, 24);
            this.inputNameToFind.TabIndex = 13;
            // 
            // inputCpfToFind
            // 
            this.inputCpfToFind.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputCpfToFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputCpfToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCpfToFind.Location = new System.Drawing.Point(255, 143);
            this.inputCpfToFind.Name = "inputCpfToFind";
            this.inputCpfToFind.Size = new System.Drawing.Size(222, 24);
            this.inputCpfToFind.TabIndex = 14;
            this.inputCpfToFind.TextChanged += new System.EventHandler(this.inputCpfToFind_TextChanged);
            // 
            // inputInitialDateToFind
            // 
            this.inputInitialDateToFind.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputInitialDateToFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputInitialDateToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputInitialDateToFind.Location = new System.Drawing.Point(375, 186);
            this.inputInitialDateToFind.Name = "inputInitialDateToFind";
            this.inputInitialDateToFind.Size = new System.Drawing.Size(118, 24);
            this.inputInitialDateToFind.TabIndex = 15;
            this.inputInitialDateToFind.TextChanged += new System.EventHandler(this.inputInitialDateToFind_TextChanged);
            // 
            // inputFinalDateToFind
            // 
            this.inputFinalDateToFind.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputFinalDateToFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFinalDateToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFinalDateToFind.Location = new System.Drawing.Point(539, 186);
            this.inputFinalDateToFind.Name = "inputFinalDateToFind";
            this.inputFinalDateToFind.Size = new System.Drawing.Size(118, 24);
            this.inputFinalDateToFind.TabIndex = 16;
            this.inputFinalDateToFind.TextChanged += new System.EventHandler(this.inputFinalDateToFind_TextChanged);
            // 
            // labelBetweenDates
            // 
            this.labelBetweenDates.AutoSize = true;
            this.labelBetweenDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBetweenDates.Location = new System.Drawing.Point(499, 189);
            this.labelBetweenDates.Name = "labelBetweenDates";
            this.labelBetweenDates.Size = new System.Drawing.Size(28, 17);
            this.labelBetweenDates.TabIndex = 17;
            this.labelBetweenDates.Text = "até";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 437);
            this.Controls.Add(this.labelBetweenDates);
            this.Controls.Add(this.inputFinalDateToFind);
            this.Controls.Add(this.inputInitialDateToFind);
            this.Controls.Add(this.inputCpfToFind);
            this.Controls.Add(this.inputNameToFind);
            this.Controls.Add(this.btnConfirmFindPerson);
            this.Controls.Add(this.outputMessageOk);
            this.Controls.Add(this.outputMessageError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdBtnFindByDateBirth);
            this.Controls.Add(this.rdBtnFindByCpf);
            this.Controls.Add(this.rdBtnFindByName);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Pessoa";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdBtnFindByDateBirth;
        private System.Windows.Forms.RadioButton rdBtnFindByCpf;
        private System.Windows.Forms.RadioButton rdBtnFindByName;
        private System.Windows.Forms.TextBox outputMessageOk;
        private System.Windows.Forms.TextBox outputMessageError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmFindPerson;
        private System.Windows.Forms.TextBox inputNameToFind;
        private System.Windows.Forms.TextBox inputCpfToFind;
        private System.Windows.Forms.TextBox inputInitialDateToFind;
        private System.Windows.Forms.TextBox inputFinalDateToFind;
        private System.Windows.Forms.Label labelBetweenDates;
    }
}