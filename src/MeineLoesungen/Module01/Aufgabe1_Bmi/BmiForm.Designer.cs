namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe1_Bmi;

partial class BmiForm
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
    LblGewicht = new Label();
    TxtGewicht = new TextBox();
    LblGewichtEinheit = new Label();
    LblGroesse = new Label();
    TxtGroesse = new TextBox();
    LblGroesseEinheit = new Label();
    CmdBerechnen = new Button();
    LblErgebnis = new Label();
    SuspendLayout();

    // LblGewicht
    LblGewicht.AutoSize = true;
    LblGewicht.Location = new Point(12, 18);
    LblGewicht.Text = "Gewicht:";

    // TxtGewicht
    TxtGewicht.Location = new Point(120, 15);
    TxtGewicht.Name = "TxtGewicht";
    TxtGewicht.Size = new Size(100, 23);

    // LblGewichtEinheit
    LblGewichtEinheit.AutoSize = true;
    LblGewichtEinheit.Location = new Point(228, 18);
    LblGewichtEinheit.Text = "kg";

    // LblGroesse
    LblGroesse.AutoSize = true;
    LblGroesse.Location = new Point(12, 53);
    LblGroesse.Text = "Grösse:";

    // TxtGroesse
    TxtGroesse.Location = new Point(120, 50);
    TxtGroesse.Name = "TxtGroesse";
    TxtGroesse.Size = new Size(100, 23);

    // LblGroesseEinheit
    LblGroesseEinheit.AutoSize = true;
    LblGroesseEinheit.Location = new Point(228, 53);
    LblGroesseEinheit.Text = "m (z. B. 1.78)";

    // CmdBerechnen
    CmdBerechnen.Location = new Point(120, 85);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(130, 28);
    CmdBerechnen.Text = "BMI berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;

    // LblErgebnis
    LblErgebnis.AutoSize = true;
    LblErgebnis.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
    LblErgebnis.Location = new Point(12, 125);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Size = new Size(300, 19);
    LblErgebnis.Text = "";

    // BmiForm
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(400, 160);
    Controls.Add(LblGewicht);
    Controls.Add(TxtGewicht);
    Controls.Add(LblGewichtEinheit);
    Controls.Add(LblGroesse);
    Controls.Add(TxtGroesse);
    Controls.Add(LblGroesseEinheit);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblErgebnis);
    Name = "BmiForm";
    Text = "BMI-Rechner – Aufgabe 1";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblGewicht;
  private TextBox TxtGewicht;
  private Label LblGewichtEinheit;
  private Label LblGroesse;
  private TextBox TxtGroesse;
  private Label LblGroesseEinheit;
  private Button CmdBerechnen;
  private Label LblErgebnis;
}
