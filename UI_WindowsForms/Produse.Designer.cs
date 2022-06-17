
namespace UI_WindowsForms
{
    partial class Produse
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStergereProdus = new System.Windows.Forms.Button();
            this.btnCautareProdus = new System.Windows.Forms.Button();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.adaugarefisier = new System.Windows.Forms.Button();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtDataExpirarii = new System.Windows.Forms.TextBox();
            this.txtDenumireProdus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridProduse = new System.Windows.Forms.DataGridView();
            this.btnMeniu = new System.Windows.Forms.Button();
            this.ckbIgiena = new System.Windows.Forms.RadioButton();
            this.ckbPanificatie = new System.Windows.Forms.RadioButton();
            this.ckbDulciuri = new System.Windows.Forms.RadioButton();
            this.ckbRacoritoare = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.buttonexit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 24);
            this.panel2.TabIndex = 2;
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonexit.FlatAppearance.BorderSize = 0;
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonexit.Location = new System.Drawing.Point(831, 0);
            this.buttonexit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(22, 24);
            this.buttonexit.TabIndex = 2;
            this.buttonexit.Text = "X";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.ckbRacoritoare);
            this.panel1.Controls.Add(this.ckbDulciuri);
            this.panel1.Controls.Add(this.ckbPanificatie);
            this.panel1.Controls.Add(this.ckbIgiena);
            this.panel1.Controls.Add(this.btnStergereProdus);
            this.panel1.Controls.Add(this.btnCautareProdus);
            this.panel1.Controls.Add(this.buttonAfisare);
            this.panel1.Controls.Add(this.adaugarefisier);
            this.panel1.Controls.Add(this.txtPret);
            this.panel1.Controls.Add(this.txtDataExpirarii);
            this.panel1.Controls.Add(this.txtDenumireProdus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 405);
            this.panel1.TabIndex = 3;
            // 
            // btnStergereProdus
            // 
            this.btnStergereProdus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnStergereProdus.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergereProdus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnStergereProdus.Location = new System.Drawing.Point(112, 354);
            this.btnStergereProdus.Margin = new System.Windows.Forms.Padding(2);
            this.btnStergereProdus.Name = "btnStergereProdus";
            this.btnStergereProdus.Size = new System.Drawing.Size(112, 48);
            this.btnStergereProdus.TabIndex = 11;
            this.btnStergereProdus.Text = "Sterge";
            this.btnStergereProdus.UseVisualStyleBackColor = false;
            this.btnStergereProdus.Click += new System.EventHandler(this.btnStergereProdus_Click);
            // 
            // btnCautareProdus
            // 
            this.btnCautareProdus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCautareProdus.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautareProdus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCautareProdus.Location = new System.Drawing.Point(0, 354);
            this.btnCautareProdus.Margin = new System.Windows.Forms.Padding(2);
            this.btnCautareProdus.Name = "btnCautareProdus";
            this.btnCautareProdus.Size = new System.Drawing.Size(112, 48);
            this.btnCautareProdus.TabIndex = 10;
            this.btnCautareProdus.Text = "Cauta";
            this.btnCautareProdus.UseVisualStyleBackColor = false;
            this.btnCautareProdus.Click += new System.EventHandler(this.btnCautareProdus_Click);
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAfisare.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfisare.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonAfisare.Location = new System.Drawing.Point(112, 297);
            this.buttonAfisare.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(112, 52);
            this.buttonAfisare.TabIndex = 9;
            this.buttonAfisare.Text = "Afiseaza";
            this.buttonAfisare.UseVisualStyleBackColor = false;
            this.buttonAfisare.Click += new System.EventHandler(this.buttonAfisare_Click_1);
            // 
            // adaugarefisier
            // 
            this.adaugarefisier.BackColor = System.Drawing.Color.CornflowerBlue;
            this.adaugarefisier.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugarefisier.ForeColor = System.Drawing.Color.MidnightBlue;
            this.adaugarefisier.Location = new System.Drawing.Point(0, 297);
            this.adaugarefisier.Margin = new System.Windows.Forms.Padding(2);
            this.adaugarefisier.Name = "adaugarefisier";
            this.adaugarefisier.Size = new System.Drawing.Size(112, 52);
            this.adaugarefisier.TabIndex = 2;
            this.adaugarefisier.Text = "Adauga";
            this.adaugarefisier.UseVisualStyleBackColor = false;
            this.adaugarefisier.Click += new System.EventHandler(this.adaugarefisier_Click);
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(131, 76);
            this.txtPret.Margin = new System.Windows.Forms.Padding(2);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(87, 20);
            this.txtPret.TabIndex = 8;
            // 
            // txtDataExpirarii
            // 
            this.txtDataExpirarii.Location = new System.Drawing.Point(131, 124);
            this.txtDataExpirarii.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataExpirarii.Name = "txtDataExpirarii";
            this.txtDataExpirarii.Size = new System.Drawing.Size(87, 20);
            this.txtDataExpirarii.TabIndex = 7;
            // 
            // txtDenumireProdus
            // 
            this.txtDenumireProdus.Location = new System.Drawing.Point(131, 33);
            this.txtDenumireProdus.Margin = new System.Windows.Forms.Padding(2);
            this.txtDenumireProdus.Name = "txtDenumireProdus";
            this.txtDenumireProdus.Size = new System.Drawing.Size(87, 20);
            this.txtDenumireProdus.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Categorii:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pret:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data expirarii:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Denumire:";
            // 
            // dataGridProduse
            // 
            this.dataGridProduse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduse.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduse.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridProduse.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridProduse.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridProduse.Location = new System.Drawing.Point(273, 58);
            this.dataGridProduse.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridProduse.Name = "dataGridProduse";
            this.dataGridProduse.RowHeadersWidth = 51;
            this.dataGridProduse.RowTemplate.Height = 24;
            this.dataGridProduse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduse.Size = new System.Drawing.Size(536, 328);
            this.dataGridProduse.TabIndex = 4;
            // 
            // btnMeniu
            // 
            this.btnMeniu.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeniu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMeniu.Location = new System.Drawing.Point(748, 391);
            this.btnMeniu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMeniu.Name = "btnMeniu";
            this.btnMeniu.Size = new System.Drawing.Size(106, 38);
            this.btnMeniu.TabIndex = 5;
            this.btnMeniu.Text = "Meniu";
            this.btnMeniu.UseVisualStyleBackColor = true;
            this.btnMeniu.Click += new System.EventHandler(this.btnMeniu_Click);
            // 
            // ckbIgiena
            // 
            this.ckbIgiena.AutoSize = true;
            this.ckbIgiena.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ckbIgiena.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbIgiena.Location = new System.Drawing.Point(12, 209);
            this.ckbIgiena.Name = "ckbIgiena";
            this.ckbIgiena.Size = new System.Drawing.Size(70, 23);
            this.ckbIgiena.TabIndex = 12;
            this.ckbIgiena.TabStop = true;
            this.ckbIgiena.Text = "Igiena";
            this.ckbIgiena.UseVisualStyleBackColor = false;
            // 
            // ckbPanificatie
            // 
            this.ckbPanificatie.AutoSize = true;
            this.ckbPanificatie.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ckbPanificatie.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPanificatie.Location = new System.Drawing.Point(112, 209);
            this.ckbPanificatie.Name = "ckbPanificatie";
            this.ckbPanificatie.Size = new System.Drawing.Size(101, 23);
            this.ckbPanificatie.TabIndex = 13;
            this.ckbPanificatie.TabStop = true;
            this.ckbPanificatie.Text = "Panificatie";
            this.ckbPanificatie.UseVisualStyleBackColor = false;
            // 
            // ckbDulciuri
            // 
            this.ckbDulciuri.AutoSize = true;
            this.ckbDulciuri.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ckbDulciuri.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDulciuri.Location = new System.Drawing.Point(12, 248);
            this.ckbDulciuri.Name = "ckbDulciuri";
            this.ckbDulciuri.Size = new System.Drawing.Size(85, 23);
            this.ckbDulciuri.TabIndex = 14;
            this.ckbDulciuri.TabStop = true;
            this.ckbDulciuri.Text = "Dulciuri";
            this.ckbDulciuri.UseVisualStyleBackColor = false;
            // 
            // ckbRacoritoare
            // 
            this.ckbRacoritoare.AutoSize = true;
            this.ckbRacoritoare.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ckbRacoritoare.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbRacoritoare.Location = new System.Drawing.Point(112, 248);
            this.ckbRacoritoare.Name = "ckbRacoritoare";
            this.ckbRacoritoare.Size = new System.Drawing.Size(106, 23);
            this.ckbRacoritoare.TabIndex = 15;
            this.ckbRacoritoare.TabStop = true;
            this.ckbRacoritoare.Text = "Racoritoare";
            this.ckbRacoritoare.UseVisualStyleBackColor = false;
            // 
            // Produse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(854, 429);
            this.Controls.Add(this.btnMeniu);
            this.Controls.Add(this.dataGridProduse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Produse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produse";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStergereProdus;
        private System.Windows.Forms.Button btnCautareProdus;
        private System.Windows.Forms.Button buttonAfisare;
        private System.Windows.Forms.Button adaugarefisier;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtDataExpirarii;
        private System.Windows.Forms.TextBox txtDenumireProdus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridProduse;
        private System.Windows.Forms.Button btnMeniu;
        private System.Windows.Forms.RadioButton ckbRacoritoare;
        private System.Windows.Forms.RadioButton ckbDulciuri;
        private System.Windows.Forms.RadioButton ckbPanificatie;
        private System.Windows.Forms.RadioButton ckbIgiena;
    }
}