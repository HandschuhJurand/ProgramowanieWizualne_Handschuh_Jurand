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
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.ParentForm = form1;
        }

        private void cena_monitor_Click(object sender, EventArgs e)
        {

        }

        private void lista_posumowanie_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }

        private void anuluj_monitor_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
