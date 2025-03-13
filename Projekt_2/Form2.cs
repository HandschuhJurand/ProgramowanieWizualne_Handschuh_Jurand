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
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.ParentForm = form1;
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

        }

        private void dysk2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dysk3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ok_komputer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anuluj_komputer_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }
    }
}
