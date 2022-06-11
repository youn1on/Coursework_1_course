using System.Drawing;
using System.Windows.Forms;
using Labyrinths_AStar_Dijkstra.View;

namespace Labyrinths_AStar_Dijkstra.Controller
{
  partial class InitialForm
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
      this.titleLabel = new System.Windows.Forms.Label();
      this.pathToFile = new System.Windows.Forms.TextBox();
      this.filepathLabel = new System.Windows.Forms.Label();
      this.confirmButton = new System.Windows.Forms.Button();
      this.selectButton = new System.Windows.Forms.Button();
      this.randomizerButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // titleLabel
      // 
      this.titleLabel.Font = Style.ButtonFont;
      this.titleLabel.Location = new System.Drawing.Point(171, 50);
      this.titleLabel.Name = "titleLabel";
      this.titleLabel.Size = new System.Drawing.Size(480, 65);
      this.titleLabel.TabIndex = 0;
      this.titleLabel.Text = "Please, select your labyrinth source file:";
      this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pathToFile
      // 
      this.pathToFile.Font = Style.TextFieldFont;
      this.pathToFile.Location = new System.Drawing.Point(170, 250);
      this.pathToFile.Name = "pathToFile";
      this.pathToFile.Size = new System.Drawing.Size(315, 50);
      this.pathToFile.TabIndex = 1;
      // 
      // filepathLabel
      // 
      this.filepathLabel.Font = Style.SmallFont;
      this.filepathLabel.Location = new System.Drawing.Point(170, 210);
      this.filepathLabel.Name = "filepathLabel";
      this.filepathLabel.Size = new System.Drawing.Size(480, 32);
      this.filepathLabel.TabIndex = 2;
      this.filepathLabel.Text = "Enter full filepath, select manually or randomize";
      this.filepathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // confirmButton
      // 
      this.confirmButton.Font = Style.ButtonFont;
      this.confirmButton.BackColor = Style.ConfirmButtonColor;
      this.confirmButton.Location = new System.Drawing.Point(419, 300);
      this.confirmButton.Name = "confirmButton";
      this.confirmButton.Size = new System.Drawing.Size(233, 55);
      this.confirmButton.TabIndex = 3;
      this.confirmButton.Text = "Confirm✓";
      this.confirmButton.Click += new System.EventHandler(this.Confirm);
      this.confirmButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // selectButton
      // 
      this.selectButton.Font = Style.ButtonFont;
      this.selectButton.Location = new System.Drawing.Point(500, 250);
      this.selectButton.Name = "selectButton";
      this.selectButton.Size = new System.Drawing.Size(152, 38);
      this.selectButton.TabIndex = 4;
      this.selectButton.Text = "Select manually";
      this.selectButton.Click += new System.EventHandler(this.Select);
      this.selectButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // randomizerButton
      // 
      this.randomizerButton.Font = Style.ButtonFont;
      this.randomizerButton.Location = new System.Drawing.Point(170, 300);
      this.randomizerButton.Name = "randomizerButton";
      this.randomizerButton.Size = new System.Drawing.Size(233, 55);
      this.randomizerButton.TabIndex = 5;
      this.randomizerButton.Text = "Randomize";
      this.randomizerButton.Click += new System.EventHandler(this.Randomize);
      this.randomizerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // InitialForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = Style.SmallFormSize;
      this.Controls.Add(this.randomizerButton);
      this.Controls.Add(this.selectButton);
      this.Controls.Add(this.confirmButton);
      this.Controls.Add(this.filepathLabel);
      this.Controls.Add(this.pathToFile);
      this.Controls.Add(this.titleLabel);
      this.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "InitialForm";
      this.Text = "Labyrinths";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.Button confirmButton;
    private System.Windows.Forms.Button selectButton;
    private System.Windows.Forms.Button randomizerButton;
    private System.Windows.Forms.Label filepathLabel;
    private System.Windows.Forms.TextBox pathToFile;
    private System.Windows.Forms.Label titleLabel;

    #endregion
  }
}

