namespace ZbW.ProgrammingFoundationShort.Challenges.Module11.Aufgabe4_FibonacciMemoization;

public sealed class FibonacciMemoizationForm : Form
{
  private readonly NumericUpDown NumN;
  private readonly ListBox LstOutput;

  public FibonacciMemoizationForm()
  {
    Text = "Fibonacci mit Memoization – Aufgabe 4";
    ClientSize = new Size(680, 360);

    Controls.Add(new Label { Location = new Point(12, 18), Size = new Size(80, 20), Text = "n:" });

    NumN = new NumericUpDown { Location = new Point(95, 15), Size = new Size(80, 23), Minimum = 0, Maximum = 35, Value = 30 };
    Button cmdCompare = new Button { Location = new Point(195, 13), Size = new Size(140, 28), Text = "Vergleichen" };
    LstOutput = new ListBox { Location = new Point(12, 60), Size = new Size(640, 250) };

    cmdCompare.Click += CmdCompare_Click;

    Controls.Add(NumN);
    Controls.Add(cmdCompare);
    Controls.Add(LstOutput);
  }

  private void CmdCompare_Click(object sender, EventArgs e)
  {
    int n = (int)NumN.Value;

    CountedResult slow = FibonacciRecursiveSlow(n);
    CountedResult memoized = FibonacciMemoized(n);

    LstOutput.Items.Clear();
    LstOutput.Items.Add($"Fibonacci({n}) = {memoized.Value}");
    LstOutput.Items.Add($"Naive Rekursion: {slow.Calls:N0} Aufrufe");
    LstOutput.Items.Add($"Memoization: {memoized.Calls:N0} Aufrufe");
    LstOutput.Items.Add("Merksatz: Memoization speichert bereits berechnete Teilprobleme.");
  }

  public static CountedResult FibonacciRecursiveSlow(int n)
  {
    long calls = 0;
    long value = Calculate(n);
    return new CountedResult(value, calls);

    long Calculate(int value)
    {
      calls++;

      if (value <= 1)
      {
        return value;
      }

      return Calculate(value - 1) + Calculate(value - 2);
    }
  }

  public static CountedResult FibonacciMemoized(int n)
  {
    long calls = 0;
    Dictionary<int, long> cache = new Dictionary<int, long>();
    long value = Calculate(n);
    return new CountedResult(value, calls);

    long Calculate(int value)
    {
      calls++;

      if (value <= 1)
      {
        return value;
      }

      if (cache.TryGetValue(value, out long cached))
      {
        return cached;
      }

      long result = Calculate(value - 1) + Calculate(value - 2);
      cache[value] = result;
      return result;
    }
  }
}

public readonly record struct CountedResult(long Value, long Calls);
