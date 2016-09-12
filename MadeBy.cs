// Decompiled with JetBrains decompiler
// Type: Kundenregister.MadeBy
// Assembly: Kundenregister, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F85C44D-B1DE-462A-9C61-F7C69C3B3084
// Assembly location: C:\Users\admin\Desktop\C#\Kundenregister\Kundenregister\Kundenregister\bin\Debug\Kundenregister.exe

using Kundenregister.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Kundenregister
{
  public class MadeBy : Form
  {
    private IContainer components = (IContainer) null;
    private Button Close;
    private Label madebytxt;
    private Label label1;
    private Label label2;
    private Label label3;
    private PictureBox pictureBox1;

    public MadeBy()
    {
      this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Close_MouseEnter(object sender, EventArgs e)
    {
      this.label1.Text = "Und wer duerfte wiedermal die Fehler suchen?";
      this.label2.Text = "RICHTIG!Ich * seufz * ~Shira";
      this.label3.Text = "In dem Fenster ging es weiter q.q";
    }

    private void Close_MouseLeave(object sender, EventArgs e)
    {
      this.label1.Text = "";
      this.label2.Text = "";
      this.label3.Text = "";
    }

    private void pictureBox1_DragEnter(object sender, DragEventArgs e)
    {
      this.label1.Text = "THIS";
      this.label2.Text = "IS";
      this.label3.Text = "SPARTA!!!!";
    }

    private void pictureBox1_DragLeave(object sender, EventArgs e)
    {
      this.label1.Text = "";
      this.label2.Text = "";
      this.label3.Text = "";
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.Close = new Button();
      this.madebytxt = new Label();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.pictureBox1 = new PictureBox();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.Close.Location = new Point(102, 128);
      this.Close.Name = "Close";
      this.Close.Size = new Size(140, 57);
      this.Close.TabIndex = 0;
      this.Close.Text = "Close";
      this.Close.UseVisualStyleBackColor = true;
      this.Close.Click += new EventHandler(this.button1_Click);
      this.Close.MouseEnter += new EventHandler(this.Close_MouseEnter);
      this.Close.MouseLeave += new EventHandler(this.Close_MouseLeave);
      this.madebytxt.AutoSize = true;
      this.madebytxt.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.madebytxt.ForeColor = SystemColors.ButtonFace;
      this.madebytxt.Location = new Point(12, 9);
      this.madebytxt.Name = "madebytxt";
      this.madebytxt.Size = new Size(154, 20);
      this.madebytxt.TabIndex = 1;
      this.madebytxt.Text = "Made by Calandra ;) ";
      this.label1.AutoSize = true;
      this.label1.ForeColor = SystemColors.ButtonFace;
      this.label1.Location = new Point(13, 40);
      this.label1.Name = "label1";
      this.label1.Size = new Size(0, 13);
      this.label1.TabIndex = 2;
      this.label2.AutoSize = true;
      this.label2.ForeColor = SystemColors.ButtonFace;
      this.label2.Location = new Point(13, 65);
      this.label2.Name = "label2";
      this.label2.Size = new Size(0, 13);
      this.label2.TabIndex = 3;
      this.label3.AutoSize = true;
      this.label3.ForeColor = SystemColors.ButtonFace;
      this.label3.Location = new Point(16, 91);
      this.label3.Name = "label3";
      this.label3.Size = new Size(0, 13);
      this.label3.TabIndex = 4;
      this.pictureBox1.Image = (Image) Resources.logo;
      this.pictureBox1.Location = new Point(290, 9);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(73, 69);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.DragEnter += new DragEventHandler(this.pictureBox1_DragEnter);
      this.pictureBox1.DragLeave += new EventHandler(this.pictureBox1_DragLeave);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveCaptionText;
      this.ClientSize = new Size(375, 199);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.madebytxt);
      this.Controls.Add((Control) this.Close);
      this.MaximizeBox = false;
      this.MaximumSize = new Size(391, 238);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(391, 238);
      this.Name = "MadeBy";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Made By";
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
