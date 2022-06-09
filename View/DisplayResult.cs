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
        private int startX, startY, endX, endY;
        private bool IsValid = false;
        private async void Check(object sender, EventArgs e)
        {
            if (!int.TryParse(this.coordinatesStartX.Text, out startX) || !int.TryParse(this.coordinatesStartY.Text, out startY) ||
                !int.TryParse(this.coordinatesEndX.Text, out endX) || !int.TryParse(this.coordinatesEndY.Text, out endY))
            {
                MessageBox.Show("Incorrect input! Please, enter numerical coordinates!");
            }
            else if (startX < 0 || endX < 0 || startY < 0 || endY < 0 || startX > Program.labyrinth[0].Length ||
                endX>Program.labyrinth[0].Length||startY>Program.labyrinth.Length||endY>Program.labyrinth.Length)
            {
                MessageBox.Show("At least one of coordinates is out of labyrinth range!");
            }
            else if (Program.labyrinth[startY][startX] == 1 || Program.labyrinth[endY][endX] == 1)
            {
                MessageBox.Show("You have chosen the wall! Please, enter the coordinates of free space!");
            }
            else
            {
                IsValid = true;
                this.labyrinthVisualiser =
                    new LabyrinthVisualiser(Program.labyrinth, this, new(startX, startY), new(endX, endY));
                return;
            }
            IsValid = false;
        }
        private void Confirm(object sender, EventArgs e)
        {
            if (!IsValid) Check(sender, e);
            if (!IsValid)
            {
                MessageBox.Show("Please, enter valid coordinates!");
                return;
            }
    
        }
    }
}