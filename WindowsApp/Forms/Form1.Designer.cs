
namespace WindowsApp.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputFilePath = new System.Windows.Forms.TextBox();
            this.inputFileName = new System.Windows.Forms.TextBox();
            this.inputFileExtension = new System.Windows.Forms.TextBox();
            this.btnNextToMenu = new System.Windows.Forms.Button();
            this.outputMessageError = new System.Windows.Forms.TextBox();
            this.outputMessageOk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seja Bem-Vindo ao Aplicativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Caminho do Arquivo (Path):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Arquivo (Name):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Extensão do Arquivo (Extension):";
            // 
            // inputFilePath
            // 
            this.inputFilePath.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFilePath.Enabled = false;
            this.inputFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFilePath.ForeColor = System.Drawing.SystemColors.Window;
            this.inputFilePath.Location = new System.Drawing.Point(340, 151);
            this.inputFilePath.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.inputFilePath.Name = "inputFilePath";
            this.inputFilePath.Size = new System.Drawing.Size(321, 26);
            this.inputFilePath.TabIndex = 4;
            this.inputFilePath.Text = "<desabilitado>";
            this.inputFilePath.TextChanged += new System.EventHandler(this.inputFilePath_TextChanged);
            // 
            // inputFileName
            // 
            this.inputFileName.AccessibleDescription = "";
            this.inputFileName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFileName.Location = new System.Drawing.Point(340, 205);
            this.inputFileName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.inputFileName.Name = "inputFileName";
            this.inputFileName.Size = new System.Drawing.Size(321, 26);
            this.inputFileName.TabIndex = 5;
            this.inputFileName.TextChanged += new System.EventHandler(this.inputFileName_TextChanged);
            // 
            // inputFileExtension
            // 
            this.inputFileExtension.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.inputFileExtension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFileExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFileExtension.Location = new System.Drawing.Point(340, 261);
            this.inputFileExtension.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.inputFileExtension.Name = "inputFileExtension";
            this.inputFileExtension.Size = new System.Drawing.Size(321, 26);
            this.inputFileExtension.TabIndex = 6;
            this.inputFileExtension.TextChanged += new System.EventHandler(this.inputFileExtension_TextChanged);
            // 
            // btnNextToMenu
            // 
            this.btnNextToMenu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNextToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextToMenu.Location = new System.Drawing.Point(576, 384);
            this.btnNextToMenu.Name = "btnNextToMenu";
            this.btnNextToMenu.Size = new System.Drawing.Size(102, 41);
            this.btnNextToMenu.TabIndex = 7;
            this.btnNextToMenu.Text = "Avançar";
            this.btnNextToMenu.UseVisualStyleBackColor = false;
            this.btnNextToMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputMessageError
            // 
            this.outputMessageError.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputMessageError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputMessageError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMessageError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.outputMessageError.Location = new System.Drawing.Point(44, 359);
            this.outputMessageError.Multiline = true;
            this.outputMessageError.Name = "outputMessageError";
            this.outputMessageError.ReadOnly = true;
            this.outputMessageError.Size = new System.Drawing.Size(385, 66);
            this.outputMessageError.TabIndex = 8;
            this.outputMessageError.Text = "ErrorMessage";
            // 
            // outputMessageOk
            // 
            this.outputMessageOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputMessageOk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputMessageOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMessageOk.ForeColor = System.Drawing.Color.DarkGreen;
            this.outputMessageOk.Location = new System.Drawing.Point(44, 316);
            this.outputMessageOk.Multiline = true;
            this.outputMessageOk.Name = "outputMessageOk";
            this.outputMessageOk.ReadOnly = true;
            this.outputMessageOk.Size = new System.Drawing.Size(264, 27);
            this.outputMessageOk.TabIndex = 9;
            this.outputMessageOk.Text = "AcceptedMessage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(563, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Não obrigatório.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 437);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outputMessageOk);
            this.Controls.Add(this.outputMessageError);
            this.Controls.Add(this.btnNextToMenu);
            this.Controls.Add(this.inputFileExtension);
            this.Controls.Add(this.inputFileName);
            this.Controls.Add(this.inputFilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Contatos";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputFilePath;
        private System.Windows.Forms.TextBox inputFileName;
        private System.Windows.Forms.TextBox inputFileExtension;
        private System.Windows.Forms.Button btnNextToMenu;
        private System.Windows.Forms.TextBox outputMessageError;
        private System.Windows.Forms.TextBox outputMessageOk;
        private System.Windows.Forms.Label label5;
    }
}

