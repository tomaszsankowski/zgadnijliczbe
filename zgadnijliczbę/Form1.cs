using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zgadnijliczbę
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                Random rand = new.Random();
                int liczba = rand.Next(1, 101);
                int a = Convert.ToInt32(textBox1.Text);
                if (a == liczba)
                {
                    Image img = Image.FromFile("img\\obraztak.jpg");
                    pictureBox1.Image = img;
                    label3.Text = "Gratulacje! Jak ty to zrobiłeś?!";
                }
                else
                {
                    Image img = Image.FromFile("img\\obraznie.jpg");
                    pictureBox1.Image = img;
                    label3.Text = "Nie udało ci się... Próbuj dalej!";
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
