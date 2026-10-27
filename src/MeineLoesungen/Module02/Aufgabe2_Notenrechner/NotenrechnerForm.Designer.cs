namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe2_Notenrechner;

partial class NotenrechnerForm
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
    LblNote = new Label();
    TxtNote = new TextBox();
    ChkDetails = new CheckBox();
    CmdBewerten = new Button();
    LblErgebnis = new Label();
    SuspendLayout();

    // LblNote
    LblNote.AutoSize = true;
    LblNote.Location = new Point(12, 20);
    LblNote.Text = "Note (1.0–6.0):";

    // TxtNote
    TxtNote.Location = new Point(140, 17);
    TxtNote.Name = "TxtNote";
    TxtNote.Size = new Size(80, 23);

    // ChkDetails
    ChkDetails.AutoSize = true;
    ChkDetails.Location = new Point(12, 50);
    ChkDetails.Name = "ChkDetails";
    ChkDetails.Text = "Details anzeigen (Prozentwert)";

    // CmdBewerten
    CmdBewerten.Location = new Point(12, 80);
    CmdBewerten.Name = "CmdBewerten";
    CmdBewerten.Size = new Size(120, 28);
    CmdBewerten.Text = "Bewerten";
    CmdBewerten.Click += CmdBewerten_Click;

    // LblErgebnis
    LblErgebnis.AutoSize = true;
    LblErgebnis.Location = new Point(12, 120);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Text = "";

    // NotenrechnerForm
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(320, 170);
    Controls.Add(LblNote);
    Controls.Add(TxtNote);
    Controls.Add(ChkDetails);
    Controls.Add(CmdBewerten);
    Controls.Add(LblErgebnis);
    Name = "NotenrechnerForm";
    Text = "Notenrechner – Aufgabe 2";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblNote;
  private TextBox TxtNote;
  private CheckBox ChkDetails;
  private Button CmdBewerten;
  private Label LblErgebnis;
}
