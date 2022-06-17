
namespace UI_WindowsForms
{
    partial class Angajati
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStergereAngajat = new System.Windows.Forms.Button();
            this.btnCautareAngajat = new System.Windows.Forms.Button();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.adaugarefisier = new System.Windows.Forms.Button();
            this.txtPrenumeAngajat = new System.Windows.Forms.TextBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtNumeAngajat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonexit = new System.Windows.Forms.Button();
            this.dataGridAngajati = new System.Windows.Forms.DataGridView();
            this.btnMeniu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAngajati)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnStergereAngajat);
            this.panel1.Controls.Add(this.btnCautareAngajat);
            this.panel1.Controls.Add(this.buttonAfisare);
            this.panel1.Controls.Add(this.adaugarefisier);
            this.panel1.Controls.Add(this.txtPrenumeAngajat);
            this.panel1.Controls.Add(this.txtVarsta);
            this.panel1.Controls.Add(this.txtJob);
            this.panel1.Controls.Add(this.txtNumeAngajat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 405);
            this.panel1.TabIndex = 0;
            // 
            // btnStergereAngajat
            // 
            this.btnStergereAngajat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnStergereAngajat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergereAngajat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnStergereAngajat.Location = new System.Drawing.Point(111, 314);
            this.btnStergereAngajat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStergereAngajat.Name = "btnStergereAngajat";
            this.btnStergereAngajat.Size = new System.Drawing.Size(112, 48);
            this.btnStergereAngajat.TabIndex = 11;
            this.btnStergereAngajat.Text = "Sterge";
            this.btnStergereAngajat.UseVisualStyleBackColor = false;
            this.btnStergereAngajat.Click += new System.EventHandler(this.btnStergereAngajat_Click);
            // 
            // btnCautareAngajat
            // 
            this.btnCautareAngajat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCautareAngajat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautareAngajat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCautareAngajat.Location = new System.Drawing.Point(0, 314);
            this.btnCautareAngajat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCautareAngajat.Name = "btnCautareAngajat";
            this.btnCautareAngajat.Size = new System.Drawing.Size(112, 48);
            this.btnCautareAngajat.TabIndex = 10;
            this.btnCautareAngajat.Text = "Cauta";
            this.btnCautareAngajat.UseVisualStyleBackColor = false;
            this.btnCautareAngajat.Click += new System.EventHandler(this.btnCautareAngajat_Click_1);
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAfisare.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfisare.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAfisare.Location = new System.Drawing.Point(113, 226);
            this.buttonAfisare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(112, 52);
            this.buttonAfisare.TabIndex = 9;
            this.buttonAfisare.Text = "Afiseaza";
            this.buttonAfisare.UseVisualStyleBackColor = false;
            this.buttonAfisare.Click += new System.EventHandler(this.buttonAfisare_Click);
            // 
            // adaugarefisier
            // 
            this.adaugarefisier.BackColor = System.Drawing.Color.CornflowerBlue;
            this.adaugarefisier.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugarefisier.ForeColor = System.Drawing.Color.MidnightBlue;
            this.adaugarefisier.Location = new System.Drawing.Point(2, 226);
            this.adaugarefisier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adaugarefisier.Name = "adaugarefisier";
            this.adaugarefisier.Size = new System.Drawing.Size(112, 52);
            this.adaugarefisier.TabIndex = 2;
            this.adaugarefisier.Text = "Adauga";
            this.adaugarefisier.UseVisualStyleBackColor = false;
            this.adaugarefisier.Click += new System.EventHandler(this.adaugarefisier_Click);
            // 
            // txtPrenumeAngajat
            // 
            this.txtPrenumeAngajat.Location = new System.Drawing.Point(110, 76);
            this.txtPrenumeAngajat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrenumeAngajat.Name = "txtPrenumeAngajat";
            this.txtPrenumeAngajat.Size = new System.Drawing.Size(101, 20);
            this.txtPrenumeAngajat.TabIndex = 8;
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(110, 124);
            this.txtVarsta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(101, 20);
            this.txtVarsta.TabIndex = 7;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(110, 163);
            this.txtJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(101, 20);
            this.txtJob.TabIndex = 6;
            // 
            // txtNumeAngajat
            // 
            this.txtNumeAngajat.Location = new System.Drawing.Point(110, 33);
            this.txtNumeAngajat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeAngajat.Name = "txtNumeAngajat";
            this.txtNumeAngajat.Size = new System.Drawing.Size(101, 20);
            this.txtNumeAngajat.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Job:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prenume:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Varsta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.buttonexit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 24);
            this.panel2.TabIndex = 1;
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonexit.FlatAppearance.BorderSize = 0;
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonexit.Location = new System.Drawing.Point(831, 0);
            this.buttonexit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(22, 24);
            this.buttonexit.TabIndex = 2;
            this.buttonexit.Text = "X";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // dataGridAngajati
            // 
            this.dataGridAngajati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAngajati.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAngajati.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridAngajati.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridAngajati.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridAngajati.Location = new System.Drawing.Point(272, 58);
            this.dataGridAngajati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridAngajati.Name = "dataGridAngajati";
            this.dataGridAngajati.RowHeadersWidth = 51;
            this.dataGridAngajati.RowTemplate.Height = 24;
            this.dataGridAngajati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAngajati.Size = new System.Drawing.Size(536, 328);
            this.dataGridAngajati.TabIndex = 2;
            // 
            // btnMeniu
            // 
            this.btnMeniu.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeniu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMeniu.Location = new System.Drawing.Point(748, 391);
            this.btnMeniu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMeniu.Name = "btnMeniu";
            this.btnMeniu.Size = new System.Drawing.Size(106, 38);
            this.btnMeniu.TabIndex = 3;
            this.btnMeniu.Text = "Meniu";
            this.btnMeniu.UseVisualStyleBackColor = true;
            this.btnMeniu.Click += new System.EventHandler(this.button1_Click);
            // 
            // Angajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(854, 429);
            this.Controls.Add(this.btnMeniu);
            this.Controls.Add(this.dataGridAngajati);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Angajati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAngajati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeAngajat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrenumeAngajat;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Button adaugarefisier;
        private System.Windows.Forms.Button buttonAfisare;
        private System.Windows.Forms.Button btnCautareAngajat;
        private System.Windows.Forms.Button btnStergereAngajat;
        private System.Windows.Forms.DataGridView dataGridAngajati;
        private System.Windows.Forms.Button btnMeniu;
    }
}

