namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe4_DeepCopy;

/// <summary>Mitarbeiter mit Shallow/Deep-Copy.</summary>
public class EmployeeCopy
{
  public string Name { get; set; } = "";
  public Address Address { get; set; } = new();

  /// <summary>Flache Kopie: Name und Address-Referenz kopiert (NICHT das Objekt).</summary>
  public EmployeeCopy ShallowCopy()
  {
    return (EmployeeCopy)this.MemberwiseClone();
  }

  /// <summary>Tiefe Kopie: Name + neue Address-Instanz.</summary>
  public EmployeeCopy DeepCopy()
  {
    return new EmployeeCopy
    {
      Name = Name,
      Address = Address.Clone() // neue Instanz!
    };
  }

  public override string ToString() => $"{Name} | {Address}";
}
