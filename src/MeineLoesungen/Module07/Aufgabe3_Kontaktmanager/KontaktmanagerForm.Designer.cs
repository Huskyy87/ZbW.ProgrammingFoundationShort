namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe3_Kontaktmanager;

partial class KontaktmanagerForm
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
    LblFirst = new Label(); TxtFirst = new TextBox();
    LblLast = new Label(); TxtLast = new TextBox();
    LblPhone = new Label(); TxtPhone = new TextBox();
    LblEmail = new Label(); TxtEmail = new TextBox();
    LblBirthday = new Label(); TxtBirthday = new TextBox();
    CmdHinzufuegen = new Button(); CmdLoeschen = new Button();
    LblSuche = new Label(); TxtSuche = new TextBox();
    CmdSuchen = new Button(); CmdAlleAnzeigen = new Button();
    TxtAusgabe = new TextBox();
    SuspendLayout();

    LblFirst.AutoSize = true; LblFirst.Location = new Point(12, 15); LblFirst.Text = "Vorname:";
    TxtFirst.Location = new Point(85, 12); TxtFirst.Name = "TxtFirst"; TxtFirst.Size = new Size(110, 23);
    LblLast.AutoSize = true; LblLast.Location = new Point(205, 15); LblLast.Text = "Nachname:";
    TxtLast.Location = new Point(275, 12); TxtLast.Name = "TxtLast"; TxtLast.Size = new Size(110, 23);
    LblPhone.AutoSize = true; LblPhone.Location = new Point(12, 45); LblPhone.Text = "Telefon:";
    TxtPhone.Location = new Point(85, 42); TxtPhone.Name = "TxtPhone"; TxtPhone.Size = new Size(110, 23);
    LblEmail.AutoSize = true; LblEmail.Location = new Point(205, 45); LblEmail.Text = "E-Mail:";
    TxtEmail.Location = new Point(255, 42); TxtEmail.Name = "TxtEmail"; TxtEmail.Size = new Size(140, 23);
    LblBirthday.AutoSize = true; LblBirthday.Location = new Point(12, 75); LblBirthday.Text = "Geburtstag:";
    TxtBirthday.Location = new Point(95, 72); TxtBirthday.Name = "TxtBirthday"; TxtBirthday.Size = new Size(100, 23);

    CmdHinzufuegen.Location = new Point(12, 105); CmdHinzufuegen.Name = "CmdHinzufuegen"; CmdHinzufuegen.Size = new Size(110, 25); CmdHinzufuegen.Text = "Hinzufügen"; CmdHinzufuegen.Click += CmdHinzufuegen_Click;
    CmdLoeschen.Location = new Point(130, 105); CmdLoeschen.Name = "CmdLoeschen"; CmdLoeschen.Size = new Size(150, 25); CmdLoeschen.Text = "Löschen (per Telefon)"; CmdLoeschen.Click += CmdLoeschen_Click;

    LblSuche.AutoSize = true; LblSuche.Location = new Point(12, 145); LblSuche.Text = "Suche:";
    TxtSuche.Location = new Point(65, 142); TxtSuche.Name = "TxtSuche"; TxtSuche.Size = new Size(150, 23);
    CmdSuchen.Location = new Point(225, 141); CmdSuchen.Name = "CmdSuchen"; CmdSuchen.Size = new Size(75, 25); CmdSuchen.Text = "Suchen"; CmdSuchen.Click += CmdSuchen_Click;
    CmdAlleAnzeigen.Location = new Point(308, 141); CmdAlleAnzeigen.Name = "CmdAlleAnzeigen"; CmdAlleAnzeigen.Size = new Size(90, 25); CmdAlleAnzeigen.Text = "Alle zeigen"; CmdAlleAnzeigen.Click += CmdAlleAnzeigen_Click;

    TxtAusgabe.Location = new Point(12, 178); TxtAusgabe.Multiline = true; TxtAusgabe.Name = "TxtAusgabe";
    TxtAusgabe.ReadOnly = true; TxtAusgabe.ScrollBars = ScrollBars.Vertical; TxtAusgabe.Size = new Size(470, 140);

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(500, 335);
    Controls.Add(LblFirst); Controls.Add(TxtFirst); Controls.Add(LblLast); Controls.Add(TxtLast);
    Controls.Add(LblPhone); Controls.Add(TxtPhone); Controls.Add(LblEmail); Controls.Add(TxtEmail);
    Controls.Add(LblBirthday); Controls.Add(TxtBirthday); Controls.Add(CmdHinzufuegen); Controls.Add(CmdLoeschen);
    Controls.Add(LblSuche); Controls.Add(TxtSuche); Controls.Add(CmdSuchen); Controls.Add(CmdAlleAnzeigen);
    Controls.Add(TxtAusgabe);
    Name = "KontaktmanagerForm"; Text = "Kontaktmanager – UI, Logik, Daten";
    ResumeLayout(false); PerformLayout();
  }

  private Label LblFirst; private TextBox TxtFirst;
  private Label LblLast; private TextBox TxtLast;
  private Label LblPhone; private TextBox TxtPhone;
  private Label LblEmail; private TextBox TxtEmail;
  private Label LblBirthday; private TextBox TxtBirthday;
  private Button CmdHinzufuegen; private Button CmdLoeschen;
  private Label LblSuche; private TextBox TxtSuche;
  private Button CmdSuchen; private Button CmdAlleAnzeigen;
  private TextBox TxtAusgabe;
}

