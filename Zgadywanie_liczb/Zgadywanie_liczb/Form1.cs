using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zgadywanie_liczb
{
    public partial class Zgadywanka : Form
    {
        public Zgadywanka()
        {
            InitializeComponent();
            textBox1.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!radioButton1.Checked || !radioButton2.Checked || !radioButton3.Checked)
            {
                button1.Enabled = false;
            }
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button1.Enabled = true;
            }
        }
        private int los;
        private int nrPR;
        private int nrPR_min = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (radioButton1.Checked)
                los = rand.Next(1, 1000);
            else if (radioButton2.Checked)
                los = rand.Next(1, 100);
            else
                los = rand.Next(1, 10);
            nrPR = 1;
            textBox1.Text = "1";

            textBox2.Clear();
            button1.Enabled = false;
            panel1.BackColor = Control.DefaultBackColor;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int liczba;
        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                liczba = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox2.Clear();
                return;
            }
            liczba = int.Parse(textBox2.Text);

            if (textBox2.Text == los.ToString())
            {
                
                panel1.BackColor = Color.FromArgb(255, 255, 0);
                
                if (nrPR_min == -1 || nrPR_min > nrPR)
                {
                    nrPR_min = nrPR;
                    label3.Text = nrPR_min.ToString();
                }
            }
            else 
            {
                nrPR++;
                textBox1.Text = nrPR.ToString();
            }
            //if (checkBox1.Checked)
            //{
            //    if (liczba > los)
            //    {
            //        label1.Text = "Mniej";
            //    }
            //    else if (liczba < los)
            //    {
            //        label1.Text = "Więcej";
            //    }
            //    else
            //    {
            //        label1.Text = "Trafione";
            //    }

            //}
                if (liczba > los)
                {
                    label1.Text = "Mniej";
                }
                else if (liczba < los)
                {
                    label1.Text = "Więcej";
                }
                else
                {
                    label1.Text = "Trafione";
                }

            //Wskazowki
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button1.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                button1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = checkBox1.Checked;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
