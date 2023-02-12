namespace Pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mewtwo mewtwo = new Mewtwo();
            this.pictureBox1.Image = mewtwo.getImage();
            this.textBox1.Text =mewtwo.getName();
            this.textBox2.Text = mewtwo.getHP().ToString();
            if (mewtwo.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.textBox1.Text = "*Eliminated*";
                this.textBox2.Text = "0";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gengar gengar= new Gengar();
            this.pictureBox1.Image = gengar.getImage();
            this.textBox1.Text = gengar.getName();
            this.textBox2.Text = gengar.getHP().ToString();
            {
                this.pictureBox1.Image = null;
                this.textBox1.Text = "*Eliminated*";
                this.textBox2.Text = "0";
                if (gengar.getHP() <= 0)
                {
                    this.pictureBox1.Image = null;
                    this.textBox1.Text = "*Eliminated*";
                    this.textBox2.Text = "0";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persian persian = new Persian();
            this.pictureBox1.Image = persian.getImage();
            this.pictureBox1.Image = persian.getImage();
            this.textBox1.Text = persian.getName();
            this.textBox2.Text = persian.getHP().ToString();
            if (persian.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.textBox1.Text = "*Eliminated*";
                this.textBox2.Text = "0";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sealeo sealeo = new Sealeo();
            this.pictureBox1.Image = sealeo.getImage();
            this.textBox1.Text = sealeo.getName();
            this.textBox2.Text = sealeo.getHP().ToString();
            if (sealeo.getHP() <= 0)
            {
                this.pictureBox1.Image = null;
                this.textBox1.Text = "*Eliminated*";
                this.textBox2.Text = "0";
            }
        }
    }
}