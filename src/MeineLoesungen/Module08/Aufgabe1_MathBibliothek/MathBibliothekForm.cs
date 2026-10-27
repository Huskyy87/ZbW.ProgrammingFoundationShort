namespace ZbW.ProgrammingFoundationShort.Challenges.Module08.Aufgabe1_MathBibliothek;

public sealed class MathBibliothekForm : Form
{
  private readonly TextBox TxtNumber;
  private readonly TextBox TxtSecondNumber;
  private readonly RadioButton RadCircleArea;
  private readonly RadioButton RadCircleCircumference;
  private readonly RadioButton RadRectangleArea;
  private readonly RadioButton RadPrime;
  private readonly RadioButton RadFactorial;
  private readonly Label LblResult;

  public MathBibliothekForm()
  {
    Text = "Math-Bibliothek – Aufgabe 1";
    ClientSize = new Size(420, 260);

    TxtNumber = new TextBox { Location = new Point(120, 12), Size = new Size(100, 23), Text = "5" };
    TxtSecondNumber = new TextBox { Location = new Point(120, 45), Size = new Size(100, 23), Text = "3" };
    RadCircleArea = new RadioButton { Location = new Point(12, 85), Size = new Size(150, 24), Text = "Kreisfläche", Checked = true };
    RadCircleCircumference = new RadioButton { Location = new Point(12, 110), Size = new Size(150, 24), Text = "Kreisumfang" };
    RadRectangleArea = new RadioButton { Location = new Point(12, 135), Size = new Size(150, 24), Text = "Rechteckfläche" };
    RadPrime = new RadioButton { Location = new Point(190, 85), Size = new Size(120, 24), Text = "Primzahl" };
    RadFactorial = new RadioButton { Location = new Point(190, 110), Size = new Size(120, 24), Text = "Fakultät" };
    Button cmdCalculate = new Button { Location = new Point(240, 10), Size = new Size(100, 28), Text = "Berechnen" };
    LblResult = new Label { Location = new Point(12, 180), Size = new Size(390, 60) };

    cmdCalculate.Click += CmdCalculate_Click;

    Controls.Add(new Label { Location = new Point(12, 15), Size = new Size(100, 20), Text = "Wert 1:" });
    Controls.Add(new Label { Location = new Point(12, 48), Size = new Size(100, 20), Text = "Wert 2:" });
    Controls.Add(TxtNumber);
    Controls.Add(TxtSecondNumber);
    Controls.Add(RadCircleArea);
    Controls.Add(RadCircleCircumference);
    Controls.Add(RadRectangleArea);
    Controls.Add(RadPrime);
    Controls.Add(RadFactorial);
    Controls.Add(cmdCalculate);
    Controls.Add(LblResult);
  }

  private void CmdCalculate_Click(object sender, EventArgs e)
  {
    if (!double.TryParse(TxtNumber.Text, out double firstValue) || !double.IsFinite(firstValue))
    {
      LblResult.Text = "Bitte Wert 1 als Zahl eingeben.";
      return;
    }

    if (RadCircleArea.Checked)
    {
      LblResult.Text = $"Kreisfläche: {MathHelper.CircleArea(firstValue):F2}";
    }
    else if (RadCircleCircumference.Checked)
    {
      LblResult.Text = $"Kreisumfang: {MathHelper.CircleCircumference(firstValue):F2}";
    }
    else if (RadRectangleArea.Checked)
    {
      if (!double.TryParse(TxtSecondNumber.Text, out double secondValue) || !double.IsFinite(secondValue))
      {
        LblResult.Text = "Bitte Wert 2 als Zahl eingeben.";
        return;
      }

      LblResult.Text = $"Rechteckfläche: {MathHelper.RectangleArea(firstValue, secondValue):F2}";
    }
    else if (RadPrime.Checked)
    {
      // Primzahl nur für ganze Zahlen: int.TryParse statt Cast, sonst würde aus 17.9 still 17
      if (!int.TryParse(TxtNumber.Text, out int number))
      {
        LblResult.Text = "Primzahltest nur für ganze Zahlen.";
        return;
      }

      LblResult.Text = MathHelper.IsPrime(number) ? $"{number} ist prim." : $"{number} ist nicht prim.";
    }
    else if (RadFactorial.Checked)
    {
      if (!int.TryParse(TxtNumber.Text, out int number))
      {
        LblResult.Text = "Fakultät nur für ganze Zahlen.";
        return;
      }

      if (number < 0 || number > 20)
      {
        LblResult.Text = "Fakultät nur für 0 bis 20 möglich.";
        return;
      }

      LblResult.Text = $"{number}! = {MathHelper.Factorial(number)}";
    }
  }
}

public static class MathHelper
{
  public const double Pi = 3.14159265358979;

  public static double CircleArea(double radius)
  {
    return Pi * radius * radius;
  }

  public static double CircleCircumference(double radius)
  {
    return 2 * Pi * radius;
  }

  public static double RectangleArea(double width, double height)
  {
    return width * height;
  }

  public static bool IsPrime(int number)
  {
    if (number < 2)
    {
      return false;
    }

    for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
    {
      if (number % divisor == 0)
      {
        return false;
      }
    }

    return true;
  }

  public static long Factorial(int number)
  {
    // long reicht bis 20!, int nur bis 12!
    if (number < 0 || number > 20)
    {
      throw new ArgumentOutOfRangeException(nameof(number), "Fakultät nur für 0 bis 20 möglich.");
    }

    long result = 1;

    for (int value = 2; value <= number; value++)
    {
      result *= value;
    }

    return result;
  }
}
