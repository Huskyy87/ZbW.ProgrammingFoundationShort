namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe2_EqualsImplementieren;

partial class EqualsForm
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
    LblP1 = new Label(); LblArtNr1 = new Label(); TxtArtNr1 = new TextBox();
    LblName1 = new Label(); TxtName1 = new TextBox();
    LblPreis1 = new Label(); TxtPreis1 = new TextBox();
    LblP2 = new Label(); LblArtNr2 = new Label(); TxtArtNr2 = new TextBox();
    LblName2 = new Label(); TxtName2 = new TextBox();
    LblPreis2 = new Label(); TxtPreis2 = new TextBox();
    CmdVergleichen = new Button(); LblErgebnis = new Label();
    SuspendLayout();

    LblP1.AutoSize = true; LblP1.Font = new Font("Segoe UI", 10F, FontStyle.Bold); LblP1.Location = new Point(12, 12); LblP1.Text = "Produkt 1:";
    LblArtNr1.AutoSize = true; LblArtNr1.Location = new Point(12, 40); LblArtNr1.Text = "Art-Nr:";
    TxtArtNr1.Location = new Point(80, 37); TxtArtNr1.Name = "TxtArtNr1"; TxtArtNr1.Size = new Size(80, 23); TxtArtNr1.Text = "A001";
    LblName1.AutoSize = true; LblName1.Location = new Point(175, 40); LblName1.Text = "Name:";
    TxtName1.Location = new Point(220, 37); TxtName1.Name = "TxtName1"; TxtName1.Size = new Size(120, 23); TxtName1.Text = "Schraube";
    LblPreis1.AutoSize = true; LblPreis1.Location = new Point(12, 70); LblPreis1.Text = "Preis:";
    TxtPreis1.Location = new Point(80, 67); TxtPreis1.Name = "TxtPreis1"; TxtPreis1.Size = new Size(80, 23); TxtPreis1.Text = "0.50";

    LblP2.AutoSize = true; LblP2.Font = new Font("Segoe UI", 10F, FontStyle.Bold); LblP2.Location = new Point(12, 105); LblP2.Text = "Produkt 2:";
    LblArtNr2.AutoSize = true; LblArtNr2.Location = new Point(12, 133); LblArtNr2.Text = "Art-Nr:";
    TxtArtNr2.Location = new Point(80, 130); TxtArtNr2.Name = "TxtArtNr2"; TxtArtNr2.Size = new Size(80, 23); TxtArtNr2.Text = "A001";
    LblName2.AutoSize = true; LblName2.Location = new Point(175, 133); LblName2.Text = "Name:";
    TxtName2.Location = new Point(220, 130); TxtName2.Name = "TxtName2"; TxtName2.Size = new Size(120, 23); TxtName2.Text = "Schraube (anderer Name)";
    LblPreis2.AutoSize = true; LblPreis2.Location = new Point(12, 163); LblPreis2.Text = "Preis:";
    TxtPreis2.Location = new Point(80, 160); TxtPreis2.Name = "TxtPreis2"; TxtPreis2.Size = new Size(80, 23); TxtPreis2.Text = "0.75";

    CmdVergleichen.Location = new Point(12, 198); CmdVergleichen.Name = "CmdVergleichen"; CmdVergleichen.Size = new Size(120, 28); CmdVergleichen.Text = "Vergleichen"; CmdVergleichen.Click += CmdVergleichen_Click;
    LblErgebnis.Location = new Point(12, 240); LblErgebnis.Name = "LblErgebnis"; LblErgebnis.Size = new Size(420, 100); LblErgebnis.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(450, 355);
    Controls.Add(LblP1); Controls.Add(LblArtNr1); Controls.Add(TxtArtNr1); Controls.Add(LblName1); Controls.Add(TxtName1); Controls.Add(LblPreis1); Controls.Add(TxtPreis1);
    Controls.Add(LblP2); Controls.Add(LblArtNr2); Controls.Add(TxtArtNr2); Controls.Add(LblName2); Controls.Add(TxtName2); Controls.Add(LblPreis2); Controls.Add(TxtPreis2);
    Controls.Add(CmdVergleichen); Controls.Add(LblErgebnis);
    Name = "EqualsForm"; Text = "Equals implementieren – Aufgabe 2";
    ResumeLayout(false); PerformLayout();
  }

  private Label LblP1; private Label LblArtNr1; private TextBox TxtArtNr1;
  private Label LblName1; private TextBox TxtName1;
  private Label LblPreis1; private TextBox TxtPreis1;
  private Label LblP2; private Label LblArtNr2; private TextBox TxtArtNr2;
  private Label LblName2; private TextBox TxtName2;
  private Label LblPreis2; private TextBox TxtPreis2;
  private Button CmdVergleichen; private Label LblErgebnis;
}
