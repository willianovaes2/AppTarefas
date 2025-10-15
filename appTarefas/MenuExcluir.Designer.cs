namespace appTarefas
{
    partial class MenuExcluir
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
            button2 = new Button();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(807, 390);
            button2.Name = "button2";
            button2.Size = new Size(179, 38);
            button2.TabIndex = 88;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonShadow;
            pictureBox3.Location = new Point(360, 162);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(635, 63);
            pictureBox3.TabIndex = 87;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(370, 390);
            button1.Name = "button1";
            button1.Size = new Size(206, 38);
            button1.TabIndex = 85;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(360, 133);
            label1.Name = "label1";
            label1.Size = new Size(113, 19);
            label1.TabIndex = 83;
            label1.Text = "Menu Excluir";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonShadow;
            pictureBox2.Location = new Point(360, 380);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(635, 63);
            pictureBox2.TabIndex = 86;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ScrollBar;
            pictureBox1.Location = new Point(360, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(635, 310);
            pictureBox1.TabIndex = 84;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(592, 284);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 104;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(520, 284);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 103;
            label2.Text = "Código";
            // 
            // MenuExcluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.windows_xp_back;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 647);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "MenuExcluir";
            Text = "MenuExcluir";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private PictureBox pictureBox3;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label2;
    }
}