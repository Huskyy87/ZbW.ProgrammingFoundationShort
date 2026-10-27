namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe4_Einheitenrechner;

/// <summary>
///   Musterlösung: Aufgabe 4 – Einheitenrechner (⭐⭐⭐⭐ Bonus)
///   Konvertiert zwischen km/Meilen, kg/Pfund und °C/°F.
///   Verwendet decimal für Präzision.
/// </summary>
public partial class EinheitenrechnerForm : Form
{
  private const decimal KgToPounds = 2.204623m; // 1 kg = 2.204623 Pfund

  // Umrechnungsfaktoren als Konstanten (dokumentiert)
  private const decimal KmToMiles = 0.621371m; // 1 km = 0.621371 Meilen
  private const decimal MilesToKm = 1.609344m; // 1 Meile = 1.609344 km

  private const decimal PoundsToKg = 0.453592m; // 1 Pfund = 0.453592 kg
  // °F = °C × 9/5 + 32   |   °C = (°F − 32) × 5/9

  public EinheitenrechnerForm()
  {
    InitializeComponent();
  }

  // ── Temperatur ───────────────────────────────────────────────

  private void CmdCelsiusToFahrenheit_Click(object sender, EventArgs e)
  {
    if (!decimal.TryParse(TxtCelsius.Text, out decimal celsius))
    {
      MessageBox.Show("Bitte einen gültigen Wert für °C eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // °F = °C × 9/5 + 32
    decimal fahrenheit = celsius * 9m / 5m + 32m;
    LblTempErgebnis.Text = $"{celsius} °C = {fahrenheit:F2} °F";
  }

  private void CmdFahrenheitToCelsius_Click(object sender, EventArgs e)
  {
    if (!decimal.TryParse(TxtFahrenheit.Text, out decimal fahrenheit))
    {
      MessageBox.Show("Bitte einen gültigen Wert für °F eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // °C = (°F − 32) × 5/9
    decimal celsius = (fahrenheit - 32m) * 5m / 9m;
    LblTempErgebnis.Text = $"{fahrenheit} °F = {celsius:F2} °C";
  }

  // ── Gewicht ─────────────────────────────────────────────────

  private void CmdKgToPounds_Click(object sender, EventArgs e)
  {
    if (!decimal.TryParse(TxtKg.Text, out decimal kg))
    {
      MessageBox.Show("Bitte einen gültigen Wert für kg eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    decimal pounds = kg * KgToPounds;
    LblGewichtErgebnis.Text = $"{kg} kg = {pounds:F4} Pfund";
  }

  // ── Distanz ─────────────────────────────────────────────────

  private void CmdKmToMiles_Click(object sender, EventArgs e)
  {
    if (!decimal.TryParse(TxtKm.Text, out decimal km))
    {
      MessageBox.Show("Bitte einen gültigen Wert für km eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    decimal miles = km * KmToMiles;
    LblDistanzErgebnis.Text = $"{km} km = {miles:F4} Meilen";
  }

  private void CmdMilesToKm_Click(object sender, EventArgs e)
  {
    if (!decimal.TryParse(TxtMeilen.Text, out decimal miles))
    {
      MessageBox.Show("Bitte einen gültigen Wert für Meilen eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    decimal km = miles * MilesToKm;
    LblDistanzErgebnis.Text = $"{miles} Meilen = {km:F4} km";
  }

  private void CmdPoundsToKg_Click(object sender, EventArgs e)
  {
    if (!decimal.TryParse(TxtPfund.Text, out decimal pounds))
    {
      MessageBox.Show("Bitte einen gültigen Wert für Pfund eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    decimal kg = pounds * PoundsToKg;
    LblGewichtErgebnis.Text = $"{pounds} Pfund = {kg:F4} kg";
  }
}
