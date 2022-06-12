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
            this.goBackButton = new System.Windows.Forms.Button();
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
            this.quickSearch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dijkstraRadioButton
            // 
            this.dijkstraRadioButton.Location = new System.Drawing.Point(65, 150);
            this.dijkstraRadioButton.Name = "dijkstraRadioButton";
            this.dijkstraRadioButton.Size = new System.Drawing.Size(140, 25);
            this.dijkstraRadioButton.TabIndex = 0;
            this.dijkstraRadioButton.TabStop = true;
            this.dijkstraRadioButton.Text = "Dijkstra";
            this.dijkstraRadioButton.UseVisualStyleBackColor = true;
            this.dijkstraRadioButton.Font = Style.SmallFont;
            this.dijkstraRadioButton.BackColor = Style.OnClickableColor;
            // 
            // manhattanRadioButton
            // 
            this.manhattanRadioButton.Location = new System.Drawing.Point(250, 150);
            this.manhattanRadioButton.Name = "manhattanRadioButton";
            this.manhattanRadioButton.Size = new System.Drawing.Size(195, 25);
            this.manhattanRadioButton.TabIndex = 1;
            this.manhattanRadioButton.TabStop = true;
            this.manhattanRadioButton.Text = "A* Manhattan";
            this.manhattanRadioButton.UseVisualStyleBackColor = true;
            this.manhattanRadioButton.Font = Style.SmallFont;
            this.manhattanRadioButton.BackColor = Style.OnClickableColor;
            // 
            // euclideanRadioButton
            // 
            this.euclideanRadioButton.Location = new System.Drawing.Point(495, 150);
            this.euclideanRadioButton.Name = "euclideanRadioButton";
            this.euclideanRadioButton.Size = new System.Drawing.Size(200, 25);
            this.euclideanRadioButton.TabIndex = 2;
            this.euclideanRadioButton.TabStop = true;
            this.euclideanRadioButton.Text = "A* Euclidean";
            this.euclideanRadioButton.UseVisualStyleBackColor = true;
            this.euclideanRadioButton.Font = Style.SmallFont;
            this.euclideanRadioButton.BackColor = Style.OnClickableColor;
            // 
            // check
            // 
            this.check.Location = Style.CheckVisualiserPoint;
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(191, 47);
            this.check.TabIndex = 3;
            this.check.Text = "Check";
            this.check.Click += new(this.Check);
            this.check.UseVisualStyleBackColor = true;
            this.check.Font = Style.ButtonFont;
            this.check.BackColor = Style.OnClickableColor;
            // 
            // quickSearch
            // 
            this.quickSearch.Font = Style.ButtonFont;
            this.quickSearch.Location = new System.Drawing.Point(198, 190);
            this.quickSearch.Name = "quickSearch";
            this.quickSearch.Size = new System.Drawing.Size(377, 38);
            this.quickSearch.TabIndex = 18;
            this.quickSearch.Text = "Quick search";
            this.quickSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quickSearch.UseVisualStyleBackColor = true;
            this.quickSearch.BackColor = Style.OnClickableColor;
            // 
            // confirm
            // 
            this.confirm.Location = Style.ConfirmVisualiserPoint;
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(194, 45);
            this.confirm.TabIndex = 4;
            this.confirm.Text = "Confirm✓";
            this.confirm.BackColor = Style.ConfirmButtonColor;
            this.confirm.Click += new(this.Confirm);
            this.confirm.Font = Style.ButtonFont;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(130, 12);
            this.title.Name = "title";
            this.title.TextAlign = ContentAlignment.MiddleCenter;
            this.title.Size = new System.Drawing.Size(500, 22);
            this.title.TabIndex = 5;
            this.title.Text = "Enter coordinates of startpoint and endpoint";
            this.title.TextAlign = ContentAlignment.MiddleCenter;
            this.title.Font = Style.SmallFont;
            // 
            // coordinatesStartX
            // 
            this.coordinatesStartX.Location = new System.Drawing.Point(215, 53);
            this.coordinatesStartX.Name = "coordinatesStartX";
            this.coordinatesStartX.Size = new System.Drawing.Size(50, 22);
            this.coordinatesStartX.TabIndex = 6;
            this.coordinatesStartX.Font = Style.TextFieldFont;
            
            // 
            // startpointLabel
            // 
            this.startpointLabel.Location = new System.Drawing.Point(80, 50);
            this.startpointLabel.Name = "startpointLabel";
            this.startpointLabel.Size = new System.Drawing.Size(110, 35);
            this.startpointLabel.TabIndex = 8;
            this.startpointLabel.Text = "Startpoint";
            this.startpointLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.startpointLabel.Font = Style.SmallFont;
            // 
            // xLabel
            // 
            this.xLabel.Location = new System.Drawing.Point(200, 54);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(15, 26);
            this.xLabel.TabIndex = 10;
            this.xLabel.Text = "x";
            this.xLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.xLabel.Font = Style.TextFieldFont;
            // 
            // yLabel
            // 
            this.yLabel.Location = new System.Drawing.Point(265, 54);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(15, 26);
            this.yLabel.TabIndex = 11;
            this.yLabel.Text = "y";
            this.yLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.yLabel.Font = Style.TextFieldFont;
            // 
            // coordinatesStartY
            // 
            this.coordinatesStartY.Location = new System.Drawing.Point(280, 53);
            this.coordinatesStartY.Name = "coordinatesStartY";
            this.coordinatesStartY.Size = new System.Drawing.Size(50, 22);
            this.coordinatesStartY.TabIndex = 12;
            this.coordinatesStartY.Font = Style.TextFieldFont;
            // 
            // coordinatesEndY
            // 
            this.coordinatesEndY.Location = new System.Drawing.Point(590, 53);
            this.coordinatesEndY.Name = "coordinatesEndY";
            this.coordinatesEndY.Size = new System.Drawing.Size(50, 22);
            this.coordinatesEndY.TabIndex = 17;
            this.coordinatesEndY.Font = Style.TextFieldFont;
            // 
            // yEndLabel
            // 
            this.yEndLabel.Location = new System.Drawing.Point(575, 54);
            this.yEndLabel.Name = "yEndLabel";
            this.yEndLabel.Size = new System.Drawing.Size(15, 26);
            this.yEndLabel.TabIndex = 16;
            this.yEndLabel.Text = "y";
            this.yEndLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.yEndLabel.Font = Style.TextFieldFont;

            // 
            // xEndLabel
            // 
            this.xEndLabel.Location = new System.Drawing.Point(510, 54);
            this.xEndLabel.Name = "xEndLabel";
            this.xEndLabel.Size = new System.Drawing.Size(15, 26);
            this.xEndLabel.TabIndex = 15;
            this.xEndLabel.Text = "x";
            this.xEndLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.xEndLabel.Font = Style.TextFieldFont;
            // 
            // endpointLabel
            // 
            this.endpointLabel.Location = new System.Drawing.Point(400, 50);
            this.endpointLabel.Name = "endpointLabel";
            this.endpointLabel.Size = new System.Drawing.Size(100, 35);
            this.endpointLabel.TabIndex = 14;
            this.endpointLabel.Text = "Endpoint";
            this.endpointLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.endpointLabel.Font = Style.SmallFont;
            // 
            // coordinatesEndX
            // 
            this.coordinatesEndX.Location = new System.Drawing.Point(525, 53);
            this.coordinatesEndX.Name = "coordinatesEndX";
            this.coordinatesEndX.Size = new System.Drawing.Size(50, 22);
            this.coordinatesEndX.TabIndex = 13;
            this.coordinatesEndX.Font = Style.TextFieldFont;
            // 
            // goBackButton
            // 
            this.goBackButton.Font = Style.ButtonFont;
            this.goBackButton.Location = Style.BackButtonLocation;
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = Style.BackButtonSize;
            this.goBackButton.TabIndex = 18;
            this.goBackButton.Text = "<";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.GoBack);
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.BackColor = Style.OnClickableColor;
            // 
            // DisplayResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = Style.FullFormSize;
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
            this.Controls.Add(this.quickSearch);
            this.Controls.Add(this.goBackButton);
            this.labyrinthVisualiser = new LabyrinthVisualiser(this);
            this.Name = "DisplayResultForm";
            this.Text = "Labyrinths";
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
        private System.Windows.Forms.CheckBox quickSearch;
        private System.Windows.Forms.RadioButton euclideanRadioButton;
        private System.Windows.Forms.RadioButton dijkstraRadioButton;
        private System.Windows.Forms.RadioButton manhattanRadioButton;
        private System.Windows.Forms.Button goBackButton;

        #endregion
    }
}