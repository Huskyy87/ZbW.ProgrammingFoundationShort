namespace Hausaufgabe01BMI
{
  public partial class BmiForm : Form
  {
    public BmiForm()
    {
      InitializeComponent();
    }

    private void CmdBmiCalculate_Click(object sender, EventArgs e)
    {

      if (!double.TryParse(TxtWeight.Text, out double weight))
      {
        MessageBox.Show("Bitte beim Gewicht eine gültige Zahl eingeben");
        return;
      }

      if (!double.TryParse(TxtHeight.Text, out double height))
      {
        MessageBox.Show("Bitte bei der Grösse eine gültige Zahl eingeben");
        return;
      }

      double bmi = weight / (height * height);

      LblResult.Text = $"Ihr BMI beträgt: {bmi:F2}";

    }
  }
}
