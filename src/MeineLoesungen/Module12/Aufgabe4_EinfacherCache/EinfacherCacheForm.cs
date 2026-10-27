namespace ZbW.ProgrammingFoundationShort.Challenges.Module12.Aufgabe4_EinfacherCache;

public sealed class EinfacherCacheForm : Form
{
  private readonly TextBox TxtKey;
  private readonly TextBox TxtValue;
  private readonly ListBox LstOutput;
  private readonly SimpleCache _cache = new SimpleCache(3);

  public EinfacherCacheForm()
  {
    Text = "Einfacher Cache – Aufgabe 4";
    ClientSize = new Size(720, 400);

    Controls.Add(new Label { Location = new Point(12, 18), Size = new Size(90, 20), Text = "Key:" });
    Controls.Add(new Label { Location = new Point(12, 55), Size = new Size(90, 20), Text = "Value:" });

    TxtKey = new TextBox { Location = new Point(105, 15), Size = new Size(160, 23), Text = "A" };
    TxtValue = new TextBox { Location = new Point(105, 52), Size = new Size(160, 23), Text = "Alpha" };
    Button cmdAdd = new Button { Location = new Point(285, 13), Size = new Size(100, 28), Text = "Speichern" };
    Button cmdRead = new Button { Location = new Point(395, 13), Size = new Size(100, 28), Text = "Lesen" };
    Button cmdDemo = new Button { Location = new Point(505, 13), Size = new Size(120, 28), Text = "Demo füllen" };
    LstOutput = new ListBox { Location = new Point(12, 100), Size = new Size(680, 250) };

    cmdAdd.Click += CmdAdd_Click;
    cmdRead.Click += CmdRead_Click;
    cmdDemo.Click += CmdDemo_Click;

    Controls.Add(TxtKey);
    Controls.Add(TxtValue);
    Controls.Add(cmdAdd);
    Controls.Add(cmdRead);
    Controls.Add(cmdDemo);
    Controls.Add(LstOutput);
  }

  private void CmdAdd_Click(object sender, EventArgs e)
  {
    _cache.Set(TxtKey.Text, TxtValue.Text);
    ShowCache($"Gespeichert: {TxtKey.Text}");
  }

  private void CmdRead_Click(object sender, EventArgs e)
  {
    string message = _cache.TryGet(TxtKey.Text, out string? value)
      ? $"Gefunden: {TxtKey.Text} = {value}"
      : $"Nicht gefunden: {TxtKey.Text}";

    ShowCache(message);
  }

  private void CmdDemo_Click(object sender, EventArgs e)
  {
    _cache.Set("A", "Alpha");
    _cache.Set("B", "Beta");
    _cache.Set("C", "Gamma");
    _cache.Set("D", "Delta");
    ShowCache("Demo: A wurde entfernt, weil der Cache nur 3 Einträge behält.");
  }

  private void ShowCache(string message)
  {
    LstOutput.Items.Clear();
    LstOutput.Items.Add(message);
    LstOutput.Items.Add("Cache-Inhalt:");

    foreach (KeyValuePair<string, string> item in _cache.Items)
    {
      LstOutput.Items.Add($"  {item.Key}: {item.Value}");
    }

    LstOutput.Items.Add("Datenstrukturen: Dictionary für schnellen Zugriff, Queue für die Einfüge-Reihenfolge.");
  }
}

public sealed class SimpleCache
{
  private readonly int _capacity;
  private readonly Dictionary<string, string> values = new Dictionary<string, string>();
  private readonly Queue<string> _insertionOrder = new Queue<string>();

  public SimpleCache(int capacity)
  {
    if (capacity <= 0)
    {
      throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity muss positiv sein.");
    }

    _capacity = capacity;
  }

  public IReadOnlyDictionary<string, string> Items => values;

  public void Set(string key, string value)
  {
    if (values.ContainsKey(key))
    {
      values[key] = value;
      return;
    }

    if (values.Count >= _capacity)
    {
      string oldestKey = _insertionOrder.Dequeue();
      values.Remove(oldestKey);
    }

    values[key] = value;
    _insertionOrder.Enqueue(key);
  }

  public bool TryGet(string key, out string? value)
  {
    return values.TryGetValue(key, out value);
  }
}
