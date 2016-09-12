// Decompiled with JetBrains decompiler
// Type: Kundenregister.Sicherung
// Assembly: Kundenregister, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F85C44D-B1DE-462A-9C61-F7C69C3B3084
// Assembly location: C:\Users\admin\Desktop\C#\Kundenregister\Kundenregister\Kundenregister\bin\Debug\Kundenregister.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Kundenregister
{
  public class Sicherung : Form
  {
    public int merk = 0;
    private IContainer components = (IContainer) null;
    private Form1 _frm1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Button button1;
    private Button button2;

    public Form1 frm1
    {
      set
      {
        this._frm1 = value;
      }
    }

    public Sicherung()
    {
      this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.merk = 1;
      this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_MouseEnter(object sender, EventArgs e)
    {
      this.button1.BackColor = Color.Red;
      this.button1.ForeColor = Color.Black;
    }

    private void button1_MouseLeave(object sender, EventArgs e)
    {
      this.button1.BackColor = Color.White;
      this.button1.ForeColor = Color.Black;
    }

    private void button2_MouseEnter(object sender, EventArgs e)
    {
      this.button2.BackColor = Color.Green;
      this.button2.ForeColor = Color.Black;
    }

    private void button2_MouseLeave(object sender, EventArgs e)
    {
      this.button2.BackColor = Color.White;
      this.button2.ForeColor = Color.Black;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.button1 = new Button();
      this.button2 = new Button();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.BackColor = SystemColors.ActiveCaptionText;
      this.label1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = SystemColors.Control;
      this.label1.Location = new Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new Size(165, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "Sind Sie Sicher,";
      this.label2.AutoSize = true;
      this.label2.BackColor = SystemColors.ActiveCaptionText;
      this.label2.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = SystemColors.Control;
      this.label2.Location = new Point(13, 89);
      this.label2.Name = "label2";
      this.label2.Size = new Size(226, 25);
      this.label2.TabIndex = 1;
      this.label2.Text = "Zurücksetzen Wollen?";
      this.label3.AutoSize = true;
      this.label3.BackColor = SystemColors.ActiveCaptionText;
      this.label3.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = SystemColors.Control;
      this.label3.Location = new Point(13, 51);
      this.label3.Name = "label3";
      this.label3.Size = new Size(178, 25);
      this.label3.TabIndex = 2;
      this.label3.Text = "Das sie Die Datei";
      this.button1.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1.Location = new Point(18, 117);
      this.button1.Name = "button1";
      this.button1.Size = new Size(106, 59);
      this.button1.TabIndex = 3;
      this.button1.Text = "Ja";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button1.MouseEnter += new EventHandler(this.button1_MouseEnter);
      this.button1.MouseLeave += new EventHandler(this.button1_MouseLeave);
      this.button2.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button2.Location = new Point(133, 117);
      this.button2.Name = "button2";
      this.button2.Size = new Size(106, 59);
      this.button2.TabIndex = 4;
      this.button2.Text = "Nein";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button2.MouseEnter += new EventHandler(this.button2_MouseEnter);
      this.button2.MouseLeave += new EventHandler(this.button2_MouseLeave);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = SystemColors.ActiveCaptionText;
      this.ClientSize = new Size(251, 185);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.MaximizeBox = false;
      this.MaximumSize = new Size(267, 224);
      this.MinimizeBox = false;
      this.MinimumSize = new Size(267, 224);
      this.Name = "Sicherung";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Sicherung";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
