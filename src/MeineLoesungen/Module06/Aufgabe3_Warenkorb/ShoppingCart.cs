namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe3_Warenkorb;

/// <summary>Warenkorb mit Produktverwaltung.</summary>
public class ShoppingCart
{
  private readonly List<Product> _items = new();

  /// <summary>Gesamtanzahl Artikel = Summe aller Mengen (2× dasselbe Buch zählt als 2).</summary>
  public int GetItemCount()
  {
    int anzahl = 0;
    foreach (Product item in _items)
    {
      anzahl += item.Quantity;
    }

    return anzahl;
  }

  public decimal GetTotal()
  {
    decimal total = 0;
    foreach (Product item in _items)
    {
      total += item.Total;
    }

    return total;
  }

  public void AddProduct(Product product)
  {
    // Gleiches Produkt = gleicher Name UND gleicher Preis → nur Menge erhöhen.
    // Anderer Preis → eigene Position, damit kein Preis verloren geht.
    foreach (Product item in _items)
    {
      if (item.Name == product.Name && item.Price == product.Price)
      {
        item.Quantity += product.Quantity;
        return;
      }
    }

    _items.Add(product);
  }

  public bool RemoveProduct(string name)
  {
    Product produkt = FindByName(name);
    if (produkt == null)
    {
      return false;
    }

    _items.Remove(produkt);
    return true;
  }

  public string GetReceipt()
  {
    string nl = Environment.NewLine;
    string bon = "========== KASSENBON ==========" + nl;
    foreach (Product item in _items)
    {
      bon += item.ToString() + nl;
    }

    bon += new string('-', 45) + nl;
    bon += $"{"TOTAL",-20} {"",14} {GetTotal(),10:F2} CHF" + nl;
    bon += $"Anzahl Artikel: {GetItemCount()}" + nl;
    return bon;
  }

  private Product FindByName(string name)
  {
    foreach (Product item in _items)
    {
      if (item.Name == name)
      {
        return item;
      }
    }

    return null;
  }
}
