using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CGPA_CALCULATOR
{
    public partial class Form1 : Form
    {

        static double q = 0.0, g = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        

        void Set1()
        {
            double a, c;
            a = double.Parse(comboBox1.Text);
            c = double.Parse(textBox1.Text);
            q = (q + c);
            if (a == 4)
            {
                g = (g + (a * c));
                textBox14.Text = (a * c).ToString();
            }
            else if (a == 3.7)
            {
                g = (g + (a * c));
                textBox14.Text = (a * c).ToString();
            }
            else if (a == 3.3)
            {
                g = (g + (a * c));
                textBox14.Text = (a * c).ToString();
            }
            else if (a == 3)
            {
                g = (g + (a * c));
                textBox14.Text = (a * c).ToString();
            }

            else if (a == 2.7)
            {
                g = (g + (a * c));
                textBox14.Text = (a * c).ToString();
            }

            else if (a == 2.3)
            {
                g = (g + (a * c));
                textBox14.Text = (a * c).ToString();
            }
            else if (a == 2)
            {
                g = (g + (a * c));
                textBox14.Text = (a * c).ToString();
            }
            else if (a == 1.7)
            {
                g = (g + (a * c));
                textBox14.Text = (a * c).ToString();
            }
            else if (a == 1.3)
            {
                g = (g + (a * c));
                textBox14.Text = (a * c).ToString();
            }
            else if (a == 1)
            {
                g = (g + (a * c));
                textBox14.Text = ((a * c).ToString());
            }
            else
            {
                g = (g + (a * c));
                textBox14.Text = (a * 0).ToString();
            }
        }
        void Set2()
        {
            double a, c;
            a = double.Parse(comboBox2.Text);
            c = double.Parse(textBox2.Text);
            q = (q + c);
            if (a == 4)
            {
                g = (g + (a * c));
                textBox13.Text = (a * c).ToString();
            }
            else if (a == 3.7)
            {
                g = (g + (a * c));
                textBox13.Text = (a * c).ToString();
            }
            else if (a == 3.3)
            {
                g = (g + (a * c));
                textBox13.Text = (a * c).ToString();
            }
            else if (a == 3)
            {
                g = (g + (a * c));
                textBox13.Text = (a * c).ToString();
            }

            else if (a == 2.7)
            {
                g = (g + (a * c));
                textBox13.Text = (a * c).ToString();
            }

            else if (a == 2.3)
            {
                g = (g + (a * c));
                textBox13.Text = (a * c).ToString();
            }
            else if (a == 2)
            {
                g = (g + (a * c));
                textBox13.Text = (a * c).ToString();
            }
            else if (a == 1.7)
            {
                g = (g + (a * c));
                textBox13.Text = (a * c).ToString();
            }
            else if (a == 1.3)
            {
                g = (g + (a * c));
                textBox13.Text = (a * c).ToString();
            }
            else if (a == 1)
            {
                g = (g + (a * c));
                textBox13.Text = ((a * c).ToString());
            }
            else
            {
                g = (g + (a * c));
                textBox13.Text = (a * 0).ToString();
            }
        }
        
        void Set3()
        {
            double a, c;
            a = double.Parse(comboBox3.Text);
            c = double.Parse(textBox3.Text);
            q = (q + c);
            if (a == 4)
            {
                g = (g + (a * c));
                textBox12.Text = (a * c).ToString();
            }
            else if (a == 3.7)
            {
                g = (g + (a * c));
                textBox12.Text = (a * c).ToString();
            }
            else if (a == 3.3)
            {
                g = (g + (a * c));
                textBox12.Text = (a * c).ToString();
            }
            else if (a == 3)
            {
                g = (g + (a * c));
                textBox12.Text = (a * c).ToString();
            }

            else if (a == 2.7)
            {
                g = (g + (a * c));
                textBox12.Text = (a * c).ToString();
            }

            else if (a == 2.3)
            {
                g = (g + (a * c));
                textBox12.Text = (a * c).ToString();
            }
            else if (a == 2)
            {
                g = (g + (a * c));
                textBox12.Text = (a * c).ToString();
            }
            else if (a == 1.7)
            {
                g = (g + (a * c));
                textBox12.Text = (a * c).ToString();
            }
            else if (a == 1.3)
            {
                g = (g + (a * c));
                textBox12.Text = (a * c).ToString();
            }
            else if (a == 1)
            {
                g = (g + (a * c));
                textBox12.Text = ((a * c).ToString());
            }
            else
            {
                g = (g + (a * c));
                textBox12.Text = (a * 0).ToString();
            }
        }
        
        void Set4()
        {
            double a, c;
            a = double.Parse(comboBox4.Text);
            c = double.Parse(textBox4.Text);
            q = (q + c);
            if (a == 4)
            {
                g = (g + (a * c));
                textBox11.Text = (a * c).ToString();
            }
            else if (a == 3.7)
            {
                g = (g + (a * c));
                textBox11.Text = (a * c).ToString();
            }
            else if (a == 3.3)
            {
                g = (g + (a * c));
                textBox11.Text = (a * c).ToString();
            }
            else if (a == 3)
            {
                g = (g + (a * c));
                textBox11.Text = (a * c).ToString();
            }

            else if (a == 2.7)
            {
                g = (g + (a * c));
                textBox11.Text = (a * c).ToString();
            }

            else if (a == 2.3)
            {
                g = (g + (a * c));
                textBox11.Text = (a * c).ToString();
            }
            else if (a == 2)
            {
                g = (g + (a * c));
                textBox11.Text = (a * c).ToString();
            }
            else if (a == 1.7)
            {
                g = (g + (a * c));
                textBox11.Text = (a * c).ToString();
            }
            else if (a == 1.3)
            {
                g = (g + (a * c));
                textBox11.Text = (a * c).ToString();
            }
            else if (a == 1)
            {
                g = (g + (a * c));
                textBox11.Text = ((a * c).ToString());
            }
            else
            {
                g = (g + (a * c));
                textBox11.Text = (a * 0).ToString();
            }
        }
        
        void Set5()
        {
            double a, c;
            a = double.Parse(comboBox5.Text);
            c = double.Parse(textBox5.Text);
            q = (q + c);
            if (a == 4)
            {
                g = (g + (a * c));
                textBox10.Text = (a * c).ToString();
            }
            else if (a == 3.7)
            {
                g = (g + (a * c));
                textBox10.Text = (a * c).ToString();
            }
            else if (a == 3.3)
            {
                g = (g + (a * c));
                textBox10.Text = (a * c).ToString();
            }
            else if (a == 3)
            {
                g = (g + (a * c));
                textBox10.Text = (a * c).ToString();
            }

            else if (a == 2.7)
            {
                g = (g + (a * c));
                textBox10.Text = (a * c).ToString();
            }

            else if (a == 2.3)
            {
                g = (g + (a * c));
                textBox10.Text = (a * c).ToString();
            }
            else if (a == 2)
            {
                g = (g + (a * c));
                textBox10.Text = (a * c).ToString();
            }
            else if (a == 1.7)
            {
                g = (g + (a * c));
                textBox10.Text = (a * c).ToString();
            }
            else if (a == 1.3)
            {
                g = (g + (a * c));
                textBox10.Text = (a * c).ToString();
            }
            else if (a == 1)
            {
                g = (g + (a * c));
                textBox10.Text = ((a * c).ToString());
            }
            else
            {
                g = (g + (a * c));
                textBox10.Text = (a * 0).ToString();
            }
        }
        
        void Set6()
        {
            double a, c;
            a = double.Parse(comboBox6.Text);
            c = double.Parse(textBox6.Text);
            q = (q + c);
            if (a == 4)
            {
                g = (g + (a * c));
                textBox9.Text = (a * c).ToString();
            }
            else if (a == 3.7)
            {
                g = (g + (a * c));
                textBox9.Text = (a * c).ToString();
            }
            else if (a == 3.3)
            {
                g = (g + (a * c));
                textBox9.Text = (a * c).ToString();
            }
            else if (a == 3)
            {
                g = (g + (a * c));
                textBox9.Text = (a * c).ToString();
            }

            else if (a == 2.7)
            {
                g = (g + (a * c));
                textBox9.Text = (a * c).ToString();
            }

            else if (a == 2.3)
            {
                g = (g + (a * c));
                textBox9.Text = (a * c).ToString();
            }
            else if (a == 2)
            {
                g = (g + (a * c));
                textBox9.Text = (a * c).ToString();
            }
            else if (a == 1.7)
            {
                g = (g + (a * c));
                textBox9.Text = (a * c).ToString();
            }
            else if (a == 1.3)
            {
                g = (g + (a * c));
                textBox9.Text = (a * c).ToString();
            }
            else if (a == 1)
            {
                g = (g + (a * c));
                textBox9.Text = ((a * c).ToString());
            }
            else
            {
                g = (g + (a * c));
                textBox9.Text = (a * 0).ToString();
            }
        }
        
        void Set7()
        {
            double a, c;
            a = double.Parse(comboBox7.Text);
            c = double.Parse(textBox7.Text);
            q = (q + c);
            if (a == 4)
            {
                g = (g + (a * c));
                textBox8.Text = (a * c).ToString();
            }
            else if (a == 3.7)
            {
                g = (g + (a * c));
                textBox8.Text = (a * c).ToString();
            }
            else if (a == 3.3)
            {
                g = (g + (a * c));
                textBox8.Text = (a * c).ToString();
            }
            else if (a == 3)
            {
                g = (g + (a * c));
                textBox8.Text = (a * c).ToString();
            }

            else if (a == 2.7)
            {
                g = (g + (a * c));
                textBox8.Text = (a * c).ToString();
            }

            else if (a == 2.3)
            {
                g = (g + (a * c));
                textBox8.Text = (a * c).ToString();
            }
            else if (a == 2)
            {
                g = (g + (a * c));
                textBox8.Text = (a * c).ToString();
            }
            else if (a == 1.7)
            {
                g = (g + (a * c));
                textBox8.Text = (a * c).ToString();
            }
            else if (a == 1.3)
            {
                g = (g + (a * c));
                textBox8.Text = (a * c).ToString();
            }
            else if (a == 1)
            {
                g = (g + (a * c));
                textBox8.Text = ((a * c).ToString());
            }
            else
            {
                g = (g + (a * c));
                textBox8.Text = (a * 0).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox17.Text = q.ToString();
            textBox16.Text = g.ToString();
            textBox15.Text = (g / q).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = q = 0;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            textBox13.Text = string.Empty;
            textBox14.Text = string.Empty;
            textBox15.Text = string.Empty;
            textBox16.Text = string.Empty;
            textBox17.Text = string.Empty;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set1();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set2();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set3();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set4();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set5();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set6();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Set7();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
