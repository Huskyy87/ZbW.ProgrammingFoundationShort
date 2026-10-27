namespace ZbW.ProgrammingFoundationShort.Challenges.Module08.Aufgabe3_ValidierungsFramework;

public sealed class ValidierungsForm : Form
{
  private readonly TextBox TxtEmail;
  private readonly TextBox TxtAge;
  private readonly TextBox TxtName;
  private readonly TextBox TxtPhone;
  private readonly Label LblResult;

  public ValidierungsForm()
  {
    Text = "Validierungs-Framework – Aufgabe 3";
    ClientSize = new Size(500, 270);

    Label lblName = new Label { Location = new Point(12, 15), Size = new Size(100, 20), Text = "Name:" };
    Label lblEmail = new Label { Location = new Point(12, 50), Size = new Size(100, 20), Text = "E-Mail:" };
    Label lblAge = new Label { Location = new Point(12, 85), Size = new Size(100, 20), Text = "Alter:" };
    Label lblPhone = new Label { Location = new Point(12, 120), Size = new Size(100, 20), Text = "Telefon:" };
    TxtName = new TextBox { Location = new Point(120, 12), Size = new Size(240, 23), Text = "Anna" };
    TxtEmail = new TextBox { Location = new Point(120, 47), Size = new Size(240, 23), Text = "test@zbw.ch" };
    TxtAge = new TextBox { Location = new Point(120, 82), Size = new Size(80, 23), Text = "18" };
    TxtPhone = new TextBox { Location = new Point(120, 117), Size = new Size(160, 23), Text = "+41791234567" };
    Button cmdValidate = new Button { Location = new Point(120, 155), Size = new Size(110, 28), Text = "Prüfen" };
    LblResult = new Label { Location = new Point(12, 195), Size = new Size(460, 60) };

    cmdValidate.Click += CmdValidate_Click;

    Controls.Add(lblName);
    Controls.Add(lblEmail);
    Controls.Add(lblAge);
    Controls.Add(lblPhone);
    Controls.Add(TxtName);
    Controls.Add(TxtEmail);
    Controls.Add(TxtAge);
    Controls.Add(TxtPhone);
    Controls.Add(cmdValidate);
    Controls.Add(LblResult);
  }

  private void CmdValidate_Click(object sender, EventArgs e)
  {
    ResetColors();
    string nameError = "";
    string emailError = "";
    string ageError = "";
    string phoneError = "";

    if (!Validator.IsNotEmpty(TxtName.Text))
    {
      MarkInvalid(TxtName);
      nameError = "Name darf nicht leer sein.";
    }

    if (!Validator.IsValidEmail(TxtEmail.Text))
    {
      MarkInvalid(TxtEmail);
      emailError = "E-Mail ist ungültig.";
    }

    if (!int.TryParse(TxtAge.Text, out int age) || !Validator.IsInRange(age, 16, 120))
    {
      MarkInvalid(TxtAge);
      ageError = "Alter muss zwischen 16 und 120 liegen.";
    }

    if (!Validator.IsValidSwissPhone(TxtPhone.Text))
    {
      MarkInvalid(TxtPhone);
      phoneError = "Telefonnummer ist ungültig.";
    }

    string errors = Validator.CollectErrors(nameError, emailError, ageError, phoneError);
    LblResult.Text = errors == "" ? "Eingabe erfolgreich." : errors;
  }

  private void ResetColors()
  {
    TxtName.BackColor = SystemColors.Window;
    TxtEmail.BackColor = SystemColors.Window;
    TxtAge.BackColor = SystemColors.Window;
    TxtPhone.BackColor = SystemColors.Window;
  }

  private void MarkInvalid(TextBox textBox)
  {
    textBox.BackColor = Color.LightCoral;
  }
}

public static class Validator
{
  public static bool IsNotEmpty(string value)
  {
    return !string.IsNullOrWhiteSpace(value);
  }

  public static bool IsValidEmail(string email)
  {
    if (string.IsNullOrWhiteSpace(email))
    {
      return false;
    }

    int atIndex = email.IndexOf('@');
    int dotIndex = email.IndexOf('.', atIndex + 1);
    return atIndex > 0 && dotIndex > atIndex + 1 && dotIndex < email.Length - 1;
  }

  public static bool IsInRange(int value, int min, int max)
  {
    return value >= min && value <= max;
  }

  public static bool IsPositive(double value)
  {
    return value > 0;
  }

  public static bool IsValidSwissPhone(string phone)
  {
    if (string.IsNullOrWhiteSpace(phone))
    {
      return false;
    }

    // Erlaubt: Ziffern, Leerzeichen und ein + ganz am Anfang – alles andere ist ungültig
    int digitCount = 0;
    for (int i = 0; i < phone.Length; i++)
    {
      char character = phone[i];
      if (char.IsDigit(character))
      {
        digitCount++;
      }
      else if (character == '+' && i == 0)
      {
        continue; // führendes + ist erlaubt
      }
      else if (character != ' ')
      {
        return false;
      }
    }

    bool validPrefix = phone.StartsWith("+41", StringComparison.Ordinal) || phone.StartsWith("0", StringComparison.Ordinal);
    return validPrefix && digitCount >= 10 && digitCount <= 12;
  }

  /// <summary>Gibt eine Fehlermeldung zurück oder "" – params aus Block 05.</summary>
  public static string CollectErrors(params string[] errors)
  {
    string result = "";
    foreach (string error in errors)
    {
      if (error != "")
      {
        result += error + Environment.NewLine;
      }
    }

    return result;
  }
}
