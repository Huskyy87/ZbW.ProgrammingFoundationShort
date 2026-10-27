namespace ZbW.ProgrammingFoundationShort.Challenges.Module09.Aufgabe3_MitarbeiterHierarchie;

public sealed class MitarbeiterForm : Form
{
  private readonly List<Employee> _employees = new List<Employee>();
  private readonly ComboBox CmbType;
  private readonly TextBox TxtName;
  private readonly TextBox TxtBaseSalary;
  private readonly TextBox TxtExtra;
  private readonly TextBox TxtTeamSize;
  private readonly ListBox LstEmployees;
  private readonly Label LblTotal;

  public MitarbeiterForm()
  {
    Text = "Mitarbeiter-Hierarchie – Aufgabe 3";
    ClientSize = new Size(650, 390);

    CmbType = new ComboBox { Location = new Point(120, 12), Size = new Size(180, 23), DropDownStyle = ComboBoxStyle.DropDownList };
    CmbType.Items.AddRange(new object[] { "FullTime", "PartTime", "Manager" });
    CmbType.SelectedIndex = 0;
    TxtName = new TextBox { Location = new Point(120, 45), Size = new Size(180, 23), Text = "Anna" };
    TxtBaseSalary = new TextBox { Location = new Point(120, 78), Size = new Size(100, 23), Text = "8000" };
    TxtExtra = new TextBox { Location = new Point(120, 111), Size = new Size(180, 23), Text = "10" };
    TxtTeamSize = new TextBox { Location = new Point(120, 144), Size = new Size(80, 23), Text = "5" };
    Button cmdAdd = new Button { Location = new Point(120, 180), Size = new Size(120, 28), Text = "Hinzufügen" };
    LstEmployees = new ListBox { Location = new Point(330, 12), Size = new Size(300, 300) };
    LblTotal = new Label { Location = new Point(330, 325), Size = new Size(300, 35) };

    Controls.Add(new Label { Location = new Point(12, 15), Size = new Size(100, 20), Text = "Typ:" });
    Controls.Add(new Label { Location = new Point(12, 48), Size = new Size(100, 20), Text = "Name:" });
    Controls.Add(new Label { Location = new Point(12, 81), Size = new Size(100, 20), Text = "Basislohn:" });
    Controls.Add(new Label { Location = new Point(12, 114), Size = new Size(100, 20), Text = "Bonus/Std/Team:" });
    Controls.Add(new Label { Location = new Point(12, 147), Size = new Size(100, 20), Text = "Teamgrösse:" });
    Controls.Add(CmbType);
    Controls.Add(TxtName);
    Controls.Add(TxtBaseSalary);
    Controls.Add(TxtExtra);
    Controls.Add(TxtTeamSize);
    Controls.Add(cmdAdd);
    Controls.Add(LstEmployees);
    Controls.Add(LblTotal);

    cmdAdd.Click += CmdAdd_Click;
  }

  private void CmdAdd_Click(object sender, EventArgs e)
  {
    if (!decimal.TryParse(TxtBaseSalary.Text, out decimal baseSalary) || baseSalary <= 0)
    {
      LblTotal.Text = "Basislohn muss eine positive Zahl sein.";
      return;
    }

    // IsFinite: NaN/Unendlich würden später bei der Umrechnung in decimal abstürzen
    if (!double.TryParse(TxtExtra.Text, out double extra) || !double.IsFinite(extra) || extra < 0 || extra > 1000)
    {
      LblTotal.Text = "Bonus/Std/Team: Zahl zwischen 0 und 1000 eingeben.";
      return;
    }

    Employee employee;

    if (CmbType.SelectedItem?.ToString() == "Manager")
    {
      if (!int.TryParse(TxtTeamSize.Text, out int teamSize) || teamSize < 0)
      {
        LblTotal.Text = "Teamgrösse muss eine ganze Zahl ab 0 sein.";
        return;
      }

      employee = new Manager(TxtName.Text, _employees.Count + 1, baseSalary, extra, teamSize);
    }
    else if (CmbType.SelectedItem?.ToString() == "PartTime")
    {
      employee = new PartTimeEmployee(TxtName.Text, _employees.Count + 1, (int)extra, baseSalary);
    }
    else
    {
      employee = new FullTimeEmployee(TxtName.Text, _employees.Count + 1, baseSalary, extra);
    }

    _employees.Add(employee);
    RefreshEmployees();
  }

  private void RefreshEmployees()
  {
    LstEmployees.Items.Clear();
    decimal total = 0;

    foreach (Employee employee in _employees)
    {
      total += employee.CalculateSalary();
      LstEmployees.Items.Add(employee.GetEmployeeInfo());
    }

    LblTotal.Text = $"Gesamtlohnkosten: {total:F2} CHF";
  }
}

public class Employee
{
  public Employee(string name, int id, decimal baseSalary)
  {
    Name = name;
    Id = id;
    BaseSalary = baseSalary;
  }

  public string Name { get; set; }
  public int Id { get; set; }
  protected decimal BaseSalary { get; set; }

  public virtual decimal CalculateSalary()
  {
    return BaseSalary;
  }

  public virtual string GetEmployeeInfo()
  {
    return $"{Id}: {Name}, Gehalt {CalculateSalary():F2} CHF";
  }
}

public class FullTimeEmployee : Employee
{
  public FullTimeEmployee(string name, int id, decimal baseSalary, double bonusPercent)
    : base(name, id, baseSalary)
  {
    BonusPercent = bonusPercent;
  }

  public double BonusPercent { get; set; }

  public override decimal CalculateSalary()
  {
    return BaseSalary * (1 + (decimal)BonusPercent / 100);
  }
}

public sealed class PartTimeEmployee : Employee
{
  public PartTimeEmployee(string name, int id, int hoursPerWeek, decimal hourlyRate)
    : base(name, id, 0)
  {
    HoursPerWeek = hoursPerWeek;
    HourlyRate = hourlyRate;
  }

  public int HoursPerWeek { get; set; }
  public decimal HourlyRate { get; set; }

  public override decimal CalculateSalary()
  {
    return HoursPerWeek * 4.33m * HourlyRate;
  }
}

public sealed class Manager : FullTimeEmployee
{
  public Manager(string name, int id, decimal baseSalary, double bonusPercent, int teamSize)
    : base(name, id, baseSalary, bonusPercent)
  {
    TeamSize = teamSize;
  }

  public int TeamSize { get; set; }

  public override decimal CalculateSalary()
  {
    return base.CalculateSalary() + TeamSize * 500m;
  }
}
