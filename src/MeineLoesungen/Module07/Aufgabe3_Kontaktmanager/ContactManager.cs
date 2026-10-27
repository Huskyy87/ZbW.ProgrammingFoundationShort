namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe3_Kontaktmanager;

/// <summary>Kontaktlogik ohne WinForms-Abhängigkeit.</summary>
public class ContactManager
{
  private readonly List<Contact> _contacts = new();

  public bool Add(Contact contact)
  {
    // Contains nutzt das überschriebene Equals (gleiche Telefonnummer = Duplikat)
    if (_contacts.Contains(contact))
    {
      return false;
    }

    _contacts.Add(contact);
    return true;
  }

  public bool Remove(string phone)
  {
    for (int i = 0; i < _contacts.Count; i++)
    {
      if (_contacts[i].Phone == phone)
      {
        _contacts.RemoveAt(i);
        return true;
      }
    }

    return false;
  }

  public List<Contact> Search(string name)
  {
    List<Contact> result = new List<Contact>();
    string suchtext = name.ToLower();

    foreach (Contact contact in _contacts)
    {
      if (contact.FirstName.ToLower().Contains(suchtext) || contact.LastName.ToLower().Contains(suchtext))
      {
        result.Add(contact);
      }
    }

    return result;
  }

  public List<Contact> GetAll()
  {
    return new List<Contact>(_contacts);
  }
}
