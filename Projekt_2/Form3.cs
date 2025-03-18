using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_2
{
    public partial class Form3 : Form
    {
        private Form1 ParentForm;
        private float cena_monitora = 0.0;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.ParentForm = form1;
            lista_posumowanie.Items.AddRange(new string[] { "Monitor 24\"", "Monitor 27\"", "Monitor 32\"" });
        }

        private void cena_monitor_Click(object sender, EventArgs e)
        {

        }

        private void lista_posumowanie_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lista_posumowanie.SelectedIndex)
            {
                case 0;
                    cena_monitora = 899.99;
                    break;
                case 1:
                    cena_monitora = 1299.99;
                    break;
                case 2:
                    cena_monitora = 1899.99;
                    break;
                case 3:
                    cena_monitora = 2499.99;
                    break;
                default:
                    cena_monitora = 0.0;
                    break;
            }

            cena_monitor.Text = cena_monitora.ToString();
        }

        //cena wynik
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ok_monitor_Click(object sender, EventArgs e)
        {
            ParentForm.cena_monitora = cena_monitora;
            ParentForm.aktualizacja_ceny();
            ParentForm.Show();
            this.Close();
        }

        private void anuluj_monitor_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
