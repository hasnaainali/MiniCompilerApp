namespace MiniCompilerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox symbolTableTextBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.compileButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.symbolTableTextBox = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            // Code TextBox
            this.codeTextBox.Location = new System.Drawing.Point(12, 12);
            this.codeTextBox.Multiline = true;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(500, 150);
            this.codeTextBox.TabIndex = 0;

            // Compile Button
            this.compileButton.Location = new System.Drawing.Point(12, 180);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(100, 30);
            this.compileButton.TabIndex = 1;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);

            // Result Label
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 220);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(92, 15);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Compilation Result";

            // Symbol Table TextBox
            this.symbolTableTextBox.Location = new System.Drawing.Point(12, 250);
            this.symbolTableTextBox.Multiline = true;
            this.symbolTableTextBox.Name = "symbolTableTextBox";
            this.symbolTableTextBox.ReadOnly = true;
            this.symbolTableTextBox.Size = new System.Drawing.Size(500, 150);
            this.symbolTableTextBox.TabIndex = 3;

            // Form1
            this.ClientSize = new System.Drawing.Size(534, 421);
            this.Controls.Add(this.symbolTableTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.compileButton);
            this.Controls.Add(this.codeTextBox);
            this.Name = "Form1";
            this.Text = "Mini Compiler App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
