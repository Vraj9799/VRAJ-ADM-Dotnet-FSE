
namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Addition = new System.Windows.Forms.RadioButton();
            this.Subtraction = new System.Windows.Forms.RadioButton();
            this.Multiplication = new System.Windows.Forms.RadioButton();
            this.Division = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Number 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // Addition
            // 
            this.Addition.AutoSize = true;
            this.Addition.Location = new System.Drawing.Point(67, 126);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(80, 21);
            this.Addition.TabIndex = 4;
            this.Addition.TabStop = true;
            this.Addition.Text = "Addition";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.CheckedChanged += new System.EventHandler(this.Addition_CheckedChanged);
            // 
            // Subtraction
            // 
            this.Subtraction.AutoSize = true;
            this.Subtraction.Location = new System.Drawing.Point(203, 126);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(101, 21);
            this.Subtraction.TabIndex = 5;
            this.Subtraction.TabStop = true;
            this.Subtraction.Text = "Subtraction";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.CheckedChanged += new System.EventHandler(this.Subtraction_CheckedChanged);
            // 
            // Multiplication
            // 
            this.Multiplication.AutoSize = true;
            this.Multiplication.Location = new System.Drawing.Point(67, 176);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(110, 21);
            this.Multiplication.TabIndex = 6;
            this.Multiplication.TabStop = true;
            this.Multiplication.Text = "Multiplication";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.CheckedChanged += new System.EventHandler(this.Multiplication_CheckedChanged);
            // 
            // Division
            // 
            this.Division.AutoSize = true;
            this.Division.Location = new System.Drawing.Point(203, 176);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(78, 21);
            this.Division.TabIndex = 7;
            this.Division.TabStop = true;
            this.Division.Text = "Division";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.CheckedChanged += new System.EventHandler(this.Division_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton Addition;
        private System.Windows.Forms.RadioButton Subtraction;
        private System.Windows.Forms.RadioButton Multiplication;
        private System.Windows.Forms.RadioButton Division;
    }
}

