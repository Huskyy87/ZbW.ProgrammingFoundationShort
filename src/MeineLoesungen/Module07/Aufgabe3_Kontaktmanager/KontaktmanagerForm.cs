namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe3_Kontaktmanager;

/// <summary>
///   Aufgabe 3 – Kontaktmanager mit getrennter UI, Logik und Daten (⭐⭐⭐ Schwer)
/// </summary>
public partial class KontaktmanagerForm : Form
{
  private readonly ContactManager _contactManager = new();

  public KontaktmanagerForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    Contact contact = new Contact
    {
      FirstName = TxtFirst.Text.Trim(),
      LastName = TxtLast.Text.Trim(),
      Phone = TxtPhone.Text.Trim(),
      Email = TxtEmail.Text.Trim(),
      Birthday = DateTime.TryParse(TxtBirthday.Text, out DateTime bday) ? bday : null
    };

    if (string.IsNullOrEmpty(contact.FirstName) || string.IsNullOrEmpty(contact.LastName) || string.IsNullOrEmpty(contact.Phone))
    {
      MessageBox.Show("Vorname, Nachname und Telefonnummer sind erforderlich.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (!_contactManager.Add(contact))
    {
      MessageBox.Show("Ein Kontakt mit dieser Telefonnummer existiert bereits.",
        "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
      return;
    }

    AktualisiereAusgabe();
    TxtFirst.Clear(); TxtLast.Clear(); TxtPhone.Clear(); TxtEmail.Clear(); TxtBirthday.Clear();
  }

  private void CmdLoeschen_Click(object sender, EventArgs e)
  {
    if (!_contactManager.Remove(TxtPhone.Text.Trim()))
    {
      MessageBox.Show("Kein Kontakt mit dieser Telefonnummer gefunden.",
        "Nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Information);
      return;
    }

    AktualisiereAusgabe();
    TxtPhone.Clear();
  }

  private void CmdSuchen_Click(object sender, EventArgs e)
  {
    List<Contact> result = _contactManager.Search(TxtSuche.Text.Trim());
    TxtAusgabe.Clear();
    foreach (Contact contact in result)
    {
      TxtAusgabe.AppendText(contact + "\r\n");
    }
  }

  private void CmdAlleAnzeigen_Click(object sender, EventArgs e)
  {
    AktualisiereAusgabe();
  }

  private void AktualisiereAusgabe()
  {
    TxtAusgabe.Clear();
    foreach (Contact contact in _contactManager.GetAll())
    {
      TxtAusgabe.AppendText(contact + "\r\n");
    }
  }
}

