namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe2_StudentNotenVerwaltung;

partial class StudentNotenForm
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    LblName = new Label(); TxtName = new TextBox();
    LblStudentId = new Label(); TxtStudentId = new TextBox();
    CmdNeuerStudent = new Button();
    LblNote = new Label(); TxtNote = new TextBox(); CmdNoteHinzufuegen = new Button();
    LblStats = new Label(); LstStudenten = new ListBox();
    SuspendLayout();

    LblName.AutoSize = true; LblName.Location = new Point(12, 15); LblName.Text = "Name:";
    TxtName.Location = new Point(80, 12); TxtName.Name = "TxtName"; TxtName.Size = new Size(150, 23);
    LblStudentId.AutoSize = true; LblStudentId.Location = new Point(245, 15); LblStudentId.Text = "Matrikel-Nr:";
    TxtStudentId.Location = new Point(330, 12); TxtStudentId.Name = "TxtStudentId"; TxtStudentId.Size = new Size(90, 23);
    CmdNeuerStudent.Location = new Point(12, 45); CmdNeuerStudent.Name = "CmdNeuerStudent"; CmdNeuerStudent.Size = new Size(130, 25); CmdNeuerStudent.Text = "Neuer Student"; CmdNeuerStudent.Click += CmdNeuerStudent_Click;
    LblNote.AutoSize = true; LblNote.Location = new Point(12, 85); LblNote.Text = "Note (1.0–6.0):";
    TxtNote.Location = new Point(120, 82); TxtNote.Name = "TxtNote"; TxtNote.Size = new Size(70, 23);
    CmdNoteHinzufuegen.Location = new Point(200, 81); CmdNoteHinzufuegen.Name = "CmdNoteHinzufuegen"; CmdNoteHinzufuegen.Size = new Size(120, 25); CmdNoteHinzufuegen.Text = "Note hinzufügen"; CmdNoteHinzufuegen.Click += CmdNoteHinzufuegen_Click;
    LblStats.AutoSize = true; LblStats.Location = new Point(12, 120); LblStats.Name = "LblStats"; LblStats.Text = "";
    LstStudenten.Location = new Point(12, 145); LstStudenten.Name = "LstStudenten"; LstStudenten.Size = new Size(430, 150);

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(460, 315);
    Controls.Add(LblName); Controls.Add(TxtName); Controls.Add(LblStudentId); Controls.Add(TxtStudentId);
    Controls.Add(CmdNeuerStudent); Controls.Add(LblNote); Controls.Add(TxtNote); Controls.Add(CmdNoteHinzufuegen);
    Controls.Add(LblStats); Controls.Add(LstStudenten);
    Name = "StudentNotenForm"; Text = "Student-Notenverwaltung – Aufgabe 2";
    ResumeLayout(false); PerformLayout();
  }

  private Label LblName; private TextBox TxtName;
  private Label LblStudentId; private TextBox TxtStudentId;
  private Button CmdNeuerStudent;
  private Label LblNote; private TextBox TxtNote; private Button CmdNoteHinzufuegen;
  private Label LblStats; private ListBox LstStudenten;
}
