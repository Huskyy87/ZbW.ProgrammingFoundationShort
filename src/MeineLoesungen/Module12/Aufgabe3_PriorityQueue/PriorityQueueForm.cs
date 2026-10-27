namespace ZbW.ProgrammingFoundationShort.Challenges.Module12.Aufgabe3_PriorityQueue;

public sealed class PriorityQueueForm : Form
{
  private readonly ListBox LstOutput;

  public PriorityQueueForm()
  {
    Text = "PriorityQueue – Aufgabe 3";
    ClientSize = new Size(760, 380);

    Button cmdRun = new Button { Location = new Point(12, 12), Size = new Size(180, 30), Text = "Reihenfolge zeigen" };
    LstOutput = new ListBox { Location = new Point(12, 60), Size = new Size(720, 270) };

    cmdRun.Click += CmdRun_Click;

    Controls.Add(cmdRun);
    Controls.Add(LstOutput);
  }

  private void CmdRun_Click(object sender, EventArgs e)
  {
    List<PatientCase> cases = new List<PatientCase>
    {
      new PatientCase("Kopfschmerzen", 5),
      new PatientCase("Armbruch", 2),
      new PatientCase("Kontrolle", 6),
      new PatientCase("Atemnot", 1),
      new PatientCase("Fieber", 4)
    };

    List<string> normalOrder = cases.Select(patientCase => patientCase.Name).ToList();
    List<string> priorityOrder = BuildTreatmentOrder(cases);

    LstOutput.Items.Clear();
    LstOutput.Items.Add("Normale Queue:");
    LstOutput.Items.Add(string.Join(" -> ", normalOrder));
    LstOutput.Items.Add("");
    LstOutput.Items.Add("PriorityQueue (kleinere Priority-Zahl = dringender):");
    LstOutput.Items.Add(string.Join(" -> ", priorityOrder));
    LstOutput.Items.Add("");
    LstOutput.Items.Add("Fazit: Priorität kann fachlich wichtiger sein als Eingangsreihenfolge.");
  }

  public static List<string> BuildTreatmentOrder(IEnumerable<PatientCase> cases)
  {
    PriorityQueue<string, int> queue = new PriorityQueue<string, int>();

    foreach (PatientCase patientCase in cases)
    {
      queue.Enqueue(patientCase.Name, patientCase.Priority);
    }

    List<string> result = new List<string>();

    while (queue.Count > 0)
    {
      result.Add(queue.Dequeue());
    }

    return result;
  }
}

public sealed record PatientCase(string Name, int Priority);
