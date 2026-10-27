namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe2_ZahlenRatespiel;

/// <summary>
///   Aufgabe 2 – Zahlen-Ratespiel (⭐⭐ Mittel)
///   WinForms-Ratespiel mit Random, Hinweisen und Versuchszähler.
/// </summary>
public partial class ZahlenRatespielForm : Form
{
  private int _geheimzahl;
  private int _versuche;
  private readonly Random _random = new();

  public ZahlenRatespielForm()
  {
    InitializeComponent();
    NeuesSpiel();
  }

  private void NeuesSpiel()
  {
    _geheimzahl = _random.Next(1, 101);
    _versuche = 0;
    LblHinweis.Text = "Ich denke an eine Zahl von 1 bis 100...";
    LblVersuche.Text = "Versuche: 0";
    TxtVermutung.Clear();
    TxtVermutung.Enabled = true;
    CmdRaten.Enabled = true;
    TxtVermutung.Focus();
  }

  private void CmdRaten_Click(object sender, EventArgs e)
  {
    if (!int.TryParse(TxtVermutung.Text, out int tipp) || tipp < 1 || tipp > 100)
    {
      MessageBox.Show("Bitte eine Zahl zwischen 1 und 100 eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    _versuche++;
    LblVersuche.Text = $"Versuche: {_versuche}";

    if (tipp < _geheimzahl)
    {
      LblHinweis.Text = $"{tipp} ist zu klein!";
    }
    else if (tipp > _geheimzahl)
    {
      LblHinweis.Text = $"{tipp} ist zu gross!";
    }
    else
    {
      LblHinweis.Text = $"Richtig! {_geheimzahl} war die gesuchte Zahl!";
      TxtVermutung.Enabled = false;
      CmdRaten.Enabled = false;
      MessageBox.Show($"Glückwunsch! Du hast in {_versuche} Versuch(en) gewonnen!",
        "Gewonnen!", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    TxtVermutung.Clear();
    TxtVermutung.Focus();
  }

  private void CmdNeuSpiel_Click(object sender, EventArgs e)
  {
    NeuesSpiel();
  }
}
