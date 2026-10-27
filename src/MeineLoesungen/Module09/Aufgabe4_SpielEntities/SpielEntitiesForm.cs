namespace ZbW.ProgrammingFoundationShort.Challenges.Module09.Aufgabe4_SpielEntities;

public sealed class SpielEntitiesForm : Form
{
  private readonly ComboBox CmbFirstType;
  private readonly ComboBox CmbSecondType;
  private readonly TextBox TxtFirstName;
  private readonly TextBox TxtSecondName;
  private readonly TextBox TxtFirstValue;
  private readonly TextBox TxtSecondValue;
  private readonly TextBox TxtLog;

  public SpielEntitiesForm()
  {
    Text = "Spiel-Entities – Aufgabe 4";
    ClientSize = new Size(650, 430);

    CmbFirstType = new ComboBox { Location = new Point(95, 12), Size = new Size(120, 23), DropDownStyle = ComboBoxStyle.DropDownList };
    CmbSecondType = new ComboBox { Location = new Point(420, 12), Size = new Size(120, 23), DropDownStyle = ComboBoxStyle.DropDownList };
    TxtFirstName = new TextBox { Location = new Point(95, 45), Size = new Size(120, 23), Text = "Ragnar" };
    TxtSecondName = new TextBox { Location = new Point(420, 45), Size = new Size(120, 23), Text = "Mira" };
    TxtFirstValue = new TextBox { Location = new Point(95, 78), Size = new Size(80, 23), Text = "18" };
    TxtSecondValue = new TextBox { Location = new Point(420, 78), Size = new Size(80, 23), Text = "16" };
    Button cmdFight = new Button { Location = new Point(260, 45), Size = new Size(120, 28), Text = "Kampf starten" };
    TxtLog = new TextBox { Location = new Point(12, 120), Size = new Size(610, 285), Multiline = true, ScrollBars = ScrollBars.Vertical };

    CmbFirstType.Items.AddRange(new object[] { "Warrior", "Mage", "Archer" });
    CmbSecondType.Items.AddRange(new object[] { "Warrior", "Mage", "Archer" });
    CmbFirstType.SelectedIndex = 0;
    CmbSecondType.SelectedIndex = 1;

    cmdFight.Click += CmdFight_Click;

    Controls.Add(new Label { Location = new Point(12, 15), Size = new Size(80, 20), Text = "Charakter 1:" });
    Controls.Add(new Label { Location = new Point(335, 15), Size = new Size(80, 20), Text = "Charakter 2:" });
    Controls.Add(new Label { Location = new Point(12, 48), Size = new Size(80, 20), Text = "Name:" });
    Controls.Add(new Label { Location = new Point(335, 48), Size = new Size(80, 20), Text = "Name:" });
    Controls.Add(new Label { Location = new Point(12, 81), Size = new Size(80, 20), Text = "Wert:" });
    Controls.Add(new Label { Location = new Point(335, 81), Size = new Size(80, 20), Text = "Wert:" });
    Controls.Add(CmbFirstType);
    Controls.Add(CmbSecondType);
    Controls.Add(TxtFirstName);
    Controls.Add(TxtSecondName);
    Controls.Add(TxtFirstValue);
    Controls.Add(TxtSecondValue);
    Controls.Add(cmdFight);
    Controls.Add(TxtLog);
  }

  private void CmdFight_Click(object sender, EventArgs e)
  {
    if (!int.TryParse(TxtFirstValue.Text, out int firstValue) || !int.TryParse(TxtSecondValue.Text, out int secondValue))
    {
      TxtLog.Text = "Bitte Werte als ganze Zahlen eingeben.";
      return;
    }

    if (!IsValidValue(firstValue) || !IsValidValue(secondValue))
    {
      TxtLog.Text = "Alle Werte müssen zwischen 1 und 100 liegen.";
      return;
    }

    GameEntity firstEntity = CreateEntity(CmbFirstType.Text, TxtFirstName.Text, firstValue);
    GameEntity secondEntity = CreateEntity(CmbSecondType.Text, TxtSecondName.Text, secondValue);
    TxtLog.Text = new Battle().SimulateFight(firstEntity, secondEntity);
  }

  // Kleiner, fester Bereich für alle Typen: hält das Spiel überschaubar und verhindert Zahlenüberlauf
  // (z. B. MagicPower * 2 bei sehr grossen Werten)
  private static bool IsValidValue(int value)
  {
    return value >= 1 && value <= 100;
  }

  private GameEntity CreateEntity(string type, string name, int value)
  {
    if (type == "Mage")
    {
      return new Mage { Name = name, MaxHealth = 90, Health = 90, MagicPower = value };
    }

    if (type == "Archer")
    {
      return new Archer { Name = name, MaxHealth = 100, Health = 100, Accuracy = value };
    }

    return new Warrior { Name = name, MaxHealth = 120, Health = 120, Strength = value };
  }
}

public abstract class GameEntity
{
  public string Name { get; set; } = "";
  public int Health { get; set; }
  public int MaxHealth { get; set; }
  public bool IsAlive => Health > 0;

  public virtual void TakeDamage(int damage)
  {
    if (damage < 0)
    {
      throw new ArgumentOutOfRangeException(nameof(damage), "Schaden darf nicht negativ sein.");
    }

    Health = Math.Max(0, Health - damage);
  }

  public abstract int Attack();
}

public sealed class Warrior : GameEntity
{
  private static readonly Random Random = new Random();
  public int Strength { get; set; }

  public override int Attack()
  {
    return Strength + Random.Next(1, 7);
  }
}

public sealed class Mage : GameEntity
{
  private int _attackCounter;
  public int MagicPower { get; set; }

  public override int Attack()
  {
    _attackCounter++;
    return _attackCounter % 2 == 0 ? 0 : MagicPower * 2;
  }
}

public sealed class Archer : GameEntity
{
  public int Accuracy { get; set; }

  public override int Attack()
  {
    return Accuracy > 70 ? 35 : 20;
  }
}

public sealed class Battle
{
  public const int MaxRounds = 100;

  public string SimulateFight(GameEntity firstEntity, GameEntity secondEntity)
  {
    string protokoll = "";
    int round = 1;

    // Rundenlimit: verhindert Endlosschleife, falls beide keinen Schaden machen
    while (firstEntity.IsAlive && secondEntity.IsAlive && round <= MaxRounds)
    {
      int firstDamage = firstEntity.Attack();
      secondEntity.TakeDamage(firstDamage);
      protokoll += $"Runde {round}: {firstEntity.Name} verursacht {firstDamage}. {secondEntity.Name}: {secondEntity.Health}/{secondEntity.MaxHealth}" + Environment.NewLine;

      if (!secondEntity.IsAlive)
      {
        break;
      }

      int secondDamage = secondEntity.Attack();
      firstEntity.TakeDamage(secondDamage);
      protokoll += $"Runde {round}: {secondEntity.Name} verursacht {secondDamage}. {firstEntity.Name}: {firstEntity.Health}/{firstEntity.MaxHealth}" + Environment.NewLine;
      round++;
    }

    if (firstEntity.IsAlive && secondEntity.IsAlive)
    {
      protokoll += $"Unentschieden nach {MaxRounds} Runden.";
      return protokoll;
    }

    string sieger = firstEntity.IsAlive ? firstEntity.Name : secondEntity.Name;
    protokoll += $"{sieger} gewinnt.";
    return protokoll;
  }
}
