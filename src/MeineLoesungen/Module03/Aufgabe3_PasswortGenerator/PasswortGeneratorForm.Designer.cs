namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe3_PasswortGenerator;

partial class PasswortGeneratorForm
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
    LblLaenge = new Label();
    TxtLaenge = new TextBox();
    ChkGross = new CheckBox();
    ChkKlein = new CheckBox();
    ChkZahlen = new CheckBox();
    ChkSonder = new CheckBox();
    CmdGenerieren = new Button();
    LblPasswortLabel = new Label();
    LblPasswort = new Label();
    CmdKopieren = new Button();
    SuspendLayout();

    LblLaenge.AutoSize = true;
    LblLaenge.Location = new Point(12, 20);
    LblLaenge.Text = "Länge (8–32):";

    TxtLaenge.Location = new Point(130, 17);
    TxtLaenge.Name = "TxtLaenge";
    TxtLaenge.Size = new Size(60, 23);
    TxtLaenge.Text = "12";

    ChkGross.AutoSize = true;
    ChkGross.Checked = true;
    ChkGross.Location = new Point(12, 50);
    ChkGross.Name = "ChkGross";
    ChkGross.Text = "Grossbuchstaben (A–Z)";

    ChkKlein.AutoSize = true;
    ChkKlein.Checked = true;
    ChkKlein.Location = new Point(12, 75);
    ChkKlein.Name = "ChkKlein";
    ChkKlein.Text = "Kleinbuchstaben (a–z)";

    ChkZahlen.AutoSize = true;
    ChkZahlen.Checked = true;
    ChkZahlen.Location = new Point(12, 100);
    ChkZahlen.Name = "ChkZahlen";
    ChkZahlen.Text = "Zahlen (0–9)";

    ChkSonder.AutoSize = true;
    ChkSonder.Location = new Point(12, 125);
    ChkSonder.Name = "ChkSonder";
    ChkSonder.Text = "Sonderzeichen (!@#...)";

    CmdGenerieren.Location = new Point(12, 160);
    CmdGenerieren.Name = "CmdGenerieren";
    CmdGenerieren.Size = new Size(130, 28);
    CmdGenerieren.Text = "Generieren";
    CmdGenerieren.Click += CmdGenerieren_Click;

    LblPasswortLabel.AutoSize = true;
    LblPasswortLabel.Location = new Point(12, 205);
    LblPasswortLabel.Text = "Passwort:";

    LblPasswort.AutoSize = true;
    LblPasswort.Font = new Font("Courier New", 11F, FontStyle.Bold);
    LblPasswort.Location = new Point(12, 225);
    LblPasswort.Name = "LblPasswort";
    LblPasswort.Text = "";

    CmdKopieren.Location = new Point(12, 255);
    CmdKopieren.Name = "CmdKopieren";
    CmdKopieren.Size = new Size(130, 28);
    CmdKopieren.Text = "Kopieren";
    CmdKopieren.Click += CmdKopieren_Click;

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(360, 300);
    Controls.Add(LblLaenge);
    Controls.Add(TxtLaenge);
    Controls.Add(ChkGross);
    Controls.Add(ChkKlein);
    Controls.Add(ChkZahlen);
    Controls.Add(ChkSonder);
    Controls.Add(CmdGenerieren);
    Controls.Add(LblPasswortLabel);
    Controls.Add(LblPasswort);
    Controls.Add(CmdKopieren);
    Name = "PasswortGeneratorForm";
    Text = "Passwort-Generator – Aufgabe 3";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblLaenge;
  private TextBox TxtLaenge;
  private CheckBox ChkGross;
  private CheckBox ChkKlein;
  private CheckBox ChkZahlen;
  private CheckBox ChkSonder;
  private Button CmdGenerieren;
  private Label LblPasswortLabel;
  private Label LblPasswort;
  private Button CmdKopieren;
}
