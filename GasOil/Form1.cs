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
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                label3.Text = "1";
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                
            }
        }
    }
}
