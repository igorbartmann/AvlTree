
namespace WindowsApp.Forms
{
    partial class Form6
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
            this.rdBtnpPrintTreeByDateBirth = new System.Windows.Forms.RadioButton();
            this.rdBtnPrintTreeByCpf = new System.Windows.Forms.RadioButton();
            this.rdBtnPrintTreeByName = new System.Windows.Forms.RadioButton();
            this.btnNextToViewTree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o Tipo da Árvore";
            // 
            // rdBtnpPrintTreeByDateBirth
            // 
            this.rdBtnpPrintTreeByDateBirth.AutoSize = true;
            this.rdBtnpPrintTreeByDateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnpPrintTreeByDateBirth.Location = new System.Drawing.Point(67, 185);
            this.rdBtnpPrintTreeByDateBirth.Margin = new System.Windows.Forms.Padding(0);
            this.rdBtnpPrintTreeByDateBirth.Name = "rdBtnpPrintTreeByDateBirth";
            this.rdBtnpPrintTreeByDateBirth.Padding = new System.Windows.Forms.Padding(10);
            this.rdBtnpPrintTreeByDateBirth.Size = new System.Drawing.Size(215, 40);
            this.rdBtnpPrintTreeByDateBirth.TabIndex = 6;
            this.rdBtnpPrintTreeByDateBirth.Text = "DATA DE NASCIMENTO";
            this.rdBtnpPrintTreeByDateBirth.UseVisualStyleBackColor = true;
            // 
            // rdBtnPrintTreeByCpf
            // 
            this.rdBtnPrintTreeByCpf.AutoSize = true;
            this.rdBtnPrintTreeByCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnPrintTreeByCpf.Location = new System.Drawing.Point(67, 145);
            this.rdBtnPrintTreeByCpf.Margin = new System.Windows.Forms.Padding(0);
            this.rdBtnPrintTreeByCpf.Name = "rdBtnPrintTreeByCpf";
            this.rdBtnPrintTreeByCpf.Padding = new System.Windows.Forms.Padding(10);
            this.rdBtnPrintTreeByCpf.Size = new System.Drawing.Size(75, 40);
            this.rdBtnPrintTreeByCpf.TabIndex = 5;
            this.rdBtnPrintTreeByCpf.Text = "CPF";
            this.rdBtnPrintTreeByCpf.UseVisualStyleBackColor = true;
            // 
            // rdBtnPrintTreeByName
            // 
            this.rdBtnPrintTreeByName.AutoSize = true;
            this.rdBtnPrintTreeByName.Checked = true;
            this.rdBtnPrintTreeByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnPrintTreeByName.Location = new System.Drawing.Point(67, 102);
            this.rdBtnPrintTreeByName.Name = "rdBtnPrintTreeByName";
            this.rdBtnPrintTreeByName.Padding = new System.Windows.Forms.Padding(10);
            this.rdBtnPrintTreeByName.Size = new System.Drawing.Size(90, 40);
            this.rdBtnPrintTreeByName.TabIndex = 4;
            this.rdBtnPrintTreeByName.TabStop = true;
            this.rdBtnPrintTreeByName.Text = "NOME";
            this.rdBtnPrintTreeByName.UseVisualStyleBackColor = true;
            // 
            // btnNextToViewTree
            // 
            this.btnNextToViewTree.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNextToViewTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextToViewTree.Location = new System.Drawing.Point(576, 384);
            this.btnNextToViewTree.Name = "btnNextToViewTree";
            this.btnNextToViewTree.Size = new System.Drawing.Size(102, 41);
            this.btnNextToViewTree.TabIndex = 9;
            this.btnNextToViewTree.Text = "Avançar";
            this.btnNextToViewTree.UseVisualStyleBackColor = false;
            this.btnNextToViewTree.Click += new System.EventHandler(this.btnNextToViewTree_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 437);
            this.Controls.Add(this.btnNextToViewTree);
            this.Controls.Add(this.rdBtnpPrintTreeByDateBirth);
            this.Controls.Add(this.rdBtnPrintTreeByCpf);
            this.Controls.Add(this.rdBtnPrintTreeByName);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir Árvore";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBtnpPrintTreeByDateBirth;
        private System.Windows.Forms.RadioButton rdBtnPrintTreeByCpf;
        private System.Windows.Forms.RadioButton rdBtnPrintTreeByName;
        private System.Windows.Forms.Button btnNextToViewTree;
    }
}