namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe4_TaschenrechnerVerlauf;

partial class TaschenrechnerVerlaufForm
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
    LblZahl1 = new Label();
    TxtZahl1 = new TextBox();
    LblZahl2 = new Label();
    TxtZahl2 = new TextBox();
    GrpOp = new GroupBox();
    RadPlus = new RadioButton();
    RadMinus = new RadioButton();
    RadMal = new RadioButton();
    RadDiv = new RadioButton();
    CmdBerechnen = new Button();
    LblErgebnis = new Label();
    LblVerlauf = new Label();
    TxtVerlauf = new TextBox();
    GrpOp.SuspendLayout();
    SuspendLayout();

    LblZahl1.AutoSize = true;
    LblZahl1.Location = new Point(12, 20);
    LblZahl1.Text = "Zahl 1:";

    TxtZahl1.Location = new Point(90, 17);
    TxtZahl1.Name = "TxtZahl1";
    TxtZahl1.Size = new Size(100, 23);

    LblZahl2.AutoSize = true;
    LblZahl2.Location = new Point(12, 50);
    LblZahl2.Text = "Zahl 2:";

    TxtZahl2.Location = new Point(90, 47);
    TxtZahl2.Name = "TxtZahl2";
    TxtZahl2.Size = new Size(100, 23);

    GrpOp.Location = new Point(12, 80);
    GrpOp.Name = "GrpOp";
    GrpOp.Size = new Size(280, 40);
    GrpOp.Text = "Operation";
    GrpOp.Controls.Add(RadPlus);
    GrpOp.Controls.Add(RadMinus);
    GrpOp.Controls.Add(RadMal);
    GrpOp.Controls.Add(RadDiv);

    RadPlus.AutoSize = true;
    RadPlus.Checked = true;
    RadPlus.Location = new Point(10, 15);
    RadPlus.Name = "RadPlus";
    RadPlus.Text = "+";

    RadMinus.AutoSize = true;
    RadMinus.Location = new Point(60, 15);
    RadMinus.Name = "RadMinus";
    RadMinus.Text = "-";

    RadMal.AutoSize = true;
    RadMal.Location = new Point(110, 15);
    RadMal.Name = "RadMal";
    RadMal.Text = "×";

    RadDiv.AutoSize = true;
    RadDiv.Location = new Point(160, 15);
    RadDiv.Name = "RadDiv";
    RadDiv.Text = "÷";

    CmdBerechnen.Location = new Point(12, 130);
    CmdBerechnen.Name = "CmdBerechnen";
    CmdBerechnen.Size = new Size(120, 28);
    CmdBerechnen.Text = "Berechnen";
    CmdBerechnen.Click += CmdBerechnen_Click;

    LblErgebnis.AutoSize = true;
    LblErgebnis.Location = new Point(145, 135);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
    LblErgebnis.Text = "";

    LblVerlauf.AutoSize = true;
    LblVerlauf.Location = new Point(12, 170);
    LblVerlauf.Text = "Verlauf:";

    TxtVerlauf.Location = new Point(12, 188);
    TxtVerlauf.Multiline = true;
    TxtVerlauf.Name = "TxtVerlauf";
    TxtVerlauf.ReadOnly = true;
    TxtVerlauf.ScrollBars = ScrollBars.Vertical;
    TxtVerlauf.Size = new Size(360, 120);

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(390, 325);
    Controls.Add(LblZahl1);
    Controls.Add(TxtZahl1);
    Controls.Add(LblZahl2);
    Controls.Add(TxtZahl2);
    Controls.Add(GrpOp);
    Controls.Add(CmdBerechnen);
    Controls.Add(LblErgebnis);
    Controls.Add(LblVerlauf);
    Controls.Add(TxtVerlauf);
    Name = "TaschenrechnerVerlaufForm";
    Text = "Taschenrechner mit Verlauf – Aufgabe 4";
    GrpOp.ResumeLayout(false);
    GrpOp.PerformLayout();
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblZahl1;
  private TextBox TxtZahl1;
  private Label LblZahl2;
  private TextBox TxtZahl2;
  private GroupBox GrpOp;
  private RadioButton RadPlus;
  private RadioButton RadMinus;
  private RadioButton RadMal;
  private RadioButton RadDiv;
  private Button CmdBerechnen;
  private Label LblErgebnis;
  private Label LblVerlauf;
  private TextBox TxtVerlauf;
}
