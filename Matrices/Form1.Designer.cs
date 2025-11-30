namespace Matrices
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
        private void InitializeComponent()
        {
            Matrix1 = new TextBox();
            Matrix2 = new TextBox();
            Result = new TextBox();
            Add = new Button();
            Subtract = new Button();
            Multiply = new Button();
            Inverse1 = new Button();
            Determinant1 = new Button();
            Add.Click += Add_Click;
            Subtract.Click += Subtract_Click;
            Multiply.Click += Multiply_Click;
            Determinant1.Click += Determinant1_Click;
            Inverse1.Click += Inverse1_Click;
            SuspendLayout();
            // Matrix1
            Matrix1.BackColor = SystemColors.InactiveCaption;
            Matrix1.Location = new Point(0, 2);
            Matrix1.Multiline = true;
            Matrix1.Name = "Matrix1";
            Matrix1.Size = new Size(517, 205);
            Matrix1.TabIndex = 0;
            Matrix1.TextChanged += Matrix1_TextChanged;
            // Matrix2
            Matrix2.BackColor = SystemColors.InactiveCaption;
            Matrix2.Location = new Point(786, 2);
            Matrix2.Multiline = true;
            Matrix2.Name = "Matrix2";
            Matrix2.Size = new Size(517, 205);
            Matrix2.TabIndex = 1;
            // Result
            Result.BackColor = SystemColors.InactiveCaption;
            Result.Location = new Point(0, 518);
            Result.Multiline = true;
            Result.Name = "Result";
            Result.Size = new Size(1303, 205);
            Result.TabIndex = 2;
            // Add
            Add.BackColor = SystemColors.ControlDarkDark;
            Add.ForeColor = SystemColors.Control;
            Add.Location = new Point(0, 259);
            Add.Name = "Add";
            Add.Size = new Size(167, 87);
            Add.TabIndex = 3;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            // Subtract
            Subtract.BackColor = SystemColors.ControlDarkDark;
            Subtract.ForeColor = SystemColors.Control;
            Subtract.Location = new Point(567, 259);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(167, 87);
            Subtract.TabIndex = 4;
            Subtract.Text = "Subtract";
            Subtract.UseVisualStyleBackColor = false;
            // Multiply
            Multiply.BackColor = SystemColors.ControlDarkDark;
            Multiply.ForeColor = SystemColors.Control;
            Multiply.Location = new Point(1136, 259);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(167, 87);
            Multiply.TabIndex = 5;
            Multiply.Text = "Multiply";
            Multiply.UseVisualStyleBackColor = false;
            // Inverse1
            Inverse1.BackColor = SystemColors.ControlDarkDark;
            Inverse1.ForeColor = SystemColors.Control;
            Inverse1.Location = new Point(567, 384);
            Inverse1.Name = "Inverse1";
            Inverse1.Size = new Size(167, 87);
            Inverse1.TabIndex = 6;
            Inverse1.Text = "Inverse1";
            Inverse1.UseVisualStyleBackColor = false;
            // Determinant1
            Determinant1.BackColor = SystemColors.ControlDarkDark;
            Determinant1.ForeColor = SystemColors.Control;
            Determinant1.Location = new Point(0, 384);
            Determinant1.Name = "Determinant1";
            Determinant1.Size = new Size(167, 87);
            Determinant1.TabIndex = 7;
            Determinant1.Text = "Determinant1";
            Determinant1.UseVisualStyleBackColor = false;
            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 726);
            Controls.Add(Determinant1);
            Controls.Add(Inverse1);
            Controls.Add(Multiply);
            Controls.Add(Subtract);
            Controls.Add(Add);
            Controls.Add(Result);
            Controls.Add(Matrix2);
            Controls.Add(Matrix1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private TextBox Matrix1;
        private TextBox Matrix2;
        private TextBox Result;
        private Button Add;
        private Button Subtract;
        private Button Multiply;
        private Button Inverse1;
        private Button Determinant1;
        private void Matrix1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
