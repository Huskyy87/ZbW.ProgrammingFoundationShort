namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag1_StatistikRechner;

// ============================================================
// AUFTRAG 1 – StatistikRechner (⭐ Einfach | ~15 Min.)
//
// Liest 5 Zahlen ein und berechnet Minimum, Maximum, Durchschnitt.
//
// Anforderungen:
//   - int[5]-Array per Konsoleneingabe befüllen
//   - Methoden: Minimum(int[]), Maximum(int[]), Average(int[])
//   - Ergebnis ausgeben
// ============================================================

public static class StatistikRechner
{
  public static void Start()
  {
    // TODO 1: int[5]-Array deklarieren
    //         5 Zahlen einlesen und im Array speichern

    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
      Console.WriteLine($"Zahl {i + 1}");
      int.TryParse(Console.ReadLine() ?? "", out array[i]);
    }


    // TODO 2: Methoden aufrufen und Ergebnis ausgeben
    //         Console.WriteLine($"Min: {Minimum(zahlen)}, Max: {Maximum(zahlen)}, Avg: {Average(zahlen):F2}");
  }

  public static int Minimum(int[] zahlen)
  {
    int min = zahlen[0];                      // Zettel 1: einfach merken

    for (int i = 1; i < zahlen.Length; i++)   // Zettel 2 bis 5 nacheinander anschauen
    {
      if (zahlen[i] < min)                  // Ist dieser Zettel kleiner?
      {
        min = zahlen[i];                  // Ja → neue Zahl merken
      }
    }

    return min;                               // Am Schluss: die gemerkte Zahl abgeben 🎁
  }


  public static int Maximum(int[] zahlen)
  {
    int max = zahlen[0];                      

    for (int i = 1; i < zahlen.Length; i++)   
    {
      if (zahlen[i] > max)                  
      {
        max = zahlen[i];                  
      }
    }

    return max;                               
  }

  public static double Average(int[] zahlen)
  {
    // TODO: Durchschnitt berechnen (Summe / Länge)
    throw new NotImplementedException("TODO: Average implementieren");
  }
}
