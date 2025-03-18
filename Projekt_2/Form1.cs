namespace Projekt_2
{
    public partial class Form1 : Form
    {
        public float cena_komputera { get; set; }
        public float cena_monitora { get; set; }
        public float cena_calkowita { get; private set; }

        public Form1()
        {
            InitializeComponent();
            cena_calkowita = 0.0;
            cena_monitora = 0.0;
            cena_komputera = 0.0;
            wynik_cena.Text = "0.00"
        }

        public void aktualizacja_ceny()
        {
            cena_calkowita = cena_komputera + cena_monitora;
            wynik_cena.Text = cena_calkowita.ToString();
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
            aktualizacja_ceny();
        }
    }
}