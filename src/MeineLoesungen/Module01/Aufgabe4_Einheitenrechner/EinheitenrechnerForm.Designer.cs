namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe4_Einheitenrechner;

partial class EinheitenrechnerForm
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
    // Distanz
    GrpDistanz = new GroupBox();
    LblKm = new Label();
    TxtKm = new TextBox();
    CmdKmToMiles = new Button();
    LblMeilen = new Label();
    TxtMeilen = new TextBox();
    CmdMilesToKm = new Button();
    LblDistanzErgebnis = new Label();

    // Gewicht
    GrpGewicht = new GroupBox();
    LblKg = new Label();
    TxtKg = new TextBox();
    CmdKgToPounds = new Button();
    LblPfund = new Label();
    TxtPfund = new TextBox();
    CmdPoundsToKg = new Button();
    LblGewichtErgebnis = new Label();

    // Temperatur
    GrpTemperatur = new GroupBox();
    LblCelsius = new Label();
    TxtCelsius = new TextBox();
    CmdCelsiusToFahrenheit = new Button();
    LblFahrenheit = new Label();
    TxtFahrenheit = new TextBox();
    CmdFahrenheitToCelsius = new Button();
    LblTempErgebnis = new Label();

    SuspendLayout();

    // ── GroupBox Distanz ─────────────────────────────────────
    GrpDistanz.Location = new Point(12, 12);
    GrpDistanz.Name = "GrpDistanz";
    GrpDistanz.Size = new Size(420, 110);
    GrpDistanz.Text = "Distanz";

    LblKm.AutoSize = true; LblKm.Location = new Point(10, 25); LblKm.Text = "km:";
    TxtKm.Location = new Point(70, 22); TxtKm.Name = "TxtKm"; TxtKm.Size = new Size(80, 23);
    CmdKmToMiles.Location = new Point(160, 21); CmdKmToMiles.Size = new Size(120, 25);
    CmdKmToMiles.Text = "→ Meilen"; CmdKmToMiles.Click += CmdKmToMiles_Click;

    LblMeilen.AutoSize = true; LblMeilen.Location = new Point(10, 60); LblMeilen.Text = "Meilen:";
    TxtMeilen.Location = new Point(70, 57); TxtMeilen.Name = "TxtMeilen"; TxtMeilen.Size = new Size(80, 23);
    CmdMilesToKm.Location = new Point(160, 56); CmdMilesToKm.Size = new Size(120, 25);
    CmdMilesToKm.Text = "→ km"; CmdMilesToKm.Click += CmdMilesToKm_Click;

    LblDistanzErgebnis.AutoSize = true; LblDistanzErgebnis.Location = new Point(10, 88);
    LblDistanzErgebnis.Name = "LblDistanzErgebnis"; LblDistanzErgebnis.Text = "";
    LblDistanzErgebnis.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);

    GrpDistanz.Controls.AddRange(new Control[] { LblKm, TxtKm, CmdKmToMiles, LblMeilen, TxtMeilen, CmdMilesToKm, LblDistanzErgebnis });

    // ── GroupBox Gewicht ─────────────────────────────────────
    GrpGewicht.Location = new Point(12, 135);
    GrpGewicht.Name = "GrpGewicht";
    GrpGewicht.Size = new Size(420, 110);
    GrpGewicht.Text = "Gewicht";

    LblKg.AutoSize = true; LblKg.Location = new Point(10, 25); LblKg.Text = "kg:";
    TxtKg.Location = new Point(70, 22); TxtKg.Name = "TxtKg"; TxtKg.Size = new Size(80, 23);
    CmdKgToPounds.Location = new Point(160, 21); CmdKgToPounds.Size = new Size(120, 25);
    CmdKgToPounds.Text = "→ Pfund"; CmdKgToPounds.Click += CmdKgToPounds_Click;

    LblPfund.AutoSize = true; LblPfund.Location = new Point(10, 60); LblPfund.Text = "Pfund:";
    TxtPfund.Location = new Point(70, 57); TxtPfund.Name = "TxtPfund"; TxtPfund.Size = new Size(80, 23);
    CmdPoundsToKg.Location = new Point(160, 56); CmdPoundsToKg.Size = new Size(120, 25);
    CmdPoundsToKg.Text = "→ kg"; CmdPoundsToKg.Click += CmdPoundsToKg_Click;

    LblGewichtErgebnis.AutoSize = true; LblGewichtErgebnis.Location = new Point(10, 88);
    LblGewichtErgebnis.Name = "LblGewichtErgebnis"; LblGewichtErgebnis.Text = "";
    LblGewichtErgebnis.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);

    GrpGewicht.Controls.AddRange(new Control[] { LblKg, TxtKg, CmdKgToPounds, LblPfund, TxtPfund, CmdPoundsToKg, LblGewichtErgebnis });

    // ── GroupBox Temperatur ──────────────────────────────────
    GrpTemperatur.Location = new Point(12, 258);
    GrpTemperatur.Name = "GrpTemperatur";
    GrpTemperatur.Size = new Size(420, 110);
    GrpTemperatur.Text = "Temperatur";

    LblCelsius.AutoSize = true; LblCelsius.Location = new Point(10, 25); LblCelsius.Text = "°C:";
    TxtCelsius.Location = new Point(70, 22); TxtCelsius.Name = "TxtCelsius"; TxtCelsius.Size = new Size(80, 23);
    CmdCelsiusToFahrenheit.Location = new Point(160, 21); CmdCelsiusToFahrenheit.Size = new Size(120, 25);
    CmdCelsiusToFahrenheit.Text = "→ °F"; CmdCelsiusToFahrenheit.Click += CmdCelsiusToFahrenheit_Click;

    LblFahrenheit.AutoSize = true; LblFahrenheit.Location = new Point(10, 60); LblFahrenheit.Text = "°F:";
    TxtFahrenheit.Location = new Point(70, 57); TxtFahrenheit.Name = "TxtFahrenheit"; TxtFahrenheit.Size = new Size(80, 23);
    CmdFahrenheitToCelsius.Location = new Point(160, 56); CmdFahrenheitToCelsius.Size = new Size(120, 25);
    CmdFahrenheitToCelsius.Text = "→ °C"; CmdFahrenheitToCelsius.Click += CmdFahrenheitToCelsius_Click;

    LblTempErgebnis.AutoSize = true; LblTempErgebnis.Location = new Point(10, 88);
    LblTempErgebnis.Name = "LblTempErgebnis"; LblTempErgebnis.Text = "";
    LblTempErgebnis.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);

    GrpTemperatur.Controls.AddRange(new Control[] { LblCelsius, TxtCelsius, CmdCelsiusToFahrenheit, LblFahrenheit, TxtFahrenheit, CmdFahrenheitToCelsius, LblTempErgebnis });

    // ── EinheitenrechnerForm ─────────────────────────────────
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(448, 385);
    Controls.Add(GrpDistanz);
    Controls.Add(GrpGewicht);
    Controls.Add(GrpTemperatur);
    Name = "EinheitenrechnerForm";
    Text = "Einheitenrechner – Aufgabe 4 (Bonus)";
    ResumeLayout(false);
    PerformLayout();
  }

  // Distanz
  private GroupBox GrpDistanz;
  private Label LblKm;
  private TextBox TxtKm;
  private Button CmdKmToMiles;
  private Label LblMeilen;
  private TextBox TxtMeilen;
  private Button CmdMilesToKm;
  private Label LblDistanzErgebnis;

  // Gewicht
  private GroupBox GrpGewicht;
  private Label LblKg;
  private TextBox TxtKg;
  private Button CmdKgToPounds;
  private Label LblPfund;
  private TextBox TxtPfund;
  private Button CmdPoundsToKg;
  private Label LblGewichtErgebnis;

  // Temperatur
  private GroupBox GrpTemperatur;
  private Label LblCelsius;
  private TextBox TxtCelsius;
  private Button CmdCelsiusToFahrenheit;
  private Label LblFahrenheit;
  private TextBox TxtFahrenheit;
  private Button CmdFahrenheitToCelsius;
  private Label LblTempErgebnis;
}
