namespace ZbW.ProgrammingFoundationShort.Challenges.Module01.Aufgabe3_ZahlenAnalyse;

/// <summary>
///   Musterlösung: Aufgabe 3 – Zahlen-Analyse (⭐⭐⭐ Anspruchsvoll)
///   Analysiert drei eingegebene Zahlen: Summe, Durchschnitt,
///   grösste/kleinste Zahl, gerade/ungerade Summe.
/// </summary>
public partial class ZahlenAnalyseForm : Form
{
  public ZahlenAnalyseForm()
  {
    InitializeComponent();
  }

  private void CmdAnalysieren_Click(object sender, EventArgs e)
  {
    // Alle drei Zahlen einlesen und validieren
    if (!int.TryParse(TxtZahl1.Text, out int zahl1) ||
        !int.TryParse(TxtZahl2.Text, out int zahl2) ||
        !int.TryParse(TxtZahl3.Text, out int zahl3))
    {
      MessageBox.Show("Bitte drei gültige ganze Zahlen eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // Berechnungen
    // long: drei grosse int-Werte würden in int überlaufen. (long) vor der ersten Addition,
    // sonst wird zuerst in int gerechnet und erst das falsche Ergebnis umgewandelt.
    long summe = (long)zahl1 + zahl2 + zahl3;
    double durchschnitt = summe / 3.0;

    // Grösste Zahl (nur Operatoren, keine Methoden)
    int groesste = zahl1;
    if (zahl2 > groesste)
    {
      groesste = zahl2;
    }

    if (zahl3 > groesste)
    {
      groesste = zahl3;
    }

    // Kleinste Zahl
    int kleinste = zahl1;
    if (zahl2 < kleinste)
    {
      kleinste = zahl2;
    }

    if (zahl3 < kleinste)
    {
      kleinste = zahl3;
    }

    // Gerade oder ungerade (Modulo)
    string geradeOderUngerade;
    if (summe % 2 == 0)
    {
      geradeOderUngerade = "gerade";
    }
    else
    {
      geradeOderUngerade = "ungerade";
    }

    // Ergebnisse anzeigen
    LblSumme.Text = $"Summe: {summe}";
    LblDurchschnitt.Text = $"Durchschnitt: {durchschnitt:F2}";
    LblGroesste.Text = $"Grösste Zahl: {groesste}";
    LblKleinste.Text = $"Kleinste Zahl: {kleinste}";
    LblGerade.Text = $"Summe ist: {geradeOderUngerade}";
  }
}
