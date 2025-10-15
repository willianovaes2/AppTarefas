namespace appTarefas
{
    partial class MenuLogin
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
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(442, 450);
            button1.Name = "button1";
            button1.Size = new Size(116, 41);
            button1.TabIndex = 19;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(514, 311);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 18;
            label3.Text = "Senha";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(582, 311);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 23);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(514, 273);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 16;
            label2.Text = "E-mail";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(582, 273);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 23);
            textBox1.TabIndex = 15;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(430, 147);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 14;
            label1.Text = "Login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ScrollBar;
            pictureBox1.Location = new Point(430, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(512, 355);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonShadow;
            pictureBox3.Location = new Point(430, 179);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(512, 63);
            pictureBox3.TabIndex = 89;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonShadow;
            pictureBox2.Location = new Point(430, 439);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(512, 63);
            pictureBox2.TabIndex = 88;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ScrollBar;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(514, 375);
            label4.Name = "label4";
            label4.Size = new Size(200, 19);
            label4.TabIndex = 90;
            label4.Text = "Ainda não tem uma conta?";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(720, 375);
            button2.Name = "button2";
            button2.Size = new Size(84, 23);
            button2.TabIndex = 91;
            button2.Text = "Cadastre-se";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // MenuLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.windows_xp_back;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 647);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "MenuLogin";
            Text = "MenuLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label4;
        private Button button2;
    }
}