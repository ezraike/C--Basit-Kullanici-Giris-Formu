namespace WinFormsApp5
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Hatali_Girisler = new ListBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Symbol", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(233, 15);
            label1.Name = "label1";
            label1.Size = new Size(273, 34);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Giriş Paneli";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(24, 52);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(228, 275);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label5
            // 
            label5.Location = new Point(6, 214);
            label5.Name = "label5";
            label5.Size = new Size(214, 59);
            label5.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 85);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 150);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 37);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(70, 190);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "Giris Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Location = new Point(5, 87);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 4;
            label4.Text = "Şifre";
            // 
            // label3
            // 
            label3.Location = new Point(5, 152);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 3;
            label3.Text = "Anahtar Kelime";
            // 
            // label2
            // 
            label2.Location = new Point(5, 39);
            label2.Name = "label2";
            label2.Size = new Size(82, 19);
            label2.TabIndex = 2;
            label2.Text = "Kullanici Adi";
            // 
            // Hatali_Girisler
            // 
            Hatali_Girisler.BackColor = SystemColors.Info;
            Hatali_Girisler.FormattingEnabled = true;
            Hatali_Girisler.ItemHeight = 15;
            Hatali_Girisler.Location = new Point(432, 52);
            Hatali_Girisler.Margin = new Padding(3, 2, 3, 2);
            Hatali_Girisler.Name = "Hatali_Girisler";
            Hatali_Girisler.Size = new Size(243, 214);
            Hatali_Girisler.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(492, 279);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(126, 34);
            button2.TabIndex = 3;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(button2);
            Controls.Add(Hatali_Girisler);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private ListBox Hatali_Girisler;
        private Button button2;
    }
}