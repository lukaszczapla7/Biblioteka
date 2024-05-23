namespace Biblioteka
{
    partial class ListaRezerwacji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaRezerwacji));
            button1 = new Button();
            label1 = new Label();
            rezerwacja = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(29, 22);
            button1.Name = "button1";
            button1.Size = new Size(85, 44);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(346, 13);
            label1.Name = "label1";
            label1.Size = new Size(249, 45);
            label1.TabIndex = 8;
            label1.Text = "Lista rezerwacji";
            // 
            // rezerwacja
            // 
            rezerwacja.BackColor = Color.FromArgb(255, 224, 192);
            rezerwacja.BorderStyle = BorderStyle.None;
            rezerwacja.Enabled = false;
            rezerwacja.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rezerwacja.Location = new Point(29, 113);
            rezerwacja.Multiline = true;
            rezerwacja.Name = "rezerwacja";
            rezerwacja.Size = new Size(901, 444);
            rezerwacja.TabIndex = 9;
            rezerwacja.Text = "\r\n";
            rezerwacja.TextChanged += rezerwacja_TextChanged;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(346, 78);
            button2.Name = "button2";
            button2.Size = new Size(249, 29);
            button2.TabIndex = 10;
            button2.Text = "Zaktualizuj listę";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ListaRezerwacji
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(964, 696);
            Controls.Add(button2);
            Controls.Add(rezerwacja);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListaRezerwacji";
            Text = "Lista Rezerwacji";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox rezerwacja;
        private Button button2;
    }
}