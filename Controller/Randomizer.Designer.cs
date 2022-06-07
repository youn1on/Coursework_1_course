using System.Windows.Forms;
using Labyrinths_AStar_Dijkstra.View;

namespace Labyrinths_AStar_Dijkstra.Controller
{
    partial class Randomizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box = new GroupBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Goudy Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(273, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Randomize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Randomize);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the labyrinth dimensions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBox1.Location = new System.Drawing.Point(271, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 34);
            this.textBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox1.Location = new System.Drawing.Point(198, 118);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(377, 38);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Create labyrinth with dead ends";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.textBox2.Location = new System.Drawing.Point(396, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 34);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(343, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "x";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // box
            //
            this.box.Location = Style.LabyrinthLocation;
            this.box.Size = Style.VisualizedLabyrinthSize;
            this.box.Name = "labyrinth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(752, 843);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private LabyrinthVisualiser labyrinthVisualiser;
        private GroupBox box;

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button1;

        #endregion
    }
}