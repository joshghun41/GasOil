using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasOil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Oil ai92 = new Oil
            {
                Name = "AI-92",
                Price = 1
            };
            Oil ai95 = new Oil
            {
                Name = "AI-95",
                Price = 2
            };
            Oil ai98 = new Oil
            {
                Name = "AI-98",
                Price = 2.3
            };
            Oil dizel = new Oil
            {
                Name = "Dizel",
                Price = 0.8
            };
            List<Oil> oils = new List<Oil>();
            oils.Add(ai92);
            oils.Add(ai95);
            oils.Add(ai98);
            oils.Add(dizel);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex == 0)
            {
                qiymetLbl.Text = "1";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                qiymetLbl.Text = "2";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                qiymetLbl.Text = "2.3";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                qiymetLbl.Text = "0.8";
            }

        }



        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox2.Clear();


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox1.Enabled = false;
            textBox1.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (radioButton1.Checked)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    double default1 = Double.Parse(textBox1.Text);

                    label7.Text = default1.ToString();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    double default21 = Double.Parse(textBox1.Text) * 2;
                    label7.Text = default21.ToString();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    double default3 = Double.Parse(textBox1.Text) * 2.3;
                    label7.Text = default3.ToString();
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    double default4 = Double.Parse(textBox1.Text) * 0.8;
                    label7.Text = default4.ToString();
                }
            }
            else if (radioButton2.Checked)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    double default1 = Double.Parse(textBox2.Text);
                    double netice = default1;
                    label7.Text = netice.ToString();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    double default2 = Double.Parse(textBox2.Text) / 2;
                    double netice = default2;
                    label7.Text = netice.ToString();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    double default3 = Double.Parse(textBox2.Text) / 2.3;
                    double netice = default3;
                    label7.Text = netice.ToString();
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    double default4 = Double.Parse(textBox2.Text) / 0.8;
                    double netice = default4;
                    label7.Text = netice.ToString();
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox3.Enabled == false)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Clear();
                label13.Text = "";
            }


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox4.Enabled == false)
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Clear();
                label13.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox5.Enabled == false)
            {
                textBox5.Enabled = true;
            }
            else
            {
                textBox5.Enabled = false;
                textBox5.Clear();
                label13.Text = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox6.Enabled == false)
            {
                textBox6.Enabled = true;
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Clear();
                label13.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double defaultsum = 0;
            if (textBox3.Enabled == true)
            {
                double default11 = Double.Parse(textBox3.Text) * 3;
                defaultsum += default11;
            }
             if (textBox4.Enabled ==true)
            {

                double default12 = Double.Parse(textBox4.Text) * 5;
                defaultsum += default12;
            }
             if (textBox5.Enabled == true)
            {
                double default13 = Double.Parse(textBox5.Text) * 2;
                defaultsum += default13;
            }
             if (textBox6.Enabled == true)
            {
                double default14 = Double.Parse(textBox6.Text);
                defaultsum += default14;

            }
            label10.Text = defaultsum.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double label7netice = Double.Parse(label7.Text);
            double label10netice = Double.Parse(label10.Text);
            double netice = label10netice + label7netice;
            label17.Text = netice.ToString();

        }
    }
}
