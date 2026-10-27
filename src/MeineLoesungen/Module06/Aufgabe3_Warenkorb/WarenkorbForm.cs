namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe3_Warenkorb;

/// <summary>
///   Aufgabe 3 – Warenkorb (⭐⭐⭐ Schwer)
/// </summary>
public partial class WarenkorbForm : Form
{
  private readonly ShoppingCart _warenkorb = new();

  public WarenkorbForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    if (!decimal.TryParse(TxtPreis.Text, out decimal preis) || preis < 0)
    {
      MessageBox.Show("Bitte einen gültigen Preis eingeben.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (!int.TryParse(TxtMenge.Text, out int menge) || menge < 1)
    {
      MessageBox.Show("Bitte eine gültige Menge (> 0) eingeben.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    Product produkt = new Product(TxtProdukt.Text.Trim(), preis);
    produkt.Quantity = menge;

    _warenkorb.AddProduct(produkt);
    TxtKassenbon.Text = _warenkorb.GetReceipt();
    TxtProdukt.Clear(); TxtPreis.Clear(); TxtMenge.Clear();
  }

  private void CmdEntfernen_Click(object sender, EventArgs e)
  {
    string name = TxtProdukt.Text.Trim();
    if (!_warenkorb.RemoveProduct(name))
    {
      MessageBox.Show($"\"{name}\" nicht im Warenkorb.",
        "Nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }
    TxtKassenbon.Text = _warenkorb.GetReceipt();
  }

  private void CmdKassenbon_Click(object sender, EventArgs e)
  {
    TxtKassenbon.Text = _warenkorb.GetReceipt();
  }
}
