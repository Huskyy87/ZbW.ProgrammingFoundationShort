namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe4_DeepCopy;

/// <summary>Adresse als separates Objekt für Deep/Shallow-Copy-Demo.</summary>
public class Address
{
  public string Street { get; set; } = "";
  public string City { get; set; } = "";

  public Address Clone() => new Address { Street = Street, City = City };

  public override string ToString() => $"{Street}, {City}";
}
