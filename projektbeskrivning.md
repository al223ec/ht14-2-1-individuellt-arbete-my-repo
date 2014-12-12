<h1>Matdagbok</h1>
<p>
    Jag tänker göra en matdagbok där en användare kan skapa en måltid och få information om måltidens näringsinnehåll.
    Jag kommer använda det öppna api:et matapi.se för att hämta information om de olika livsmedlens näringsinformation.
    Änvändaren ska kunna söka efter ett livsmedel för att sedan kunna lägga till detta till en lista, användaren behöver
    också ange hur mycket av livsmedlet hen använder.
</p>
<p>
    Applikationen kommer att hämta ut alla livsmedel som finns därefter hämta livsmedlets specifika näringsinnehåll utefter behov. 
    Livsmedlets näringsinformation kommer därefter att "cachas" i databasen. 
</p>
<h3>
    MatApi.se
</h3>
<p>
    Matapi hämtar sin data från livsmedelsverkets databas.
</p>
<h3>Applikationsspecifika krav</h3>
<ul>
    <li>
        Användaren ska ha full CRUD på måltider.
    </li>
    <li>
        Användaren ska kunna kopiera en måltid.
    </li>
    <li>
        En användare kan logga in/logga ut
    </li>
    <li>
        En ny användare kan registrera sig
    </li>
</ul>
<h3>Exktra krav om tid finns</h3>
<ul>
    <li>
        En måltid kan bestå av "rätter"/recept som sparas tex köttfärssås
    </li>
    <li>
        Användaren ska kunna lägga till nya livsmedel.
    </li>
    <li>

    </li>

</ul>
<h3>Betygskrav</h3>
Betyg 3
------------
För betyget 3 på det individuella arbetet ska din applikation uppfylla nedanstående.
1. Applikationen ska arbeta med data från minst två datakällor, vara av en måste vara en databas. En
databas med minst en tabell och hämtning av data från minst en webbservice anses uppfylla kravet
på två datakällor.
2. Speciella krav beroende på typ av applikation.
a) Väljer du att göra en väderapplikation måste följande krav vara uppfyllda:
1. En femdygnsprognos ska presenteras. En dags prognos ska minst baseras på period 2,
d.v.s. prognosen mellan 12:00-18:00. Saknas period 2 ska period 3 användas. Saknas
period 3 tas nästa dags period 2. Det står dig fritt att utöka presentationen av
prognoserna och presentera prognoser för samtliga perioder eller prognoser för varje
timme.
2. En prognos ska minst innehålla en bild beskrivande vädret samt temperatur. Det står dig
fritt att utöka presentationen av en prognos med ytterligare information som t.ex.
vindriktning, vindhastighet och nedbördsmängd.
b) Väljer du inte att göra en väderapplikation måste du lämna in en kortfattad beskrivning av
applikationen om maximalt en A4-sida innehållande syftet med applikationen samt en
konceptuell modell över databasen.
3. Webbapplikationen ska vara skapad med Microsoft ASP.NET MVC 5 och C#.
4. Relationsdatabasen SQL Server 2008 R2 ska användas för persistent lagring av data.
a) All kommunikation med databashanteraren ska ske genom användaren appUser med
lösenordet 1Br@Lösen=rd?.
5. Webbapplikationen ska följa riktlinjer för utformning av innehåll på webben enligt W3C WCAG
2.0.
6. Webbapplikationen ska vara uppdelad enligt designmönstret Model –View –Controller. Den ska
vara uppdelad i två projekt.
a) Ett projekt av typen ASP.NET MVC där all kod rörande användargränssnittet återfinns. Kod i
katalogen Models är inte tillåten. Kod som normalt återfinns i katalogen Models ska placeras
i ett separat projekt.
b) Ett ”Class Library Project” innehållande domänmodellen.
7. För hantering av persistent data ska Microsoft Entity Framework användas.
8. Controllermetoder får inte använda sig direkt av några objekt härrörande från Entity Framework,
utan måste använda sig av ett centrallager (”repository”) och servicelager.
9. Webbapplikationen ska ha CRUD-funktionalitet (”Create”, ”Read”, ”Update”, ”Delete”), d.v.s.
användaren ska, förutom att kunna skapa nya poster, även kunna läsa, redigera och ta bort
ASP.NET MVC (1DV409) 6 (8)befintliga poster i tabeller i en databas. Avsteg från detta krav kan i undantagsfall godtas beroende
på implementation.
10. Användaren appUser ska som mest ha rättigheter att exekvera:
a) SQL-satser för SELECT, INSERT, UPDATE och DELETE.
b) lagrade procedurer (Execute).
11. Applikationen ska:
a) ha en hög användbarhet, d.v.s. vara lätt att lära sig, effektiv att använda och ge positiva
upplevelser för användaren.
b) ha en bra och genomarbetad layout och design.
c) tillhandahålla en genomtänkt och logisk navigation.
d) använda sig av minst en " Layout Page".
12. Allt data ska valideras. (Validering i "controller layer" inte tillåten!)
13. Validering av formulärdatat ska vara utformad så att valideringen sker i så stor utsträckning som
möjligt på klienten innan datat skickas till servern för validering och bearbetning.

Betyg 4
------------
För betyget 4 på det individuella arbetet ska din applikation, förutom kraven som ställs för betyget 3,
uppfylla nedanstående:
1. Leveransdatum ("deadlines") ska hållas; det är en förutsättning för ett högre betyg än godkänd (3).
2. Minst ett textfält i applikationen ska ha ”autocomplete” och controllermetoden som klienten
anropar ska returnera data av typen JsonResult.
a) Väljer du att göra en väderapplikation måste följande krav vara uppfyllda:
1. Underlaget för de platser som presenteras av textfältet med ”autocomplete” ska hämtas
från databasen och får inte hämtas från en extern webservice.
3. Om det finns flera platser med samma namn ska en karta presenteras där de olika platserna
markerats.
4. En karta där aktuell plats markerats ska presenteras i anslutning till en prognos.
5. Controller- och/eller serviceklasser måste använda sig av DI (”dependency injection”) för att
möjliggöra tester.
6. "Test-Driven Development" (TDD) ska ha undersökts. Det ska finnas minst fyra testmetoder i ett
separat testprojekt som testar funktionaliteten i fyra olika controllermetoder.

Betyg 5
------------
För betyget 5 på det individuella arbetet ska din applikation, förutom kraven som ställs för betyget 4,
uppfylla nedanstående:
1. Leveransdatum ("deadlines") ska hållas; det är en förutsättning för ett högre betyg än godkänd (3).
2. Code First ska tillämpas, d.v.s. klasserna DbContext respektive DbSet<t>
    ska användas utan att
    du använder ”ADO.NET Entity Data Model” (.edmx-fil). OBS! Detta krav medför att appUser
    måste ha lämpliga rättigheter för att kunna exekvera SQL-satser för INSERT, UPDATE och
    DELETE.
    3. För hantering av webbapplikationens användare och roller ska ASP.NET Identity API användas.
    Exempel på funktionalitet applikationen ska erbjuda listas nedan. Visar det sig att listan inte är
    tillämpbar på din applikation diskutera det i så fall med kursledningen.
    ASP.NET MVC (1DV409) 7 (8)a) Användare ska kunna autentiseras.
    b) Användares åtkomst av resurser ska styras med hjälp av roller.
    c) En användares autentiseringsuppgifter ska kunna skapas, antingen genom självregistrering
    eller genom att en administratör gör det.
    d) Användare ska kunna logga in och logga ut.
    e) Användare ska kunna ändra sitt lösenord.
    f) En lista med de fem senaste platserna användaren begärt en prognos för ska kunna visas för
    användaren. Användaren ska kunna ta bort en plats ur listan.
