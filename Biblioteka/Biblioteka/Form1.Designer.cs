namespace Biblioteka
{
    partial class Biblioteka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblioteka));
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            panel1 = new Panel();
            Tytul = new TextBox();
            label21 = new Label();
            Klasa = new NumericUpDown();
            label20 = new Label();
            label19 = new Label();
            DataRezerwacji = new DateTimePicker();
            Nazwisko = new TextBox();
            Imie = new TextBox();
            label18 = new Label();
            label17 = new Label();
            button3 = new Button();
            Lista = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Klasa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1064, 108);
            label1.TabIndex = 0;
            label1.Text = "Biblioteka szkolna";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.OldLace;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label12, 1, 4);
            tableLayoutPanel1.Controls.Add(label11, 1, 3);
            tableLayoutPanel1.Controls.Add(label10, 1, 2);
            tableLayoutPanel1.Controls.Add(label9, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(label8, 0, 4);
            tableLayoutPanel1.Location = new Point(12, 160);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(237, 229);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label12.ForeColor = SystemColors.WindowText;
            label12.Location = new Point(122, 182);
            label12.Name = "label12";
            label12.Size = new Size(110, 45);
            label12.TabIndex = 9;
            label12.Text = "8:20 - 14:40";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label11.ForeColor = SystemColors.WindowText;
            label11.Location = new Point(122, 137);
            label11.Name = "label11";
            label11.Size = new Size(110, 43);
            label11.TabIndex = 8;
            label11.Text = "8:20 - 13:45";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label10.ForeColor = SystemColors.WindowText;
            label10.Location = new Point(122, 92);
            label10.Name = "label10";
            label10.Size = new Size(110, 43);
            label10.TabIndex = 7;
            label10.Text = "9:05 - 15:25";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label9.ForeColor = SystemColors.WindowText;
            label9.Location = new Point(122, 47);
            label9.Name = "label9";
            label9.Size = new Size(110, 43);
            label9.TabIndex = 6;
            label9.Text = "8:20 - 13:45";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(5, 47);
            label5.Name = "label5";
            label5.Size = new Size(109, 43);
            label5.TabIndex = 2;
            label5.Text = "Wtorek";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(122, 2);
            label4.Name = "label4";
            label4.Size = new Size(110, 43);
            label4.TabIndex = 1;
            label4.Text = "8:20 - 14:40";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(5, 2);
            label3.Name = "label3";
            label3.Size = new Size(109, 43);
            label3.TabIndex = 0;
            label3.Text = "Poniedziałek";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = SystemColors.WindowText;
            label6.Location = new Point(5, 92);
            label6.Name = "label6";
            label6.Size = new Size(109, 43);
            label6.TabIndex = 3;
            label6.Text = "Środa";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.ForeColor = SystemColors.WindowText;
            label7.Location = new Point(5, 137);
            label7.Name = "label7";
            label7.Size = new Size(109, 43);
            label7.TabIndex = 4;
            label7.Text = "Czwartek";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.ForeColor = SystemColors.WindowText;
            label8.Location = new Point(5, 182);
            label8.Name = "label8";
            label8.Size = new Size(109, 45);
            label8.TabIndex = 5;
            label8.Text = "Piątek";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(11, 133);
            label2.Name = "label2";
            label2.Size = new Size(241, 25);
            label2.TabIndex = 2;
            label2.Text = "Godziny otwarcia biblioteki";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            button1.Location = new Point(43, 421);
            button1.Name = "button1";
            button1.Size = new Size(175, 45);
            button1.TabIndex = 3;
            button1.Text = "Zasoby biblioteki";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            button2.Location = new Point(43, 483);
            button2.Name = "button2";
            button2.Size = new Size(175, 45);
            button2.TabIndex = 4;
            button2.Text = "Regulamin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label13.ForeColor = SystemColors.WindowText;
            label13.Location = new Point(12, 573);
            label13.Name = "label13";
            label13.Size = new Size(85, 25);
            label13.TabIndex = 5;
            label13.Text = "Kontakt:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label14.ForeColor = SystemColors.WindowText;
            label14.Location = new Point(13, 600);
            label14.Name = "label14";
            label14.Size = new Size(225, 21);
            label14.TabIndex = 6;
            label14.Text = "email: bibliotekasp12@mail.pl";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label15.ForeColor = SystemColors.WindowText;
            label15.Location = new Point(13, 621);
            label15.Name = "label15";
            label15.Size = new Size(124, 21);
            label15.TabIndex = 7;
            label15.Text = "tel: 123-323-321";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label16.ForeColor = SystemColors.WindowText;
            label16.Location = new Point(236, 666);
            label16.Name = "label16";
            label16.Size = new Size(586, 40);
            label16.TabIndex = 8;
            label16.Text = "„Książka to najlepszy przyjaciel człowieka, a biblioteka to świątynia jego myśli.” – Cyceron\r\n\r\n";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Tytul);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(Klasa);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(DataRezerwacji);
            panel1.Controls.Add(Nazwisko);
            panel1.Controls.Add(Imie);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Location = new Point(364, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(552, 366);
            panel1.TabIndex = 9;
            // 
            // Tytul
            // 
            Tytul.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Tytul.Location = new Point(182, 224);
            Tytul.Name = "Tytul";
            Tytul.Size = new Size(275, 39);
            Tytul.TabIndex = 19;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label21.ForeColor = SystemColors.WindowText;
            label21.Location = new Point(46, 231);
            label21.Name = "label21";
            label21.Size = new Size(79, 32);
            label21.TabIndex = 18;
            label21.Text = "Tytuł:";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Klasa
            // 
            Klasa.Font = new Font("Segoe UI", 18F);
            Klasa.Location = new Point(182, 157);
            Klasa.Name = "Klasa";
            Klasa.Size = new Size(120, 39);
            Klasa.TabIndex = 17;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label20.ForeColor = SystemColors.WindowText;
            label20.Location = new Point(46, 293);
            label20.Name = "label20";
            label20.Size = new Size(198, 32);
            label20.TabIndex = 16;
            label20.Text = "Data rezerwacji:";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label19.ForeColor = SystemColors.WindowText;
            label19.Location = new Point(46, 164);
            label19.Name = "label19";
            label19.Size = new Size(81, 32);
            label19.TabIndex = 15;
            label19.Text = "Klasa:";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DataRezerwacji
            // 
            DataRezerwacji.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            DataRezerwacji.Font = new Font("Segoe UI", 12F);
            DataRezerwacji.Location = new Point(257, 296);
            DataRezerwacji.Name = "DataRezerwacji";
            DataRezerwacji.Size = new Size(200, 29);
            DataRezerwacji.TabIndex = 14;
            DataRezerwacji.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Nazwisko
            // 
            Nazwisko.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Nazwisko.Location = new Point(182, 93);
            Nazwisko.Name = "Nazwisko";
            Nazwisko.Size = new Size(275, 39);
            Nazwisko.TabIndex = 13;
            // 
            // Imie
            // 
            Imie.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Imie.Location = new Point(182, 37);
            Imie.Name = "Imie";
            Imie.Size = new Size(275, 39);
            Imie.TabIndex = 12;
            Imie.TextChanged += Imie_TextChanged;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label18.ForeColor = SystemColors.WindowText;
            label18.Location = new Point(46, 100);
            label18.Name = "label18";
            label18.Size = new Size(130, 32);
            label18.TabIndex = 11;
            label18.Text = "Nazwisko:";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label17.ForeColor = SystemColors.WindowText;
            label17.Location = new Point(46, 44);
            label17.Name = "label17";
            label17.Size = new Size(71, 32);
            label17.TabIndex = 10;
            label17.Text = "Imię:";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 238);
            button3.Location = new Point(580, 534);
            button3.Name = "button3";
            button3.Size = new Size(175, 45);
            button3.TabIndex = 10;
            button3.Text = "Zarezerwuj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Lista
            // 
            Lista.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            Lista.Location = new Point(761, 534);
            Lista.Name = "Lista";
            Lista.Size = new Size(155, 45);
            Lista.TabIndex = 11;
            Lista.Text = "Lista rezerwacji";
            Lista.UseVisualStyleBackColor = true;
            Lista.Click += Lista_Click;
            // 
            // Biblioteka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1064, 696);
            Controls.Add(Lista);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1080, 735);
            MinimumSize = new Size(1080, 735);
            Name = "Biblioteka";
            Text = "Biblioteka";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Klasa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button2;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Panel panel1;
        private Label label18;
        private Label label17;
        private TextBox Nazwisko;
        private TextBox Imie;
        private Button button3;
        private Label label20;
        private Label label19;
        private DateTimePicker DataRezerwacji;
        private NumericUpDown Klasa;
        private TextBox Tytul;
        private Label label21;
        private Button Lista;
    }
}
