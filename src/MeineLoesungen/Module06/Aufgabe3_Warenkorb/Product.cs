namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe3_Warenkorb;

/// <summary>Produkt mit Name, Preis und Menge.</summary>
public class Product
{
  public Product(string name, decimal price)
  {
    Name = name;
    Price = price;
    Quantity = 1; // Standardmenge
  }

  public string Name { get; set; }
  public decimal Price { get; set; }
  public int Quantity { get; set; }

  public decimal Total => Price * Quantity;

  public override string ToString()
  {
    return $"{Name,-20} {Quantity,3} × {Price,8:F2} = {Total,10:F2} CHF";
  }
}
