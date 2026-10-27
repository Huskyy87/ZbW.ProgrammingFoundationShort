namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe4_SortierVisualisierung;

partial class SortierVisualisierungForm
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
    LblEingabe = new Label();
    TxtEingabe = new TextBox();
    CmdSortieren = new Button();
    TxtErgebnis = new TextBox();
    SuspendLayout();

    LblEingabe.AutoSize = true;
    LblEingabe.Location = new Point(12, 20);
    LblEingabe.Text = "Zahlen (kommagetrennt):";

    TxtEingabe.Location = new Point(12, 40);
    TxtEingabe.Name = "TxtEingabe";
    TxtEingabe.Size = new Size(400, 23);
    TxtEingabe.Text = "5,3,8,1,9,2,7,4,6";

    CmdSortieren.Location = new Point(12, 75);
    CmdSortieren.Name = "CmdSortieren";
    CmdSortieren.Size = new Size(130, 28);
    CmdSortieren.Text = "Sortieren";
    CmdSortieren.Click += CmdSortieren_Click;

    TxtErgebnis.Location = new Point(12, 115);
    TxtErgebnis.Multiline = true;
    TxtErgebnis.Name = "TxtErgebnis";
    TxtErgebnis.ReadOnly = true;
    TxtErgebnis.Font = new Font("Courier New", 9F);
    TxtErgebnis.ScrollBars = ScrollBars.Vertical;
    TxtErgebnis.Size = new Size(400, 220);

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(430, 350);
    Controls.Add(LblEingabe);
    Controls.Add(TxtEingabe);
    Controls.Add(CmdSortieren);
    Controls.Add(TxtErgebnis);
    Name = "SortierVisualisierungForm";
    Text = "Sortier-Visualisierung – Aufgabe 4";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblEingabe;
  private TextBox TxtEingabe;
  private Button CmdSortieren;
  private TextBox TxtErgebnis;
}
