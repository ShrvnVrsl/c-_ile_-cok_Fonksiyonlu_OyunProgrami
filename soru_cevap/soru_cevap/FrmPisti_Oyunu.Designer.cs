
namespace soru_cevap
{
    partial class FrmPisti_Oyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPisti_Oyunu));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_toplam_puan_kulla = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_puan_rakip = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_toplam_puan_rakip = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcb_pisti = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pcb_cards = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_puan_kullanici = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_arka = new System.Windows.Forms.Panel();
            this.Bilgisayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_pisti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnl_arka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(815, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(815, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Yeni Oyun";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbl_toplam_puan_kulla
            // 
            this.lbl_toplam_puan_kulla.AutoSize = true;
            this.lbl_toplam_puan_kulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam_puan_kulla.Location = new System.Drawing.Point(132, 464);
            this.lbl_toplam_puan_kulla.Name = "lbl_toplam_puan_kulla";
            this.lbl_toplam_puan_kulla.Size = new System.Drawing.Size(19, 20);
            this.lbl_toplam_puan_kulla.TabIndex = 11;
            this.lbl_toplam_puan_kulla.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(739, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_puan_rakip
            // 
            this.lbl_puan_rakip.AutoSize = true;
            this.lbl_puan_rakip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_puan_rakip.Location = new System.Drawing.Point(132, 103);
            this.lbl_puan_rakip.Name = "lbl_puan_rakip";
            this.lbl_puan_rakip.Size = new System.Drawing.Size(19, 20);
            this.lbl_puan_rakip.TabIndex = 2;
            this.lbl_puan_rakip.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_toplam_puan_rakip
            // 
            this.lbl_toplam_puan_rakip.AutoSize = true;
            this.lbl_toplam_puan_rakip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam_puan_rakip.Location = new System.Drawing.Point(132, 136);
            this.lbl_toplam_puan_rakip.Name = "lbl_toplam_puan_rakip";
            this.lbl_toplam_puan_rakip.Size = new System.Drawing.Size(19, 20);
            this.lbl_toplam_puan_rakip.TabIndex = 10;
            this.lbl_toplam_puan_rakip.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pcb_pisti
            // 
            this.pcb_pisti.Location = new System.Drawing.Point(22, 257);
            this.pcb_pisti.Name = "pcb_pisti";
            this.pcb_pisti.Size = new System.Drawing.Size(156, 120);
            this.pcb_pisti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_pisti.TabIndex = 5;
            this.pcb_pisti.TabStop = false;
            this.pcb_pisti.Tag = "1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 407);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pcb_cards
            // 
            this.pcb_cards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_cards.Location = new System.Drawing.Point(590, 257);
            this.pcb_cards.Name = "pcb_cards";
            this.pcb_cards.Size = new System.Drawing.Size(102, 120);
            this.pcb_cards.TabIndex = 2;
            this.pcb_cards.Paint += new System.Windows.Forms.PaintEventHandler(this.pcb_cards_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(256, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 112);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(256, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 112);
            this.panel1.TabIndex = 0;
            // 
            // lbl_puan_kullanici
            // 
            this.lbl_puan_kullanici.AutoSize = true;
            this.lbl_puan_kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_puan_kullanici.Location = new System.Drawing.Point(132, 431);
            this.lbl_puan_kullanici.Name = "lbl_puan_kullanici";
            this.lbl_puan_kullanici.Size = new System.Drawing.Size(19, 20);
            this.lbl_puan_kullanici.TabIndex = 3;
            this.lbl_puan_kullanici.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(308, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 120);
            this.panel2.TabIndex = 1;
            // 
            // pnl_arka
            // 
            this.pnl_arka.BackColor = System.Drawing.Color.Transparent;
            this.pnl_arka.Controls.Add(this.lbl_toplam_puan_kulla);
            this.pnl_arka.Controls.Add(this.lbl_toplam_puan_rakip);
            this.pnl_arka.Controls.Add(this.pictureBox2);
            this.pnl_arka.Controls.Add(this.pcb_pisti);
            this.pnl_arka.Controls.Add(this.pictureBox3);
            this.pnl_arka.Controls.Add(this.pcb_cards);
            this.pnl_arka.Controls.Add(this.panel3);
            this.pnl_arka.Controls.Add(this.pictureBox1);
            this.pnl_arka.Controls.Add(this.panel1);
            this.pnl_arka.Controls.Add(this.lbl_puan_kullanici);
            this.pnl_arka.Controls.Add(this.panel2);
            this.pnl_arka.Controls.Add(this.lbl_puan_rakip);
            this.pnl_arka.Location = new System.Drawing.Point(26, 21);
            this.pnl_arka.Name = "pnl_arka";
            this.pnl_arka.Size = new System.Drawing.Size(724, 535);
            this.pnl_arka.TabIndex = 9;
            this.pnl_arka.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_arka_Paint);
            // 
            // Bilgisayar
            // 
            this.Bilgisayar.Frozen = true;
            this.Bilgisayar.HeaderText = "Bilgisayar";
            this.Bilgisayar.Name = "Bilgisayar";
            this.Bilgisayar.ReadOnly = true;
            // 
            // Sen
            // 
            this.Sen.Frozen = true;
            this.Sen.HeaderText = "Sen";
            this.Sen.Name = "Sen";
            this.Sen.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sen,
            this.Bilgisayar});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(815, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(203, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // FrmPisti_Oyunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl_arka);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPisti_Oyunu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PİŞTİ OYUNU";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPisti_Oyunu_FormClosing);
            this.Load += new System.EventHandler(this.FrmPisti_Oyunu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_pisti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnl_arka.ResumeLayout(false);
            this.pnl_arka.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_toplam_puan_kulla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_puan_rakip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_toplam_puan_rakip;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pcb_pisti;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pcb_cards;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_puan_kullanici;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_arka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bilgisayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sen;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}