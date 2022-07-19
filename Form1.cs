using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_encrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Enter the first number: ");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Console.ReadLine());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Enter the second number: ");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine(sum);
        }
    }
}
