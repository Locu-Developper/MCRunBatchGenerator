namespace MCSupportApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.確認ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jDKバージョンToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 23);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "サーバーファイルを指定してください(ドラッグ&ドロップでもできます)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.確認ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 確認ToolStripMenuItem
            // 
            this.確認ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jDKバージョンToolStripMenuItem});
            this.確認ToolStripMenuItem.Name = "確認ToolStripMenuItem";
            this.確認ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.確認ToolStripMenuItem.Text = "確認";
            // 
            // jDKバージョンToolStripMenuItem
            // 
            this.jDKバージョンToolStripMenuItem.Name = "jDKバージョンToolStripMenuItem";
            this.jDKバージョンToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.jDKバージョンToolStripMenuItem.Text = "JDK バージョン";
            this.jDKバージョンToolStripMenuItem.Click += new System.EventHandler(this.jDKバージョンToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "MCバージョン";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1.19.2",
            "1.19.1",
            "1.19",
            "1.18.2",
            "1.18.1",
            "1.18",
            "1.17.1",
            "1.17",
            "1.16.5",
            "1.16.4",
            "1.16.2",
            "1.16.1",
            "1.16",
            "1.15.2",
            "1.15.1",
            "1.15",
            "1.14.4",
            "1.14.3",
            "1.14.2",
            "1.14.1",
            "1.14",
            "1.13.2",
            "1.13.1",
            "1.13",
            "1.12.2",
            "1.12.1",
            "1.12",
            "1.11.2",
            "1.11.1",
            "1.11",
            "1.10.2",
            "1.10.1",
            "1.10",
            "1.9.4",
            "1.9.3",
            "1.9.2",
            "1.9.1",
            "1.9",
            "1.8.9",
            "1.8.8",
            "1.8.7",
            "1.8.6",
            "1.8.5",
            "1.8.4",
            "1.8.3",
            "1.8.2",
            "1.8.1",
            "1.8",
            "1.7.10",
            "1.7.9",
            "1.7.8",
            "1.7.7",
            "1.7.6",
            "1.7.5",
            "1.7.4",
            "1.7.2",
            "1.6.4",
            "1.6.2",
            "1.6.1"});
            this.comboBox1.Location = new System.Drawing.Point(219, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(361, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "生成";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "起動用ファイル名";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 23);
            this.textBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(282, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 28);
            this.label4.TabIndex = 11;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(301, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 19);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "GUI 表示";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(249, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 1);
            this.label5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(59, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "詳細設定(わからない方は無視でOK)";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(0, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 1);
            this.label7.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 196);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(330, 23);
            this.textBox3.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 19;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "例)C:\\Program Files\\Java";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "起動時メモリ量(Xms)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "最大時メモリ量(Xmx)";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(273, 228);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(52, 23);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(273, 253);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(52, 23);
            this.textBox5.TabIndex = 24;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "GB",
            "MB"});
            this.comboBox2.Location = new System.Drawing.Point(331, 228);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(45, 23);
            this.comboBox2.TabIndex = 25;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "GB",
            "MB"});
            this.comboBox3.Location = new System.Drawing.Point(331, 253);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(45, 23);
            this.comboBox3.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(16, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 43);
            this.label12.TabIndex = 27;
            this.label12.Text = "未入力の場合、デフォルト値になります";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(0, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(385, 1);
            this.label13.TabIndex = 28;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(385, 331);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Run Batch Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 確認ToolStripMenuItem;
        private ToolStripMenuItem jDKバージョンToolStripMenuItem;
        private Label label2;
        private ComboBox comboBox1;
        private Button button2;
        private RichTextBox richTextBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private CheckBox checkBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private Button button3;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Label label12;
        private Label label13;
    }
}