namespace PokemonBattle
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Nenemy = new TextBox();
            HPenemy = new TextBox();
            Ntp = new TextBox();
            HPtp = new TextBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            Hearth = new Button();
            Gengar = new Button();
            Sealeo = new Button();
            Persian = new Button();
            Mewtwo = new Button();
            Attack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(109, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Nidoking;
            pictureBox2.Location = new Point(514, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(194, 187);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 234);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 275);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 3;
            label2.Text = "HP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 234);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 4;
            label3.Text = "Name ENEMY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(426, 275);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 5;
            label4.Text = "HP ENEMY";
            // 
            // Nenemy
            // 
            Nenemy.Location = new Point(514, 231);
            Nenemy.Name = "Nenemy";
            Nenemy.Size = new Size(194, 27);
            Nenemy.TabIndex = 6;
            // 
            // HPenemy
            // 
            HPenemy.Location = new Point(512, 272);
            HPenemy.Name = "HPenemy";
            HPenemy.Size = new Size(194, 27);
            HPenemy.TabIndex = 7;
            // 
            // Ntp
            // 
            Ntp.Location = new Point(109, 234);
            Ntp.Name = "Ntp";
            Ntp.Size = new Size(194, 27);
            Ntp.TabIndex = 8;
            // 
            // HPtp
            // 
            HPtp.Location = new Point(109, 272);
            HPtp.Name = "HPtp";
            HPtp.Size = new Size(194, 27);
            HPtp.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(514, 327);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 238);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Command";
            // 
            // button3
            // 
            button3.Location = new Point(27, 152);
            button3.Name = "button3";
            button3.Size = new Size(127, 29);
            button3.TabIndex = 2;
            button3.Text = "Defense";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(27, 105);
            button2.Name = "button2";
            button2.Size = new Size(127, 29);
            button2.TabIndex = 1;
            button2.Text = "HP";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(27, 59);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 0;
            button1.Text = "Attack";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Hearth);
            groupBox2.Controls.Add(Gengar);
            groupBox2.Controls.Add(Sealeo);
            groupBox2.Controls.Add(Persian);
            groupBox2.Controls.Add(Mewtwo);
            groupBox2.Controls.Add(Attack);
            groupBox2.Location = new Point(109, 327);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(194, 253);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Command";
            // 
            // Hearth
            // 
            Hearth.Location = new Point(32, 210);
            Hearth.Name = "Hearth";
            Hearth.Size = new Size(127, 29);
            Hearth.TabIndex = 5;
            Hearth.Text = "Hearth";
            Hearth.UseVisualStyleBackColor = true;
            Hearth.Click += Hearth_Click;
            // 
            // Gengar
            // 
            Gengar.Location = new Point(32, 175);
            Gengar.Name = "Gengar";
            Gengar.Size = new Size(127, 29);
            Gengar.TabIndex = 4;
            Gengar.Text = "Gengar";
            Gengar.UseVisualStyleBackColor = true;
            Gengar.Click += Gengar_Click;
            // 
            // Sealeo
            // 
            Sealeo.Location = new Point(32, 140);
            Sealeo.Name = "Sealeo";
            Sealeo.Size = new Size(127, 29);
            Sealeo.TabIndex = 3;
            Sealeo.Text = "Sealeo";
            Sealeo.UseVisualStyleBackColor = true;
            Sealeo.Click += button7_Click;
            // 
            // Persian
            // 
            Persian.Location = new Point(32, 110);
            Persian.Name = "Persian";
            Persian.Size = new Size(127, 24);
            Persian.TabIndex = 2;
            Persian.Text = "Persian";
            Persian.UseVisualStyleBackColor = true;
            Persian.Click += button4_Click;
            // 
            // Mewtwo
            // 
            Mewtwo.Location = new Point(32, 75);
            Mewtwo.Name = "Mewtwo";
            Mewtwo.Size = new Size(127, 29);
            Mewtwo.TabIndex = 1;
            Mewtwo.Text = "Mewtwo";
            Mewtwo.UseVisualStyleBackColor = true;
            Mewtwo.Click += Mewtwo_Click;
            // 
            // Attack
            // 
            Attack.Location = new Point(32, 40);
            Attack.Name = "Attack";
            Attack.Size = new Size(127, 29);
            Attack.TabIndex = 0;
            Attack.Text = "Attack";
            Attack.UseVisualStyleBackColor = true;
            Attack.Click += Attack_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 592);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(HPtp);
            Controls.Add(Ntp);
            Controls.Add(HPenemy);
            Controls.Add(Nenemy);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "PokemonBattle";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Nenemy;
        private TextBox HPenemy;
        private TextBox Ntp;
        private TextBox HPtp;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
        private Button Sealeo;
        private Button Persian;
        private Button Mewtwo;
        private Button Attack;
        private Button Gengar;
        private Button Hearth;
    }
}