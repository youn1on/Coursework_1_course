using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Labyrinths_AStar_Dijkstra.Model;
using Labyrinths_AStar_Dijkstra.View;

namespace Labyrinths_AStar_Dijkstra.Controller
{
    public partial class Randomizer : Form
    {
        public Randomizer()
        {
            InitializeComponent();
            Load += OnLoad;
        }

        public Label background;

        public void OnLoad(object sender, EventArgs e)
        {
            this.Location = Style.RandomizerFormLocation;
        }
        
        private void Randomize(object sender, EventArgs e)
        {
            string pattern = @"^[3-9]$|^\d\d$";
            if (!Regex.IsMatch(xDimension.Text, pattern) || !Regex.IsMatch(yDimension.Text, pattern))
            {
                MessageBox.Show("Incorrect dimensions. Enter dimensions in range 3-99.");
                return;
            }

            if (this.labyrinthVisualiser != null) Controls.Remove(background);
            int sizeX = Int32.Parse(yDimension.Text) * 2 + 1;
            int sizeY = Int32.Parse(xDimension.Text) * 2 + 1;
            Program.labyrinth = deadEndCheckBox.Checked
                ? LabyrinthGenerator.GenerateDeadEndLabyrinth(sizeX, sizeY)
                : LabyrinthGenerator.GenerateLabyrinth(sizeX, sizeY);
            this.labyrinthVisualiser = new LabyrinthVisualiser(this);
            Refresh();
        }

        private void GoBack(object sender, EventArgs e)
        {
            Program.ClosedByUser = false;
            this.Close();
        }
        private void Confirm(object sender, EventArgs e)
        {
            if (Program.labyrinth == null) MessageBox.Show("Please randomize labyrinth first");
            else
            {
                this.Hide();
                new DisplayResult().ShowDialog();
                if (Program.ClosedByUser) Close();
                else
                {
                    Program.ClosedByUser = true;
                    this.Show();
                }
            }
        }
    }
}