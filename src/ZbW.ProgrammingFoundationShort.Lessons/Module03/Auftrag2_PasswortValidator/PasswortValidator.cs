namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator;

// ============================================================
// AUFTRAG 2 – PasswortValidator (⭐⭐ Mittel | ~30 Min.)
//
// Validiert ein Passwort und fordert erneute Eingabe per do-while.
//
// Anforderungen:
//   - do-while-Schleife: solange Passwort ungültig
//   - gültig: mindestens 8 Zeichen UND mindestens eine Ziffer
//   - Ziffer mit foreach über die Zeichen + char.IsDigit(...) suchen
//   - Fehlermeldung: was fehlt
// ============================================================

public static class PasswortValidator
{
  public static void Start()
  {
    // TODO 1: string passwort; bool gueltig;
    //         do { ... } while (!gueltig);



    string passwort; bool gueltig;
    do
    {
      // TODO 2: In der Schleife Passwort einlesen (Console.ReadLine() ?? "")
      Console.Write("Passwort eingeben: ");
      passwort = Console.ReadLine() ?? "";


      // TODO 3: bool hatZiffer = false;
      //         foreach (char zeichen in passwort) → char.IsDigit(zeichen) prüfen
      bool hatZiffer = false;

      foreach (char zeichen in passwort)
      {
        if (char.IsDigit(zeichen))
        {
          hatZiffer = true;
        }
      }

      // TODO 4: gueltig berechnen und konkrete Fehlermeldung ausgeben
      gueltig = passwort.Length >= 8 && hatZiffer;

      if (passwort.Length < 8)
      {
        Console.WriteLine("Das Passwort muss mindestens 8 Zeichen haben");
      }

      if (!hatZiffer)
      {
        Console.WriteLine("Das Passwort muss mindestens eine Ziffer haben");
      }

    }
    while (!gueltig);

    // TODO 5: Nach der Schleife Erfolgsmeldung ausgeben
    Console.WriteLine("Das Passwort ist gültig");

  }
}
