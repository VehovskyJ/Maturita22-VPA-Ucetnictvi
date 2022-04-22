# Účetnictví

Moje řešení praktické části maturitní zkoušky z VPA 2022.
Nejsem na toto řešení zrovna pyšný, ale funguje to a to je důležité.

### Spuštění
Pro spuštění je nutno vytvořit textový soubor a do programu ho načíst

## Zadáni
Vytvořte OOP program pro domácí účetnictví, který bude mít následující funkce:
(Vzhled programu je na žákovi, lze využít OOP jazyky (Java, C#, PHP,..)) 

1. Aplikace bude mít název v záhlaví (formuláře). Všechny prvky budou vhodně rozmístěné. Aplikace bude mít menu. Realizujte princip objektově orientovaného programování v GUI.
2. Promyslete rozdělení funkcí do více souborů, tedy ne vše by mělo být v hlavním souboru.
3. V programu se budou rozlišovat příjmy a výdaje.
4. Vytvoříte TXT dokumenty pro příjmy a pro výdaje, do nich se budou inkrementálně zapisovat pohyby na daném účtu (alternativně k TXT dokumentům můžete vytvořit i příslušnou databázi).
5. Vnitřní formát zápisu položek je ponechán na uživateli, jediná podmínka je „co řádek, to účetní položka“.
6. Základní operace pro účty budou následující. 
   * přidat položku účetnictví
   * odebrat položku účetnictví 
   * update položky z účetnictví
7. Program bude moci zobrazit z TXT souboru (nebo z databáze) již vložené položky v jednoduchém seznamu.
8. Položky se budou přidávat v novém okně (formuláři) a u jednotlivých položek se budou evidovat následující sloupce:
   * Datum
   * Druh (příjmy, výdaje) – combo box / select input
   * Účet (běžný, kreditní, hotovost) – combo box / select input
   * Cena
   * Kategorie (jídlo, bydlení, elektronika apod.) – combo box / select input
   * Osoba (osoba, s níž platba souvisí) – combo box / select input
9. Program bude mít menu, ve kterém se objeví základní položky, které umožní kompletní ovládání programu (dle implementace například: načíst TXT, konec programu, přidat, upravit, nebo vložit položku apod.)
