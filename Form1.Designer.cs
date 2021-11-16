namespace GUI_08_Factorial
{
    partial class Form1
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
            this.labelInputPrime = new System.Windows.Forms.Label();
            this.textBoxInputFactorial = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelInputPrime
            // 
            this.labelInputPrime.Location = new System.Drawing.Point(12, 9);
            this.labelInputPrime.Name = "labelInputPrime";
            this.labelInputPrime.Size = new System.Drawing.Size(112, 20);
            this.labelInputPrime.TabIndex = 0;
            this.labelInputPrime.Text = "Primes up to";
            // 
            // textBoxInputFactorial
            // 
            this.textBoxInputFactorial.Location = new System.Drawing.Point(83, 6);
            this.textBoxInputFactorial.Name = "textBoxInputFactorial";
            this.textBoxInputFactorial.Size = new System.Drawing.Size(82, 20);
            this.textBoxInputFactorial.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(12, 32);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(165, 22);
            this.buttonCalculate.TabIndex = 4;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(15, 68);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(773, 370);
            this.textBoxResult.TabIndex = 5;
            this.textBoxResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxInputFactorial);
            this.Controls.Add(this.labelInputPrime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelInputPrime;

        private System.Windows.Forms.RichTextBox textBoxResult;

        private System.Windows.Forms.RichTextBox textBoxResults;

        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCalculate;

        private System.Windows.Forms.Label labelInputFactorial;
        private System.Windows.Forms.TextBox textBoxInputFactorial;
        private System.Windows.Forms.Label labelEquals;

        #endregion
    }
}