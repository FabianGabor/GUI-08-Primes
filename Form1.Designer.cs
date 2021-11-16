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
            this.labelInputFactorial = new System.Windows.Forms.Label();
            this.textBoxInputFactorial = new System.Windows.Forms.TextBox();
            this.labelEquals = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInputFactorial
            // 
            this.labelInputFactorial.Location = new System.Drawing.Point(12, 9);
            this.labelInputFactorial.Name = "labelInputFactorial";
            this.labelInputFactorial.Size = new System.Drawing.Size(112, 20);
            this.labelInputFactorial.TabIndex = 0;
            this.labelInputFactorial.Text = "Factorial of";
            // 
            // textBoxInputFactorial
            // 
            this.textBoxInputFactorial.Location = new System.Drawing.Point(83, 6);
            this.textBoxInputFactorial.Name = "textBoxInputFactorial";
            this.textBoxInputFactorial.Size = new System.Drawing.Size(82, 20);
            this.textBoxInputFactorial.TabIndex = 1;
            // 
            // labelEquals
            // 
            this.labelEquals.Location = new System.Drawing.Point(171, 9);
            this.labelEquals.Name = "labelEquals";
            this.labelEquals.Size = new System.Drawing.Size(13, 20);
            this.labelEquals.TabIndex = 2;
            this.labelEquals.Text = "=";
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(190, 9);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(140, 20);
            this.labelResult.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelEquals);
            this.Controls.Add(this.textBoxInputFactorial);
            this.Controls.Add(this.labelInputFactorial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCalculate;

        private System.Windows.Forms.Label labelInputFactorial;
        private System.Windows.Forms.TextBox textBoxInputFactorial;
        private System.Windows.Forms.Label labelEquals;

        #endregion
    }
}