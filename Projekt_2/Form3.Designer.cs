namespace Projekt_2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lista_posumowanie = new ListView();
            cena_monitor = new Label();
            cena_wynik = new Label();
            label2 = new Label();
            ok_monitor = new Button();
            anuluj_monitor = new Button();
            SuspendLayout();
            // 
            // lista_posumowanie
            // 
            lista_posumowanie.Location = new Point(33, 30);
            lista_posumowanie.Name = "lista_posumowanie";
            lista_posumowanie.Size = new Size(398, 362);
            lista_posumowanie.TabIndex = 0;
            lista_posumowanie.UseCompatibleStateImageBehavior = false;
            lista_posumowanie.SelectedIndexChanged += lista_posumowanie_SelectedIndexChanged;
            // 
            // cena_monitor
            // 
            cena_monitor.AutoSize = true;
            cena_monitor.Location = new Point(64, 444);
            cena_monitor.Name = "cena_monitor";
            cena_monitor.Size = new Size(51, 25);
            cena_monitor.TabIndex = 1;
            cena_monitor.Text = "Cena";
            cena_monitor.Click += cena_monitor_Click;
            // 
            // cena_wynik
            // 
            cena_wynik.AutoSize = true;
            cena_wynik.BorderStyle = BorderStyle.FixedSingle;
            cena_wynik.Location = new Point(183, 435);
            cena_wynik.MinimumSize = new Size(112, 34);
            cena_wynik.Name = "cena_wynik";
            cena_wynik.Size = new Size(112, 34);
            cena_wynik.TabIndex = 2;
            cena_wynik.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 444);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 3;
            label2.Text = "zl";
            label2.Click += label2_Click;
            // 
            // ok_monitor
            // 
            ok_monitor.Location = new Point(33, 514);
            ok_monitor.Name = "ok_monitor";
            ok_monitor.Size = new Size(112, 34);
            ok_monitor.TabIndex = 4;
            ok_monitor.Text = "OK";
            ok_monitor.UseVisualStyleBackColor = true;
            ok_monitor.Click += ok_monitor_Click;
            // 
            // anuluj_monitor
            // 
            anuluj_monitor.Location = new Point(319, 514);
            anuluj_monitor.Name = "anuluj_monitor";
            anuluj_monitor.Size = new Size(112, 34);
            anuluj_monitor.TabIndex = 5;
            anuluj_monitor.Text = "ANULUJ";
            anuluj_monitor.UseVisualStyleBackColor = true;
            anuluj_monitor.Click += anuluj_monitor_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 593);
            Controls.Add(anuluj_monitor);
            Controls.Add(ok_monitor);
            Controls.Add(label2);
            Controls.Add(cena_wynik);
            Controls.Add(cena_monitor);
            Controls.Add(lista_posumowanie);
            Name = "Form3";
            Text = "Monitor";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lista_posumowanie;
        private Label cena_monitor;
        private Label cena_wynik;
        private Label label2;
        private Button ok_monitor;
        private Button anuluj_monitor;
    }
}