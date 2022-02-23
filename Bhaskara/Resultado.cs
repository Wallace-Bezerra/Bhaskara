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
    public partial class Resultado : Form
    {
       
        public Resultado(Bhaskara conta)
        {
            InitializeComponent();

            label_X1.Text = $"x1: {conta.X1.ToString()}";
            label_X2.Text = $"x2: {conta.X2.ToString()}";
        }
        private void Resultado_Load(object sender, EventArgs e)
        {
            //textBox1.Text = X1.ToString();
        }
    }
}
