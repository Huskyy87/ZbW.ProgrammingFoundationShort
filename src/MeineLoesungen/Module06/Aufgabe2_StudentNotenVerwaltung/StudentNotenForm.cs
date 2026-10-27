namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe2_StudentNotenVerwaltung;

/// <summary>
///   Aufgabe 2 – Student-Notenverwaltung (⭐⭐ Mittel)
/// </summary>
public partial class StudentNotenForm : Form
{
  private readonly List<Student> _studenten = new();
  private Student? _aktuellerStudent;

  public StudentNotenForm()
  {
    InitializeComponent();
  }

  private void CmdNeuerStudent_Click(object sender, EventArgs e)
  {
    if (string.IsNullOrWhiteSpace(TxtName.Text) || !int.TryParse(TxtStudentId.Text, out int studentId))
    {
      MessageBox.Show("Bitte Name und eine Matrikelnummer (Zahl) eingeben.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    _aktuellerStudent = new Student(TxtName.Text.Trim(), studentId);

    _studenten.Add(_aktuellerStudent);
    AktualisiereStudentListe();
    LblStats.Text = $"Student: {_aktuellerStudent.Name} – bereit für Noten";
    TxtName.Clear(); TxtStudentId.Clear();
  }

  private void CmdNoteHinzufuegen_Click(object sender, EventArgs e)
  {
    if (_aktuellerStudent == null)
    {
      MessageBox.Show("Bitte zuerst einen Studenten erstellen.",
        "Kein Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (!double.TryParse(TxtNote.Text, out double note))
    {
      MessageBox.Show("Bitte eine gültige Note eingeben.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    try
    {
      _aktuellerStudent.AddNote(note);
      LblStats.Text = $"{_aktuellerStudent.Name}: Ø {_aktuellerStudent.GetAverage():F2} | " +
                      $"Beste: {_aktuellerStudent.GetBestNote():F1} | " +
                      $"Schlechteste: {_aktuellerStudent.GetWorstNote():F1} | " +
                      $"Anzahl: {_aktuellerStudent.NoteCount}";
      AktualisiereStudentListe();
      TxtNote.Clear();
    }
    catch (ArgumentOutOfRangeException ex)
    {
      MessageBox.Show(ex.Message, "Ungültige Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
  }

  private void AktualisiereStudentListe()
  {
    LstStudenten.Items.Clear();
    foreach (var s in _studenten)
    {
      LstStudenten.Items.Add(s.ToString());
    }
  }
}
