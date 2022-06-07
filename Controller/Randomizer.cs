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

        private async void Randomize(object sender, EventArgs e)
        {
            string pattern = @"^[3-9]$|^\d\d$";
            if (!Regex.IsMatch(textBox1.Text, pattern) || !Regex.IsMatch(textBox2.Text, pattern))
            {
                MessageBox.Show("Incorrect dimensions. Enter dimensions in range 3-99.");
                return;
            }

            if (this.labyrinthVisualiser != null) RemoveLabyrinth();
            int sizeX = Int32.Parse(textBox2.Text) * 2 + 1;
            int sizeY = Int32.Parse(textBox1.Text) * 2 + 1;
            Program.labyrinth = checkBox1.Checked
                ? LabyrinthGenerator.GenerateDeadEndLabyrinth(sizeX, sizeY)
                : LabyrinthGenerator.GenerateLabyrinth(sizeX, sizeY);
            this.labyrinthVisualiser = new LabyrinthVisualiser(Program.labyrinth);
            foreach (var label in labyrinthVisualiser.GetCellsArray())
            {
                this.box.Controls.Add(label);
            }

            box.Size = new Size(labyrinthVisualiser.Cells.Length * labyrinthVisualiser.CellSize,
                labyrinthVisualiser.Cells[0].Length * labyrinthVisualiser.CellSize);
            this.Controls.Add(box);
            Refresh();
        }

        private void RemoveLabyrinth()
        {
            /*Label[] cells = this.labyrinthVisualiser.GetCellsArray();
            foreach (var label in cells) Controls.Remove(label);*/
            
            this.Controls.Remove(box);
            box.Controls.Clear();
        }
    }
}