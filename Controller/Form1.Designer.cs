using Labyrinths_AStar_Dijkstra.View;

namespace Labyrinths_AStar_Dijkstra.Controller
{
  partial class Form1
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
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(171, 50);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(480, 65);
      this.label1.TabIndex = 0;
      this.label1.Text = "Please, select your labyrinth source file:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox1
      // 
      this.textBox1.Font = Style.TextFieldFont;
      this.textBox1.Location = new System.Drawing.Point(170, 250);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(315, 50);
      this.textBox1.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label2.Location = new System.Drawing.Point(170, 210);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(480, 32);
      this.label2.TabIndex = 2;
      this.label2.Text = "Enter full filepath, select manually or randomize";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // button1
      // 
      this.button1.Font = Style.ButtonFont;
      this.button1.BackColor = Style.ConfirmButtonColor;
      this.button1.Location = new System.Drawing.Point(419, 300);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(233, 55);
      this.button1.TabIndex = 3;
      this.button1.Text = "Confirm ✓";
      //this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Confirm);
      this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // button2
      // 
      this.button2.Font = Style.ButtonFont;
      this.button2.Location = new System.Drawing.Point(500, 250);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(152, 38);
      this.button2.TabIndex = 4;
      this.button2.Text = "Select manually";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.Select);
      this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // button3
      // 
      this.button3.Font = Style.ButtonFont;
      this.button3.Location = new System.Drawing.Point(170, 300);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(233, 55);
      this.button3.TabIndex = 5;
      this.button3.Text = "Randomize";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.Randomize);
      this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = new System.Drawing.Size(825, 450);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Goudy Old Style", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "Form1";
      this.Text = "Labyrinths";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Label label1;

    #endregion
  }
}

