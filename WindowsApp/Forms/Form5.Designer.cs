
namespace WindowsApp.Forms
{
    partial class Form5
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
            this.inputPersonCpf = new System.Windows.Forms.TextBox();
            this.btnRemovePerson = new System.Windows.Forms.Button();
            this.outputMessageError = new System.Windows.Forms.TextBox();
            this.outputMessageOk = new System.Windows.Forms.TextBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remover Cadastro de Pessoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o CPF da pessoa a ser removida:";
            // 
            // inputPersonCpf
            // 
            this.inputPersonCpf.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputPersonCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPersonCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPersonCpf.Location = new System.Drawing.Point(396, 153);
            this.inputPersonCpf.Name = "inputPersonCpf";
            this.inputPersonCpf.Size = new System.Drawing.Size(248, 26);
            this.inputPersonCpf.TabIndex = 2;
            this.inputPersonCpf.TextChanged += new System.EventHandler(this.inputPersonCpf_TextChanged);
            // 
            // btnRemovePerson
            // 
            this.btnRemovePerson.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRemovePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePerson.Location = new System.Drawing.Point(576, 384);
            this.btnRemovePerson.Name = "btnRemovePerson";
            this.btnRemovePerson.Size = new System.Drawing.Size(102, 41);
            this.btnRemovePerson.TabIndex = 3;
            this.btnRemovePerson.Text = "Remover";
            this.btnRemovePerson.UseVisualStyleBackColor = false;
            this.btnRemovePerson.Click += new System.EventHandler(this.btnRemovePerson_Click);
            // 
            // outputMessageError
            // 
            this.outputMessageError.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputMessageError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputMessageError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMessageError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.outputMessageError.Location = new System.Drawing.Point(51, 283);
            this.outputMessageError.Multiline = true;
            this.outputMessageError.Name = "outputMessageError";
            this.outputMessageError.ReadOnly = true;
            this.outputMessageError.Size = new System.Drawing.Size(222, 42);
            this.outputMessageError.TabIndex = 4;
            this.outputMessageError.Text = "ErrorMessage";
            // 
            // outputMessageOk
            // 
            this.outputMessageOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputMessageOk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputMessageOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMessageOk.ForeColor = System.Drawing.Color.DarkGreen;
            this.outputMessageOk.Location = new System.Drawing.Point(51, 331);
            this.outputMessageOk.Multiline = true;
            this.outputMessageOk.Name = "outputMessageOk";
            this.outputMessageOk.ReadOnly = true;
            this.outputMessageOk.Size = new System.Drawing.Size(222, 42);
            this.outputMessageOk.TabIndex = 5;
            this.outputMessageOk.Text = "AcceptedMessage";
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(468, 384);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(102, 41);
            this.btnBackToMenu.TabIndex = 7;
            this.btnBackToMenu.Text = "Voltar";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 437);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.outputMessageOk);
            this.Controls.Add(this.outputMessageError);
            this.Controls.Add(this.btnRemovePerson);
            this.Controls.Add(this.inputPersonCpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar Pessoa";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPersonCpf;
        private System.Windows.Forms.Button btnRemovePerson;
        private System.Windows.Forms.TextBox outputMessageError;
        private System.Windows.Forms.TextBox outputMessageOk;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}