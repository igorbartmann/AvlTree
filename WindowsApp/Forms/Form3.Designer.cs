
namespace WindowsApp.Forms
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputPersonName = new System.Windows.Forms.TextBox();
            this.inputPersonCpf = new System.Windows.Forms.TextBox();
            this.inputPersonRg = new System.Windows.Forms.TextBox();
            this.inputPersonDateBirth = new System.Windows.Forms.TextBox();
            this.inputPersonCityBirth = new System.Windows.Forms.TextBox();
            this.btnConfirmAddPerson = new System.Windows.Forms.Button();
            this.outputMessageError = new System.Windows.Forms.TextBox();
            this.outputMessageOk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOVA PESSOA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(148, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(122, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label4.Size = new System.Drawing.Size(113, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número RG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 240);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label5.Size = new System.Drawing.Size(186, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 300);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label6.Size = new System.Drawing.Size(204, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cidade de Nascimento:";
            // 
            // inputPersonName
            // 
            this.inputPersonName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputPersonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPersonName.Location = new System.Drawing.Point(245, 78);
            this.inputPersonName.Name = "inputPersonName";
            this.inputPersonName.Size = new System.Drawing.Size(278, 26);
            this.inputPersonName.TabIndex = 6;
            this.inputPersonName.TextChanged += new System.EventHandler(this.inputPersonName_TextChanged);
            // 
            // inputPersonCpf
            // 
            this.inputPersonCpf.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputPersonCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPersonCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPersonCpf.Location = new System.Drawing.Point(245, 130);
            this.inputPersonCpf.Name = "inputPersonCpf";
            this.inputPersonCpf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputPersonCpf.Size = new System.Drawing.Size(278, 26);
            this.inputPersonCpf.TabIndex = 7;
            this.inputPersonCpf.TextChanged += new System.EventHandler(this.inputPersonCpf_TextChanged);
            // 
            // inputPersonRg
            // 
            this.inputPersonRg.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputPersonRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPersonRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPersonRg.Location = new System.Drawing.Point(245, 187);
            this.inputPersonRg.Name = "inputPersonRg";
            this.inputPersonRg.Size = new System.Drawing.Size(278, 26);
            this.inputPersonRg.TabIndex = 8;
            this.inputPersonRg.TextChanged += new System.EventHandler(this.inputPersonRg_TextChanged);
            // 
            // inputPersonDateBirth
            // 
            this.inputPersonDateBirth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputPersonDateBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPersonDateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPersonDateBirth.Location = new System.Drawing.Point(245, 244);
            this.inputPersonDateBirth.Name = "inputPersonDateBirth";
            this.inputPersonDateBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputPersonDateBirth.Size = new System.Drawing.Size(278, 26);
            this.inputPersonDateBirth.TabIndex = 9;
            this.inputPersonDateBirth.TextChanged += new System.EventHandler(this.inputPersonDateBirth_TextChanged);
            // 
            // inputPersonCityBirth
            // 
            this.inputPersonCityBirth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputPersonCityBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPersonCityBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPersonCityBirth.Location = new System.Drawing.Point(245, 304);
            this.inputPersonCityBirth.Name = "inputPersonCityBirth";
            this.inputPersonCityBirth.Size = new System.Drawing.Size(278, 26);
            this.inputPersonCityBirth.TabIndex = 10;
            this.inputPersonCityBirth.TextChanged += new System.EventHandler(this.inputPersonCityBirth_TextChanged);
            // 
            // btnConfirmAddPerson
            // 
            this.btnConfirmAddPerson.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnConfirmAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAddPerson.Location = new System.Drawing.Point(576, 384);
            this.btnConfirmAddPerson.Name = "btnConfirmAddPerson";
            this.btnConfirmAddPerson.Size = new System.Drawing.Size(102, 41);
            this.btnConfirmAddPerson.TabIndex = 11;
            this.btnConfirmAddPerson.Text = "Confirmar";
            this.btnConfirmAddPerson.UseVisualStyleBackColor = false;
            this.btnConfirmAddPerson.Click += new System.EventHandler(this.btnConfirmAddPerson_Click);
            // 
            // outputMessageError
            // 
            this.outputMessageError.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputMessageError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputMessageError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMessageError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.outputMessageError.Location = new System.Drawing.Point(16, 357);
            this.outputMessageError.Multiline = true;
            this.outputMessageError.Name = "outputMessageError";
            this.outputMessageError.ReadOnly = true;
            this.outputMessageError.Size = new System.Drawing.Size(390, 28);
            this.outputMessageError.TabIndex = 13;
            this.outputMessageError.Text = "ErrorMessage";
            // 
            // outputMessageOk
            // 
            this.outputMessageOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputMessageOk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputMessageOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMessageOk.ForeColor = System.Drawing.Color.DarkGreen;
            this.outputMessageOk.Location = new System.Drawing.Point(16, 403);
            this.outputMessageOk.Multiline = true;
            this.outputMessageOk.Name = "outputMessageOk";
            this.outputMessageOk.ReadOnly = true;
            this.outputMessageOk.Size = new System.Drawing.Size(390, 28);
            this.outputMessageOk.TabIndex = 14;
            this.outputMessageOk.Text = "AcceptedMessage";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 437);
            this.Controls.Add(this.outputMessageOk);
            this.Controls.Add(this.outputMessageError);
            this.Controls.Add(this.btnConfirmAddPerson);
            this.Controls.Add(this.inputPersonCityBirth);
            this.Controls.Add(this.inputPersonDateBirth);
            this.Controls.Add(this.inputPersonRg);
            this.Controls.Add(this.inputPersonCpf);
            this.Controls.Add(this.inputPersonName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Pessoa";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputPersonName;
        private System.Windows.Forms.TextBox inputPersonCpf;
        private System.Windows.Forms.TextBox inputPersonRg;
        private System.Windows.Forms.TextBox inputPersonDateBirth;
        private System.Windows.Forms.TextBox inputPersonCityBirth;
        private System.Windows.Forms.Button btnConfirmAddPerson;
        private System.Windows.Forms.TextBox outputMessageError;
        private System.Windows.Forms.TextBox outputMessageOk;
    }
}