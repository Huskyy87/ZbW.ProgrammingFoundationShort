namespace ZbW.ProgrammingFoundationShort.Challenges.Module10.Aufgabe2_TodosUmsetzen;

public sealed class TodosUmsetzenForm : Form
{
  private readonly NumericUpDown NumAge;
  private readonly Label LblResult;

  public TodosUmsetzenForm()
  {
    Text = "TODOs umsetzen – Aufgabe 2";
    ClientSize = new Size(420, 170);

    Label lblAge = new Label { Location = new Point(12, 18), Size = new Size(80, 23), Text = "Alter:" };
    NumAge = new NumericUpDown { Location = new Point(95, 15), Size = new Size(90, 23), Minimum = -1, Maximum = 120, Value = 30 };
    Button cmdEvaluate = new Button { Location = new Point(200, 13), Size = new Size(110, 28), Text = "Bewerten" };
    LblResult = new Label { Location = new Point(12, 65), Size = new Size(390, 60) };

    cmdEvaluate.Click += CmdEvaluate_Click;

    Controls.Add(lblAge);
    Controls.Add(NumAge);
    Controls.Add(cmdEvaluate);
    Controls.Add(LblResult);
  }

  private void CmdEvaluate_Click(object sender, EventArgs e)
  {
    int age = (int)NumAge.Value;
    LblResult.Text = $"Ergebnis: {GetTicketType(age)}";
  }

  public static string GetTicketType(int age)
  {
    if (age < 0)
    {
      return "Ungültig";
    }

    if (age < 6)
    {
      return "Gratis";
    }

    if (age <= 15)
    {
      return "Kinderpreis";
    }

    if (age <= 64)
    {
      return "Normalpreis";
    }

    return "Seniorenpreis";
  }
}