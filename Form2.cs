using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valeurA = textBox1.Text;
            string valeurB = textBox2.Text;


            if (int.TryParse(valeurA, out int nombreA) && int.TryParse(valeurB, out int nombreB))
            {

                int somme = nombreA + nombreB;

                textBox3.Text = somme.ToString();
            }
            else
            {

                MessageBox.Show("Veuillez entrer des nombres valides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valeurA = textBox1.Text;
            string valeurB = textBox2.Text;


            if (int.TryParse(valeurA, out int nombreA) && int.TryParse(valeurB, out int nombreB))
            {

                int somme = nombreA - nombreB;

                textBox3.Text = somme.ToString();
            }
            else
            {

                MessageBox.Show("Veuillez entrer des nombres valides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valeurA = textBox1.Text;
            string valeurB = textBox2.Text;


            if (int.TryParse(valeurA, out int nombreA) && int.TryParse(valeurB, out int nombreB))
            {

                int somme = nombreA * nombreB;

                textBox3.Text = somme.ToString();
            }
            else
            {

                MessageBox.Show("Veuillez entrer des nombres valides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string valeurA = textBox1.Text;
            string valeurB = textBox2.Text;


            if (int.TryParse(valeurA, out int nombreA) && int.TryParse(valeurB, out int nombreB))
            {

                int somme = nombreA / nombreB;

                textBox3.Text = somme.ToString();
            }
            else
            {

                MessageBox.Show("Veuillez entrer des nombres valides.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
