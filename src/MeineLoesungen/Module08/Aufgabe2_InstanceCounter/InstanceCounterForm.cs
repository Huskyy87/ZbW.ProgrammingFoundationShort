namespace ZbW.ProgrammingFoundationShort.Challenges.Module08.Aufgabe2_InstanceCounter;

public sealed class InstanceCounterForm : Form
{
  private readonly TextBox TxtMake;
  private readonly TextBox TxtModel;
  private readonly ListBox LstUsers;
  private readonly Label LblCount;

  public InstanceCounterForm()
  {
    Text = "Instance Counter – Aufgabe 2";
    ClientSize = new Size(430, 320);

    TxtMake = new TextBox { Location = new Point(90, 12), Size = new Size(120, 23), Text = "VW" };
    TxtModel = new TextBox { Location = new Point(90, 45), Size = new Size(120, 23), Text = "Golf" };
    Button cmdCreate = new Button { Location = new Point(230, 10), Size = new Size(140, 28), Text = "Fahrzeug erstellen" };
    Button cmdReset = new Button { Location = new Point(230, 45), Size = new Size(120, 28), Text = "Reset" };
    LstUsers = new ListBox { Location = new Point(12, 90), Size = new Size(390, 170) };
    LblCount = new Label { Location = new Point(12, 270), Size = new Size(390, 30) };

    cmdCreate.Click += CmdCreate_Click;
    cmdReset.Click += CmdReset_Click;

    Controls.Add(new Label { Location = new Point(12, 15), Size = new Size(70, 20), Text = "Marke:" });
    Controls.Add(new Label { Location = new Point(12, 48), Size = new Size(70, 20), Text = "Modell:" });
    Controls.Add(TxtMake);
    Controls.Add(TxtModel);
    Controls.Add(cmdCreate);
    Controls.Add(cmdReset);
    Controls.Add(LstUsers);
    Controls.Add(LblCount);
    UpdateView();
  }

  private void CmdCreate_Click(object sender, EventArgs e)
  {
    Vehicle vehicle = new Vehicle(TxtMake.Text.Trim(), TxtModel.Text.Trim());
    VehicleRegistry.Register(vehicle);
    UpdateView();
  }

  private void CmdReset_Click(object sender, EventArgs e)
  {
    Vehicle.ResetCounter();
    VehicleRegistry.Clear();
    UpdateView();
  }

  private void UpdateView()
  {
    LstUsers.Items.Clear();

    foreach (Vehicle vehicle in VehicleRegistry.GetAll())
    {
      LstUsers.Items.Add(vehicle.ToString());
    }

    LblCount.Text = $"Vehicle.TotalCount = {Vehicle.TotalCount}, Registry.Count = {VehicleRegistry.Count}";
  }
}

public sealed class Vehicle
{
  private static int _totalCount;

  public Vehicle(string make, string model)
  {
    Make = make;
    Model = model;
    _totalCount++;
  }

  public string Make { get; set; }
  public string Model { get; set; }

  public static int TotalCount
  {
    get { return _totalCount; }
  }

  public static void ResetCounter()
  {
    _totalCount = 0;
  }

  public override string ToString()
  {
    return $"{Make} {Model}";
  }
}

public static class VehicleRegistry
{
  private static readonly List<Vehicle> Vehicles = new List<Vehicle>();

  public static int Count
  {
    get { return Vehicles.Count; }
  }

  public static void Register(Vehicle vehicle)
  {
    Vehicles.Add(vehicle);
  }

  public static List<Vehicle> GetAll()
  {
    return new List<Vehicle>(Vehicles); // Kopie: niemand verändert die interne Liste
  }

  public static void Clear()
  {
    Vehicles.Clear();
  }
}
