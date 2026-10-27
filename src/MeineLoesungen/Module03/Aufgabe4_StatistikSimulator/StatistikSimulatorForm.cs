namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe4_StatistikSimulator;

/// <summary>
///   Aufgabe 4 – Statistik-Simulator (⭐⭐⭐ Schwer)
///   Würfelsimulation mit Häufigkeitsanalyse und try-catch-finally.
/// </summary>
public partial class StatistikSimulatorForm : Form
{
  private readonly Random _random = new();

  public StatistikSimulatorForm()
  {
    InitializeComponent();
  }

  private void CmdSimulieren_Click(object sender, EventArgs e)
  {
    LblStatus.Text = "Simulation läuft...";
    TxtErgebnis.Clear();

    try
    {
      if (!int.TryParse(TxtAnzahl.Text, out int anzahl) || anzahl < 100 || anzahl > 10000)
      {
        throw new ArgumentException("Bitte eine Anzahl zwischen 100 und 10000 eingeben.");
      }

      // Häufigkeiten zählen
      int[] haeufigkeit = new int[7]; // Index 1–6 verwenden

      for (int i = 0; i < anzahl; i++)
      {
        int wurf = _random.Next(1, 7);
        haeufigkeit[wurf]++;
      }

      // Ergebnis aufbauen
      string nl = Environment.NewLine;
      string text = $"Simulation: {anzahl} Würfe{nl}{nl}";
      text += "Augenzahl | Häufigkeit | Anteil" + nl;
      text += "----------------------------------------" + nl;

      double summe = 0;
      for (int i = 1; i <= 6; i++)
      {
        double prozent = (double)haeufigkeit[i] / anzahl * 100;
        summe += i * haeufigkeit[i];
        text += $"   {i}      |   {haeufigkeit[i],5}   |  {prozent,5:F1}%" + nl;
      }

      double durchschnitt = summe / anzahl;
      text += "----------------------------------------" + nl;
      text += $"Durchschnitt: {durchschnitt:F3} (Erwartungswert: 3.500)" + nl;
      text += "Je mehr Würfe, desto näher liegen die Anteile bei 16.7 % (Gesetz der grossen Zahlen).";

      TxtErgebnis.Text = text;
    }
    catch (ArgumentException ex)
    {
      MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    catch (Exception ex)
    {
      MessageBox.Show($"Unerwarteter Fehler: {ex.Message}",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally
    {
      LblStatus.Text = "Simulation abgeschlossen";
    }
  }
}
