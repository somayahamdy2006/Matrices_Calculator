using System;
using System.Windows.Forms;
namespace Matrices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[,] ParseMatrix(string text)
        {
            var rows = text.Trim().Split('\n');
            int r = rows.Length;
            int c = rows[0].Trim().Split(' ').Length;

            double[,] m = new double[r, c];

            for (int i = 0; i < r; i++)
            {
                var nums = rows[i].Trim().Split(' ');
                for (int j = 0; j < c; j++)
                    m[i, j] = double.Parse(nums[j]);
            }
            return m;
        }
        // Convert the Matrix to Text
        string MatrixToString(double[,] m)
        {
            string result = "";
            int r = m.GetLength(0);
            int c = m.GetLength(1);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                    result += m[i, j] + " ";
                result += Environment.NewLine;
            }
            return result;
        }
        // Combine button
        private void Add_Click(object sender, EventArgs e)
        {
            var A = ParseMatrix(Matrix1.Text);
            var B = ParseMatrix(Matrix2.Text);
            int r = A.GetLength(0);
            int c = A.GetLength(1);
            double[,] R = new double[r, c];
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    R[i, j] = A[i, j] + B[i, j];
            Result.Text = MatrixToString(R);
        }
        // Subtract button
        private void Subtract_Click(object sender, EventArgs e)
        {
            var A = ParseMatrix(Matrix1.Text);
            var B = ParseMatrix(Matrix2.Text);
            int r = A.GetLength(0);
            int c = A.GetLength(1);
            double[,] R = new double[r, c];
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    R[i, j] = A[i, j] - B[i, j];
            Result.Text = MatrixToString(R);
        }
        // Multiplication button
        private void Multiply_Click(object sender, EventArgs e)
        {
            var A = ParseMatrix(Matrix1.Text);
            var B = ParseMatrix(Matrix2.Text);
            int r1 = A.GetLength(0);
            int c1 = A.GetLength(1);
            int r2 = B.GetLength(0);
            int c2 = B.GetLength(1);
            if (c1 != r2)
            {
                MessageBox.Show("عدد أعمدة Matrix1 يجب يساوي عدد صفوف Matrix2");
                return;
            }
            double[,] R = new double[r1, c2];
            for (int i = 0; i < r1; i++)
                for (int j = 0; j < c2; j++)
                    for (int k = 0; k < c1; k++)
                        R[i, j] += A[i, k] * B[k, j];
            Result.Text = MatrixToString(R);
        }
        // Determinant
        private double Determinant(double[,] m)
        {
            int n = m.GetLength(0);
            if (n == 1) return m[0, 0];
            if (n == 2) return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
            double det = 0;
            for (int k = 0; k < n; k++)
            {
                double[,] sub = new double[n - 1, n - 1];
                for (int i = 1; i < n; i++)
                {
                    int colIndex = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j == k) continue;
                        sub[i - 1, colIndex++] = m[i, j];
                    }
                }
                det += Math.Pow(-1, k) * m[0, k] * Determinant(sub);
            }
            return det;
        }
        private void Determinant1_Click(object sender, EventArgs e)
        {
            var A = ParseMatrix(Matrix1.Text);
            double det = Determinant(A);
            Result.Text = "Determinant = " + det;
        }
        // Inverse Matrix
        private double[,] Adjoint(double[,] m)
        {
            int n = m.GetLength(0);
            double[,] adj = new double[n, n];
            if (n == 1)
            {
                adj[0, 0] = 1;
                return adj;
            }
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    double[,] sub = new double[n - 1, n - 1];
                    int r = 0, c = 0;
                    for (int x = 0; x < n; x++)
                    {
                        if (x == i) continue;
                        c = 0;
                        for (int y = 0; y < n; y++)
                        {
                            if (y == j) continue;
                            sub[r, c++] = m[x, y];
                        }
                        r++;
                    }
                    adj[j, i] = Math.Pow(-1, i + j) * Determinant(sub);
                }
            return adj;
        }
        private void Inverse1_Click(object sender, EventArgs e)
        {
            var A = ParseMatrix(Matrix1.Text);
            double det = Determinant(A);
            double epsilon = 1e-10; // قيمة صغيرة جدًا

            if (Math.Abs(det) < epsilon)
            {
                MessageBox.Show("المصفوفة غير قابلة للعكس!");
                return;
            }
            double[,] adj = Adjoint(A);
            int n = A.GetLength(0);
            double[,] inv = new double[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    inv[i, j] = adj[i, j] / det;

            Result.Text = MatrixToString(inv);
        }
    }
}