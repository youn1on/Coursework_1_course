using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            Program.labyrinth = checkBox1.Checked
                ? LabyrinthGenerator.GenerateDeadEndLabyrinth(sizeX, sizeY)
                : LabyrinthGenerator.GenerateLabyrinth(sizeX, sizeY);
            this.labyrinthVisualiser = new LabyrinthVisualiser(Program.labyrinth, this);
            Refresh();
        }
        private void Confirm(object sender, EventArgs e)
        {
            if (Program.labyrinth == null) MessageBox.Show("Please randomize labyrinth first");
            else
            {
                Program.ClosedByUser = false;
                Close();
            }
        }
    }
}