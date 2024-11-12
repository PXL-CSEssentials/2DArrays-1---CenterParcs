# Oefening 1: Centerparcs

Maak een applicatie die de prijzen simuleert van een Center Parcs verblijf.

Gebruikers kunnen de hoeveelheid dagen en gasten ingeven om vervolgens de prijs te zien.

![Afbeelding met tekst, schermopname, software, scherm Automatisch
gegenereerde
beschrijving](./media/image1.png)

**Applicatie layout:**

In de layout wordt een Grid gebruikt om de applicatie op te delen in drie kolommen.

In de middelste kolom wordt een WrapPanel gebruikt. De gebruikte kleuren in de applicatie zijn: Green, LightGreen en White.

1.  In de middelste kolom staan twee ComboBox'en voor de type woning en het aantal dagen.
2.  De TextBox waarin de prijs verschijnt is niet enabled.
3.  De Center Parcs titel staat horizontaal gecentreerd en heeft een lettergrootte van 40.

**Applicatie functionaliteit:**

1.  Als gebruiker kan ik een type woning en een aantal dagen ingeven.
2.  Wanneer voor beide ComboBox'en een keuze is aangeduid, dan wordt de totaalprijs onmiddellijk getoond.
3.  Gebruik de volgende array om de aantal dagen ComboBox te vullen\
    ```cs
	private readonly int[] _numberOfDays = new int[] { 1, 2, 5, 7, 8, 12, 14, 21 };
    ```
4.  Gebruik de volgende 2D array om de ComboBox voor woningtype in te vullen.
    ```cs
	private string[,] _houseWithPrice = new string[5, 2] {
		{ "2 personen", "80" },
		{ "4 personen", "120" } ,
		{ "4 personen lux", "140" } ,
		{ "6 personen", "180" },
		{ "8 personen", "200"}
	};	
    ```
5.  Gebruik de 2D array, woningMetPrijs, om de prijs te berekenen.
6.  Maak gebruik van methodes om de opties in de ComboBox te laden.
