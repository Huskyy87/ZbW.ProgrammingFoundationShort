namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe1_TemperaturAuswertung;

partial class TemperaturAuswertungForm
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
    LblMo = new Label(); TxtMo = new TextBox();
    LblDi = new Label(); TxtDi = new TextBox();
    LblMi = new Label(); TxtMi = new TextBox();
    LblDo = new Label(); TxtDo = new TextBox();
    LblFr = new Label(); TxtFr = new TextBox();
    LblSa = new Label(); TxtSa = new TextBox();
    LblSo = new Label(); TxtSo = new TextBox();
    CmdAuswerten = new Button();
    LblDurchschnitt = new Label();
    LblMax = new Label();
    LblMin = new Label();
    SuspendLayout();

    string[] tage = { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" };
    Label[] labels = { LblMo, LblDi, LblMi, LblDo, LblFr, LblSa, LblSo };
    TextBox[] felder = { TxtMo, TxtDi, TxtMi, TxtDo, TxtFr, TxtSa, TxtSo };

    for (int i = 0; i < 7; i++)
    {
      labels[i].AutoSize = true;
      labels[i].Location = new Point(12, 20 + i * 30);
      labels[i].Text = $"{tage[i]}:";
      felder[i].Location = new Point(60, 17 + i * 30);
      felder[i].Name = $"Txt{tage[i]}";
      felder[i].Size = new Size(80, 23);
      Controls.Add(labels[i]);
      Controls.Add(felder[i]);
    }

    CmdAuswerten.Location = new Point(12, 235);
    CmdAuswerten.Name = "CmdAuswerten";
    CmdAuswerten.Size = new Size(130, 28);
    CmdAuswerten.Text = "Auswerten";
    CmdAuswerten.Click += CmdAuswerten_Click;

    LblDurchschnitt.AutoSize = true;
    LblDurchschnitt.Location = new Point(12, 275);
    LblDurchschnitt.Name = "LblDurchschnitt";
    LblDurchschnitt.Text = "";

    LblMax.AutoSize = true;
    LblMax.Location = new Point(12, 295);
    LblMax.Name = "LblMax";
    LblMax.Text = "";

    LblMin.AutoSize = true;
    LblMin.Location = new Point(12, 315);
    LblMin.Name = "LblMin";
    LblMin.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(280, 345);
    Controls.Add(CmdAuswerten);
    Controls.Add(LblDurchschnitt);
    Controls.Add(LblMax);
    Controls.Add(LblMin);
    Name = "TemperaturAuswertungForm";
    Text = "Temperatur-Auswertung – Aufgabe 1";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblMo; private TextBox TxtMo;
  private Label LblDi; private TextBox TxtDi;
  private Label LblMi; private TextBox TxtMi;
  private Label LblDo; private TextBox TxtDo;
  private Label LblFr; private TextBox TxtFr;
  private Label LblSa; private TextBox TxtSa;
  private Label LblSo; private TextBox TxtSo;
  private Button CmdAuswerten;
  private Label LblDurchschnitt;
  private Label LblMax;
  private Label LblMin;
}
