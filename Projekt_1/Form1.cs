namespace Projekt_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Kalkulator";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private double wynik = 0;
        private string aktualny_numer = "";
        private string operacja = "";
        private bool czy_nowy_numer = true;

        private void Dopisz_numer(string numer)
        {
            if (czy_nowy_numer)
            {
                textBox2.Text = numer;
                czy_nowy_numer = false;
            }
            else
            {
                textBox2.Text += numer;
            }
            textBox2.Text = textBox2.Text;
        }

        private void Wykonaj_operacje(string op)
        {
            if (!czy_nowy_numer)
            {
                if (operacja == "")
                {
                    wynik = double.Parse(textBox2.Text);
                }
                else
                {
                    Oblicz_wynik();
                }
                operacja = op;
                czy_nowy_numer = true;
            }
        }

        private void Oblicz_wynik()
        {
            double number = double.Parse(textBox2.Text);
            switch (operacja)
            {
                case "+":
                    wynik += number;
                    break;
                case "-":
                    wynik -= number;
                    break;
                case "x":
                    wynik *= number;
                    break;
                case "/":
                    if (number != 0)
                        wynik /= number;
                    else
                        MessageBox.Show("Nie mo¿na dzieliæ przez zero!");
                    break;
            }
            textBox2.Text = wynik.ToString();
        }

        // przycisk 0
        private void button1_Click(object sender, EventArgs e)
        {
            Dopisz_numer("0");
        }
        //przycisk 3
        private void button5_Click(object sender, EventArgs e)
        {
            Dopisz_numer("3");
        }
       
        //przycisk 8
        private void button4_Click(object sender, EventArgs e)
        {
            Dopisz_numer("8");
        }
        //przycisk backspace
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox2 != null)
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                if (textBox2 != null)
                {
                    textBox2.Text = "0";
                }
            }
        }
        //przycisk 1
        private void button8_Click(object sender, EventArgs e)
        {
            Dopisz_numer("1");
        }
        // przycisk 2
        private void button2_Click(object sender, EventArgs e)
        {
            Dopisz_numer("2");
        }
        // przycisk 4
        private void button9_Click(object sender, EventArgs e)
        {
            Dopisz_numer("4");
        }
        // przycisk 5
        private void button3_Click(object sender, EventArgs e)
        {
            Dopisz_numer("5");
        }
        // przycisk 6
        private void button6_Click(object sender, EventArgs e)
        {
            Dopisz_numer("6");
        }
        // przycisk 7
        private void button10_Click(object sender, EventArgs e)
        {
            Dopisz_numer("7");
        }
        // przycisk 9
        private void button7_Click(object sender, EventArgs e)
        {
            Dopisz_numer("9");
        }
        // przycisk x
        private void button15_Click(object sender, EventArgs e)
        {
            Wykonaj_operacje("x");
        }
        //przycisk /
        private void button16_Click(object sender, EventArgs e)
        {
            Wykonaj_operacje("/");
        }
        //przycisk -
        private void button14_Click(object sender, EventArgs e)
        {
            Wykonaj_operacje("-");
        }
        //przycisk ,
        private void button11_Click(object sender, EventArgs e)
        {
            if(!textBox2.Text.Contains(","))
            {
                textBox2.Text += ",";
                czy_nowy_numer = false;
            }
        }
        //przycisk +
        private void button13_Click(object sender, EventArgs e)
        {
            Wykonaj_operacje("+");
        }
        //przycisk =
        private void button12_Click(object sender, EventArgs e)
        {
            if (!czy_nowy_numer && operacja != "")
            {
                Oblicz_wynik();
                operacja = "";
                czy_nowy_numer = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}