namespace Projekt_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Komputer = new Button();
            Monitor = new Button();
            Cena = new Label();
            wynik_cena = new Label();
            SuspendLayout();
            // 
            // Komputer
            // 
            Komputer.Location = new Point(123, 175);
            Komputer.Name = "Komputer";
            Komputer.Size = new Size(112, 34);
            Komputer.TabIndex = 0;
            Komputer.Text = "Komputer";
            Komputer.UseVisualStyleBackColor = true;
            Komputer.Click += Komputer_Click;
            // 
            // Monitor
            // 
            Monitor.Location = new Point(266, 175);
            Monitor.Name = "Monitor";
            Monitor.Size = new Size(112, 34);
            Monitor.TabIndex = 1;
            Monitor.Text = "Monitor";
            Monitor.UseVisualStyleBackColor = true;
            Monitor.Click += Monitor_Click;
            // 
            // Cena
            // 
            Cena.AutoSize = true;
            Cena.Location = new Point(458, 136);
            Cena.Name = "Cena";
            Cena.Size = new Size(68, 25);
            Cena.TabIndex = 2;
            Cena.Text = "Cena zl";
            Cena.Click += Cena_Click;
            // 
            // wynik_cena
            // 
            wynik_cena.AutoSize = true;
            wynik_cena.BorderStyle = BorderStyle.FixedSingle;
            wynik_cena.Location = new Point(439, 175);
            wynik_cena.MinimumSize = new Size(112, 34);
            wynik_cena.Name = "wynik_cena";
            wynik_cena.Size = new Size(112, 34);
            wynik_cena.TabIndex = 3;
            wynik_cena.Click += wynik_cena_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 382);
            Controls.Add(wynik_cena);
            Controls.Add(Cena);
            Controls.Add(Monitor);
            Controls.Add(Komputer);
            Name = "Form1";
            Text = "Kalkulator Zestawow Komputerowych";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Komputer;
        private Button Monitor;
        private Label Cena;
        private Label wynik_cena;
    }
}