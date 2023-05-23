namespace BirKelimeBirİşlem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHarf1 = new System.Windows.Forms.TextBox();
            this.txtHarf8 = new System.Windows.Forms.TextBox();
            this.txtHarf4 = new System.Windows.Forms.TextBox();
            this.txtHarf3 = new System.Windows.Forms.TextBox();
            this.txtHarf7 = new System.Windows.Forms.TextBox();
            this.txtHarf5 = new System.Windows.Forms.TextBox();
            this.txtHarf9 = new System.Windows.Forms.TextBox();
            this.txtHarf2 = new System.Windows.Forms.TextBox();
            this.txtHarf6 = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lstKelimeler = new System.Windows.Forms.ListBox();
            this.btnKelime = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHarf1
            // 
            this.txtHarf1.BackColor = System.Drawing.Color.Linen;
            this.txtHarf1.Location = new System.Drawing.Point(50, 42);
            this.txtHarf1.Multiline = true;
            this.txtHarf1.Name = "txtHarf1";
            this.txtHarf1.Size = new System.Drawing.Size(48, 35);
            this.txtHarf1.TabIndex = 0;
            // 
            // txtHarf8
            // 
            this.txtHarf8.BackColor = System.Drawing.Color.Linen;
            this.txtHarf8.Location = new System.Drawing.Point(222, 104);
            this.txtHarf8.Multiline = true;
            this.txtHarf8.Name = "txtHarf8";
            this.txtHarf8.Size = new System.Drawing.Size(48, 35);
            this.txtHarf8.TabIndex = 1;
            // 
            // txtHarf4
            // 
            this.txtHarf4.BackColor = System.Drawing.Color.Linen;
            this.txtHarf4.Location = new System.Drawing.Point(310, 42);
            this.txtHarf4.Multiline = true;
            this.txtHarf4.Name = "txtHarf4";
            this.txtHarf4.Size = new System.Drawing.Size(48, 35);
            this.txtHarf4.TabIndex = 2;
            // 
            // txtHarf3
            // 
            this.txtHarf3.BackColor = System.Drawing.Color.Linen;
            this.txtHarf3.Location = new System.Drawing.Point(222, 42);
            this.txtHarf3.Multiline = true;
            this.txtHarf3.Name = "txtHarf3";
            this.txtHarf3.Size = new System.Drawing.Size(48, 35);
            this.txtHarf3.TabIndex = 3;
            // 
            // txtHarf7
            // 
            this.txtHarf7.BackColor = System.Drawing.Color.Linen;
            this.txtHarf7.Location = new System.Drawing.Point(136, 104);
            this.txtHarf7.Multiline = true;
            this.txtHarf7.Name = "txtHarf7";
            this.txtHarf7.Size = new System.Drawing.Size(48, 35);
            this.txtHarf7.TabIndex = 4;
            // 
            // txtHarf5
            // 
            this.txtHarf5.BackColor = System.Drawing.Color.Linen;
            this.txtHarf5.Location = new System.Drawing.Point(389, 42);
            this.txtHarf5.Multiline = true;
            this.txtHarf5.Name = "txtHarf5";
            this.txtHarf5.Size = new System.Drawing.Size(48, 35);
            this.txtHarf5.TabIndex = 5;
            // 
            // txtHarf9
            // 
            this.txtHarf9.BackColor = System.Drawing.Color.Linen;
            this.txtHarf9.Location = new System.Drawing.Point(310, 104);
            this.txtHarf9.Multiline = true;
            this.txtHarf9.Name = "txtHarf9";
            this.txtHarf9.Size = new System.Drawing.Size(48, 35);
            this.txtHarf9.TabIndex = 6;
            // 
            // txtHarf2
            // 
            this.txtHarf2.BackColor = System.Drawing.Color.Linen;
            this.txtHarf2.Location = new System.Drawing.Point(136, 42);
            this.txtHarf2.Multiline = true;
            this.txtHarf2.Name = "txtHarf2";
            this.txtHarf2.Size = new System.Drawing.Size(48, 35);
            this.txtHarf2.TabIndex = 7;
            // 
            // txtHarf6
            // 
            this.txtHarf6.BackColor = System.Drawing.Color.Linen;
            this.txtHarf6.Location = new System.Drawing.Point(50, 104);
            this.txtHarf6.Multiline = true;
            this.txtHarf6.Name = "txtHarf6";
            this.txtHarf6.Size = new System.Drawing.Size(48, 35);
            this.txtHarf6.TabIndex = 8;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.btnRandom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnRandom.Location = new System.Drawing.Point(389, 104);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(103, 35);
            this.btnRandom.TabIndex = 9;
            this.btnRandom.Text = "Random Harf";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lstKelimeler
            // 
            this.lstKelimeler.BackColor = System.Drawing.Color.SeaShell;
            this.lstKelimeler.FormattingEnabled = true;
            this.lstKelimeler.ItemHeight = 16;
            this.lstKelimeler.Location = new System.Drawing.Point(50, 171);
            this.lstKelimeler.Name = "lstKelimeler";
            this.lstKelimeler.Size = new System.Drawing.Size(442, 100);
            this.lstKelimeler.TabIndex = 10;
            // 
            // btnKelime
            // 
            this.btnKelime.BackColor = System.Drawing.Color.AliceBlue;
            this.btnKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.btnKelime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnKelime.Location = new System.Drawing.Point(50, 293);
            this.btnKelime.Name = "btnKelime";
            this.btnKelime.Size = new System.Drawing.Size(103, 35);
            this.btnKelime.TabIndex = 11;
            this.btnKelime.Text = "Kelime Üret";
            this.btnKelime.UseVisualStyleBackColor = false;
            this.btnKelime.Click += new System.EventHandler(this.btnKelime_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.AliceBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnClear.Location = new System.Drawing.Point(159, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 35);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnKelime);
            this.Controls.Add(this.lstKelimeler);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtHarf6);
            this.Controls.Add(this.txtHarf2);
            this.Controls.Add(this.txtHarf9);
            this.Controls.Add(this.txtHarf5);
            this.Controls.Add(this.txtHarf7);
            this.Controls.Add(this.txtHarf3);
            this.Controls.Add(this.txtHarf4);
            this.Controls.Add(this.txtHarf8);
            this.Controls.Add(this.txtHarf1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHarf1;
        private System.Windows.Forms.TextBox txtHarf8;
        private System.Windows.Forms.TextBox txtHarf4;
        private System.Windows.Forms.TextBox txtHarf3;
        private System.Windows.Forms.TextBox txtHarf7;
        private System.Windows.Forms.TextBox txtHarf5;
        private System.Windows.Forms.TextBox txtHarf9;
        private System.Windows.Forms.TextBox txtHarf2;
        private System.Windows.Forms.TextBox txtHarf6;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ListBox lstKelimeler;
        private System.Windows.Forms.Button btnKelime;
        private System.Windows.Forms.Button btnClear;
    }
}

