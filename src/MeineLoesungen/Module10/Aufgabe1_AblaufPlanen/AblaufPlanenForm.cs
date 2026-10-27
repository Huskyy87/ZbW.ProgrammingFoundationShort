namespace ZbW.ProgrammingFoundationShort.Challenges.Module10.Aufgabe1_AblaufPlanen;

public sealed class AblaufPlanenForm : Form
{
  private readonly TextBox TxtFlowchart;
  private readonly TextBox TxtTodos;

  public AblaufPlanenForm()
  {
    Text = "Ablauf planen – Aufgabe 1";
    ClientSize = new Size(760, 520);

    Label lblRules = new Label
    {
      Location = new Point(12, 12),
      Size = new Size(720, 75),
      Text = "Problem: Eintrittspreis berechnen\r\n" +
             "Alter < 0: ungültig | unter 6: gratis | 6-15: Kinderpreis | 16-64: Normalpreis | ab 65: Seniorenpreis"
    };

    Button cmdMusterloesung = new Button { Location = new Point(12, 95), Size = new Size(170, 30), Text = "Musterlösung anzeigen" };
    TxtFlowchart = new TextBox
    {
      Location = new Point(12, 135),
      Size = new Size(350, 360),
      Multiline = true,
      ScrollBars = ScrollBars.Vertical
    };
    TxtTodos = new TextBox
    {
      Location = new Point(380, 135),
      Size = new Size(360, 360),
      Multiline = true,
      ScrollBars = ScrollBars.Vertical
    };

    cmdMusterloesung.Click += CmdMusterloesung_Click;

    Controls.Add(lblRules);
    Controls.Add(cmdMusterloesung);
    Controls.Add(TxtFlowchart);
    Controls.Add(TxtTodos);
  }

  private void CmdMusterloesung_Click(object sender, EventArgs e)
  {
    // Musterlösung – erst anzeigen, nachdem du selbst geplant hast!
    TxtFlowchart.Text = "Start\r\n  |\r\nAlter einlesen\r\n  |\r\n" +
                        "Alter < 0? --ja--> \"Ungültig\" --> Ende\r\n  | nein\r\n" +
                        "Alter < 6? --ja--> \"Gratis\" --> Ende\r\n  | nein\r\n" +
                        "Alter <= 15? --ja--> \"Kinderpreis\" --> Ende\r\n  | nein\r\n" +
                        "Alter <= 64? --ja--> \"Normalpreis\" --> Ende\r\n  | nein\r\n" +
                        "\"Seniorenpreis\" --> Ende";
    TxtTodos.Text = "static string GetTicketType(int age)\r\n{\r\n" +
                    "    // TODO: age < 0 → \"Ungültig\"\r\n" +
                    "    // TODO: age < 6 → \"Gratis\"\r\n" +
                    "    // TODO: age <= 15 → \"Kinderpreis\"\r\n" +
                    "    // TODO: age <= 64 → \"Normalpreis\"\r\n" +
                    "    // TODO: sonst → \"Seniorenpreis\"\r\n" +
                    "    return \"TODO\";\r\n}";
  }
}