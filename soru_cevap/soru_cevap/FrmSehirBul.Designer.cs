
namespace soru_cevap
{
    partial class FrmSehirBul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSehirBul));
            this.GrpOyunalani = new System.Windows.Forms.GroupBox();
            this.GrpCevapalani = new System.Windows.Forms.GroupBox();
            this.lblkalanhak = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblgirilenharf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkelime = new System.Windows.Forms.TextBox();
            this.btntahminet = new System.Windows.Forms.Button();
            this.btnHarfGir = new System.Windows.Forms.Button();
            this.txtharf = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GrpCevapalani.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpOyunalani
            // 
            this.GrpOyunalani.BackColor = System.Drawing.Color.LightSalmon;
            this.GrpOyunalani.Location = new System.Drawing.Point(12, 57);
            this.GrpOyunalani.Name = "GrpOyunalani";
            this.GrpOyunalani.Size = new System.Drawing.Size(636, 152);
            this.GrpOyunalani.TabIndex = 0;
            this.GrpOyunalani.TabStop = false;
            this.GrpOyunalani.Text = "Soru Alanı";
            // 
            // GrpCevapalani
            // 
            this.GrpCevapalani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GrpCevapalani.Controls.Add(this.lblkalanhak);
            this.GrpCevapalani.Controls.Add(this.label2);
            this.GrpCevapalani.Controls.Add(this.lblgirilenharf);
            this.GrpCevapalani.Controls.Add(this.label1);
            this.GrpCevapalani.Controls.Add(this.txtkelime);
            this.GrpCevapalani.Controls.Add(this.btntahminet);
            this.GrpCevapalani.Controls.Add(this.btnHarfGir);
            this.GrpCevapalani.Controls.Add(this.txtharf);
            this.GrpCevapalani.Location = new System.Drawing.Point(12, 247);
            this.GrpCevapalani.Name = "GrpCevapalani";
            this.GrpCevapalani.Size = new System.Drawing.Size(636, 166);
            this.GrpCevapalani.TabIndex = 1;
            this.GrpCevapalani.TabStop = false;
            this.GrpCevapalani.Text = "Cevap Alanı";
            // 
            // lblkalanhak
            // 
            this.lblkalanhak.AutoSize = true;
            this.lblkalanhak.Location = new System.Drawing.Point(119, 132);
            this.lblkalanhak.Name = "lblkalanhak";
            this.lblkalanhak.Size = new System.Drawing.Size(13, 13);
            this.lblkalanhak.TabIndex = 7;
            this.lblkalanhak.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kalan Hak :";
            // 
            // lblgirilenharf
            // 
            this.lblgirilenharf.AutoSize = true;
            this.lblgirilenharf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgirilenharf.Location = new System.Drawing.Point(119, 84);
            this.lblgirilenharf.Name = "lblgirilenharf";
            this.lblgirilenharf.Size = new System.Drawing.Size(0, 17);
            this.lblgirilenharf.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Girilen Harfler :";
            // 
            // txtkelime
            // 
            this.txtkelime.Location = new System.Drawing.Point(380, 28);
            this.txtkelime.Name = "txtkelime";
            this.txtkelime.Size = new System.Drawing.Size(126, 20);
            this.txtkelime.TabIndex = 3;
            // 
            // btntahminet
            // 
            this.btntahminet.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btntahminet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntahminet.Location = new System.Drawing.Point(527, 23);
            this.btntahminet.Name = "btntahminet";
            this.btntahminet.Size = new System.Drawing.Size(103, 28);
            this.btntahminet.TabIndex = 2;
            this.btntahminet.Text = "TAHMİN ET";
            this.btntahminet.UseVisualStyleBackColor = false;
            this.btntahminet.Click += new System.EventHandler(this.btntahminet_Click);
            // 
            // btnHarfGir
            // 
            this.btnHarfGir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHarfGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHarfGir.Location = new System.Drawing.Point(172, 23);
            this.btnHarfGir.Name = "btnHarfGir";
            this.btnHarfGir.Size = new System.Drawing.Size(117, 32);
            this.btnHarfGir.TabIndex = 1;
            this.btnHarfGir.Text = "HARF GİR";
            this.btnHarfGir.UseVisualStyleBackColor = false;
            this.btnHarfGir.Click += new System.EventHandler(this.btnHarfGir_Click);
            // 
            // txtharf
            // 
            this.txtharf.Location = new System.Drawing.Point(7, 31);
            this.txtharf.Name = "txtharf";
            this.txtharf.Size = new System.Drawing.Size(137, 20);
            this.txtharf.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(392, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "YENİ OYUN BAŞLAT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSehirBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GrpCevapalani);
            this.Controls.Add(this.GrpOyunalani);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSehirBul";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ŞEHİR TAHMİN";
            this.Load += new System.EventHandler(this.FrmSehirBul_Load);
            this.GrpCevapalani.ResumeLayout(false);
            this.GrpCevapalani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpOyunalani;
        private System.Windows.Forms.GroupBox GrpCevapalani;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblkalanhak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblgirilenharf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkelime;
        private System.Windows.Forms.Button btntahminet;
        private System.Windows.Forms.Button btnHarfGir;
        private System.Windows.Forms.TextBox txtharf;
    }
}