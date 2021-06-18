
namespace WindowsApp.Forms
{
    partial class Form6Extra
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
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.outputPrintTree = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMenu.Location = new System.Drawing.Point(576, 384);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(102, 41);
            this.btnBackToMenu.TabIndex = 5;
            this.btnBackToMenu.Text = "Voltar";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // outputPrintTree
            // 
            this.outputPrintTree.BackColor = System.Drawing.Color.Gainsboro;
            this.outputPrintTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputPrintTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputPrintTree.Location = new System.Drawing.Point(79, 66);
            this.outputPrintTree.Multiline = true;
            this.outputPrintTree.Name = "outputPrintTree";
            this.outputPrintTree.ReadOnly = true;
            this.outputPrintTree.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputPrintTree.Size = new System.Drawing.Size(526, 312);
            this.outputPrintTree.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Impressão da Árvore";
            // 
            // Form6Extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 437);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.outputPrintTree);
            this.Controls.Add(this.label1);
            this.Name = "Form6Extra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir Árvore";
            this.Load += new System.EventHandler(this.Form6Extra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.TextBox outputPrintTree;
        private System.Windows.Forms.Label label1;
    }
}