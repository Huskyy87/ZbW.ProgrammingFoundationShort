namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe3_MatrizenRechner;

/// <summary>
///   Aufgabe 3 – Matrizen-Rechner (⭐⭐⭐ Schwer)
///   3×3-Matrix-Addition und Transposition.
/// </summary>
public partial class MatrizenRechnerForm : Form
{
  public MatrizenRechnerForm()
  {
    InitializeComponent();
  }

  // Eine Methode für beide Matrizen – die TextBoxen werden als Parameter übergeben
  private static int[,] ReadMatrix(TextBox[,] felder, string name)
  {
    int[,] matrix = new int[3, 3];
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        if (!int.TryParse(felder[i, j].Text, out matrix[i, j]))
        {
          throw new FormatException($"Ungültiger Wert in Matrix {name} [{i},{j}]");
        }
      }
    }

    return matrix;
  }

  private int[,] ReadMatrixA()
  {
    TextBox[,] felder = {
      { TxtA00, TxtA01, TxtA02 },
      { TxtA10, TxtA11, TxtA12 },
      { TxtA20, TxtA21, TxtA22 }
    };
    return ReadMatrix(felder, "A");
  }

  private int[,] ReadMatrixB()
  {
    TextBox[,] felder = {
      { TxtB00, TxtB01, TxtB02 },
      { TxtB10, TxtB11, TxtB12 },
      { TxtB20, TxtB21, TxtB22 }
    };
    return ReadMatrix(felder, "B");
  }

  private void CmdAddieren_Click(object sender, EventArgs e)
  {
    try
    {
      int[,] a = ReadMatrixA();
      int[,] b = ReadMatrixB();
      int[,] result = AddMatrices(a, b);
      LblErgebnis.Text = "A + B =\r\n";
      ShowMatrix(result, LblErgebnis);
    }
    catch (FormatException ex)
    {
      MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
  }

  private void CmdTransponieren_Click(object sender, EventArgs e)
  {
    try
    {
      int[,] a = ReadMatrixA();
      int[,] result = Transpose(a);
      LblErgebnis.Text = "A^T =\r\n";
      ShowMatrix(result, LblErgebnis);
    }
    catch (FormatException ex)
    {
      MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
  }

  private static int[,] AddMatrices(int[,] a, int[,] b)
  {
    var result = new int[3, 3];
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        result[i, j] = a[i, j] + b[i, j];
      }
    }

    return result;
  }

  private static int[,] Transpose(int[,] matrix)
  {
    var result = new int[3, 3];
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        result[j, i] = matrix[i, j];
      }
    }

    return result;
  }

  private static void ShowMatrix(int[,] matrix, Label label)
  {
    string text = label.Text;
    for (int i = 0; i < 3; i++)
    {
      text += "| ";
      for (int j = 0; j < 3; j++)
      {
        text += $"{matrix[i, j],4} ";
      }

      text += "|" + Environment.NewLine;
    }

    label.Text = text;
  }
}