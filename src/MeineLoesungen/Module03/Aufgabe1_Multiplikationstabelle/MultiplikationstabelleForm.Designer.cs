namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe1_Multiplikationstabelle;

partial class MultiplikationstabelleForm
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
    LblZahl = new Label();
    TxtZahl = new TextBox();
    ChkRueckwaerts = new CheckBox();
    CmdAnzeigen = new Button();
    TxtAusgabe = new TextBox();
    SuspendLayout();

    LblZahl.AutoSize = true;
    LblZahl.Location = new Point(12, 20);
    LblZahl.Text = "Zahl (1–10):";

    TxtZahl.Location = new Point(120, 17);
    TxtZahl.Name = "TxtZahl";
    TxtZahl.Size = new Size(60, 23);

    ChkRueckwaerts.AutoSize = true;
    ChkRueckwaerts.Location = new Point(12, 50);
    ChkRueckwaerts.Name = "ChkRueckwaerts";
    ChkRueckwaerts.Text = "Rückwärts (10 → 1)";

    CmdAnzeigen.Location = new Point(12, 80);
    CmdAnzeigen.Name = "CmdAnzeigen";
    CmdAnzeigen.Size = new Size(120, 28);
    CmdAnzeigen.Text = "Anzeigen";
    CmdAnzeigen.Click += CmdAnzeigen_Click;

    TxtAusgabe.Location = new Point(12, 120);
    TxtAusgabe.Multiline = true;
    TxtAusgabe.Name = "TxtAusgabe";
    TxtAusgabe.ReadOnly = true;
    TxtAusgabe.Font = new Font("Courier New", 10F);
    TxtAusgabe.ScrollBars = ScrollBars.Vertical;
    TxtAusgabe.Size = new Size(200, 200);

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(240, 335);
    Controls.Add(LblZahl);
    Controls.Add(TxtZahl);
    Controls.Add(ChkRueckwaerts);
    Controls.Add(CmdAnzeigen);
    Controls.Add(TxtAusgabe);
    Name = "MultiplikationstabelleForm";
    Text = "Multiplikationstabelle – Aufgabe 1";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblZahl;
  private TextBox TxtZahl;
  private CheckBox ChkRueckwaerts;
  private Button CmdAnzeigen;
  private TextBox TxtAusgabe;
}
