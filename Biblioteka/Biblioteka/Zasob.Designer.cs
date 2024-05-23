namespace Biblioteka
{
    partial class Zasob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zasob));
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            listBox2 = new ListBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(350, 24);
            label1.Name = "label1";
            label1.Size = new Size(279, 45);
            label1.TabIndex = 0;
            label1.Text = "Zasoby biblioteki";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.OldLace;
            listBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 30;
            listBox1.Items.AddRange(new object[] { "OBOWIĄZKOWE:", "● Arystoteles – Poetyka, Retoryka ", "● Platon – Państwo ", "● Arystofanes – Chmury", "● Wergiliusz – Eneida ", "● Św. Augustyn – Wyznania ", "● Św. Tomasz z Akwinu – Summa teologiczna ", "● François Rabelais – Gargantua i Pantagruel ", "● Michel de Montaigne – Próby ", "● Jan Kochanowski – Treny ", "● William Szekspir – Hamlet", "● Juliusz Słowacki – Lilla Weneda", "● Stanisław Wyspiański – Noc listopadowa", "● Franz Kafka – Proces ", "● Michaił Bułhakow – Mistrz i Małgorzata", "● Stanisław Ignacy Witkiewicz – Szewcy", "● Bruno Schulz – Sklepy cynamonowe", "● Tadeusz Konwicki – Mała apokalipsa", "", "NIEOBOWIĄZKOWE:", "● Sofokles – Król Edyp", "● Dzieje Tristana i Izoldy ", "● Giovanni Boccaccio – Sokół", "● Mikołaj Rej – Żywot człowieka poczciwego ", "● Wespazjan Kochowski – Psalmodia polska", "● Wacław Potocki – ", "   Transakcja wojny chocimskiej ", "● Ignacy Krasicki – Monachomachia ", "● Stanisław Trembecki – Franciszek Kniaźnin", "● Julian Ursyn Niemcewicz – Powrót posła", "● Stanisław Staszic – Przestrogi dla Polski ", "● Juliusz Słowacki – Beniowski ", "● Aleksander Fredro – Śluby panieńskie", "● Johann Wolfgang Goethe –", "    Cierpienia młodego Wertera", "● George Byron – Giaur ", "● Adam Mickiewicz – Dziady cz. IV", "● Eliza Orzeszkowa – Nad Niemnem", "● Maria Konopnicka – wybór wierszy", "● Stefan Żeromski – Echa leśne", "● Zofia Nałkowska – Granica", "● Tadeusz Peiper – wybór wierszy", "● Joseph Conrad – Lord Jim", "● Jan Józef Szczepański – Święty", "● Tadeusz Różewicz – Kartoteka", "● Józef Czapski – Na nieludzkiej ziemi ", "● Leopold Tyrmand – Dziennik 1954 ", "● Stanisław Lem – Wizja lokalna", "● Samuel Beckett – Czekając na Godota", "● Friedrich Dürrenmatt –", "    Wizyta starszej pani", "● Eugène Ionesco – Lekcja", "● Zofia Kossak-Szczucka – Błogosławiona wina", "● Krystyna Lubieniecka-Baraniak – ", "   Gdy brat staje się katem", "● Karol Wojtyła – Przed sklepem jubilera", "● Stefan Wyszyński – Zapiski więzienne" });
            listBox1.Location = new Point(12, 145);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(461, 454);
            listBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(219, 97);
            label2.Name = "label2";
            label2.Size = new Size(142, 45);
            label2.TabIndex = 2;
            label2.Text = "Lektury:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click_1;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.OldLace;
            listBox2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 30;
            listBox2.Items.AddRange(new object[] { "● James Clear - Atomowe nawyki", "● David Goggins - Nic mnie nie złamie", "● Erin Doom - Rzeźbiarz łez", "● Cixin Liu - Problem trzech ciał", "● Delia Owens - Gdzie śpiewają raki", "● Remigiusz Mróz - Paderborn", "● Frank Herbert - Diuna", "● James Clavell - Shogun", "● Kristen Ciccarelli - Szkarłatna ćma", "● Katarzyna Bonda - Krew w piach", "● Marcel Moss - Polana" });
            listBox2.Location = new Point(491, 145);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(461, 454);
            listBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(652, 97);
            label3.Name = "label3";
            label3.Size = new Size(173, 45);
            label3.TabIndex = 4;
            label3.Text = "Pozostałe:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(28, 25);
            button1.Name = "button1";
            button1.Size = new Size(85, 44);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Zasob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(964, 696);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(980, 735);
            MinimumSize = new Size(980, 735);
            Name = "Zasob";
            Text = "Zasob";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private ListBox listBox2;
        private Label label3;
        private Button button1;
    }
}