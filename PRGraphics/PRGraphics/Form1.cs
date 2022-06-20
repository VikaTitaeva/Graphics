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

namespace PRGraphics
{
    public partial class Form1 : Form
    {
        private double a, b, h;
        private double x, y;

        public Form1()
        {
            InitializeComponent();
        }
        private void DefaultParams()
        {
            a = -10;
            b = 10;
            h = 0.1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            h = Convert.ToDouble(textBox3.Text);
            if (comboBox1.SelectedIndex==0)
            {
                x = a;
                this.chart1.Series[0].Points.Clear();
                while (x <= b)
                {
                    y = Math.Pow(x,2)*Math.Cos(x);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                x = a;
                this.chart1.Series[0].Points.Clear();
                while (x <= b)
                {
                    y = Math.Pow(Math.Sin(Math.Pow(x,3)),2);
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                x = a;
                this.chart1.Series[0].Points.Clear();
                while (x <= b)
                {
                    y = Math.Sin(Math.Pow(x,2));
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                x = a;
                this.chart1.Series[0].Points.Clear();
                while (x <= b)
                {
                    y = Math.Pow(x,4)+Math.Pow(x,3)-x;
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
            if (comboBox1.SelectedIndex == 4)
            {
                x = a;
                this.chart1.Series[0].Points.Clear();
                while (x <= b)
                {
                    y = Math.Log(Math.Sin(x + 1));
                    this.chart1.Series[0].Points.AddXY(x, y);
                    x += h;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
       
        

        private void Postr_btn_Click(object sender, EventArgs e)
        {
          
        }

        public void grafics_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}




