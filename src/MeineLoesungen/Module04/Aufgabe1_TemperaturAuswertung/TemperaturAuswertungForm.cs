namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe1_TemperaturAuswertung;

/// <summary>
///   Aufgabe 1 – Temperatur-Auswertung (⭐ Einfach)
///   Wertet 7 Tagestemperaturen mit Array-Methoden aus.
/// </summary>
public partial class TemperaturAuswertungForm : Form
{
  public TemperaturAuswertungForm()
  {
    InitializeComponent();
  }

  private void CmdAuswerten_Click(object sender, EventArgs e)
  {
    TextBox[] felder = { TxtMo, TxtDi, TxtMi, TxtDo, TxtFr, TxtSa, TxtSo };
    double[] temperaturen = new double[7];

    for (int i = 0; i < felder.Length; i++)
    {
      if (!double.TryParse(felder[i].Text, out temperaturen[i]))
      {
        MessageBox.Show($"Ungültige Temperatur für Tag {i + 1}.",
          "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
    }

    LblDurchschnitt.Text = $"Durchschnitt: {Average(temperaturen):F1} °C";
    LblMax.Text = $"Maximum: {Maximum(temperaturen):F1} °C";
    LblMin.Text = $"Minimum: {Minimum(temperaturen):F1} °C";
  }

  private static double Average(double[] werte)
  {
    double summe = 0;
    for (int i = 0; i < werte.Length; i++)
    {
      summe += werte[i];
    }

    return summe / werte.Length;
  }

  private static double Maximum(double[] werte)
  {
    double max = werte[0];
    for (int i = 1; i < werte.Length; i++)
    {
      if (werte[i] > max)
      {
        max = werte[i];
      }
    }

    return max;
  }

  private static double Minimum(double[] werte)
  {
    double min = werte[0];
    for (int i = 1; i < werte.Length; i++)
    {
      if (werte[i] < min)
      {
        min = werte[i];
      }
    }

    return min;
  }
}
