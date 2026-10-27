namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe2_ZahlenRatespiel;

partial class ZahlenRatespielForm
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
    LblTitel = new Label();
    TxtVermutung = new TextBox();
    CmdRaten = new Button();
    CmdNeuSpiel = new Button();
    LblHinweis = new Label();
    LblVersuche = new Label();
    SuspendLayout();

    LblTitel.AutoSize = true;
    LblTitel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
    LblTitel.Location = new Point(12, 12);
    LblTitel.Text = "Zahlen-Ratespiel (1–100)";

    TxtVermutung.Location = new Point(12, 50);
    TxtVermutung.Name = "TxtVermutung";
    TxtVermutung.Size = new Size(100, 23);

    CmdRaten.Location = new Point(122, 49);
    CmdRaten.Name = "CmdRaten";
    CmdRaten.Size = new Size(80, 25);
    CmdRaten.Text = "Raten";
    CmdRaten.Click += CmdRaten_Click;

    CmdNeuSpiel.Location = new Point(212, 49);
    CmdNeuSpiel.Name = "CmdNeuSpiel";
    CmdNeuSpiel.Size = new Size(100, 25);
    CmdNeuSpiel.Text = "Neues Spiel";
    CmdNeuSpiel.Click += CmdNeuSpiel_Click;

    LblHinweis.AutoSize = true;
    LblHinweis.Location = new Point(12, 85);
    LblHinweis.Name = "LblHinweis";
    LblHinweis.Text = "";

    LblVersuche.AutoSize = true;
    LblVersuche.Location = new Point(12, 110);
    LblVersuche.Name = "LblVersuche";
    LblVersuche.Text = "Versuche: 0";

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(340, 150);
    Controls.Add(LblTitel);
    Controls.Add(TxtVermutung);
    Controls.Add(CmdRaten);
    Controls.Add(CmdNeuSpiel);
    Controls.Add(LblHinweis);
    Controls.Add(LblVersuche);
    Name = "ZahlenRatespielForm";
    Text = "Zahlen-Ratespiel – Aufgabe 2";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblTitel;
  private TextBox TxtVermutung;
  private Button CmdRaten;
  private Button CmdNeuSpiel;
  private Label LblHinweis;
  private Label LblVersuche;
}
