
namespace WindowsApp.Forms
{
    partial class Form4Extra
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
            this.outputPeopleFound = new System.Windows.Forms.TextBox();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pessoas Encontrados";
            // 
            // outputPeopleFound
            // 
            this.outputPeopleFound.BackColor = System.Drawing.Color.Gainsboro;
            this.outputPeopleFound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPeopleFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputPeopleFound.Location = new System.Drawing.Point(79, 66);
            this.outputPeopleFound.Multiline = true;
            this.outputPeopleFound.Name = "outputPeopleFound";
            this.outputPeopleFound.ReadOnly = true;
            this.outputPeopleFound.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputPeopleFound.Size = new System.Drawing.Size(526, 312);
            this.outputPeopleFound.TabIndex = 1;
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(576, 384);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(102, 41);
            this.btnBackToMenu.TabIndex = 2;
            this.btnBackToMenu.Text = "Voltar";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // Form4Extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 437);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.outputPeopleFound);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form4Extra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Usuário";
            this.Load += new System.EventHandler(this.Form4Extra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputPeopleFound;
        private System.Windows.Forms.Button btnBackToMenu;
    }
}