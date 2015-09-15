namespace SumaDeDosNumeros
{
    partial class Suma
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
            this.numero1TextBox = new System.Windows.Forms.TextBox();
            this.numero2TextBox = new System.Windows.Forms.TextBox();
            this.resultadoTextBox = new System.Windows.Forms.TextBox();
            this.SumarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // numero1TextBox
            // 
            this.numero1TextBox.Location = new System.Drawing.Point(121, 40);
            this.numero1TextBox.Name = "numero1TextBox";
            this.numero1TextBox.Size = new System.Drawing.Size(100, 20);
            this.numero1TextBox.TabIndex = 3;
            // 
            // numero2TextBox
            // 
            this.numero2TextBox.Location = new System.Drawing.Point(121, 66);
            this.numero2TextBox.Name = "numero2TextBox";
            this.numero2TextBox.Size = new System.Drawing.Size(100, 20);
            this.numero2TextBox.TabIndex = 4;
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.Location = new System.Drawing.Point(121, 105);
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.ReadOnly = true;
            this.resultadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.resultadoTextBox.TabIndex = 5;
            // 
            // SumarButton
            // 
            this.SumarButton.Location = new System.Drawing.Point(146, 150);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(75, 23);
            this.SumarButton.TabIndex = 6;
            this.SumarButton.Text = "Sumar";
            this.SumarButton.UseVisualStyleBackColor = true;
            this.SumarButton.Click += new System.EventHandler(this.SumarButton_Click);
            // 
            // Suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SumarButton);
            this.Controls.Add(this.resultadoTextBox);
            this.Controls.Add(this.numero2TextBox);
            this.Controls.Add(this.numero1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Suma";
            this.Text = "Suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numero1TextBox;
        private System.Windows.Forms.TextBox numero2TextBox;
        private System.Windows.Forms.TextBox resultadoTextBox;
        private System.Windows.Forms.Button SumarButton;
    }
}

