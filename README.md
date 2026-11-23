# ProNatur Biomarkt GmbH – Warenwirtschaft (C# / WinForms)

Desktop-Anwendung zur Verwaltung von Produkten und Rechnungen für einen fiktiven Biomarkt.
Entstanden 2023 als Abschlussprojekt eines C#-Zertifikatskurses.

## Funktionen

- **Ladebildschirm** mit Fortschrittsbalken beim Start
- **Hauptmenü** als Einstieg in die beiden Bereiche
- **Produktverwaltung:** Produkte anlegen, bearbeiten, löschen und in einer Tabelle (DataGridView) anzeigen
- **Rechnungsverwaltung:** Rechnungen anlegen, bearbeiten, löschen und anzeigen
- Datenhaltung in einer **SQL-Server-LocalDB**-Datenbank

## Technik

| Bereich    | Eingesetzt                         |
|------------|------------------------------------|
| Sprache    | C#                                 |
| UI         | Windows Forms                      |
| Framework  | .NET Framework 4.8                 |
| Datenbank  | Microsoft SQL Server LocalDB (ADO.NET, `SqlConnection` / `SqlCommand`) |
| IDE        | Visual Studio                      |

## Projektstruktur

```
Loadingscreen.cs     Startbildschirm mit Ladebalken
MainMenuScreen.cs    Hauptmenü
ProductsScreen.cs    CRUD für Produkte
BillScreen.cs        CRUD für Rechnungen
Program.cs           Einstiegspunkt
Resources.zip        Bilder für die Oberfläche
```

## Starten

1. `ProNatur-Biomarkt GmbH.sln` in Visual Studio öffnen
2. `Resources.zip` entpacken
3. Eine LocalDB-Datenbank mit den Tabellen für Produkte und Rechnungen anlegen und den Verbindungs-String in `ProductsScreen.cs` und `BillScreen.cs` auf den eigenen Pfad anpassen
4. Projekt starten (F5)

## Was ich heute anders machen würde

Das Projekt ist eines meiner ersten größeren C#-Programme. Mit meinem heutigen Wissen würde ich:

- SQL-Abfragen **parametrisieren** statt Strings zusammenzusetzen (Schutz vor SQL-Injection)
- den Verbindungs-String in die `App.config` auslagern
- Datenbankzugriff und Oberfläche in getrennte Schichten aufteilen (z. B. Repository-Klasse)
