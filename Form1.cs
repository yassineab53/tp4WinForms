namespace WinFormsTp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }
}
