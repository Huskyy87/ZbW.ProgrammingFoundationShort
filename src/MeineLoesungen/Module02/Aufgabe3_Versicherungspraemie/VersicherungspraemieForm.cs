namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe3_Versicherungspraemie;

/// <summary>
///   Aufgabe 3 – Versicherungsprämie (⭐⭐⭐ Schwer)
///   Berechnet Prämie aus Alter, Versicherungstyp und Unfall-Option.
/// </summary>
public enum InsuranceType { Basis, Standard, Premium }

public partial class VersicherungspraemieForm : Form
{
  public VersicherungspraemieForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // Alter validieren
    if (!int.TryParse(TxtAlter.Text, out int alter) || alter < 0 || alter > 120)
    {
      MessageBox.Show("Bitte ein gültiges Alter eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // Basisprämie nach Alter
    double basis;
    if (alter < 25)
    {
      basis = 150;
    }
    else if (alter <= 45)
    {
      basis = 200;
    }
    else if (alter <= 65)
    {
      basis = 280;
    }
    else
    {
      basis = 350;
    }

    // Versicherungstyp ermitteln
    InsuranceType typ;
    if (RadStandard.Checked)
    {
      typ = InsuranceType.Standard;
    }
    else if (RadPremium.Checked)
    {
      typ = InsuranceType.Premium;
    }
    else
    {
      typ = InsuranceType.Basis;
    }

    // Multiplikator per switch
    double multiplikator = typ switch
    {
      InsuranceType.Basis => 1.0,
      InsuranceType.Standard => 1.4,
      InsuranceType.Premium => 1.8,
      _ => 1.0
    };

    double praemie = basis * multiplikator;

    // Unfallzusatz
    if (ChkUnfall.Checked)
    {
      praemie += 20;
    }

    LblErgebnis.Text = $"Alter: {alter} Jahre\r\n" +
                       $"Versicherungstyp: {typ}\r\n" +
                       $"Basisprämie: {basis:F2} CHF\r\n" +
                       $"Unfall: {(ChkUnfall.Checked ? "+20 CHF" : "nein")}\r\n" +
                       $"Monatsprämie: {praemie:F2} CHF";
  }
}
