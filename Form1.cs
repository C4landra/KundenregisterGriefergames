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
        public int meowmerk = 0;
        public int meowmerk2 = 10;

        public int yolo = 0;
        public string[] meow = new string[10000];
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
        private Button button2;
        private Button button3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameeingeben
            // 
            this.nameeingeben.Location = new System.Drawing.Point(12, 36);
            this.nameeingeben.Name = "nameeingeben";
            this.nameeingeben.Size = new System.Drawing.Size(121, 23);
            this.nameeingeben.TabIndex = 0;
            this.nameeingeben.Text = "Handel eingeben:";
            this.nameeingeben.UseVisualStyleBackColor = true;
            this.nameeingeben.Click += new System.EventHandler(this.nameeingeben_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 68);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
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
            this.makieren.Location = new System.Drawing.Point(154, 39);
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
            this.test1.Location = new System.Drawing.Point(11, 361);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(0, 24);
            this.test1.TabIndex = 3;
            // 
            // anderes
            // 
            this.anderes.Location = new System.Drawing.Point(280, 78);
            this.anderes.Name = "anderes";
            this.anderes.Size = new System.Drawing.Size(235, 20);
            this.anderes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(280, 62);
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
            this.abgabe.Location = new System.Drawing.Point(515, 12);
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
            this.Madeby.Location = new System.Drawing.Point(582, 365);
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
            this.pictureBox2.Location = new System.Drawing.Point(-23, 331);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(716, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // zuruck
            // 
            this.zuruck.Location = new System.Drawing.Point(439, 164);
            this.zuruck.Name = "zuruck";
            this.zuruck.Size = new System.Drawing.Size(92, 23);
            this.zuruck.TabIndex = 19;
            this.zuruck.Text = "Zurücksetzen 1";
            this.zuruck.UseVisualStyleBackColor = true;
            this.zuruck.Click += new System.EventHandler(this.zuruck_Click);
            // 
            // sucheein
            // 
            this.sucheein.Location = new System.Drawing.Point(15, 226);
            this.sucheein.Name = "sucheein";
            this.sucheein.Size = new System.Drawing.Size(198, 20);
            this.sucheein.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Was Möchten Sie Suchen?";
            // 
            // suche
            // 
            this.suche.Location = new System.Drawing.Point(219, 201);
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
            this.label5.Location = new System.Drawing.Point(9, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Suche nur mit Einzelnen Buchstaben möglich!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Zurücksetzen 2";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Prev.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tipp: Bitte schreibt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Die Namensanfänge groß";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(272, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tipp: Groß- und Kleinschreibung beachten beim Suchen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Zum zurücksetzen erst 1 dann 2 drücken!";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(439, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Dies Löscht eure Datenbank";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 388);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kundenregister";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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

            int lastmerk = 0;
            for(int i=0;i<suchausg.Length;i++) //Calandra: ;     i=11
            {
                
                if (suchausg[i] == ';') //suchausgabe 11 = ;
                {
                    
                    for(int x=lastmerk;x<i;x++)   //x=0; solange x< 11;x++
                    {
                        meow[meowmerk] = meow[meowmerk] + suchausg[x]; //meow[0]
                        lastmerk = x;
                    }
                    meowmerk++;
                }
            }
            sucheaus.Text = "0: "+meow[0];
            //sucheaus.Text = meow[0];
            test1.Text = "gefunden:" + Convert.ToString(meowmerk);            

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

        private void button2_Click(object sender, EventArgs e)
        {
            yolo = yolo - 1;
            //prev
            if (yolo<meowmerk&&yolo>=0)
            {
                sucheaus.Text = "";                
                sucheaus.Text = yolo+": "+meow[yolo];
                test1.Text = "gefunden:" + Convert.ToString(meowmerk);
                

            }
            else
            {
                
                test1.Text = "ERROR minimale anzahl erreicht";
                yolo = 0;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yolo++;
            //next
            if (yolo < meowmerk && yolo >= 0)
            {
                sucheaus.Text = "";
                sucheaus.Text = yolo + ": "+meow[yolo];                
                test1.Text = "gefunden:"+Convert.ToString(meowmerk);


            }
            else
            {
                test1.Text = "ERROR maximale anzahl erreicht";
                yolo = meowmerk;
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
    
}
