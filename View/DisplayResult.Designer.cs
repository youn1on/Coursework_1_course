using System.Drawing;
using System.Windows.Forms;

namespace Labyrinths_AStar_Dijkstra.View
{
    partial class DisplayResult
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
            this.dijkstraRadioButton = new System.Windows.Forms.RadioButton();
            this.manhattanRadioButton = new System.Windows.Forms.RadioButton();
            this.euclideanRadioButton = new System.Windows.Forms.RadioButton();
            this.check = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.coordinatesStartX = new System.Windows.Forms.TextBox();
            this.startpointLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.coordinatesStartY = new System.Windows.Forms.TextBox();
            this.coordinatesEndY = new System.Windows.Forms.TextBox();
            this.yEndLabel = new System.Windows.Forms.Label();
            this.xEndLabel = new System.Windows.Forms.Label();
            this.endpointLabel = new System.Windows.Forms.Label();
            this.coordinatesEndX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dijkstraRadioButton
            // 
            this.dijkstraRadioButton.Location = new System.Drawing.Point(57, 180);
            this.dijkstraRadioButton.Name = "dijkstraRadioButton";
            this.dijkstraRadioButton.Size = new System.Drawing.Size(140, 25);
            this.dijkstraRadioButton.TabIndex = 0;
            this.dijkstraRadioButton.TabStop = true;
            this.dijkstraRadioButton.Text = "Dijkstra";
            this.dijkstraRadioButton.UseVisualStyleBackColor = true;
            // 
            // manhattanRadioButton
            // 
            this.manhattanRadioButton.Location = new System.Drawing.Point(198, 180);
            this.manhattanRadioButton.Name = "manhattanRadioButton";
            this.manhattanRadioButton.Size = new System.Drawing.Size(140, 25);
            this.manhattanRadioButton.TabIndex = 1;
            this.manhattanRadioButton.TabStop = true;
            this.manhattanRadioButton.Text = "A* Manhattan";
            this.manhattanRadioButton.UseVisualStyleBackColor = true;
            // 
            // euclideanRadioButton
            // 
            this.euclideanRadioButton.Location = new System.Drawing.Point(358, 180);
            this.euclideanRadioButton.Name = "euclideanRadioButton";
            this.euclideanRadioButton.Size = new System.Drawing.Size(140, 25);
            this.euclideanRadioButton.TabIndex = 2;
            this.euclideanRadioButton.TabStop = true;
            this.euclideanRadioButton.Text = "A* Euclidean";
            this.euclideanRadioButton.UseVisualStyleBackColor = true;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(48, 120);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(191, 47);
            this.check.TabIndex = 3;
            this.check.Text = "Check";
            this.check.Click += new(this.Check);
            this.check.UseVisualStyleBackColor = true;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(307, 120);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(194, 45);
            this.confirm.TabIndex = 4;
            this.confirm.Text = "Confirm✓";
            this.confirm.Click += new(this.Confirm);
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.title.Location = new System.Drawing.Point(250, 12);
            this.title.Name = "title";
            this.title.TextAlign = ContentAlignment.MiddleCenter;
            this.title.Size = new System.Drawing.Size(320, 22);
            this.title.TabIndex = 5;
            this.title.Text = "Enter coordinates of startpoint and endpoint";
            // 
            // coordinatesStartX
            // 
            this.coordinatesStartX.Location = new System.Drawing.Point(237, 66);
            this.coordinatesStartX.Name = "coordinatesStartX";
            this.coordinatesStartX.Size = new System.Drawing.Size(30, 22);
            this.coordinatesStartX.TabIndex = 6;
            // 
            // label1
            // 
            this.startpointLabel.Location = new System.Drawing.Point(115, 66);
            this.startpointLabel.Name = "startpointLabel";
            this.startpointLabel.Size = new System.Drawing.Size(80, 35);
            this.startpointLabel.TabIndex = 8;
            this.startpointLabel.Text = "Startpoint";
            // 
            // label3
            // 
            this.xLabel.Location = new System.Drawing.Point(215, 66);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(15, 17);
            this.xLabel.TabIndex = 10;
            this.xLabel.Text = "x";
            // 
            // yLabel
            // 
            this.yLabel.Location = new System.Drawing.Point(276, 66);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(15, 17);
            this.yLabel.TabIndex = 11;
            this.yLabel.Text = "y";
            // 
            // coordinatesStartY
            // 
            this.coordinatesStartY.Location = new System.Drawing.Point(300, 66);
            this.coordinatesStartY.Name = "coordinatesStartY";
            this.coordinatesStartY.Size = new System.Drawing.Size(30, 22);
            this.coordinatesStartY.TabIndex = 12;
            // 
            // coordinatesEndY
            // 
            this.coordinatesEndY.Location = new System.Drawing.Point(455, 69);
            this.coordinatesEndY.Name = "coordinatesEndY";
            this.coordinatesEndY.Size = new System.Drawing.Size(30, 22);
            this.coordinatesEndY.TabIndex = 17;
            // 
            // yEndLabel
            // 
            this.yEndLabel.Location = new System.Drawing.Point(434, 69);
            this.yEndLabel.Name = "yEndLabel";
            this.yEndLabel.Size = new System.Drawing.Size(15, 17);
            this.yEndLabel.TabIndex = 16;
            this.yEndLabel.Text = "y";
            // 
            // xEndLabel
            // 
            this.xEndLabel.Location = new System.Drawing.Point(373, 69);
            this.xEndLabel.Name = "xEndLabel";
            this.xEndLabel.Size = new System.Drawing.Size(15, 17);
            this.xEndLabel.TabIndex = 15;
            this.xEndLabel.Text = "x";
            // 
            // endpointLabel
            // 
            this.endpointLabel.Location = new System.Drawing.Point(306, 69);
            this.endpointLabel.Name = "endpointLabel";
            this.endpointLabel.Size = new System.Drawing.Size(82, 35);
            this.endpointLabel.TabIndex = 14;
            this.endpointLabel.Text = "Endpoint";
            // 
            // textBox6
            // 
            this.coordinatesEndX.Location = new System.Drawing.Point(394, 69);
            this.coordinatesEndX.Name = "coordinatesEndX";
            this.coordinatesEndX.Size = new System.Drawing.Size(30, 22);
            this.coordinatesEndX.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Clear();
            this.Controls.Add(this.coordinatesEndY);
            this.Controls.Add(this.yEndLabel);
            this.Controls.Add(this.xEndLabel);
            this.Controls.Add(this.endpointLabel);
            this.Controls.Add(this.coordinatesEndX);
            this.Controls.Add(this.coordinatesStartY);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.startpointLabel);
            this.Controls.Add(this.coordinatesStartX);
            this.Controls.Add(this.title);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.check);
            this.Controls.Add(this.euclideanRadioButton);
            this.Controls.Add(this.manhattanRadioButton);
            this.Controls.Add(this.dijkstraRadioButton);
            this.labyrinthVisualiser = new LabyrinthVisualiser(Program.labyrinth, this);
            this.Name = "DisplayResultForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private LabyrinthVisualiser labyrinthVisualiser;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox coordinatesStartY;
        private System.Windows.Forms.TextBox coordinatesEndY;
        private System.Windows.Forms.Label yEndLabel;
        private System.Windows.Forms.Label xEndLabel;
        private System.Windows.Forms.Label endpointLabel;
        private System.Windows.Forms.TextBox coordinatesEndX;
        private System.Windows.Forms.Label startpointLabel;
        private System.Windows.Forms.TextBox coordinatesStartX;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.RadioButton euclideanRadioButton;
        private System.Windows.Forms.RadioButton dijkstraRadioButton;
        private System.Windows.Forms.RadioButton manhattanRadioButton;

        #endregion
    }
}