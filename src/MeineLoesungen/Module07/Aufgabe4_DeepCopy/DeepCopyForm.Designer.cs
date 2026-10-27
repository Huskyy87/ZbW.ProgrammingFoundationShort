namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe4_DeepCopy;

partial class DeepCopyForm
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
    CmdShallowCopy = new Button(); LblShallow = new Label();
    CmdDeepCopy = new Button(); LblDeep = new Label();
    SuspendLayout();

    CmdShallowCopy.Location = new Point(12, 12); CmdShallowCopy.Name = "CmdShallowCopy"; CmdShallowCopy.Size = new Size(130, 28); CmdShallowCopy.Text = "Shallow Copy Demo"; CmdShallowCopy.Click += CmdShallowCopy_Click;
    LblShallow.Location = new Point(12, 50); LblShallow.Name = "LblShallow"; LblShallow.Size = new Size(460, 110); LblShallow.Text = "";

    CmdDeepCopy.Location = new Point(12, 175); CmdDeepCopy.Name = "CmdDeepCopy"; CmdDeepCopy.Size = new Size(130, 28); CmdDeepCopy.Text = "Deep Copy Demo"; CmdDeepCopy.Click += CmdDeepCopy_Click;
    LblDeep.Location = new Point(12, 213); LblDeep.Name = "LblDeep"; LblDeep.Size = new Size(460, 110); LblDeep.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(490, 340);
    Controls.Add(CmdShallowCopy); Controls.Add(LblShallow);
    Controls.Add(CmdDeepCopy); Controls.Add(LblDeep);
    Name = "DeepCopyForm"; Text = "Deep Copy – Aufgabe 4";
    ResumeLayout(false); PerformLayout();
  }

  private Button CmdShallowCopy; private Label LblShallow;
  private Button CmdDeepCopy; private Label LblDeep;
}
