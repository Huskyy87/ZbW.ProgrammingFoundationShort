namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe4_TaschenrechnerVerlauf;

/// <summary>
///   Aufgabe 4 – Taschenrechner mit Verlauf (⭐⭐⭐ Schwer)
///   Taschenrechner mit RadioButtons und mehrzeiligem Verlauf.
/// </summary>
public partial class TaschenrechnerVerlaufForm : Form
{
  public TaschenrechnerVerlaufForm()
  {
    InitializeComponent();
  }

  private void CmdBerechnen_Click(object sender, EventArgs e)
  {
    // Eingaben validieren
    if (!double.TryParse(TxtZahl1.Text, out double zahl1))
    {
      MessageBox.Show("Bitte eine gültige erste Zahl eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (!double.TryParse(TxtZahl2.Text, out double zahl2))
    {
      MessageBox.Show("Bitte eine gültige zweite Zahl eingeben.",
        "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // Operation ermitteln
    string op;
    if (RadPlus.Checked)
    {
      op = "+";
    }
    else if (RadMinus.Checked)
    {
      op = "-";
    }
    else if (RadMal.Checked)
    {
      op = "×";
    }
    else
    {
      op = "÷";
    }

    // Division durch 0 prüfen (ohne try-catch)
    if (op == "÷" && zahl2 == 0)
    {
      LblErgebnis.Text = "Fehler: Division durch 0!";
      TxtVerlauf.AppendText($"{zahl1} ÷ {zahl2} = FEHLER (Div/0)\r\n");
      return;
    }

    // Berechnung
    double ergebnis = op switch
    {
      "+" => zahl1 + zahl2,
      "-" => zahl1 - zahl2,
      "×" => zahl1 * zahl2,
      "÷" => zahl1 / zahl2,
      _ => 0
    };

    // Ternärer Operator für Vorzeichen
    string vorzeichen = (ergebnis < 0) ? " (negativ)" : "";
    LblErgebnis.Text = $"= {ergebnis:F2}{vorzeichen}";

    // Verlauf
    TxtVerlauf.AppendText($"{zahl1} {op} {zahl2} = {ergebnis:F2}{vorzeichen}\r\n");
  }
}
