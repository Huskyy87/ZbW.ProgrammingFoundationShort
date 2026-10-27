namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe3_Versicherungspraemie;

partial class VersicherungspraemieForm
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
    LblAlter = new Label();
    TxtAlter = new TextBox();
    GrpTyp = new GroupBox();
    RadBasis = new RadioButton();
    RadStandard = new RadioButton();
    RadPremium = new RadioButton();
    ChkUnfall = new CheckBox();
    CmdBerechnen = new Button();
    LblErgebnis = new Label();
    GrpTyp.SuspendLayout();
    SuspendLayout();

    LblAlter.AutoSize = true;
    LblAlter.Location = new Point(12, 20);
    LblAlter.Text = "Alter (Jahre):";

    TxtAlter.Location = new Point(130, 17);
    TxtAlter.Name = "TxtAlter";
    TxtAlter.Size = new Size(80, 23);

    GrpTyp.Location = new Point(12, 50);
    GrpTyp.Name = "GrpTyp";
    GrpTyp.Size = new Size(220, 95);
    GrpTyp.Text = "Versicherungstyp";
    GrpTyp.Controls.Add(RadBasis);
    GrpTyp.Controls.Add(RadStandard);
    GrpTyp.Controls.Add(RadPremium);

    RadBasis.AutoSize = true;
    RadBasis.Checked = true;
    RadBasis.Location = new Point(10, 20);
    RadBasis.Name = "RadBasis";
    RadBasis.Text = "Basis (×1.0)";

    RadStandard.AutoSize = true;
    RadStandard.Location = new Point(10, 45);
    RadStandard.Name = "RadStandard";
    RadStandard.Text = "Standard (×1.4)";

    RadPremium.AutoSize = true;
    RadPremium.Location = new Point(10, 68);
    RadPremium.Name = "RadPremium";
    RadPremium.Text = "Premium (×1.8)";

    ChkUnfall.AutoSize = true;
    ChkUnfall.Location = new Point(12, 155);
    ChkUnfall.Name = "ChkUnfall";
    ChkUnfall.Text = "Unfallzusatz (+20 CHF)";

    CmdBerechnen.Location = new Point(12, 185);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(130, 28);
    CmdBerechnen.Text = "Berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;

    LblErgebnis.AutoSize = true;
    LblErgebnis.Location = new Point(12, 225);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(380, 340);
    Controls.Add(LblAlter);
    Controls.Add(TxtAlter);
    Controls.Add(GrpTyp);
    Controls.Add(ChkUnfall);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblErgebnis);
    Name = "VersicherungspraemieForm";
    Text = "Versicherungsprämie – Aufgabe 3";
    GrpTyp.ResumeLayout(false);
    GrpTyp.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblAlter;
  private TextBox TxtAlter;
  private GroupBox GrpTyp;
  private RadioButton RadBasis;
  private RadioButton RadStandard;
  private RadioButton RadPremium;
  private CheckBox ChkUnfall;
  private Button CmdBerechnen;
  private Label LblErgebnis;
}
