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
    public partial class Form2 : Form
    {

        private Form1 ParentForm;

        private float cena_procesora = 0.0;
        private float cena_dysku = 0.0;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.ParentForm = form1;

            wybor_proc.Items.AddRange(new string[] { "Intel Core i9-14900K", "Intel Core i7-14700K", "AMD Ryzen 9 5900X", "AMD Ryzen 7 7800X3D" });
        }     

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cena_dysk_Click(object sender, EventArgs e)
        {

        }

        private void cena_reszty_Click(object sender, EventArgs e)
        {

        }

        private void Procesor_Click(object sender, EventArgs e)
        {

        }

        private void cena_proc_Click(object sender, EventArgs e)
        {

        }

        private void zl1_Click(object sender, EventArgs e)
        {

        }

        private void wybor_proc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (wybor_proc.SelectedIndex)
            {
                case 0:
                    cena_procesora = 2499;
                    break;
                case 1:
                    cena_procesora = 1999.99;
                    break;
                case 2:
                    cena_procesora = 1599;
                    break;
                case 3:
                    cena_procesora = 2199;
                    break;
                default:
                    cena_procesora = 0;
                    break;
            }
            cena_proc.Text = cena_procesora.ToString();
        }

        private void dysk_Click(object sender, EventArgs e)
        {

        }

        private void zl2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reszta_Click(object sender, EventArgs e)
        {

        }

        private void dysk1_CheckedChanged(object sender, EventArgs e)
        {
            cena_dysku = 199;
            cena_dysk.Text = cena_dysku.ToString();
        }

        private void dysk2_CheckedChanged(object sender, EventArgs e)
        {
            cena_dysku = 299;
            cena_dysk.Text = cena_dysku.ToString();
        }

        private void dysk3_CheckedChanged(object sender, EventArgs e)
        {
            cena_dysku = 399.99;
            cena_dysk.Text = cena_dysku.ToString();
        }

        private void ok_komputer_Click(object sender, EventArgs e)
        {
            ParentForm.cena_komputera = cena_procesora + cena_dysku;
            ParentForm.aktualizacja_ceny();
            ParentForm.Show();
            this.Close();
        }

        private void anuluj_komputer_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }
    }
}
