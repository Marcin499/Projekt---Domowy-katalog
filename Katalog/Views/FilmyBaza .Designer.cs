﻿namespace Katalog
{
    partial class Książki
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Książki));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Zamknij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Przegladaj = new System.Windows.Forms.Button();
            this.Aktualizuj = new System.Windows.Forms.Button();
            this.Usun = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.SortujGatunki = new System.Windows.Forms.CheckBox();
            this.SortujDatyPremiery = new System.Windows.Forms.CheckBox();
            this.SortujWytwornii = new System.Windows.Forms.CheckBox();
            this.SortujRezyserow = new System.Windows.Forms.CheckBox();
            this.SortujTytuły = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SortujCzasTrwania = new System.Windows.Forms.CheckBox();
            this.Szukaj = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(439, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(781, 457);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Controls.Add(this.Zamknij);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 100);
            this.panel1.TabIndex = 1;
            // 
            // Zamknij
            // 
            this.Zamknij.FlatAppearance.BorderSize = 0;
            this.Zamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zamknij.Image = ((System.Drawing.Image)(resources.GetObject("Zamknij.Image")));
            this.Zamknij.Location = new System.Drawing.Point(1170, 30);
            this.Zamknij.Name = "Zamknij";
            this.Zamknij.Size = new System.Drawing.Size(50, 31);
            this.Zamknij.TabIndex = 5;
            this.toolTip1.SetToolTip(this.Zamknij, "Zamknij");
            this.Zamknij.UseVisualStyleBackColor = true;
            this.Zamknij.Click += new System.EventHandler(this.ZamknijClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("French Script MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Domowy katalog - Baza Filmów";
            // 
            // Przegladaj
            // 
            this.Przegladaj.FlatAppearance.BorderSize = 0;
            this.Przegladaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Przegladaj.Image = ((System.Drawing.Image)(resources.GetObject("Przegladaj.Image")));
            this.Przegladaj.Location = new System.Drawing.Point(1040, 610);
            this.Przegladaj.Name = "Przegladaj";
            this.Przegladaj.Size = new System.Drawing.Size(82, 62);
            this.Przegladaj.TabIndex = 137;
            this.toolTip1.SetToolTip(this.Przegladaj, "Przeglądaj");
            this.Przegladaj.UseVisualStyleBackColor = true;
            this.Przegladaj.Click += new System.EventHandler(this.PrzegladajClick);
            // 
            // Aktualizuj
            // 
            this.Aktualizuj.FlatAppearance.BorderSize = 0;
            this.Aktualizuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aktualizuj.Image = ((System.Drawing.Image)(resources.GetObject("Aktualizuj.Image")));
            this.Aktualizuj.Location = new System.Drawing.Point(893, 610);
            this.Aktualizuj.Name = "Aktualizuj";
            this.Aktualizuj.Size = new System.Drawing.Size(82, 62);
            this.Aktualizuj.TabIndex = 136;
            this.toolTip1.SetToolTip(this.Aktualizuj, "Aktualizuj");
            this.Aktualizuj.UseVisualStyleBackColor = true;
            this.Aktualizuj.Click += new System.EventHandler(this.AktualizujFilmyClick);
            // 
            // Usun
            // 
            this.Usun.FlatAppearance.BorderSize = 0;
            this.Usun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usun.Image = ((System.Drawing.Image)(resources.GetObject("Usun.Image")));
            this.Usun.Location = new System.Drawing.Point(731, 610);
            this.Usun.Name = "Usun";
            this.Usun.Size = new System.Drawing.Size(82, 62);
            this.Usun.TabIndex = 135;
            this.toolTip1.SetToolTip(this.Usun, "Usuń");
            this.Usun.UseVisualStyleBackColor = true;
            this.Usun.Click += new System.EventHandler(this.UsunFilmyClick);
            // 
            // Dodaj
            // 
            this.Dodaj.FlatAppearance.BorderSize = 0;
            this.Dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dodaj.Image = ((System.Drawing.Image)(resources.GetObject("Dodaj.Image")));
            this.Dodaj.Location = new System.Drawing.Point(572, 610);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(82, 62);
            this.Dodaj.TabIndex = 134;
            this.toolTip1.SetToolTip(this.Dodaj, "Dodaj");
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.DodajFilmyClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(160, 546);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 23);
            this.label18.TabIndex = 162;
            this.label18.Text = "Sortuj wg.:";
            // 
            // SortujGatunki
            // 
            this.SortujGatunki.AutoSize = true;
            this.SortujGatunki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortujGatunki.Location = new System.Drawing.Point(164, 643);
            this.SortujGatunki.Name = "SortujGatunki";
            this.SortujGatunki.Size = new System.Drawing.Size(86, 20);
            this.SortujGatunki.TabIndex = 161;
            this.SortujGatunki.Text = "Gatunków";
            this.SortujGatunki.UseVisualStyleBackColor = true;
            this.SortujGatunki.CheckedChanged += new System.EventHandler(this.SortujGatunkiFilmyCheckedChanged);
            // 
            // SortujDatyPremiery
            // 
            this.SortujDatyPremiery.AutoSize = true;
            this.SortujDatyPremiery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortujDatyPremiery.Location = new System.Drawing.Point(31, 643);
            this.SortujDatyPremiery.Name = "SortujDatyPremiery";
            this.SortujDatyPremiery.Size = new System.Drawing.Size(104, 20);
            this.SortujDatyPremiery.TabIndex = 160;
            this.SortujDatyPremiery.Text = "Daty premier";
            this.SortujDatyPremiery.UseVisualStyleBackColor = true;
            this.SortujDatyPremiery.CheckedChanged += new System.EventHandler(this.SortujDatyPremieryFilmyCheckedChanged);
            // 
            // SortujWytwornii
            // 
            this.SortujWytwornii.AutoSize = true;
            this.SortujWytwornii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortujWytwornii.Location = new System.Drawing.Point(289, 596);
            this.SortujWytwornii.Name = "SortujWytwornii";
            this.SortujWytwornii.Size = new System.Drawing.Size(84, 20);
            this.SortujWytwornii.TabIndex = 159;
            this.SortujWytwornii.Text = "Wytwórnii";
            this.SortujWytwornii.UseVisualStyleBackColor = true;
            this.SortujWytwornii.CheckedChanged += new System.EventHandler(this.SortujWytworniiFilmyCheckedChanged);
            // 
            // SortujRezyserow
            // 
            this.SortujRezyserow.AutoSize = true;
            this.SortujRezyserow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortujRezyserow.Location = new System.Drawing.Point(164, 596);
            this.SortujRezyserow.Name = "SortujRezyserow";
            this.SortujRezyserow.Size = new System.Drawing.Size(94, 20);
            this.SortujRezyserow.TabIndex = 158;
            this.SortujRezyserow.Text = "Reżyserów";
            this.SortujRezyserow.UseVisualStyleBackColor = true;
            this.SortujRezyserow.CheckedChanged += new System.EventHandler(this.SortujRezyserowFilmyCheckedChanged);
            // 
            // SortujTytuły
            // 
            this.SortujTytuły.AutoSize = true;
            this.SortujTytuły.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortujTytuły.Location = new System.Drawing.Point(31, 596);
            this.SortujTytuły.Name = "SortujTytuły";
            this.SortujTytuły.Size = new System.Drawing.Size(76, 20);
            this.SortujTytuły.TabIndex = 157;
            this.SortujTytuły.Text = "Tytułów";
            this.SortujTytuły.UseVisualStyleBackColor = true;
            this.SortujTytuły.CheckedChanged += new System.EventHandler(this.SortujTytułyFilmyCheckedChanged);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(164, 405);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(190, 26);
            this.textBox6.TabIndex = 155;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(27, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 154;
            this.label7.Text = "Gatunek:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(164, 354);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 26);
            this.textBox5.TabIndex = 152;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(27, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 151;
            this.label6.Text = "Data premiery:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(164, 306);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 26);
            this.textBox4.TabIndex = 149;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(27, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 148;
            this.label5.Text = "Wytwórnia:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(164, 256);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(190, 26);
            this.textBox3.TabIndex = 146;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(27, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 145;
            this.label4.Text = "Reżyseria:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(164, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 26);
            this.textBox1.TabIndex = 143;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(27, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 142;
            this.label3.Text = "Tytuł:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox7.Location = new System.Drawing.Point(164, 450);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(190, 26);
            this.textBox7.TabIndex = 163;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(27, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 164;
            this.label2.Text = "Czas trwania";
            // 
            // SortujCzasTrwania
            // 
            this.SortujCzasTrwania.AutoSize = true;
            this.SortujCzasTrwania.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortujCzasTrwania.Location = new System.Drawing.Point(287, 643);
            this.SortujCzasTrwania.Name = "SortujCzasTrwania";
            this.SortujCzasTrwania.Size = new System.Drawing.Size(112, 20);
            this.SortujCzasTrwania.TabIndex = 165;
            this.SortujCzasTrwania.Text = "Czasu  trwania";
            this.SortujCzasTrwania.UseVisualStyleBackColor = true;
            this.SortujCzasTrwania.CheckedChanged += new System.EventHandler(this.SortujCzasTrwaniaFilmyCheckedChanged);
            // 
            // Szukaj
            // 
            this.Szukaj.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Szukaj.Location = new System.Drawing.Point(164, 496);
            this.Szukaj.Name = "Szukaj";
            this.Szukaj.Size = new System.Drawing.Size(99, 31);
            this.Szukaj.TabIndex = 166;
            this.Szukaj.Text = "Szukaj";
            this.Szukaj.UseVisualStyleBackColor = true;
            this.Szukaj.Click += new System.EventHandler(this.SzukajFilmyClick);
            // 
            // Książki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1248, 683);
            this.Controls.Add(this.Szukaj);
            this.Controls.Add(this.SortujCzasTrwania);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.SortujGatunki);
            this.Controls.Add(this.SortujDatyPremiery);
            this.Controls.Add(this.SortujWytwornii);
            this.Controls.Add(this.SortujRezyserow);
            this.Controls.Add(this.SortujTytuły);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Przegladaj);
            this.Controls.Add(this.Aktualizuj);
            this.Controls.Add(this.Usun);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Książki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Zamknij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Przegladaj;
        private System.Windows.Forms.Button Aktualizuj;
        private System.Windows.Forms.Button Usun;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox SortujGatunki;
        private System.Windows.Forms.CheckBox SortujDatyPremiery;
        private System.Windows.Forms.CheckBox SortujWytwornii;
        private System.Windows.Forms.CheckBox SortujRezyserow;
        private System.Windows.Forms.CheckBox SortujTytuły;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox SortujCzasTrwania;
        private System.Windows.Forms.Button Szukaj;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}