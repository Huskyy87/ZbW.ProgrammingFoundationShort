namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe2_EqualsImplementieren;

/// <summary>Produkt mit Equals nach Artikelnummer.</summary>
public class ProductVergleich
{
  public string Name { get; set; } = "";
  public int ArticleNumber { get; set; }
  public decimal Price { get; set; }

  public override bool Equals(object? obj)
  {
    if (obj is ProductVergleich other)
    {
      return ArticleNumber == other.ArticleNumber;
    }

    return false;
  }

  public override int GetHashCode()
  {
    return ArticleNumber.GetHashCode();
  }

  public override string ToString()
  {
    return $"[{ArticleNumber}] {Name} ({Price:F2} CHF)";
  }

  public static ProductVergleich? FindProduct(List<ProductVergleich> list, int articleNumber)
  {
    // IndexOf ruft intern Equals auf – ein "Suchobjekt" mit der Artikelnummer genügt
    ProductVergleich suchobjekt = new ProductVergleich { ArticleNumber = articleNumber };
    int index = list.IndexOf(suchobjekt);
    if (index < 0)
    {
      return null;
    }

    return list[index];
  }
}
