namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe2_Waehrungsrechner;

/// <summary>
///   Musterlösung: Aufgabe 2 – Währungsrechner (⭐⭐ Mittel)
///   CHF ↔ EUR Konvertierung mit decimal (Geldbeträge!).
/// </summary>
public partial class WaehrungsrechnerForm : Form
{
  // Fester Übungskurs: 1 EUR = 1.05 CHF
  //   CHF → EUR:  eur = chf / ChfPerEur
  //   EUR → CHF:  chf = eur * ChfPerEur
  private const decimal ChfPerEur = 1.05m;
  private const decimal MaxBetrag = 1000000000m; // Übungsbereich, verhindert Überlauf bei sehr grossen Zahlen

  public WaehrungsrechnerForm()
  {
    InitializeComponent();
  }

  private void CmdChfToEur_Click(object sender, EventArgs e)
  {
    if (!decimal.TryParse(TxtBetrag.Text, out decimal betrag))
    {
      MessageBox.Show("Bitte einen gültigen Betrag eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (betrag < 0 || betrag > MaxBetrag)
    {
      MessageBox.Show("Bitte einen Betrag von 0 bis 1 Milliarde eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    decimal eur = betrag / ChfPerEur;
    LblErgebnis.Text = $"{betrag:F2} CHF = {eur:F2} EUR";
  }

  private void CmdEurToChf_Click(object sender, EventArgs e)
  {
    if (!decimal.TryParse(TxtBetrag.Text, out decimal betrag))
    {
      MessageBox.Show("Bitte einen gültigen Betrag eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (betrag < 0 || betrag > MaxBetrag)
    {
      MessageBox.Show("Bitte einen Betrag von 0 bis 1 Milliarde eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    decimal chf = betrag * ChfPerEur;
    LblErgebnis.Text = $"{betrag:F2} EUR = {chf:F2} CHF";
  }
}
