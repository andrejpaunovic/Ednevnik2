﻿namespace Ednevnik2
{
    partial class Osoba
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_adresa = new System.Windows.Forms.TextBox();
            this.txt_jmbg = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_uloga = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_adresa = new System.Windows.Forms.Label();
            this.lbl_jmbg = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_uloga = new System.Windows.Forms.Label();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_prv = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(429, 39);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(181, 22);
            this.txt_id.TabIndex = 0;
            // 
            // txt_ime
            // 
            this.txt_ime.Location = new System.Drawing.Point(429, 90);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(181, 22);
            this.txt_ime.TabIndex = 1;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Location = new System.Drawing.Point(430, 146);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(181, 22);
            this.txt_prezime.TabIndex = 2;
            // 
            // txt_adresa
            // 
            this.txt_adresa.Location = new System.Drawing.Point(431, 200);
            this.txt_adresa.Name = "txt_adresa";
            this.txt_adresa.Size = new System.Drawing.Size(181, 22);
            this.txt_adresa.TabIndex = 3;
            // 
            // txt_jmbg
            // 
            this.txt_jmbg.Location = new System.Drawing.Point(429, 246);
            this.txt_jmbg.Name = "txt_jmbg";
            this.txt_jmbg.Size = new System.Drawing.Size(181, 22);
            this.txt_jmbg.TabIndex = 4;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(431, 293);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(181, 22);
            this.txt_email.TabIndex = 5;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(431, 351);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(181, 22);
            this.txt_pass.TabIndex = 6;
            // 
            // txt_uloga
            // 
            this.txt_uloga.Location = new System.Drawing.Point(431, 401);
            this.txt_uloga.Name = "txt_uloga";
            this.txt_uloga.Size = new System.Drawing.Size(181, 22);
            this.txt_uloga.TabIndex = 7;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(355, 41);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(20, 16);
            this.lbl_id.TabIndex = 8;
            this.lbl_id.Text = "ID";
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Location = new System.Drawing.Point(356, 94);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(29, 16);
            this.lbl_ime.TabIndex = 9;
            this.lbl_ime.Text = "Ime";
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Location = new System.Drawing.Point(357, 150);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(56, 16);
            this.lbl_prezime.TabIndex = 10;
            this.lbl_prezime.Text = "Prezime";
            // 
            // lbl_adresa
            // 
            this.lbl_adresa.AutoSize = true;
            this.lbl_adresa.Location = new System.Drawing.Point(358, 203);
            this.lbl_adresa.Name = "lbl_adresa";
            this.lbl_adresa.Size = new System.Drawing.Size(51, 16);
            this.lbl_adresa.TabIndex = 11;
            this.lbl_adresa.Text = "Adresa";
            // 
            // lbl_jmbg
            // 
            this.lbl_jmbg.AutoSize = true;
            this.lbl_jmbg.Location = new System.Drawing.Point(358, 246);
            this.lbl_jmbg.Name = "lbl_jmbg";
            this.lbl_jmbg.Size = new System.Drawing.Size(44, 16);
            this.lbl_jmbg.TabIndex = 12;
            this.lbl_jmbg.Text = "JMBG";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(361, 297);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(46, 16);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "EMAIL";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(366, 356);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(53, 16);
            this.lbl_pass.TabIndex = 14;
            this.lbl_pass.Text = "Lozinka";
            // 
            // lbl_uloga
            // 
            this.lbl_uloga.AutoSize = true;
            this.lbl_uloga.Location = new System.Drawing.Point(364, 403);
            this.lbl_uloga.Name = "lbl_uloga";
            this.lbl_uloga.Size = new System.Drawing.Size(44, 16);
            this.lbl_uloga.TabIndex = 15;
            this.lbl_uloga.Text = "Uloga";
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(202, 456);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(75, 23);
            this.btn_first.TabIndex = 16;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_prv
            // 
            this.btn_prv.Location = new System.Drawing.Point(301, 455);
            this.btn_prv.Name = "btn_prv";
            this.btn_prv.Size = new System.Drawing.Size(75, 23);
            this.btn_prv.TabIndex = 17;
            this.btn_prv.Text = "<";
            this.btn_prv.UseVisualStyleBackColor = true;
            this.btn_prv.Click += new System.EventHandler(this.btn_prv_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(402, 456);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 18;
            this.btn_insert.Text = "DODAJ";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(503, 456);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "IZMENI";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(607, 459);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "BRISI";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(710, 460);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 21;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(812, 460);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(75, 23);
            this.btn_last.TabIndex = 22;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.button7_Click);
            // 
            // Osoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 585);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_prv);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.lbl_uloga);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_jmbg);
            this.Controls.Add(this.lbl_adresa);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_uloga);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_jmbg);
            this.Controls.Add(this.txt_adresa);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.txt_id);
            this.Name = "Osoba";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_adresa;
        private System.Windows.Forms.TextBox txt_jmbg;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_uloga;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_adresa;
        private System.Windows.Forms.Label lbl_jmbg;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_uloga;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_prv;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
    }
}

