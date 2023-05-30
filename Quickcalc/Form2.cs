using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Quickcalc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private float left = 0;
        private float right = 100;
        private float step = 1;

        
       
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // only allow one negative sign
            if (e.KeyChar == '-' && (sender as TextBox).Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // only allow one negative sign
            if (e.KeyChar == '-' && (sender as TextBox).Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // only allow one negative sign
            if (e.KeyChar == '-' && (sender as TextBox).Text.IndexOf('-') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(textBox1.Text, out left);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(textBox2.Text,out right);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            float.TryParse(textBox4.Text, out step);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            chart1.Series["Series1"].Points.Clear();
            error.Visible = false;


            for (float i = left; i <= right; i += step)
            {
                Expression expression = new Expression(textBox3.Text,new Argument("x", i));

                
                double result = expression.calculate();

                if (!Double.IsNaN(result)) 
                {
                    chart1.Series["Series1"].Points.AddXY(i, result);
                }

                if (chart1.Series["Series1"].Points.Count==0)
                {
                    error.Visible = true;
                }

            }

            
        }
    }
}
