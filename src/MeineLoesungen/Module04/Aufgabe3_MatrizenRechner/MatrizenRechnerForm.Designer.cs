namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe3_MatrizenRechner;

partial class MatrizenRechnerForm
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
    LblA = new Label();
    TxtA00 = new TextBox(); TxtA01 = new TextBox(); TxtA02 = new TextBox();
    TxtA10 = new TextBox(); TxtA11 = new TextBox(); TxtA12 = new TextBox();
    TxtA20 = new TextBox(); TxtA21 = new TextBox(); TxtA22 = new TextBox();
    LblB = new Label();
    TxtB00 = new TextBox(); TxtB01 = new TextBox(); TxtB02 = new TextBox();
    TxtB10 = new TextBox(); TxtB11 = new TextBox(); TxtB12 = new TextBox();
    TxtB20 = new TextBox(); TxtB21 = new TextBox(); TxtB22 = new TextBox();
    CmdAddieren = new Button();
    CmdTransponieren = new Button();
    LblErgebnis = new Label();
    SuspendLayout();

    // Matrix A Label
    LblA.AutoSize = true;
    LblA.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
    LblA.Location = new Point(12, 12);
    LblA.Text = "Matrix A:";

    // Matrix A TextBoxen (3×3, Grösse 45×23)
    int baseX = 12, baseY = 35, sz = 45, gap = 50;
    TextBox[,] a = { { TxtA00, TxtA01, TxtA02 }, { TxtA10, TxtA11, TxtA12 }, { TxtA20, TxtA21, TxtA22 } };
    string[,] nA = { { "TxtA00", "TxtA01", "TxtA02" }, { "TxtA10", "TxtA11", "TxtA12" }, { "TxtA20", "TxtA21", "TxtA22" } };
    for (int i = 0; i < 3; i++)
      for (int j = 0; j < 3; j++)
      {
        a[i, j].Location = new Point(baseX + j * gap, baseY + i * 30);
        a[i, j].Name = nA[i, j];
        a[i, j].Size = new Size(sz, 23);
        a[i, j].Text = "0";
        Controls.Add(a[i, j]);
      }

    // Matrix B Label
    LblB.AutoSize = true;
    LblB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
    LblB.Location = new Point(200, 12);
    LblB.Text = "Matrix B:";

    // Matrix B TextBoxen
    TextBox[,] b = { { TxtB00, TxtB01, TxtB02 }, { TxtB10, TxtB11, TxtB12 }, { TxtB20, TxtB21, TxtB22 } };
    string[,] nB = { { "TxtB00", "TxtB01", "TxtB02" }, { "TxtB10", "TxtB11", "TxtB12" }, { "TxtB20", "TxtB21", "TxtB22" } };
    int bX = 200;
    for (int i = 0; i < 3; i++)
      for (int j = 0; j < 3; j++)
      {
        b[i, j].Location = new Point(bX + j * gap, baseY + i * 30);
        b[i, j].Name = nB[i, j];
        b[i, j].Size = new Size(sz, 23);
        b[i, j].Text = "0";
        Controls.Add(b[i, j]);
      }

    CmdAddieren.Location = new Point(12, 135);
    CmdAddieren.Name = "CmdAddieren";
    CmdAddieren.Size = new Size(130, 28);
    CmdAddieren.Text = "A + B Addieren";
    CmdAddieren.Click += CmdAddieren_Click;

    CmdTransponieren.Location = new Point(155, 135);
    CmdTransponieren.Name = "CmdTransponieren";
    CmdTransponieren.Size = new Size(130, 28);
    CmdTransponieren.Text = "A Transponieren";
    CmdTransponieren.Click += CmdTransponieren_Click;

    LblErgebnis.AutoSize = true;
    LblErgebnis.Font = new Font("Courier New", 10F);
    LblErgebnis.Location = new Point(12, 175);
    LblErgebnis.Name = "LblErgebnis";
    LblErgebnis.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(420, 320);
    Controls.Add(LblA);
    Controls.Add(LblB);
    Controls.Add(CmdAddieren);
    Controls.Add(CmdTransponieren);
    Controls.Add(LblErgebnis);
    Name = "MatrizenRechnerForm";
    Text = "Matrizen-Rechner – Aufgabe 3";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblA;
  private TextBox TxtA00, TxtA01, TxtA02;
  private TextBox TxtA10, TxtA11, TxtA12;
  private TextBox TxtA20, TxtA21, TxtA22;
  private Label LblB;
  private TextBox TxtB00, TxtB01, TxtB02;
  private TextBox TxtB10, TxtB11, TxtB12;
  private TextBox TxtB20, TxtB21, TxtB22;
  private Button CmdAddieren;
  private Button CmdTransponieren;
  private Label LblErgebnis;
}
