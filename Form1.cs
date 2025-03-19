using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;
using System.Media;

namespace ShagaiProject
{
    public partial class Shagai : Form
    {
        Random shagaiFace = new Random();
        private int attempts = 3;
        private bool gameOver = false;

        enum ShagaiFace
        {
            Horse,
            Sheep,
            Camel,
            Goat
        }
        private static Dictionary<string, string> interpretations = new Dictionary<string, string>()
        {

            {"Horse, Sheep, Camel, Goat", "FOUR DIFFICULTIES - Best Fortune"},
            {"Horse, Horse, Horse, Horse", "Superior"},
            {"Sheep, Sheep, Sheep, Sheep", "No Obstacles"},
            {"Camel, Camel, Camel, Camel", "Lead Gain"},
            {"Goat, Goat, Goat, Goat", "Depends on Somebody else"},
            {"Horse, Horse, Horse, Sheep", "No Obstacles and Problems with Transformation"},
            {"Horse, Horse, Horse, Camel", "Good"},
            {"Camel, Goat, Goat, Goat", "No hope"},
            {"Sheep, Goat, Goat, Goat", "Not good for business"},
            {"Horse, Horse, Sheep, Sheep ", "No difficulties"},
            {"Horse, Horse, Camel, Camel", "Good business & will gain profit"},
            {"Horse, Horse, Goat, Goat", "Need to try"},
            {"Camel, Camel, Goat, Goat", "Uncertain if it will be good or not"},
            {"Sheep, Sheep, Goat, Goat", "Difficulties in the future"},
            {"Sheep, Sheep, Camel, Camel","Good for you"},
            {"Horse, Horse, Sheep, Camel", "Good and happy"},
            {"Horse, Horse, Camel, Goat", "Good and no obstacles"},
            {"Sheep, Sheep, Camel, Goat", "Uncertain"},
            {"Horse, Camel, Camel, Goat", "No difficulties and happy"},
            {"Horse, Sheep, Goat, Goat", "Close to truth, message will be"},
            {"Sheep, Camel, Goat, Goat", "Good for the other part"},
            {"Horse, Camel, Goat, Goat", "Joy and Happiness"},
            {"Horse, Sheep, Sheep, Sheep", "Happy for long time, good for you"},
            {"Horse, Camel, Camel, Camel", "Small obstacles , wait hear later"},
            {"Horse, Goat, Goat, Goat", "Something will cause difficulties"},
            {"Camel, Camel, Camel, Goat", "Depends on somebody else"},
            {"Sheep, Sheep, Sheep, Goat", "So, so, Other person may be right"},
            {"Horse, Horse, Horse, Goat", "Very Good"},
            {"Horse, Sheep, Sheep, Camel", "Message will be delivered"},
            {"Horse, Sheep, Camel, Camel", "Slow success"},
            //{"Horse, Sheep, Camel, Camel", "Good business"},
            {"Sheep, Camel, Camel, Goat", "Good business"},
            {"Sheep, Sheep, Sheep, Camel", "No harm for life and health"},
            {"Sheep, Camel, Camel, Camel", "Unsuccessful"}

        };

        private Dictionary<ShagaiFace, Image> shagaiImages = new Dictionary<ShagaiFace, Image>();
        public Shagai()
        {
            InitializeComponent();
            LoadShagaiImages();
            UpdateAttemptsLabel();
        }

        private void UpdateAttemptsLabel()
        {
            if (attemptsLabel != null)
            {
                attemptsLabel.Text = $"{attempts}";
            }
        }

        private void LoadShagaiImages()
        {

            shagaiImages[ShagaiFace.Horse] = Properties.Resources.horse;
            shagaiImages[ShagaiFace.Camel] = Properties.Resources.camel;
            shagaiImages[ShagaiFace.Sheep] = Properties.Resources.sheep;
            shagaiImages[ShagaiFace.Goat] = Properties.Resources.goat;

        }
        private void welcomeLabel_Click(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Welcome to Shagai Fortune Teller";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (attempts > 0 && !gameOver)
            {

                ShagaiFace[] results = new ShagaiFace[4];
                Dictionary<ShagaiFace, int> sideCounts = new Dictionary<ShagaiFace, int>()
                {
                    { ShagaiFace.Horse, 0},
                    { ShagaiFace.Sheep, 0},
                    { ShagaiFace.Camel, 0},
                    { ShagaiFace.Goat, 0}
                };

                for (int i = 0; i < 4; i++)
                {
                    results[i] = (ShagaiFace)shagaiFace.Next(0, 4);
                    sideCounts[results[i]]++;
                }


                pictureBox1.Image = shagaiImages[results[0]];
                pictureBox2.Image = shagaiImages[results[1]];
                pictureBox3.Image = shagaiImages[results[2]];
                pictureBox4.Image = shagaiImages[results[3]];

             string key = string.Join(", ", results.OrderBy(f => f)); // Its a correct key format.
                
             SoundPlayer player = new SoundPlayer();
                player.SoundLocation = "C:\\Users\\vbyam\\source\\repos\\ShagaiFortuneTeller\\ShagaiFortuneTeller\\PNG\\click-soundeffect.wav";
                player.Load();
                player.Play();

                    if (results.Distinct().Count() == 4)
                    {
                        MessageBox.Show("YOU WON! FOUR DIFFICULTIES!");
                        gameOver = true;
                        attempts = 0;
                        UpdateAttemptsLabel();
                        return;

                    }

                    else if (results.All(r => r == ShagaiFace.Horse))
                    {
                        MessageBox.Show("YOU WON! FOUR HORSES!");
                        gameOver = true;
                        attempts = 0;
                        UpdateAttemptsLabel();
                        return;
                    }


                string countsMessage = $"Horse: {sideCounts[ShagaiFace.Horse]}, Sheep: {sideCounts[ShagaiFace.Sheep]}, Camel: {sideCounts[ShagaiFace.Camel]}, Goat: {sideCounts[ShagaiFace.Goat]}";
                if (countsLabel != null)
                {

                    countsLabel.Text = countsMessage;
                }

                if (interpretations.ContainsKey(key))
                {
                    MessageBox.Show($"{interpretations[key]}"); //should be displayed interpretation.;
                }

                else
                {
                    MessageBox.Show($"Interpretation not found.");
                }
                attempts--;
                UpdateAttemptsLabel();

                if (attempts == 0)
                {
                    MessageBox.Show("No more attempts remaining.");
                }
            }


            else if (!gameOver)
            {
                MessageBox.Show("Game is over. Please resart the game.");
            }
            else
            {
                MessageBox.Show("No more attempts remaining.");
            }

           
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void attemptsLabel_Click(object sender, EventArgs e)
        {

        }

        private void sideCounter_Click(object sender, EventArgs e)
        {

        }
    }
}
