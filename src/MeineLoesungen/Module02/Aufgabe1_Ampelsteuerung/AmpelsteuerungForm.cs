namespace ZbW.ProgrammingFoundationShort.Challenges.Module02.Aufgabe1_Ampelsteuerung;

/// <summary>
///   Aufgabe 1 – Ampelsteuerung (⭐ Einfach)
///   Zeigt die Ampelfarbe und Bedeutung per switch-case an.
/// </summary>
public enum TrafficLightColor { Red, Yellow, Green }

public partial class AmpelsteuerungForm : Form
{
  public AmpelsteuerungForm()
  {
    InitializeComponent();
  }

  private void CmdAnzeigen_Click(object sender, EventArgs e)
  {
    // Gewählte Farbe aus RadioButtons ermitteln
    TrafficLightColor farbe;
    if (RadRot.Checked)
    {
      farbe = TrafficLightColor.Red;
    }
    else if (RadGelb.Checked)
    {
      farbe = TrafficLightColor.Yellow;
    }
    else
    {
      farbe = TrafficLightColor.Green;
    }

    // Meldung und Farbe per switch-case setzen
    string meldung;
    Color ampelFarbe;

    switch (farbe)
    {
      case TrafficLightColor.Red:
        meldung = "STOP – Bitte anhalten!";
        ampelFarbe = Color.Red;
        break;
      case TrafficLightColor.Yellow:
        meldung = "ACHTUNG – Bereit machen!";
        ampelFarbe = Color.Yellow;
        break;
      case TrafficLightColor.Green:
        meldung = "FAHREN – Sie dürfen fahren!";
        ampelFarbe = Color.Green;
        break;
      default:
        meldung = "Unbekannt";
        ampelFarbe = Color.Gray;
        break;
    }

    LblMeldung.Text = meldung;
    LblAmpel.BackColor = ampelFarbe;
  }
}
