namespace Tester
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericTextBox1 = new NumericTextBox.NumericTextBox();
            SuspendLayout();
            // 
            // numericTextBox1
            // 
            numericTextBox1.BackColor = Color.Pink;
            numericTextBox1.ForeColor = Color.Black;
            numericTextBox1.HasDecimal = false;
            numericTextBox1.Location = new Point(12, 12);
            numericTextBox1.Name = "numericTextBox1";
            numericTextBox1.Size = new Size(100, 23);
            numericTextBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericTextBox.NumericTextBox numericTextBox1;
    }
}
