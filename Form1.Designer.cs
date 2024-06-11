namespace ankara
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
            carp = new Button();
            cikar = new Button();
            topla = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            temizle = new Button();
            bolme = new Button();
            SuspendLayout();
            // 
            // carp
            // 
            carp.Location = new Point(74, 210);
            carp.Name = "carp";
            carp.Size = new Size(67, 29);
            carp.TabIndex = 13;
            carp.Text = "ÇARP";
            carp.UseVisualStyleBackColor = true;
            carp.Click += carp_Click;
            // 
            // cikar
            // 
            cikar.Location = new Point(7, 210);
            cikar.Name = "cikar";
            cikar.Size = new Size(61, 29);
            cikar.TabIndex = 12;
            cikar.Text = "ÇIKAR";
            cikar.UseVisualStyleBackColor = true;
            cikar.Click += cikar_Click;
            // 
            // topla
            // 
            topla.Location = new Point(7, 175);
            topla.Name = "topla";
            topla.Size = new Size(61, 29);
            topla.TabIndex = 11;
            topla.Text = "TOPLA";
            topla.UseVisualStyleBackColor = true;
            topla.Click += topla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 9);
            label1.MaximumSize = new Size(350, 60);
            label1.Name = "label1";
            label1.Size = new Size(314, 40);
            label1.TabIndex = 1;
            label1.Text = "İŞLEM YAPMAK İÇİN ALTTAKİ BUTONLARDAN BİRİNE TIKLAYINIZ.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 27);
            textBox2.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 74);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 4;
            label2.Text = "1.Sayı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 74);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 5;
            label3.Text = "2.Sayı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 111);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 6;
            label4.Text = "0";
            // 
            // temizle
            // 
            temizle.Location = new Point(147, 176);
            temizle.Name = "temizle";
            temizle.Size = new Size(163, 64);
            temizle.TabIndex = 16;
            temizle.Text = "TEMİZLE";
            temizle.UseVisualStyleBackColor = true;
            temizle.Click += temizle_Click;
            // 
            // bolme
            // 
            bolme.Location = new Point(76, 176);
            bolme.Name = "bolme";
            bolme.Size = new Size(65, 29);
            bolme.TabIndex = 17;
            bolme.Text = "BÖL";
            bolme.UseVisualStyleBackColor = true;
            bolme.Click += bolme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 247);
            Controls.Add(bolme);
            Controls.Add(temizle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(carp);
            Controls.Add(label2);
            Controls.Add(cikar);
            Controls.Add(textBox2);
            Controls.Add(topla);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Basit Hesap Makinesi.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private Button carp;
        private Button cikar;
        private Button topla;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button temizle;
        private Button bolme;
    }
}
