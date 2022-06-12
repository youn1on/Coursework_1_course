using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Labyrinths_AStar_Dijkstra.Model;
using Labyrinths_AStar_Dijkstra.View;

namespace Labyrinths_AStar_Dijkstra.Controller
{
    public partial class Randomizer : Form
    {
        /// <summary>
        /// Allows user to randomly generate labyrinth of given dimensions.
        /// </summary>
        public Randomizer()
        {
            InitializeComponent();
            Load += OnLoad;
        }

        public Label background;

        private void OnLoad(object sender, EventArgs e)
        {
            this.Location = Style.RandomizerFormLocation;
        }
        /// <summary>
        /// Creates labyrinths if inputs are valid.
        /// </summary>
        private void Randomize(object sender, EventArgs e)
        {
            string pattern = @"^[3-9]$|^\d{2}$";
            if (!Regex.IsMatch(xDimension.Text, pattern) || !Regex.IsMatch(yDimension.Text, pattern)) // if one of dimensions is less than 3 or bigger than 99:
            {
                MessageBox.Show("Incorrect dimensions. Enter dimensions in range 3-99.");
                return;
            }

            if (this.labyrinthVisualiser != null) Controls.Remove(background); // if we already have painted a labyrinth, remove it
            int sizeX = Int32.Parse(yDimension.Text) * 2 + 1;
            int sizeY = Int32.Parse(xDimension.Text) * 2 + 1;
            Program.labyrinth = deadEndCheckBox.Checked // generate new labyrinth with dead ends or not
                ? LabyrinthGenerator.GenerateDeadEndLabyrinth(sizeX, sizeY)
                : LabyrinthGenerator.GenerateLabyrinth(sizeX, sizeY);
            this.labyrinthVisualiser = new LabyrinthVisualiser(this); // recreate a labyrinth
            Refresh();
        }
        /// <summary>
        /// Returns user to the previous form.
        /// </summary>
        private void GoBack(object sender, EventArgs e)
        {
            // Indicates that the window is closed by the program, not by user, so we shouldn't close the entire program.
            Program.ClosedByUser = false; 
            
            this.Close(); // Close this form and return to previous.
        }
        
        /// <summary>
        /// Sends user to the next form, if labyrinth is created.
        /// </summary>
        private void Confirm(object sender, EventArgs e)
        {
            if (Program.labyrinth == null) MessageBox.Show("Please randomize labyrinth first"); 
            else // If labyrinth is generated:
            {
                this.Hide(); //Hide this form and display next.
                new DisplayResult().ShowDialog();
                // When next form is closed:
                if (Program.ClosedByUser) Close();
                else // If closed by program (goBack button is clicked):
                {
                    Program.ClosedByUser = true;
                    this.Show();
                }
            }
        }
    }
}