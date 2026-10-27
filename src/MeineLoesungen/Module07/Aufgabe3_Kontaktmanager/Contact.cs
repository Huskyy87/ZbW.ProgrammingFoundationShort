namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe3_Kontaktmanager;

/// <summary>Datenklasse für einen Kontakt mit allen Feldern und optionalem Geburtstag.</summary>
public class Contact
{
  public string FirstName { get; set; } = "";
  public string LastName { get; set; } = "";
  public string Phone { get; set; } = "";
  public string Email { get; set; } = "";
  public DateTime? Birthday { get; set; }

  public override bool Equals(object? obj)
  {
    if (obj is not Contact other)
    {
      return false;
    }

    return Phone.Equals(other.Phone, StringComparison.OrdinalIgnoreCase);
  }

  public override int GetHashCode()
  {
    return Phone.ToLowerInvariant().GetHashCode();
  }

  public override string ToString()
  {
    string birthdayText = Birthday?.ToString("dd.MM.yyyy") ?? "kein Geburtstag";
    return $"{FirstName} {LastName} | {Phone} | {Email} | Geb: {birthdayText}";
  }
}

