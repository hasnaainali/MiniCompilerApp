// Form1.Designer.cs
namespace MiniCompilerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label resultLabel;

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
            this.compileButton = new System.Windows.Forms.Button();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // compileButton
            this.compileButton.Location = new System.Drawing.Point(100, 150);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(75, 23);
            this.compileButton.TabIndex = 0;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);

            // codeTextBox
            this.codeTextBox.Location = new System.Drawing.Point(50, 50);
            this.codeTextBox.Multiline = true;
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(200, 80);
            this.codeTextBox.TabIndex = 1;

            // resultLabel
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(50, 200);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 15);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Result";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.compileButton);
            this.Name = "Form1";
            this.Text = "Syntax Checker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
