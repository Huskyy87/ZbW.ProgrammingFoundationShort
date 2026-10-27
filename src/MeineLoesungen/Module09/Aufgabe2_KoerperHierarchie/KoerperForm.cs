namespace ZbW.ProgrammingFoundationShort.Challenges.Module09.Aufgabe2_KoerperHierarchie;

public sealed class KoerperForm : Form
{
  private readonly RadioButton RadCube;
  private readonly RadioButton RadCuboid;
  private readonly RadioButton RadSphere;
  private readonly TextBox TxtColor;
  private readonly TextBox TxtA;
  private readonly TextBox TxtB;
  private readonly TextBox TxtC;
  private readonly List<Solid> _solids = new List<Solid>();
  private readonly ListBox LstSolids;
  private readonly Label LblTotal;

  public KoerperForm()
  {
    Text = "Körper-Hierarchie – Aufgabe 2";
    ClientSize = new Size(680, 360);

    RadCube = new RadioButton { Location = new Point(120, 12), Size = new Size(75, 24), Text = "Würfel", Checked = true };
    RadCuboid = new RadioButton { Location = new Point(200, 12), Size = new Size(75, 24), Text = "Quader" };
    RadSphere = new RadioButton { Location = new Point(280, 12), Size = new Size(75, 24), Text = "Kugel" };
    TxtColor = new TextBox { Location = new Point(120, 45), Size = new Size(120, 23), Text = "Rot" };
    TxtA = new TextBox { Location = new Point(120, 78), Size = new Size(80, 23), Text = "2" };
    TxtB = new TextBox { Location = new Point(120, 111), Size = new Size(80, 23), Text = "3" };
    TxtC = new TextBox { Location = new Point(120, 144), Size = new Size(80, 23), Text = "4" };
    Button cmdAdd = new Button { Location = new Point(120, 180), Size = new Size(120, 28), Text = "Hinzufügen" };
    LstSolids = new ListBox { Location = new Point(300, 45), Size = new Size(360, 240) };
    LblTotal = new Label { Location = new Point(300, 300), Size = new Size(360, 30) };

    cmdAdd.Click += CmdAdd_Click;
    RadCube.CheckedChanged += RadShape_CheckedChanged;
    RadCuboid.CheckedChanged += RadShape_CheckedChanged;
    RadSphere.CheckedChanged += RadShape_CheckedChanged;
    RadShape_CheckedChanged(this, EventArgs.Empty);

    Controls.Add(new Label { Location = new Point(12, 15), Size = new Size(100, 20), Text = "Körper:" });
    Controls.Add(new Label { Location = new Point(12, 48), Size = new Size(100, 20), Text = "Farbe:" });
    Controls.Add(new Label { Location = new Point(12, 81), Size = new Size(100, 20), Text = "Kante/Länge/r:" });
    Controls.Add(new Label { Location = new Point(12, 114), Size = new Size(100, 20), Text = "Breite:" });
    Controls.Add(new Label { Location = new Point(12, 147), Size = new Size(100, 20), Text = "Höhe:" });
    Controls.Add(RadCube);
    Controls.Add(RadCuboid);
    Controls.Add(RadSphere);
    Controls.Add(TxtColor);
    Controls.Add(TxtA);
    Controls.Add(TxtB);
    Controls.Add(TxtC);
    Controls.Add(cmdAdd);
    Controls.Add(LstSolids);
    Controls.Add(LblTotal);
  }

  private void CmdAdd_Click(object sender, EventArgs e)
  {
    // Nur die Felder lesen, die der gewählte Körper braucht
    if (!TryReadSize(TxtA, out double a))
    {
      LblTotal.Text = "Wert 1: positive Zahl bis 1000 eingeben.";
      return;
    }

    Solid solid;

    if (RadCube.Checked)
    {
      solid = new Cube(a, TxtColor.Text);
    }
    else if (RadCuboid.Checked)
    {
      if (!TryReadSize(TxtB, out double b) || !TryReadSize(TxtC, out double c))
      {
        LblTotal.Text = "Quader: Werte 2 und 3 als positive Zahlen bis 1000 eingeben.";
        return;
      }

      solid = new Cuboid(a, b, c, TxtColor.Text);
    }
    else
    {
      solid = new Sphere(a, TxtColor.Text);
    }

    _solids.Add(solid);

    LstSolids.Items.Clear();
    double totalVolume = 0;

    foreach (Solid existingSolid in _solids)
    {
      totalVolume += existingSolid.Volume();
      LstSolids.Items.Add(existingSolid.ToString());
    }

    LblTotal.Text = $"Gesamtvolumen: {totalVolume:F2}";
  }

  private static bool TryReadSize(TextBox textBox, out double value)
  {
    return double.TryParse(textBox.Text, out value) && double.IsFinite(value) && value > 0 && value <= 1000;
  }

  private void RadShape_CheckedChanged(object sender, EventArgs e)
  {
    // Werte 2 und 3 braucht nur der Quader
    TxtB.Enabled = RadCuboid.Checked;
    TxtC.Enabled = RadCuboid.Checked;
  }
}

public abstract class Solid
{
  protected Solid(string color)
  {
    Color = color;
  }

  public string Color { get; }

  public abstract double Volume();

  public abstract double SurfaceArea();

  public override string ToString()
  {
    return $"{GetType().Name}, {Color}, Volumen: {Volume():F2}, Oberfläche: {SurfaceArea():F2}";
  }
}

public class Cube : Solid
{
  public Cube(double edge, string color) : base(color)
  {
    Edge = edge;
  }

  public double Edge { get; }

  public override double Volume()
  {
    return Edge * Edge * Edge;
  }

  public override double SurfaceArea()
  {
    return 6 * Edge * Edge;
  }
}

public class Cuboid : Solid
{
  public Cuboid(double length, double width, double height, string color) : base(color)
  {
    Length = length;
    Width = width;
    Height = height;
  }

  public double Length { get; }
  public double Width { get; }
  public double Height { get; }

  public override double Volume()
  {
    return Length * Width * Height;
  }

  public override double SurfaceArea()
  {
    return 2 * (Length * Width + Length * Height + Width * Height);
  }
}

public class Sphere : Solid
{
  public Sphere(double radius, string color) : base(color)
  {
    Radius = radius;
  }

  public double Radius { get; }

  public override double Volume()
  {
    return 4.0 / 3.0 * Math.PI * Radius * Radius * Radius;
  }

  public override double SurfaceArea()
  {
    return 4 * Math.PI * Radius * Radius;
  }
}
