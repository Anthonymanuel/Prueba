using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaDeDosNumeros
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }

        private void SumarButton_Click(object sender, EventArgs e)
        {
            double num1, num2, res = 0;
            double.TryParse(numero1TextBox.Text,out num1);
            double.TryParse(numero2TextBox.Text, out num2);
            resultadoTextBox.Text = (res = num1 + num2).ToString();
           
        }
    }
}
