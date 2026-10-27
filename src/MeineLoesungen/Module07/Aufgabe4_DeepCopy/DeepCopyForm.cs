namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe4_DeepCopy;

/// <summary>
///   Aufgabe 4 – Deep Copy Demo (⭐⭐⭐ Schwer)
/// </summary>
public partial class DeepCopyForm : Form
{
  public DeepCopyForm()
  {
    InitializeComponent();
  }

  private void CmdShallowCopy_Click(object sender, EventArgs e)
  {
    var original = new EmployeeCopy
    {
      Name = "Anna",
      Address = new Address { Street = "Hauptstrasse 1", City = "Zürich" }
    };

    var kopie = original.ShallowCopy();
    kopie.Name = "Kopie-Anna";
    kopie.Address.City = "Bern"; // ändert auch Original!

    LblShallow.Text = $"SHALLOW COPY:\r\n" +
                      $"Original: {original}\r\n" +
                      $"Kopie:    {kopie}\r\n" +
                      $"→ Address.City wurde bei beiden geändert!\r\n" +
                      $"  (beide zeigen auf dieselbe Address-Instanz)";
  }

  private void CmdDeepCopy_Click(object sender, EventArgs e)
  {
    var original = new EmployeeCopy
    {
      Name = "Bob",
      Address = new Address { Street = "Bahnhofstrasse 5", City = "Basel" }
    };

    var kopie = original.DeepCopy();
    kopie.Name = "Kopie-Bob";
    kopie.Address.City = "Bern"; // ändert NUR die Kopie!

    LblDeep.Text = $"DEEP COPY:\r\n" +
                   $"Original: {original}\r\n" +
                   $"Kopie:    {kopie}\r\n" +
                   $"→ Original unverändert!\r\n" +
                   $"  (neue Address-Instanz durch Clone())";
  }
}
