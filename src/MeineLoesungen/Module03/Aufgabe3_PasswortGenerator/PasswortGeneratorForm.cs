namespace ZbW.ProgrammingFoundationShort.Challenges.Module03.Aufgabe3_PasswortGenerator;

/// <summary>
///   Aufgabe 3 – Passwort-Generator (⭐⭐⭐ Anspruchsvoll)
///   Generiert zufällige Passwörter aus konfigurierbarem Zeichenpool.
/// </summary>
public partial class PasswortGeneratorForm : Form
{
  private readonly Random _random = new();

  public PasswortGeneratorForm()
  {
    InitializeComponent();
  }

  private void CmdGenerieren_Click(object sender, EventArgs e)
  {
    try
    {
      if (!int.TryParse(TxtLaenge.Text, out int laenge) || laenge < 8 || laenge > 32)
      {
        MessageBox.Show("Bitte eine Länge zwischen 8 und 32 eingeben.",
          "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      string pool = "";
      if (ChkGross.Checked)
      {
        pool += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      }

      if (ChkKlein.Checked)
      {
        pool += "abcdefghijklmnopqrstuvwxyz";
      }

      if (ChkZahlen.Checked)
      {
        pool += "0123456789";
      }

      if (ChkSonder.Checked)
      {
        pool += "!@#$%^&*";
      }

      if (pool.Length == 0)
      {
        MessageBox.Show("Bitte mindestens einen Zeichentyp auswählen.",
          "Keine Zeichen", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      // Hinweis: Random ist für Übungen ok, aber nicht kryptografisch sicher.
      // Für echte Passwörter: System.Security.Cryptography.RandomNumberGenerator.
      string passwort = "";
      for (int i = 0; i < laenge; i++)
      {
        passwort += pool[_random.Next(pool.Length)];
      }

      LblPasswort.Text = passwort;
    }
    catch (Exception ex)
    {
      MessageBox.Show($"Fehler beim Generieren: {ex.Message}",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }

  private void CmdKopieren_Click(object sender, EventArgs e)
  {
    if (!string.IsNullOrEmpty(LblPasswort.Text))
    {
      Clipboard.SetText(LblPasswort.Text);
      MessageBox.Show("Passwort in die Zwischenablage kopiert!",
        "Kopiert", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}