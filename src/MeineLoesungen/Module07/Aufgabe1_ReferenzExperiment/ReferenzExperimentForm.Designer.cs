namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe1_ReferenzExperiment;

partial class ReferenzExperimentForm
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
    CmdWerttyp = new Button(); LblWerttyp = new Label();
    CmdReferenztyp = new Button(); LblReferenztyp = new Label();
    CmdEchteKopie = new Button(); LblEchteKopie = new Label();
    CmdMethode = new Button(); LblMethode = new Label();
    SuspendLayout();

    CmdWerttyp.Location = new Point(12, 12); CmdWerttyp.Name = "CmdWerttyp"; CmdWerttyp.Size = new Size(130, 25); CmdWerttyp.Text = "Werttyp Demo"; CmdWerttyp.Click += CmdWerttyp_Click;
    LblWerttyp.Location = new Point(155, 12); LblWerttyp.Name = "LblWerttyp"; LblWerttyp.Size = new Size(280, 65); LblWerttyp.Text = "";

    CmdReferenztyp.Location = new Point(12, 90); CmdReferenztyp.Name = "CmdReferenztyp"; CmdReferenztyp.Size = new Size(130, 25); CmdReferenztyp.Text = "Referenztyp Demo"; CmdReferenztyp.Click += CmdReferenztyp_Click;
    LblReferenztyp.Location = new Point(155, 90); LblReferenztyp.Name = "LblReferenztyp"; LblReferenztyp.Size = new Size(280, 65); LblReferenztyp.Text = "";

    CmdEchteKopie.Location = new Point(12, 168); CmdEchteKopie.Name = "CmdEchteKopie"; CmdEchteKopie.Size = new Size(130, 25); CmdEchteKopie.Text = "Echte Kopie"; CmdEchteKopie.Click += CmdEchteKopie_Click;
    LblEchteKopie.Location = new Point(155, 168); LblEchteKopie.Name = "LblEchteKopie"; LblEchteKopie.Size = new Size(280, 65); LblEchteKopie.Text = "";

    CmdMethode.Location = new Point(12, 246); CmdMethode.Name = "CmdMethode"; CmdMethode.Size = new Size(130, 25); CmdMethode.Text = "Methoden-Test"; CmdMethode.Click += CmdMethode_Click;
    LblMethode.Location = new Point(155, 246); LblMethode.Name = "LblMethode"; LblMethode.Size = new Size(280, 65); LblMethode.Text = "";

    AutoScaleDimensions = new SizeF(7F, 15F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(450, 330);
    Controls.Add(CmdWerttyp); Controls.Add(LblWerttyp);
    Controls.Add(CmdReferenztyp); Controls.Add(LblReferenztyp);
    Controls.Add(CmdEchteKopie); Controls.Add(LblEchteKopie);
    Controls.Add(CmdMethode); Controls.Add(LblMethode);
    Name = "ReferenzExperimentForm"; Text = "Referenz-Experiment – Aufgabe 1";
    ResumeLayout(false); PerformLayout();
  }

  private Button CmdWerttyp; private Label LblWerttyp;
  private Button CmdReferenztyp; private Label LblReferenztyp;
  private Button CmdEchteKopie; private Label LblEchteKopie;
  private Button CmdMethode; private Label LblMethode;
}
