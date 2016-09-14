// Decompiled with JetBrains decompiler
// Type: Kundenregister.Form1
// Assembly: Kundenregister, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F85C44D-B1DE-462A-9C61-F7C69C3B3084
// Assembly location: C:\Users\admin\Desktop\C#\Kundenregister\Kundenregister\Kundenregister\bin\Debug\Kundenregister.exe

using Kundenregister.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Kundenregister
{
  public class Form1 : Form
  {
    public string[] speichernamen = new string[10000];
    public int speichernamenmerk = 1;
    public int gedrueckt = 0;
    private IContainer components = (IContainer) null;
    public string checkmerk;
    public int merkdir=0;
    public string suchausg;
        public int bestatige = 0;


        public string[] meow;
        private Button nameeingeben;
    private TextBox name;
    private CheckedListBox makieren;
    private Label test1;
    private ColorDialog colorDialog1;
    private TextBox anderes;
    private BindingSource bindingSource1;
    private Label label1;
    private PictureBox pictureBox1;
    private Label label2;
    private Button abgabe;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private Button Madeby;
    private Label nutzerzahl;
    private PictureBox pictureBox5;
        private TextBox sucheein;
        private Label label3;
        private Button suche;
        private Label label4;
        private Label sucheaus;
        private Label label5;
        private Button button1;
        private Label label6;
        private Button zuruck;

    public Form1()
    {
      this.InitializeComponent();
      string[] strArray = File.ReadAllLines(".\\handelsregister.txt");
      for (int index = 0; index < strArray.Length; ++index)
        this.speichernamen[index] = strArray[index];
      this.speichernamenmerk = Convert.ToInt32(this.speichernamen[0]);
      this.checkmerk = Convert.ToString(this.speichernamenmerk);
            int checkmerk2;
            string checkmerk3;
            checkmerk2 = Convert.ToInt32(this.checkmerk) - 1;
            checkmerk3 = Convert.ToString(checkmerk2);
      this.nutzerzahl.Text = ("Momentan Eingetragene Accounts: " +checkmerk3) ;
    }

    private void nameeingeben_Click(object sender, EventArgs e)
    {
      if (this.gedrueckt == 0)
      {
        this.checkmerk = this.name.Text + ": ";
        for (int index = 0; index < this.makieren.CheckedIndices.Count; ++index)
        {
          if (this.makieren.CheckedIndices[index] == 1)
            this.checkmerk = this.checkmerk + "Freundlich, ";
          else if (this.makieren.CheckedIndices[index] == 2)
            this.checkmerk = this.checkmerk + "Scamt, ";
          else if (this.makieren.CheckedIndices[index] == 0)
            this.checkmerk = this.checkmerk + "Sicherer Handel, ";
          else if (this.makieren.CheckedIndices[index] == 3)
            this.checkmerk = this.checkmerk + "Beleidigung, ";
          else if (this.makieren.CheckedIndices[index] == 4)
          {
            this.checkmerk = this.checkmerk + this.anderes.Text + ", ";
            this.anderes.Text = "";
          }
        }
        this.test1.Text = this.checkmerk;
        this.speichernamen[this.speichernamenmerk] = this.checkmerk+";";
        this.test1.Text = this.speichernamen[this.speichernamenmerk];
        this.speichernamenmerk = this.speichernamenmerk + 1;
        this.name.Text = "";
      }
      else
      {
        this.test1.Text = "Error, sie haben bereits abgegeben!";
        this.anderes.Text = "Error";
        this.name.Text = "Error";
      }
    }

    private void abgabe_Click(object sender, EventArgs e)
    {
      this.speichernamen[0] = Convert.ToString(this.speichernamenmerk);
      this.gedrueckt = 1;
      File.WriteAllLines(".\\handelsregister.txt", this.speichernamen);
      this.nameeingeben.BackColor = Color.Red;
    }

    private void novirgin_Click(object sender, EventArgs e)
    {
      Thread.Sleep(2000);
    }

    private void abgabe_MouseEnter(object sender, EventArgs e)
    {
      this.abgabe.BackColor = Color.MediumVioletRed;
    }

    private void abgabe_MouseLeave(object sender, EventArgs e)
    {
      this.abgabe.BackColor = Color.LightGray;
    }

    private void makieren_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void Madeby_Click(object sender, EventArgs e)
    {
      new MadeBy().Show((IWin32Window) this);
    }

    private void Madeby_MouseEnter(object sender, EventArgs e)
    {
      this.Madeby.BackColor = Color.LightGreen;
      this.Madeby.ForeColor = Color.Black;
    }

    private void Madeby_MouseLeave(object sender, EventArgs e)
    {
      this.Madeby.BackColor = Color.Black;
      this.Madeby.ForeColor = Color.White;
    }

    private void zuruck_Click(object sender, EventArgs e)
    {
            /*this.merkdir = 0;
            Sicherung sicherung = new Sicherung();
            sicherung.frm1 = this;
            int num = (int) sicherung.ShowDialog();
            this.merkdir = sicherung.merk;
            if (this.merkdir != 0)
                  {
                      return;
                  }
              */

            bestatige = 1;
        }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.nameeingeben = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.makieren = new System.Windows.Forms.CheckedListBox();
            this.test1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.anderes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.abgabe = new System.Windows.Forms.Button();
            this.Madeby = new System.Windows.Forms.Button();
            this.nutzerzahl = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zuruck = new System.Windows.Forms.Button();
            this.sucheein = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.suche = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sucheaus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameeingeben
            // 
            this.nameeingeben.Location = new System.Drawing.Point(12, 39);
            this.nameeingeben.Name = "nameeingeben";
            this.nameeingeben.Size = new System.Drawing.Size(121, 23);
            this.nameeingeben.TabIndex = 0;
            this.nameeingeben.Text = "Handel eingeben:";
            this.nameeingeben.UseVisualStyleBackColor = true;
            this.nameeingeben.Click += new System.EventHandler(this.nameeingeben_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 77);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 1;
            // 
            // makieren
            // 
            this.makieren.FormattingEnabled = true;
            this.makieren.Items.AddRange(new object[] {
            "Sicherer Handel",
            "Freundlich",
            "Scamt",
            "Beleidigung",
            "Anderes"});
            this.makieren.Location = new System.Drawing.Point(140, 39);
            this.makieren.Name = "makieren";
            this.makieren.Size = new System.Drawing.Size(120, 79);
            this.makieren.TabIndex = 2;
            this.makieren.SelectedIndexChanged += new System.EventHandler(this.makieren_SelectedIndexChanged);
            // 
            // test1
            // 
            this.test1.AutoSize = true;
            this.test1.BackColor = System.Drawing.Color.Black;
            this.test1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test1.ForeColor = System.Drawing.Color.White;
            this.test1.Location = new System.Drawing.Point(16, 344);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(0, 24);
            this.test1.TabIndex = 3;
            // 
            // anderes
            // 
            this.anderes.Location = new System.Drawing.Point(266, 98);
            this.anderes.Name = "anderes";
            this.anderes.Size = new System.Drawing.Size(235, 20);
            this.anderes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(266, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wenn \"Anderes\", hier Grund angeben:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Eingaben:";
            // 
            // abgabe
            // 
            this.abgabe.BackColor = System.Drawing.Color.LightGray;
            this.abgabe.FlatAppearance.BorderSize = 0;
            this.abgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abgabe.Location = new System.Drawing.Point(507, 12);
            this.abgabe.Name = "abgabe";
            this.abgabe.Size = new System.Drawing.Size(121, 106);
            this.abgabe.TabIndex = 8;
            this.abgabe.Text = "Liste abgeben!";
            this.abgabe.UseVisualStyleBackColor = false;
            this.abgabe.Click += new System.EventHandler(this.abgabe_Click);
            this.abgabe.MouseEnter += new System.EventHandler(this.abgabe_MouseEnter);
            this.abgabe.MouseLeave += new System.EventHandler(this.abgabe_MouseLeave);
            // 
            // Madeby
            // 
            this.Madeby.BackColor = System.Drawing.Color.Black;
            this.Madeby.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Madeby.Location = new System.Drawing.Point(583, 361);
            this.Madeby.Name = "Madeby";
            this.Madeby.Size = new System.Drawing.Size(58, 23);
            this.Madeby.TabIndex = 15;
            this.Madeby.Text = "MadeBy";
            this.Madeby.UseVisualStyleBackColor = false;
            this.Madeby.Click += new System.EventHandler(this.Madeby_Click);
            this.Madeby.MouseEnter += new System.EventHandler(this.Madeby_MouseEnter);
            this.Madeby.MouseLeave += new System.EventHandler(this.Madeby_MouseLeave);
            // 
            // nutzerzahl
            // 
            this.nutzerzahl.AutoSize = true;
            this.nutzerzahl.BackColor = System.Drawing.Color.Black;
            this.nutzerzahl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nutzerzahl.Location = new System.Drawing.Point(13, 137);
            this.nutzerzahl.Name = "nutzerzahl";
            this.nutzerzahl.Size = new System.Drawing.Size(0, 13);
            this.nutzerzahl.TabIndex = 16;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Kundenregister.Properties.Resources.bild51;
            this.pictureBox5.Location = new System.Drawing.Point(-23, 124);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(744, 34);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kundenregister.Properties.Resources.bild2;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kundenregister.Properties.Resources.bild4;
            this.pictureBox2.Location = new System.Drawing.Point(-23, 301);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(716, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Kundenregister.Properties.Resources.bild5;
            this.pictureBox3.Location = new System.Drawing.Point(-68, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(765, 396);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // zuruck
            // 
            this.zuruck.Location = new System.Drawing.Point(269, 36);
            this.zuruck.Name = "zuruck";
            this.zuruck.Size = new System.Drawing.Size(107, 23);
            this.zuruck.TabIndex = 19;
            this.zuruck.Text = "Zurück setzen";
            this.zuruck.UseVisualStyleBackColor = true;
            this.zuruck.Click += new System.EventHandler(this.zuruck_Click);
            // 
            // sucheein
            // 
            this.sucheein.Location = new System.Drawing.Point(16, 226);
            this.sucheein.Name = "sucheein";
            this.sucheein.Size = new System.Drawing.Size(198, 20);
            this.sucheein.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Was Möchten Sie Suchen?";
            // 
            // suche
            // 
            this.suche.Location = new System.Drawing.Point(224, 203);
            this.suche.Name = "suche";
            this.suche.Size = new System.Drawing.Size(75, 43);
            this.suche.TabIndex = 22;
            this.suche.Text = "Suchen";
            this.suche.UseVisualStyleBackColor = true;
            this.suche.Click += new System.EventHandler(this.suche_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ergebnisse:";
            // 
            // sucheaus
            // 
            this.sucheaus.AutoSize = true;
            this.sucheaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucheaus.Location = new System.Drawing.Point(12, 287);
            this.sucheaus.Name = "sucheaus";
            this.sucheaus.Size = new System.Drawing.Size(0, 20);
            this.sucheaus.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Suche nur mit Einzelnen Buchstaben möglich!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Zurück setzen Sicher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ausgabe:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 383);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sucheaus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.suche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sucheein);
            this.Controls.Add(this.zuruck);
            this.Controls.Add(this.nutzerzahl);
            this.Controls.Add(this.Madeby);
            this.Controls.Add(this.abgabe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anderes);
            this.Controls.Add(this.test1);
            this.Controls.Add(this.makieren);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameeingeben);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kundenregister";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }
        
        private void suche_Click(object sender, EventArgs e)
        {
            
            string einsuch = sucheein.Text;
            int einsuch2 =0 ;
            int verg = 0;
            suchausg = "";
            int einsuch3 = 0;
            for(int i=1;i<speichernamenmerk;i++) //speichernamenmerk = 4
            {
                einsuch2 = i;
                for (int j=0;j<speichernamen[i].Length;j++) //speichernamenmerk[i].length = Calandra = 8     //j=1
                {
                    
                    for (int k=0;k<einsuch.Length;k++) //einsuch.length = eingegebens wort. länge : Ca = 2  //k=1<2
                    {
                        
                        if (speichernamen[i][j] == einsuch[k])  //wenn speichername[1][1] = sucheingabe[0] -> Wenn C == C  //speichername[1][2] a == a
                        { 

                            verg++; //verg = 1    //verg = 2
                        }
                    }
                    if (einsuch.Length == verg) //wenn sucheingabe Länge = vergleiche (hier 2)
                    {
                        einsuch3 = 1;
                        
                    }
                    verg = 0;

                }
                if (einsuch3 == 1)
                {
                    einsuch3 = 0;
                    suchausg = suchausg + speichernamen[einsuch2];
                }


            }

            
            
            for(int i=0;i<suchausg.Length;i++)
            {
                if (suchausg[i] == ';')
                {
                    
                    for(int x=0;x<i;x++)
                    {
                        meow[i] = meow[i] + suchausg[x];
                    }
                }
            }
            if (meow.Length>10)
            {
                test1.Text = "Suche nicht anzeigbar, mehr wie 10 ergebnisse";
            }
            
            sucheaus.Text = meow[1] + "\n"+ meow[2] + "\n" + meow[3] + "\n"+meow[4] + "\n" + meow[5] + "\n"+meow[6] + "\n" + meow[7] + "\n"+meow[8] + "\n" + meow[9] + "\n"+meow[10];
            suchausg = "";
            
            //object findText = "suchbegriff";
 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bestatige==1)
            {
                this.speichernamenmerk = 1;
                for (int index = 0; index < this.speichernamenmerk; ++index)
                this.speichernamen[index] = "";
                this.speichernamen[0] = "1";
                this.speichernamen[0] = Convert.ToString(this.speichernamenmerk);
                this.gedrueckt = 1;
                File.WriteAllLines(".\\handelsregister.txt", this.speichernamen);
                this.nameeingeben.BackColor = Color.Red;

                MessageBox.Show("Programm wird nun geschlossen!");
                Close();
            }

        }
    }
    
}
