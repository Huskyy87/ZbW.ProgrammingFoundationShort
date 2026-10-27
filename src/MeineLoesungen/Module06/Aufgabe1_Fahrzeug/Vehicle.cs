namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe1_Fahrzeug;

/// <summary>
///   Fahrzeug-Klasse mit Drive()-Methode und Kilometerstand.
/// </summary>
public class Vehicle
{
  public Vehicle(string make, string model, int year, double mileage)
  {
    Make = make;
    Model = model;
    Year = year;
    Mileage = mileage;
  }

  public string Make { get; set; }
  public string Model { get; set; }
  public int Year { get; set; }
  public double Mileage { get; private set; }

  public string GetInfo()
  {
    return $"{Year} {Make} {Model} | Kilometerstand: {Mileage:F1} km";
  }

  public void Drive(double km)
  {
    // IsFinite: NaN und Unendlich sind keine gültigen Strecken
    if (!double.IsFinite(km) || km <= 0)
    {
      throw new ArgumentException("Kilometeranzahl muss eine positive Zahl sein.");
    }

    Mileage += km;
  }
}
