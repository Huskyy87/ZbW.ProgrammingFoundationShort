namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe2_StudentNotenVerwaltung;

/// <summary>
///   Student-Klasse mit Notenverwaltung.
/// </summary>
public class Student
{
  private readonly List<double> _noten = new();

  public Student(string name, int studentId)
  {
    Name = name;
    StudentId = studentId;
  }

  public string Name { get; set; }
  public int StudentId { get; set; }
  public int NoteCount => _noten.Count;

  public void AddNote(double note)
  {
    // IsNaN: NaN ist weder < 1.0 noch > 6.0 und würde sonst durchrutschen
    if (double.IsNaN(note) || note < 1.0 || note > 6.0)
    {
      throw new ArgumentOutOfRangeException(nameof(note), "Note muss zwischen 1.0 und 6.0 liegen.");
    }

    _noten.Add(note);
  }

  public double GetAverage()
  {
    if (_noten.Count == 0)
    {
      return 0;
    }

    double sum = 0;
    foreach (double n in _noten)
    {
      sum += n;
    }

    return sum / _noten.Count;
  }

  public double GetBestNote()
  {
    if (_noten.Count == 0)
    {
      return 0;
    }

    double best = _noten[0];
    foreach (double n in _noten)
    {
      if (n > best)
      {
        best = n;
      }
    }

    return best;
  }

  public double GetWorstNote()
  {
    if (_noten.Count == 0)
    {
      return 0;
    }

    double worst = _noten[0];
    foreach (double n in _noten)
    {
      if (n < worst)
      {
        worst = n;
      }
    }

    return worst;
  }

  public override string ToString()
  {
    return $"{StudentId} – {Name} ({NoteCount} Noten, Ø {GetAverage():F2})";
  }
}
