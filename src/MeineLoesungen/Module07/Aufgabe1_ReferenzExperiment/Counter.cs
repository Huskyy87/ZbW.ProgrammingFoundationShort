namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe1_ReferenzExperiment;

/// <summary>Einfacher Counter als Referenztyp für das Experiment.</summary>
public class Counter
{
  public int Value { get; set; }

  public Counter(int value) { Value = value; }

  public override string ToString() => $"Counter({Value})";
}
