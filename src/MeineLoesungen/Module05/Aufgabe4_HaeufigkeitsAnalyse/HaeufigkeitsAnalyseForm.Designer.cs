namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe4_HaeufigkeitsAnalyse;

partial class HaeufigkeitsAnalyseForm
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
    LblEingabe = new Label(); TxtEingabe = new TextBox();
    CmdAnalysieren = new Button(); TxtErgebnis = new TextBox();
    SuspendLayout();

    LblEingabe.AutoSize = true; LblEingabe.Location = new Point(12, 12); LblEingabe.Text = "Text eingeben:";
    TxtEingabe.Location = new Point(12, 30); TxtEingabe.Multiline = true; TxtEingabe.Name = "TxtEingabe";
    TxtEingabe.ScrollBars = ScrollBars.Vertical; TxtEingabe.Size = new Size(420, 100);
    CmdAnalysieren.Location = new Point(12, 140); CmdAnalysieren.Name = "CmdAnalysieren"; CmdAnalysieren.Size = new Size(130, 28); CmdAnalysieren.Text = "Analysieren"; CmdAnalysieren.Click += CmdAnalysieren_Click;
    TxtErgebnis.Location = new Point(12, 180); TxtErgebnis.Multiline = true; TxtErgebnis.Name = "TxtErgebnis";
    TxtErgebnis.ReadOnly = true; TxtErgebnis.Font = new Font("Courier New", 10F);
    TxtErgebnis.ScrollBars = ScrollBars.Vertical; TxtErgebnis.Size = new Size(420, 150);

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(450, 345);
    Controls.Add(LblEingabe); Controls.Add(TxtEingabe); Controls.Add(CmdAnalysieren); Controls.Add(TxtErgebnis);
    Name = "HaeufigkeitsAnalyseForm"; Text = "Häufigkeits-Analyse – Aufgabe 4";
    ResumeLayout(false); PerformLayout();
  }

  private Label LblEingabe; private TextBox TxtEingabe;
  private Button CmdAnalysieren; private TextBox TxtErgebnis;
}
