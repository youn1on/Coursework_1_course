using System;
using System.IO;
using System.Windows.Forms;
using Labyrinths_AStar_Dijkstra.Model;

namespace Labyrinths_AStar_Dijkstra.Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Confirm(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text.Trim())) MessageBox.Show($"The program don`t accept empty path!");
            else if (File.Exists(this.textBox1.Text))
            {
                string[] content = FileOperations.GetFileContent(this.textBox1.Text);
                if (content != null)
                {
                    Program.FileContent = content;
                    NextForm();
                }
                MessageBox.Show("Invalid file structure!");
                this.textBox1.Text = "";
            }
            else
            {
                MessageBox.Show($"Path {this.textBox1.Text} doesn't exist!");
                this.textBox1.Text = "";
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
                this.textBox1.Text = dialog.FileName;
            }
        }

        private void Randomize(object sender, EventArgs e)
        {
            NextForm();
        }

        private void NextForm()
        {
            Program.ClosedByUser = false;
            Close();
        }
    }
}