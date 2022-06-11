using System;
using System.IO;
using System.Windows.Forms;
using Labyrinths_AStar_Dijkstra.Model;
using Labyrinths_AStar_Dijkstra.View;

namespace Labyrinths_AStar_Dijkstra.Controller
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
            Load += OnLoad;
        }
        
        private void OnLoad(object sender, EventArgs e)
        {
            Location = Style.SmallFormLocation;
        }
        private void Confirm(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.pathToFile.Text.Trim())) MessageBox.Show($"The program doesn`t accept empty path!");
            else if (File.Exists(this.pathToFile.Text))
            {
                string[] content = FileOperations.GetFileContent(this.pathToFile.Text);
                if (content != null)
                {
                    Program.labyrinth = FileContentProcessor.GetLabyrinthMatrix(content);
                    Hide();
                    new DisplayResult().ShowDialog();
                    if (Program.ClosedByUser) Close();
                    else
                    {
                        this.Show();
                        Program.ClosedByUser = true;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid file structure!");
                    this.pathToFile.Text = "";
                }
            }
            else
            {
                MessageBox.Show($"Path {this.pathToFile.Text} doesn't exist!");
                this.pathToFile.Text = "";
            }
        }

        private void Select(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"c:\Users\";
            dialog.Filter = "txt files (*.txt)|*.txt";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                this.pathToFile.Text = dialog.FileName;
            }
        }

        private void Randomize(object sender, EventArgs e)
        {
            this.Hide();
            new Randomizer().ShowDialog();
            if (Program.ClosedByUser) Close();
            {
                this.Show();
                Program.ClosedByUser = true;
            }
        }
    }
}