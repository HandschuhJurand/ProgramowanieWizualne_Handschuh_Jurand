namespace Projekt_2
{
    partial class Form2
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
            Procesor = new Label();
            cena_proc = new Label();
            zl1 = new Label();
            wybor_proc = new ComboBox();
            dysk = new Label();
            cena_dysk = new Label();
            zl2 = new Label();
            reszta = new Label();
            cena_reszty = new Label();
            dysk1 = new RadioButton();
            dysk2 = new RadioButton();
            dysk3 = new RadioButton();
            ok_komputer = new Button();
            anuluj_komputer = new Button();
            SuspendLayout();
            // 
            // Procesor
            // 
            Procesor.AutoSize = true;
            Procesor.Location = new Point(70, 67);
            Procesor.Name = "Procesor";
            Procesor.Size = new Size(81, 25);
            Procesor.TabIndex = 0;
            Procesor.Text = "Procesor";
            Procesor.Click += Procesor_Click;
            // 
            // cena_proc
            // 
            cena_proc.AutoSize = true;
            cena_proc.BorderStyle = BorderStyle.FixedSingle;
            cena_proc.Location = new Point(200, 58);
            cena_proc.MinimumSize = new Size(112, 34);
            cena_proc.Name = "cena_proc";
            cena_proc.Size = new Size(112, 34);
            cena_proc.TabIndex = 1;
            cena_proc.Click += cena_proc_Click;
            // 
            // zl1
            // 
            zl1.AutoSize = true;
            zl1.Location = new Point(359, 67);
            zl1.Name = "zl1";
            zl1.Size = new Size(24, 25);
            zl1.TabIndex = 2;
            zl1.Text = "zl";
            zl1.Click += zl1_Click;
            // 
            // wybor_proc
            // 
            wybor_proc.FormattingEnabled = true;
            wybor_proc.Location = new Point(70, 134);
            wybor_proc.Name = "wybor_proc";
            wybor_proc.Size = new Size(313, 33);
            wybor_proc.TabIndex = 3;
            wybor_proc.SelectedIndexChanged += wybor_proc_SelectedIndexChanged;
            // 
            // dysk
            // 
            dysk.AutoSize = true;
            dysk.Location = new Point(70, 208);
            dysk.Name = "dysk";
            dysk.Size = new Size(51, 25);
            dysk.TabIndex = 4;
            dysk.Text = "Dysk";
            dysk.Click += dysk_Click;
            // 
            // cena_dysk
            // 
            cena_dysk.AutoSize = true;
            cena_dysk.BorderStyle = BorderStyle.FixedSingle;
            cena_dysk.Location = new Point(200, 199);
            cena_dysk.MinimumSize = new Size(112, 34);
            cena_dysk.Name = "cena_dysk";
            cena_dysk.Size = new Size(112, 34);
            cena_dysk.TabIndex = 5;
            cena_dysk.Click += cena_dysk_Click;
            // 
            // zl2
            // 
            zl2.AutoSize = true;
            zl2.Location = new Point(359, 208);
            zl2.Name = "zl2";
            zl2.Size = new Size(24, 25);
            zl2.TabIndex = 6;
            zl2.Text = "zl";
            zl2.Click += zl2_Click;
            // 
            // reszta
            // 
            reszta.AutoSize = true;
            reszta.Location = new Point(70, 390);
            reszta.Name = "reszta";
            reszta.Size = new Size(66, 25);
            reszta.TabIndex = 8;
            reszta.Text = "Reszta:";
            reszta.Click += reszta_Click;
            // 
            // cena_reszty
            // 
            cena_reszty.AutoSize = true;
            cena_reszty.Location = new Point(210, 390);
            cena_reszty.Name = "cena_reszty";
            cena_reszty.Size = new Size(69, 25);
            cena_reszty.TabIndex = 9;
            cena_reszty.Text = "1500 zl";
            cena_reszty.Click += cena_reszty_Click;
            // 
            // dysk1
            // 
            dysk1.AutoSize = true;
            dysk1.Location = new Point(70, 268);
            dysk1.Name = "dysk1";
            dysk1.Size = new Size(132, 29);
            dysk1.TabIndex = 10;
            dysk1.TabStop = true;
            dysk1.Text = "240 GB SSD";
            dysk1.UseVisualStyleBackColor = true;
            dysk1.CheckedChanged += dysk1_CheckedChanged;
            // 
            // dysk2
            // 
            dysk2.AutoSize = true;
            dysk2.Location = new Point(70, 303);
            dysk2.Name = "dysk2";
            dysk2.Size = new Size(140, 29);
            dysk2.TabIndex = 11;
            dysk2.TabStop = true;
            dysk2.Text = "500 GB SATA";
            dysk2.UseVisualStyleBackColor = true;
            dysk2.CheckedChanged += dysk2_CheckedChanged;
            // 
            // dysk3
            // 
            dysk3.AutoSize = true;
            dysk3.Location = new Point(70, 338);
            dysk3.Name = "dysk3";
            dysk3.Size = new Size(150, 29);
            dysk3.TabIndex = 12;
            dysk3.TabStop = true;
            dysk3.Text = "1000 GB SATA";
            dysk3.UseVisualStyleBackColor = true;
            dysk3.CheckedChanged += dysk3_CheckedChanged;
            // 
            // ok_komputer
            // 
            ok_komputer.Location = new Point(70, 504);
            ok_komputer.Name = "ok_komputer";
            ok_komputer.Size = new Size(112, 34);
            ok_komputer.TabIndex = 13;
            ok_komputer.Text = "OK";
            ok_komputer.UseVisualStyleBackColor = true;
            ok_komputer.Click += ok_komputer_Click;
            // 
            // anuluj_komputer
            // 
            anuluj_komputer.Location = new Point(271, 504);
            anuluj_komputer.Name = "anuluj_komputer";
            anuluj_komputer.Size = new Size(112, 34);
            anuluj_komputer.TabIndex = 14;
            anuluj_komputer.Text = "ANULUJ";
            anuluj_komputer.UseVisualStyleBackColor = true;
            anuluj_komputer.Click += anuluj_komputer_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 583);
            Controls.Add(anuluj_komputer);
            Controls.Add(ok_komputer);
            Controls.Add(dysk3);
            Controls.Add(dysk2);
            Controls.Add(dysk1);
            Controls.Add(cena_reszty);
            Controls.Add(reszta);
            Controls.Add(zl2);
            Controls.Add(cena_dysk);
            Controls.Add(dysk);
            Controls.Add(wybor_proc);
            Controls.Add(zl1);
            Controls.Add(cena_proc);
            Controls.Add(Procesor);
            Name = "Form2";
            Text = "Komputer";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Procesor;
        private Label cena_proc;
        private Label zl1;
        private ComboBox wybor_proc;
        private Label dysk;
        private Label cena_dysk;
        private Label zl2;
        private Label reszta;
        private Label cena_reszty;
        private RadioButton dysk1;
        private RadioButton dysk2;
        private RadioButton dysk3;
        private Button ok_komputer;
        private Button anuluj_komputer;
    }
}