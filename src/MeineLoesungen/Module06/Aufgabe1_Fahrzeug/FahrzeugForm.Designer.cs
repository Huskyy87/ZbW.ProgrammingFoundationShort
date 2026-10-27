namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe1_Fahrzeug;

partial class FahrzeugForm
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
    LblMake = new Label(); TxtMake = new TextBox();
    LblModel = new Label(); TxtModel = new TextBox();
    LblYear = new Label(); TxtYear = new TextBox();
    CmdErstellen = new Button();
    LblKm = new Label(); TxtKm = new TextBox(); CmdFahren = new Button();
    LblInfo = new Label();
    SuspendLayout();

    LblMake.AutoSize = true; LblMake.Location = new Point(12, 15); LblMake.Text = "Marke:";
    TxtMake.Location = new Point(80, 12); TxtMake.Name = "TxtMake"; TxtMake.Size = new Size(120, 23);
    LblModel.AutoSize = true; LblModel.Location = new Point(215, 15); LblModel.Text = "Modell:";
    TxtModel.Location = new Point(265, 12); TxtModel.Name = "TxtModel"; TxtModel.Size = new Size(120, 23);
    LblYear.AutoSize = true; LblYear.Location = new Point(12, 45); LblYear.Text = "Baujahr:";
    TxtYear.Location = new Point(80, 42); TxtYear.Name = "TxtYear"; TxtYear.Size = new Size(80, 23);
    CmdErstellen.Location = new Point(12, 75); CmdErstellen.Name = "CmdErstellen"; CmdErstellen.Size = new Size(120, 25); CmdErstellen.Text = "Fahrzeug erstellen"; CmdErstellen.Click += CmdErstellen_Click;
    LblKm.AutoSize = true; LblKm.Location = new Point(12, 115); LblKm.Text = "Fahren (km):";
    TxtKm.Location = new Point(110, 112); TxtKm.Name = "TxtKm"; TxtKm.Size = new Size(80, 23);
    CmdFahren.Location = new Point(200, 111); CmdFahren.Name = "CmdFahren"; CmdFahren.Size = new Size(80, 25); CmdFahren.Text = "Fahren"; CmdFahren.Enabled = false; CmdFahren.Click += CmdFahren_Click;
    LblInfo.AutoSize = true; LblInfo.Location = new Point(12, 150); LblInfo.Name = "LblInfo"; LblInfo.Text = "(noch kein Fahrzeug)";

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(420, 200);
    Controls.Add(LblMake); Controls.Add(TxtMake); Controls.Add(LblModel); Controls.Add(TxtModel);
    Controls.Add(LblYear); Controls.Add(TxtYear); Controls.Add(CmdErstellen);
    Controls.Add(LblKm); Controls.Add(TxtKm); Controls.Add(CmdFahren); Controls.Add(LblInfo);
    Name = "FahrzeugForm"; Text = "Fahrzeug – Aufgabe 1";
    ResumeLayout(false); PerformLayout();
  }

  private Label LblMake; private TextBox TxtMake;
  private Label LblModel; private TextBox TxtModel;
  private Label LblYear; private TextBox TxtYear;
  private Button CmdErstellen;
  private Label LblKm; private TextBox TxtKm; private Button CmdFahren;
  private Label LblInfo;
}
