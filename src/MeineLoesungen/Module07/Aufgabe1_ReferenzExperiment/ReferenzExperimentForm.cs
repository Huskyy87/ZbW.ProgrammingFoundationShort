namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe1_ReferenzExperiment;

/// <summary>
///   Aufgabe 1 – Referenz-Experiment (⭐ Einfach)
///   Zeigt den Unterschied zwischen Wert- und Referenztypen in WinForms.
/// </summary>
public partial class ReferenzExperimentForm : Form
{
  public ReferenzExperimentForm()
  {
    InitializeComponent();
  }

  private void CmdWerttyp_Click(object sender, EventArgs e)
  {
    // Werttyp: int – Kopie des Wertes
    int a = 10;
    int b = a; // Kopie!
    b = 20;
    LblWerttyp.Text = $"Werttyp:\r\na = {a} (unverändert)\r\nb = {b}\r\n→ b ist KOPIE von a";
  }

  private void CmdReferenztyp_Click(object sender, EventArgs e)
  {
    // Referenztyp: Counter – beide zeigen auf dasselbe Objekt
    var c1 = new Counter(10);
    var c2 = c1; // gleiche Referenz!
    c2.Value = 99;
    LblReferenztyp.Text = $"Referenztyp:\r\nc1 = {c1} (verändert!)\r\nc2 = {c2}\r\n→ c1 und c2 sind GLEICH";
  }

  private void CmdEchteKopie_Click(object sender, EventArgs e)
  {
    // Echte Kopie mit new
    var c1 = new Counter(10);
    var c2 = new Counter(c1.Value); // neues Objekt
    c2.Value = 99;
    LblEchteKopie.Text = $"Echte Kopie:\r\nc1 = {c1} (unverändert)\r\nc2 = {c2}\r\n→ neue Instanz mit 'new'";
  }

  private void CmdMethode_Click(object sender, EventArgs e)
  {
    // Transfer: Was passiert, wenn man Werte bzw. Objekte an eine Methode übergibt?
    int zahl = 10;
    Counter counter = new Counter(10);

    Erhoehe(zahl);       // Methode bekommt eine KOPIE des int
    Erhoehe(counter);    // Methode bekommt eine Kopie der REFERENZ → gleiches Objekt

    LblMethode.Text = $"Methoden-Test:\r\nint nach Aufruf = {zahl} (unverändert)\r\n" +
                      $"Counter nach Aufruf = {counter} (verändert!)";
  }

  private static void Erhoehe(int wert)
  {
    wert = wert + 1;
  }

  private static void Erhoehe(Counter counter)
  {
    counter.Value = counter.Value + 1;
  }
}
