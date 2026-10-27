namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe1_Bmi;

/// <summary>
///   Musterlösung: Aufgabe 1 – Body-Mass-Index (⭐ Einfach)
///   WinForms-App zur Berechnung des BMI.
///   Formel: BMI = Gewicht / (Grösse * Grösse)
/// </summary>
public partial class BmiForm : Form
{
  public BmiForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // Gewicht einlesen und validieren
    if (!double.TryParse(TxtGewicht.Text, out double gewicht) || double.IsNaN(gewicht) || gewicht <= 0 || gewicht > 500)
    {
      MessageBox.Show("Bitte ein gültiges Gewicht in kg eingeben (z. B. 75, höchstens 500).",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // Grösse einlesen und validieren
    if (!double.TryParse(TxtGroesse.Text, out double groesse) || double.IsNaN(groesse) || groesse <= 0 || groesse > 3)
    {
      MessageBox.Show("Bitte eine gültige Grösse in Metern eingeben (z. B. 1.78, höchstens 3).",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // BMI berechnen
    double bmi = gewicht / (groesse * groesse);

    LblErgebnis.Text = $"Ihr BMI beträgt: {bmi:F2}";
  }
}
