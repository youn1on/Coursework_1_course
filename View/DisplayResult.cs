using System.Windows.Forms;
using System;
using System.Drawing;
using Labyrinths_AStar_Dijkstra.Model;
using Labyrinths_AStar_Dijkstra.Controller;

namespace Labyrinths_AStar_Dijkstra.View
{
    public partial class DisplayResult : Randomizer
    {
        public DisplayResult()
        {
            InitializeComponent();
            Load += OnLoad;
        }
        private int startX, startY, endX, endY;
        private bool IsValid = false;
        public Vertice[] vertices; // Array of vertices, which is used by visualiser.
        public static int EndPointIndex; // The index of endpoint vertice in array of vertices.

        private void OnLoad(object sender, EventArgs e)
        {
            Location = Style.FullFormsLocation;
        }
        
        /// <summary>
        /// Allows user to go to previous form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoBack(object sender, EventArgs e)
        {
            Program.ClosedByUser = false;
            this.Close();
        }
        
        /// <summary>
        /// Does visualisation of valid coordinates on the labyrinth.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private  void Check(object sender, EventArgs e)
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
                this.Controls.Remove(this.background);
                IsValid = true;
                this.labyrinthVisualiser =
                    new LabyrinthVisualiser(this, new(startY, startX), new(endY, endX));
                return;
            }
            IsValid = false;
        }
        
        /// <summary>
        /// Visualises route found by selected algorithm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Confirm(object sender, EventArgs e)
        {
            Check(sender, e);
            if (!IsValid)
            {
                MessageBox.Show("Please, enter valid coordinates!");
                return;
            }

            vertices = LabyrinthProcessor.GetVerticeList(Program.labyrinth,
                new[] {new[] {startY, startX}, new[] {endY, endX}});
            int[][] distances = LabyrinthProcessor.GetDistances(vertices, Program.labyrinth);
            DijkstrasAlgorithm algo;
            if (dijkstraRadioButton.Checked) algo = new DijkstrasAlgorithm(vertices, distances, labyrinthVisualiser);
            else if (euclideanRadioButton.Checked) algo = new AStarEuclidean(vertices, distances, labyrinthVisualiser);
            else algo = new AStarManhattan(vertices, distances, labyrinthVisualiser);
            int[]entryPoints =
                LabyrinthProcessor.GetEntryPointIndexes(vertices, new[] {new[] {startY, startX}, new[] {endY, endX}});
            EndPointIndex = entryPoints[1];
            algo.animated = !quickSearch.Checked;
            algo.FindRoute(entryPoints[0], entryPoints[1]);
            this.background.Refresh();
        }
    }
}