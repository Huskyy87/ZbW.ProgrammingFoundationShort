namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe4_StatistikSimulator;

partial class StatistikSimulatorForm
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
    LblAnzahl = new Label();
    TxtAnzahl = new TextBox();
    CmdSimulieren = new Button();
    TxtErgebnis = new TextBox();
    LblStatus = new Label();
    SuspendLayout();

    LblAnzahl.AutoSize = true;
    LblAnzahl.Location = new Point(12, 20);
    LblAnzahl.Text = "Anzahl Würfe (100–10000):";

    TxtAnzahl.Location = new Point(200, 17);
    TxtAnzahl.Name = "TxtAnzahl";
    TxtAnzahl.Size = new Size(80, 23);
    TxtAnzahl.Text = "1000";

    CmdSimulieren.Location = new Point(12, 50);
    CmdSimulieren.Name = "CmdSimulieren";
    CmdSimulieren.Size = new Size(130, 28);
    CmdSimulieren.Text = "Simulieren";
    CmdSimulieren.Click += CmdSimulieren_Click;

    TxtErgebnis.Location = new Point(12, 90);
    TxtErgebnis.Multiline = true;
    TxtErgebnis.Name = "TxtErgebnis";
    TxtErgebnis.ReadOnly = true;
    TxtErgebnis.Font = new Font("Courier New", 9F);
    TxtErgebnis.ScrollBars = ScrollBars.Vertical;
    TxtErgebnis.Size = new Size(430, 200);

    LblStatus.AutoSize = true;
    LblStatus.Location = new Point(12, 302);
    LblStatus.Name = "LblStatus";
    LblStatus.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(460, 330);
    Controls.Add(LblAnzahl);
    Controls.Add(TxtAnzahl);
    Controls.Add(CmdSimulieren);
    Controls.Add(TxtErgebnis);
    Controls.Add(LblStatus);
    Name = "StatistikSimulatorForm";
    Text = "Statistik-Simulator – Aufgabe 4";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblAnzahl;
  private TextBox TxtAnzahl;
  private Button CmdSimulieren;
  private TextBox TxtErgebnis;
  private Label LblStatus;
}
