namespace ZbW.ProgrammingFoundationShort.Challenges.Module09.Aufgabe1_FahrzeugHierarchie;

public sealed class FahrzeugHierarchieForm : Form
{
  private readonly RadioButton RadCar;
  private readonly RadioButton RadMotorcycle;
  private readonly RadioButton RadTruck;
  private readonly TextBox TxtBrand;
  private readonly TextBox TxtYear;
  private readonly TextBox TxtExtra;
  private readonly Label LblResult;

  public FahrzeugHierarchieForm()
  {
    Text = "Fahrzeug-Hierarchie – Aufgabe 1";
    ClientSize = new Size(460, 260);

    RadCar = new RadioButton { Location = new Point(120, 12), Size = new Size(70, 24), Text = "Auto", Checked = true };
    RadMotorcycle = new RadioButton { Location = new Point(195, 12), Size = new Size(90, 24), Text = "Motorrad" };
    RadTruck = new RadioButton { Location = new Point(290, 12), Size = new Size(90, 24), Text = "Lastwagen" };
    TxtBrand = new TextBox { Location = new Point(120, 50), Size = new Size(160, 23), Text = "VW" };
    TxtYear = new TextBox { Location = new Point(120, 83), Size = new Size(80, 23), Text = "2020" };
    TxtExtra = new TextBox { Location = new Point(120, 116), Size = new Size(80, 23), Text = "5" };
    Button cmdCreate = new Button { Location = new Point(120, 155), Size = new Size(150, 28), Text = "Erstellen + Hupen" };
    LblResult = new Label { Location = new Point(12, 195), Size = new Size(430, 50) };

    Controls.Add(new Label { Location = new Point(12, 15), Size = new Size(100, 20), Text = "Fahrzeugtyp:" });
    Controls.Add(new Label { Location = new Point(12, 53), Size = new Size(100, 20), Text = "Marke:" });
    Controls.Add(new Label { Location = new Point(12, 86), Size = new Size(100, 20), Text = "Jahrgang:" });
    Controls.Add(new Label { Location = new Point(12, 119), Size = new Size(100, 20), Text = "Türen/ja/Tonnen:" });
    Controls.Add(RadCar);
    Controls.Add(RadMotorcycle);
    Controls.Add(RadTruck);
    Controls.Add(TxtBrand);
    Controls.Add(TxtYear);
    Controls.Add(TxtExtra);
    Controls.Add(cmdCreate);
    Controls.Add(LblResult);

    cmdCreate.Click += CmdCreate_Click;
  }

  private void CmdCreate_Click(object sender, EventArgs e)
  {
    if (!int.TryParse(TxtYear.Text, out int year))
    {
      LblResult.Text = "Jahrgang ist ungültig.";
      return;
    }

    Vehicle vehicle;

    if (RadCar.Checked)
    {
      if (!int.TryParse(TxtExtra.Text, out int doors))
      {
        LblResult.Text = "Anzahl Türen ist ungültig.";
        return;
      }

      vehicle = new Car(TxtBrand.Text, year, doors);
    }
    else if (RadMotorcycle.Checked)
    {
      bool hasSidecar = TxtExtra.Text.Trim().ToLower() == "ja";
      vehicle = new Motorcycle(TxtBrand.Text, year, hasSidecar);
    }
    else
    {
      if (!double.TryParse(TxtExtra.Text, out double loadTons))
      {
        LblResult.Text = "Nutzlast ist ungültig.";
        return;
      }

      vehicle = new Truck(TxtBrand.Text, year, loadTons);
    }

    // Polymorphismus: Honk() und ToString() der echten Klasse werden aufgerufen
    LblResult.Text = $"{vehicle.Honk()} ({vehicle})";
  }
}

public class Vehicle
{
  public Vehicle(string brand, int year)
  {
    Brand = brand;
    Year = year;
  }

  public string Brand { get; }
  public int Year { get; }

  public virtual string Honk()
  {
    return "Tut!";
  }

  public override string ToString()
  {
    return $"{Brand}, {Year}";
  }
}

public class Car : Vehicle
{
  public Car(string brand, int year, int doors) : base(brand, year)
  {
    Doors = doors;
  }

  public int Doors { get; }

  public override string Honk()
  {
    return "Tuut tuut!";
  }

  public override string ToString()
  {
    return $"{base.ToString()}, {Doors} Türen";
  }
}

public class Motorcycle : Vehicle
{
  public Motorcycle(string brand, int year, bool hasSidecar) : base(brand, year)
  {
    HasSidecar = hasSidecar;
  }

  public bool HasSidecar { get; }

  public override string Honk()
  {
    return "Möööp!";
  }

  public override string ToString()
  {
    string sidecar = HasSidecar ? "mit Seitenwagen" : "ohne Seitenwagen";
    return $"{base.ToString()}, {sidecar}";
  }
}

public class Truck : Vehicle
{
  public Truck(string brand, int year, double loadTons) : base(brand, year)
  {
    LoadTons = loadTons;
  }

  public double LoadTons { get; }

  public override string Honk()
  {
    return "TOOOT!";
  }

  public override string ToString()
  {
    return $"{base.ToString()}, {LoadTons} t Nutzlast";
  }
}
