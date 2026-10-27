namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe2_Notenrechner;

/// <summary>
///   Aufgabe 2 – Notenrechner (⭐⭐ Mittel)
///   Bewertet eine Note von 1.0–6.0 mit Detailanzeige.
/// </summary>
public partial class NotenrechnerForm : Form
{
  public NotenrechnerForm()
  {
    InitializeComponent();
  }

  private void CmdBewerten_Click(object sender, EventArgs e)
  {
    // Note einlesen und validieren
    if (!double.TryParse(TxtNote.Text, out double note) || double.IsNaN(note) || note < 1.0 || note > 6.0)
    {
      MessageBox.Show("Bitte eine gültige Note zwischen 1.0 und 6.0 eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // Bewertung per if/else-if
    string bewertung;
    if (note >= 5.5)
    {
      bewertung = "Sehr gut";
    }
    else if (note >= 4.5)
    {
      bewertung = "Gut";
    }
    else if (note >= 4.0)
    {
      bewertung = "Genügend";
    }
    else
    {
      bewertung = "Ungenügend";
    }

    // Ergebnis aufbauen
    string ergebnis = $"Note {note:F1}: {bewertung}";

    // Details wenn Checkbox aktiviert
    if (ChkDetails.Checked)
    {
      double prozent = (note - 1.0) / 5.0 * 100.0;
      ergebnis += $"\r\nLeistung: {prozent:F1}%";
    }

    LblErgebnis.Text = ergebnis;
  }
}
