using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PokemonBattle
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        public Form1()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>();
            pokemons.Add(new Gengar());
            pokemons.Add(new Persian());
            pokemons.Add(new Mewtwo());
            pokemons.Add(new Sealeo());

            monster = new Nidoking();
            pictureBox2.Image = monster.getImage();
            Nenemy.Text = monster.getHP().ToString();
            HPenemy.Text = monster.getName();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("Dead");
            }
            else
            {
                pictureBox1.Image = selectedPokemon.getImage();
                Ntp.Text = selectedPokemon.getName();
                HPtp.Text = selectedPokemon.getHP().ToString();
            }
        }

        private void Mewtwo_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("Dead");
            }
            else
            {
                pictureBox1.Image = selectedPokemon.getImage();
                Ntp.Text = selectedPokemon.getName();
                HPtp.Text = selectedPokemon.getHP().ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("Dead");
            }
            else
            {
                pictureBox1.Image = selectedPokemon.getImage();
                Ntp.Text = selectedPokemon.getName();
                HPtp.Text = selectedPokemon.getHP().ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Gengar_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("Dead");
            }
            else
            {
                pictureBox1.Image = selectedPokemon.getImage();
                Ntp.Text = selectedPokemon.getName();
                HPtp.Text = selectedPokemon.getHP().ToString();
            }
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            {
                if (selectedPokemon.getHP() > 0)
                {

                    int damage = (selectedPokemon.getAttack() - monster.getDefense());
                    monster.takeDamage(damage);
                    HPenemy.Text = monster.getHP().ToString();

                    if (monster.getHP() <= 0)
                    {
                        HPenemy.Text = "0";
                        MessageBox.Show("Monster Defeated!!");
                    }
                    else
                    {
                        int enemyDamage = (monster.getAttack() - selectedPokemon.getDefense());
                        selectedPokemon.takeDamage(enemyDamage);
                        HPtp.Text = selectedPokemon.getHP().ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Your Pokemon has no HP left.");
                }
            }
        }
        private void Hearth_Click(object sender, EventArgs e)
        {
            if (selectedPokemon != null)
            {
                selectedPokemon.IncreaseHP(50);
                HPtp.Text = selectedPokemon.getHP().ToString();
            }
            else
            {
                MessageBox.Show(" เพิ่มHP Pokemon");
            }
        }
    }
}