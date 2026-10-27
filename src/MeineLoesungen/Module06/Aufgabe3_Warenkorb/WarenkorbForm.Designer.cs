namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe3_Warenkorb;

partial class WarenkorbForm
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
    LblProdukt = new Label(); TxtProdukt = new TextBox();
    LblPreis = new Label(); TxtPreis = new TextBox();
    LblMenge = new Label(); TxtMenge = new TextBox();
    CmdHinzufuegen = new Button(); CmdEntfernen = new Button(); CmdKassenbon = new Button();
    TxtKassenbon = new TextBox();
    SuspendLayout();

    LblProdukt.AutoSize = true; LblProdukt.Location = new Point(12, 15); LblProdukt.Text = "Produkt:";
    TxtProdukt.Location = new Point(80, 12); TxtProdukt.Name = "TxtProdukt"; TxtProdukt.Size = new Size(160, 23);
    LblPreis.AutoSize = true; LblPreis.Location = new Point(255, 15); LblPreis.Text = "Preis:";
    TxtPreis.Location = new Point(295, 12); TxtPreis.Name = "TxtPreis"; TxtPreis.Size = new Size(80, 23);
    LblMenge.AutoSize = true; LblMenge.Location = new Point(385, 15); LblMenge.Text = "Menge:";
    TxtMenge.Location = new Point(435, 12); TxtMenge.Name = "TxtMenge"; TxtMenge.Size = new Size(50, 23);

    CmdHinzufuegen.Location = new Point(12, 45); CmdHinzufuegen.Name = "CmdHinzufuegen"; CmdHinzufuegen.Size = new Size(110, 25); CmdHinzufuegen.Text = "Hinzufügen"; CmdHinzufuegen.Click += CmdHinzufuegen_Click;
    CmdEntfernen.Location = new Point(130, 45); CmdEntfernen.Name = "CmdEntfernen"; CmdEntfernen.Size = new Size(110, 25); CmdEntfernen.Text = "Entfernen"; CmdEntfernen.Click += CmdEntfernen_Click;
    CmdKassenbon.Location = new Point(248, 45); CmdKassenbon.Name = "CmdKassenbon"; CmdKassenbon.Size = new Size(100, 25); CmdKassenbon.Text = "Kassenbon"; CmdKassenbon.Click += CmdKassenbon_Click;

    TxtKassenbon.Location = new Point(12, 80); TxtKassenbon.Multiline = true; TxtKassenbon.Name = "TxtKassenbon";
    TxtKassenbon.ReadOnly = true; TxtKassenbon.Font = new Font("Courier New", 9F);
    TxtKassenbon.ScrollBars = ScrollBars.Vertical; TxtKassenbon.Size = new Size(480, 220);

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(510, 315);
    Controls.Add(LblProdukt); Controls.Add(TxtProdukt); Controls.Add(LblPreis); Controls.Add(TxtPreis);
    Controls.Add(LblMenge); Controls.Add(TxtMenge);
    Controls.Add(CmdHinzufuegen); Controls.Add(CmdEntfernen); Controls.Add(CmdKassenbon);
    Controls.Add(TxtKassenbon);
    Name = "WarenkorbForm"; Text = "Warenkorb – Aufgabe 3";
    ResumeLayout(false); PerformLayout();
  }

  private Label LblProdukt; private TextBox TxtProdukt;
  private Label LblPreis; private TextBox TxtPreis;
  private Label LblMenge; private TextBox TxtMenge;
  private Button CmdHinzufuegen; private Button CmdEntfernen; private Button CmdKassenbon;
  private TextBox TxtKassenbon;
}
