namespace ZbW.ProgrammingFoundationShort.Challenges.Module08.Aufgabe4_TicketSystem;

public sealed class TicketSystemForm : Form
{
  private readonly TextBox TxtTitle;
  private readonly ComboBox CmbPriority;
  private readonly ComboBox CmbFilter;
  private readonly ListBox LstTickets;
  private readonly Label LblUrgent;

  public TicketSystemForm()
  {
    Text = "Ticket-System – Aufgabe 4";
    ClientSize = new Size(560, 360);

    TxtTitle = new TextBox { Location = new Point(12, 12), Size = new Size(280, 23), Text = "Drucker druckt nicht" };
    CmbPriority = new ComboBox { Location = new Point(300, 12), Size = new Size(110, 23), DropDownStyle = ComboBoxStyle.DropDownList };
    Button cmdAdd = new Button { Location = new Point(420, 10), Size = new Size(110, 27), Text = "Erfassen" };
    CmbFilter = new ComboBox { Location = new Point(12, 47), Size = new Size(130, 23), DropDownStyle = ComboBoxStyle.DropDownList };
    LblUrgent = new Label { Location = new Point(160, 50), Size = new Size(300, 23) };
    LstTickets = new ListBox { Location = new Point(12, 85), Size = new Size(520, 250) };

    CmbPriority.Items.AddRange(new object[] { Priority.Low, Priority.Normal, Priority.High });
    CmbPriority.SelectedIndex = 1;
    CmbFilter.Items.AddRange(new object[] { "Alle", "Low", "Normal", "High" });
    CmbFilter.SelectedIndex = 0;

    cmdAdd.Click += CmdAdd_Click;
    CmbFilter.SelectedIndexChanged += CmbFilter_SelectedIndexChanged;

    Controls.Add(TxtTitle);
    Controls.Add(CmbPriority);
    Controls.Add(cmdAdd);
    Controls.Add(CmbFilter);
    Controls.Add(LblUrgent);
    Controls.Add(LstTickets);

    RefreshList();
  }

  private void CmdAdd_Click(object sender, EventArgs e)
  {
    string title = TxtTitle.Text.Trim();
    if (title == "")
    {
      MessageBox.Show("Bitte einen Titel eingeben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    Priority priority = (Priority)CmbPriority.SelectedItem;
    TicketStore.Add(new Ticket(title, priority));
    TxtTitle.Clear();
    RefreshList();
  }

  private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
  {
    RefreshList();
  }

  private void RefreshList()
  {
    List<Ticket> tickets;

    if (CmbFilter.SelectedIndex == 0)
    {
      tickets = TicketStore.GetAll();
    }
    else
    {
      // Index 1 → Low, 2 → Normal, 3 → High (enum-Werte 0, 1, 2)
      tickets = TicketStore.GetByPriority((Priority)(CmbFilter.SelectedIndex - 1));
    }

    LstTickets.Items.Clear();
    foreach (Ticket ticket in tickets)
    {
      LstTickets.Items.Add(ticket.ToString());
    }

    LblUrgent.Text = $"Dringende Tickets: {TicketStore.CountByPriority(Priority.High)}";
  }
}

public enum Priority
{
  Low,
  Normal,
  High
}

public static class TicketNumberGenerator
{
  public const string Prefix = "T-";

  // static: EIN Zähler für alle Tickets – sonst würde jedes Ticket bei 1 beginnen
  private static int _counter = 0;

  public static string Next()
  {
    _counter++;
    return Prefix + _counter.ToString("D4");
  }

  public static void Reset()
  {
    _counter = 0;
  }
}

public class Ticket
{
  public Ticket(string title, Priority priority)
  {
    // Die Id gehört zum einzelnen Ticket (Instanz), der Zähler zur Klasse (static)
    Id = TicketNumberGenerator.Next();
    Title = title;
    Priority = priority;
  }

  public string Id { get; }
  public string Title { get; set; }
  public Priority Priority { get; set; }

  public override string ToString()
  {
    return $"{Id} [{Priority}] {Title}";
  }
}

public static class TicketStore
{
  private static readonly List<Ticket> _tickets = new List<Ticket>();

  public static void Add(Ticket ticket)
  {
    _tickets.Add(ticket);
  }

  public static List<Ticket> GetAll()
  {
    return new List<Ticket>(_tickets);
  }

  public static List<Ticket> GetByPriority(Priority priority)
  {
    List<Ticket> result = new List<Ticket>();
    foreach (Ticket ticket in _tickets)
    {
      if (ticket.Priority == priority)
      {
        result.Add(ticket);
      }
    }

    return result;
  }

  public static int CountByPriority(Priority priority)
  {
    return GetByPriority(priority).Count;
  }
}
