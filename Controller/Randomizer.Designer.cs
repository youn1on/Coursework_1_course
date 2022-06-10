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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialForm));
            this.randomizeButton = new System.Windows.Forms.Button();
            this.dimenionsLabel = new System.Windows.Forms.Label();
            this.xDimension = new System.Windows.Forms.TextBox();
            this.deadEndCheckBox = new System.Windows.Forms.CheckBox();
            this.yDimension = new System.Windows.Forms.TextBox();
            this.multiplyLabel = new System.Windows.Forms.Label();
            this.box = new GroupBox();
            this.confirmButton = new Button();
            this.SuspendLayout();
            // 
            // randomizeButton
            // 
            this.randomizeButton.Font = new System.Drawing.Font("Goudy Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.randomizeButton.Location = Style.RandomizeLocation;
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(205, 67);
            this.randomizeButton.TabIndex = 0;
            this.randomizeButton.Text = "Randomize";
            this.randomizeButton.UseVisualStyleBackColor = true;
            this.randomizeButton.Click += new System.EventHandler(this.Randomize);
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Goudy Old Style", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.confirmButton.Location = Style.ConfirmButtonPoint;
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(205, 67);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "Confirm✓";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.Confirm);
            this.confirmButton.BackColor = Style.ConfirmButtonColor;
            // 
            // dimensionsLabel
            // 
            this.dimenionsLabel.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.dimenionsLabel.Location = new System.Drawing.Point(231, 9);
            this.dimenionsLabel.Name = "dimenionsLabel";
            this.dimenionsLabel.Size = new System.Drawing.Size(287, 39);
            this.dimenionsLabel.TabIndex = 1;
            this.dimenionsLabel.Text = "Enter the labyrinth dimensions";
            this.dimenionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xDimension
            // 
            this.xDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.xDimension.Location = new System.Drawing.Point(271, 62);
            this.xDimension.Name = "xDimension";
            this.xDimension.Size = new System.Drawing.Size(66, 34);
            this.xDimension.TabIndex = 2;
            // 
            // deadEndCheckBox
            // 
            this.deadEndCheckBox.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.deadEndCheckBox.Location = new System.Drawing.Point(198, 118);
            this.deadEndCheckBox.Name = "deadEndCheckBox";
            this.deadEndCheckBox.Size = new System.Drawing.Size(377, 38);
            this.deadEndCheckBox.TabIndex = 3;
            this.deadEndCheckBox.Text = "Create labyrinth with dead ends";
            this.deadEndCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deadEndCheckBox.UseVisualStyleBackColor = true;
            // 
            // yDimension
            // 
            this.yDimension.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.yDimension.Location = new System.Drawing.Point(396, 62);
            this.yDimension.Name = "yDimension";
            this.yDimension.Size = new System.Drawing.Size(66, 34);
            this.yDimension.TabIndex = 4;
            // 
            // multiplyLabel
            // 
            this.multiplyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.multiplyLabel.Location = new System.Drawing.Point(343, 62);
            this.multiplyLabel.Name = "multiplyLabel";
            this.multiplyLabel.Size = new System.Drawing.Size(47, 34);
            this.multiplyLabel.TabIndex = 5;
            this.multiplyLabel.Text = "x";
            this.multiplyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Randomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(752, 780);
            this.Controls.Add(this.multiplyLabel);
            this.Controls.Add(this.yDimension);
            this.Controls.Add(this.deadEndCheckBox);
            this.Controls.Add(this.xDimension);
            this.Controls.Add(this.dimenionsLabel);
            this.Controls.Add(this.randomizeButton);
            this.Controls.Add(this.confirmButton);
            this.Name = "InitialForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private LabyrinthVisualiser labyrinthVisualiser;
        private GroupBox box;

        private System.Windows.Forms.TextBox yDimension;
        private System.Windows.Forms.Label multiplyLabel;

        private System.Windows.Forms.CheckBox deadEndCheckBox;

        private System.Windows.Forms.TextBox xDimension;

        private System.Windows.Forms.Label dimenionsLabel;

        private System.Windows.Forms.Button randomizeButton;
        
        private System.Windows.Forms.Button confirmButton;

        #endregion
    }
}