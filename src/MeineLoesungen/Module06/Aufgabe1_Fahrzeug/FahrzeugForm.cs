namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe1_Fahrzeug;

/// <summary>
///   Aufgabe 1 – Fahrzeug (⭐⭐ Mittel)
///   Vehicle-Klasse mit Drive()-Methode.
/// </summary>
public partial class FahrzeugForm : Form
{
  private Vehicle? _fahrzeug;

  public FahrzeugForm()
  {
    InitializeComponent();
  }

  private void CmdErstellen_Click(object sender, EventArgs e)
  {
    if (!int.TryParse(TxtYear.Text, out int year))
    {
      MessageBox.Show("Bitte ein gültiges Baujahr eingeben.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // Neues Fahrzeug startet mit Kilometerstand 0
    _fahrzeug = new Vehicle(TxtMake.Text.Trim(), TxtModel.Text.Trim(), year, 0);

    LblInfo.Text = _fahrzeug.GetInfo();
    CmdFahren.Enabled = true;
  }

  private void CmdFahren_Click(object sender, EventArgs e)
  {
    if (_fahrzeug == null)
    {
      return;
    }

    if (!double.TryParse(TxtKm.Text, out double km) || km <= 0)
    {
      MessageBox.Show("Bitte eine positive Kilometeranzahl eingeben.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    _fahrzeug.Drive(km);
    LblInfo.Text = _fahrzeug.GetInfo();
  }
}
