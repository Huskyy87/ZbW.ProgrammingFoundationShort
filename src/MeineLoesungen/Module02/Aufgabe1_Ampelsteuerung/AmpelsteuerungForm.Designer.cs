namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe1_Ampelsteuerung;

partial class AmpelsteuerungForm
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    GrpFarbe = new GroupBox();
    RadRot = new RadioButton();
    RadGelb = new RadioButton();
    RadGruen = new RadioButton();
    CmdAnzeigen = new Button();
    LblMeldung = new Label();
    LblAmpel = new Label();
    GrpFarbe.SuspendLayout();
    SuspendLayout();

    // GrpFarbe
    GrpFarbe.Location = new Point(12, 12);
    GrpFarbe.Name = "GrpFarbe";
    GrpFarbe.Size = new Size(200, 100);
    GrpFarbe.Text = "Ampelfarbe";
    GrpFarbe.Controls.Add(RadRot);
    GrpFarbe.Controls.Add(RadGelb);
    GrpFarbe.Controls.Add(RadGruen);

    // RadRot
    RadRot.AutoSize = true;
    RadRot.Checked = true;
    RadRot.Location = new Point(10, 20);
    RadRot.Name = "RadRot";
    RadRot.Text = "Rot";

    // RadGelb
    RadGelb.AutoSize = true;
    RadGelb.Location = new Point(10, 45);
    RadGelb.Name = "RadGelb";
    RadGelb.Text = "Gelb";

    // RadGruen
    RadGruen.AutoSize = true;
    RadGruen.Location = new Point(10, 68);
    RadGruen.Name = "RadGruen";
    RadGruen.Text = "Grün";

    // CmdAnzeigen
    CmdAnzeigen.Location = new Point(12, 120);
    CmdAnzeigen.Name = "CmdAnzeigen";
    CmdAnzeigen.Size = new Size(120, 28);
    CmdAnzeigen.Text = "Anzeigen";
    CmdAnzeigen.Click += CmdAnzeigen_Click;

    // LblMeldung
    LblMeldung.AutoSize = true;
    LblMeldung.Location = new Point(12, 160);
    LblMeldung.Name = "LblMeldung";
    LblMeldung.Text = "";

    // LblAmpel
    LblAmpel.Location = new Point(220, 12);
    LblAmpel.Name = "LblAmpel";
    LblAmpel.Size = new Size(60, 60);
    LblAmpel.BackColor = Color.Gray;
    LblAmpel.BorderStyle = BorderStyle.FixedSingle;

    // AmpelsteuerungForm
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(320, 200);
    Controls.Add(GrpFarbe);
    Controls.Add(CmdAnzeigen);
    Controls.Add(LblMeldung);
    Controls.Add(LblAmpel);
    Name = "AmpelsteuerungForm";
    Text = "Ampelsteuerung – Aufgabe 1";
    GrpFarbe.ResumeLayout(false);
    GrpFarbe.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }

  private GroupBox GrpFarbe;
  private RadioButton RadRot;
  private RadioButton RadGelb;
  private RadioButton RadGruen;
  private Button CmdAnzeigen;
  private Label LblMeldung;
  private Label LblAmpel;
}
