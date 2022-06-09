using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;
using Labyrinths_AStar_Dijkstra.Model;
using Labyrinths_AStar_Dijkstra.Controller;

namespace Labyrinths_AStar_Dijkstra.View
{
    public partial class DisplayResult : Randomizer
    {
        public DisplayResult()
        {
            InitializeComponent();
        }

        public Label background;

        private async void Randomize(object sender, EventArgs e)
        {
            string pattern = @"^[3-9]$|^\d\d$";
            if (!Regex.IsMatch(textBox1.Text, pattern) || !Regex.IsMatch(textBox2.Text, pattern))
            {
                MessageBox.Show("Incorrect dimensions. Enter dimensions in range 3-99.");
                return;
            }

            if (this.labyrinthVisualiser != null) Controls.Remove(background);
            int sizeX = Int32.Parse(textBox2.Text) * 2 + 1;
            int sizeY = Int32.Parse(textBox1.Text) * 2 + 1;
            this.labyrinthVisualiser = new LabyrinthVisualiser(Program.labyrinth, this);
            Refresh();
        }

        private void Confirm(object sender, EventArgs e)
        {
            
        }
    }
}