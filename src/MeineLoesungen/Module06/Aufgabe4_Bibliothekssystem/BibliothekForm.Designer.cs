namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe4_Bibliothekssystem;

partial class BibliothekForm
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
    LblTitle = new Label(); TxtTitle = new TextBox();
    LblAuthor = new Label(); TxtAuthor = new TextBox();
    LblISBN = new Label(); TxtISBN = new TextBox();
    CmdHinzufuegen = new Button(); CmdLeihen = new Button();
    CmdZurueckgeben = new Button(); CmdSuchen = new Button();
    LstBuecher = new ListBox(); LblStatus = new Label();
    SuspendLayout();

    LblTitle.AutoSize = true; LblTitle.Location = new Point(12, 15); LblTitle.Text = "Titel:";
    TxtTitle.Location = new Point(70, 12); TxtTitle.Name = "TxtTitle"; TxtTitle.Size = new Size(200, 23);
    LblAuthor.AutoSize = true; LblAuthor.Location = new Point(280, 15); LblAuthor.Text = "Autor:";
    TxtAuthor.Location = new Point(325, 12); TxtAuthor.Name = "TxtAuthor"; TxtAuthor.Size = new Size(150, 23);
    LblISBN.AutoSize = true; LblISBN.Location = new Point(12, 45); LblISBN.Text = "ISBN:";
    TxtISBN.Location = new Point(70, 42); TxtISBN.Name = "TxtISBN"; TxtISBN.Size = new Size(150, 23);

    CmdHinzufuegen.Location = new Point(12, 75); CmdHinzufuegen.Name = "CmdHinzufuegen"; CmdHinzufuegen.Size = new Size(105, 25); CmdHinzufuegen.Text = "Hinzufügen"; CmdHinzufuegen.Click += CmdHinzufuegen_Click;
    CmdLeihen.Location = new Point(125, 75); CmdLeihen.Name = "CmdLeihen"; CmdLeihen.Size = new Size(75, 25); CmdLeihen.Text = "Leihen"; CmdLeihen.Click += CmdLeihen_Click;
    CmdZurueckgeben.Location = new Point(208, 75); CmdZurueckgeben.Name = "CmdZurueckgeben"; CmdZurueckgeben.Size = new Size(110, 25); CmdZurueckgeben.Text = "Zurückgeben"; CmdZurueckgeben.Click += CmdZurueckgeben_Click;
    CmdSuchen.Location = new Point(326, 75); CmdSuchen.Name = "CmdSuchen"; CmdSuchen.Size = new Size(80, 25); CmdSuchen.Text = "Suchen"; CmdSuchen.Click += CmdSuchen_Click;

    LstBuecher.Location = new Point(12, 110); LstBuecher.Name = "LstBuecher"; LstBuecher.Size = new Size(480, 170);
    LblStatus.AutoSize = true; LblStatus.Location = new Point(12, 292); LblStatus.Name = "LblStatus"; LblStatus.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(510, 320);
    Controls.Add(LblTitle); Controls.Add(TxtTitle); Controls.Add(LblAuthor); Controls.Add(TxtAuthor);
    Controls.Add(LblISBN); Controls.Add(TxtISBN);
    Controls.Add(CmdHinzufuegen); Controls.Add(CmdLeihen); Controls.Add(CmdZurueckgeben); Controls.Add(CmdSuchen);
    Controls.Add(LstBuecher); Controls.Add(LblStatus);
    Name = "BibliothekForm"; Text = "Bibliothekssystem – Aufgabe 4";
    ResumeLayout(false); PerformLayout();
  }

  private Label LblTitle; private TextBox TxtTitle;
  private Label LblAuthor; private TextBox TxtAuthor;
  private Label LblISBN; private TextBox TxtISBN;
  private Button CmdHinzufuegen; private Button CmdLeihen;
  private Button CmdZurueckgeben; private Button CmdSuchen;
  private ListBox LstBuecher; private Label LblStatus;
}
