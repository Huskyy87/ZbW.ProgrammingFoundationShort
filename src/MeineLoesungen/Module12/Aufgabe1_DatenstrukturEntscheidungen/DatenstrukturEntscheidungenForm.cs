namespace ZbW.ProgrammingFoundationShort.Challenges.Module12.Aufgabe1_DatenstrukturEntscheidungen;

public sealed class DatenstrukturEntscheidungenForm : Form
{
  private readonly ListBox LstOutput;

  public DatenstrukturEntscheidungenForm()
  {
    Text = "Datenstruktur-Entscheidungen – Aufgabe 1";
    ClientSize = new Size(760, 360);

    Button cmdShow = new Button { Location = new Point(12, 12), Size = new Size(170, 30), Text = "Lösung anzeigen" };
    LstOutput = new ListBox { Location = new Point(12, 60), Size = new Size(720, 250) };

    cmdShow.Click += CmdShow_Click;

    Controls.Add(cmdShow);
    Controls.Add(LstOutput);
  }

  private void CmdShow_Click(object sender, EventArgs e)
  {
    LstOutput.Items.Clear();

    foreach (Decision decision in GetDecisions())
    {
      LstOutput.Items.Add($"{decision.Situation}: {decision.DataStructure} – {decision.Reason}");
    }
  }

  public static List<Decision> GetDecisions()
  {
    return new List<Decision>
    {
      new Decision("Undo-Verlauf", "Stack<T>", "die letzte Aktion wird zuerst rückgängig gemacht"),
      new Decision("Support-Tickets", "Queue<T>", "das zuerst eingetroffene Ticket wird zuerst bearbeitet"),
      new Decision("Telefonbuch", "Dictionary<string,string>", "ein Name führt direkt zur Telefonnummer"),
      new Decision("eindeutige Benutzernamen", "HashSet<string>", "jeder Name darf nur einmal vorkommen")
    };
  }
}

public sealed record Decision(string Situation, string DataStructure, string Reason);
