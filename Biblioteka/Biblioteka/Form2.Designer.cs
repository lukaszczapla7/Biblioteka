namespace Biblioteka
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            regulamin = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(345, 15);
            label1.Name = "label1";
            label1.Size = new Size(331, 45);
            label1.TabIndex = 0;
            label1.Text = "Regulamin biblioteki";
            // 
            // regulamin
            // 
            regulamin.BackColor = Color.FromArgb(255, 224, 192);
            regulamin.BorderStyle = BorderStyle.None;
            regulamin.Enabled = false;
            regulamin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            regulamin.Location = new Point(29, 79);
            regulamin.Multiline = true;
            regulamin.Name = "regulamin";
            regulamin.Size = new Size(894, 591);
            regulamin.TabIndex = 1;
            regulamin.Text = resources.GetString("regulamin.Text");
            regulamin.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(29, 19);
            button1.Name = "button1";
            button1.Size = new Size(85, 44);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(964, 696);
            Controls.Add(button1);
            Controls.Add(regulamin);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(980, 735);
            MinimumSize = new Size(980, 735);
            Name = "Form2";
            Text = "Regulamin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox regulamin;
        private Button button1;
    }
}