namespace Projekt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cena_Click(object sender, EventArgs e)
        {

        }

        private void Komputer_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        private void Monitor_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            this.Hide();
        }

        private void wynik_cena_Click(object sender, EventArgs e)
        {

        }
    }
}