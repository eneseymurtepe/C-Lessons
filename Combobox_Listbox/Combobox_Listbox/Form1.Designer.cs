namespace Combobox_Listbox
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            button3 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kocaeli", "Tekirdağ", "İstanbul", "Sakarya", "Ağrı", "Bursa", "Zonguldak", "İzmir", "Antalya", "Manisa" });
            comboBox1.Location = new Point(395, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 32);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(409, 105);
            button1.Name = "button1";
            button1.Size = new Size(113, 32);
            button1.TabIndex = 1;
            button1.Text = "Şehir Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 32);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(179, 105);
            button2.Name = "button2";
            button2.Size = new Size(122, 30);
            button2.TabIndex = 3;
            button2.Text = "Listeye Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(147, 26);
            label1.TabIndex = 4;
            label1.Text = "Eklenecek Şehir";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Items.AddRange(new object[] { "Bilişim Uzmanı", "Yazılım Geliştirici", "Doktor", "Avukat", "İşçi", "Mühendis", "Aşçı" });
            listBox1.Location = new Point(780, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(174, 172);
            listBox1.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(802, 251);
            button3.Name = "button3";
            button3.Size = new Size(123, 45);
            button3.TabIndex = 7;
            button3.Text = "Meslek Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Location = new Point(580, 42);
            label2.Name = "label2";
            label2.Size = new Size(160, 24);
            label2.TabIndex = 8;
            label2.Text = "Eklenecek Meslek";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(597, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 32);
            textBox2.TabIndex = 9;
            // 
            // button4
            // 
            button4.Location = new Point(597, 137);
            button4.Name = "button4";
            button4.Size = new Size(129, 54);
            button4.TabIndex = 10;
            button4.Text = "Listeye Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1100, 540);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Combobox and Listbox";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
        private ListBox listBox1;
        private Button button3;
        private Label label2;
        private TextBox textBox2;
        private Button button4;
    }
}
