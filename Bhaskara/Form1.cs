using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button_Calcular_Click(object sender, EventArgs e)
        {
            Bhaskara conta = new Bhaskara(Convert.ToInt32(textBox_A.Text),
                Convert.ToInt32(textBox_B.Text),Convert.ToInt32(textBox_C.Text));
            
            int Delta = conta.Delta(conta.A, conta.B, conta.C);
            conta.X1 = (-conta.B + (int)Math.Sqrt(Delta)) / (2*conta.A);
            //conta.X2 = (-conta.B - (int)Math.Sqrt(Delta)) / (2*conta.A);
            conta.X2 = (-conta.B - Math.Sqrt(Delta)) / (2 * conta.A);

            Resultado resultado = new Resultado(conta);
            resultado.ShowDialog();
            
           // MessageBox.Show(conta.X1 + "\n" +x2.ToString());
            //MessageBox.Show(Math.Sqrt(Delta).ToString());

        }
    }
}
