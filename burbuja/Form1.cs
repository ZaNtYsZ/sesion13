using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Operaciones;

namespace burbuja,operaciones
{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btmagregar_Click(object sender, EventArgs e)
        {
            int number = int.Parse(lbnumbers.Text);
            numbers(i++) = number;
        } 

        private void ShowNumbers()
        {
            if (numbers.Length > 0) {
                lbnumbers.Items.Clear();
            }

            for(int i = 0; i < numbers.Length; i++)
            {
                lbnumbers.items.Add(numbers[i]);
            }
        }

        private void btmordenar_Click(object sender, EventArgs e)
        {
           metoburbuja burbuja = new metoburbuja();
        }
    }
}
