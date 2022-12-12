## VendingMachine

Så min tanke när jag började med det här projektet var att testa använda nått Design Pattern som vi hade gått igenom i skolan. Testade att använda mig av Decorator mönstret 
där man har en abstrakt klass, en konkret klass och ett interface. Sedan adderade man varje produkt som en "tempproduct". Men efter ha omvärderat så kändes det onödigt och jag valde strukturen 
med en abstract klass Product med ett Interface IProduct istället. Varje individuell Product ärver sedan från Product och overridar dess metoder med egna värden. 

Anlendningen till att Product fick namnet ProductItem var för jag fick ett problem med namespaces när jag strukturerade upp projektet med mappar och flyttade runt filerna, försökte lösa det men hann inte riktigt med sista dagen.

När jag började ville jag försöka undvika att använda så mycket switch satser och Console.Writelines och istället använda mig av StringBuilder för att kunna komponera ihop en 
meny som jag ville skulle innehålla en "statisk" top och bottom del som var likadan hela tiden och kunna byta ut arrayen med "content"
som skulle visa menyalterativen dynamiskt. Detta lyckades jag inte riktigt lösa som jag tänkt från början utan fick använda StringBuildern och hårdkoda de olika menyerna i olika metoder.

Detta gjorde att jag ändå fick använda en stor switch sats i min ConsoleHelper klass och metoden MenuHelper() som fick styra appens menyval. 
Där använder tar jag ett View objekt som jag använder för att displaya de olika hårdkodade menyerna. 

När en produkt köps och skapas så skapas den i Factory klassen och returneras till MenuHelper där jag sedan kan skriva ut varje produkts beskrivning, kostnad och namn via dess overriden metoder.
Kallar också på TestUserInput() metoden som parsar till en Int och kollar att den inte är högre än menyvalen som existerar. 

I klassen MenuHelper så byggs de olika menyerna. I MenuOptions klassen har jag en string[] Options som är tom. MainMenu klassen skapar olika objekt av MenuOptions och skriver över Options[] med olika hårdkodade string arrays.

PageBuilder klassen används sedan till att "Bygga" ihop en meny med Top, en Mid(content) och en Bottom del via Build() metoden, som tar in en string för top, en string[] för content och en string för bottom.
Där Appendar metoden alla delarna och kör en ForEach loop för att skriva ut varje string ur arrayen som skicktats in.

Det finns också en metod för BuildTop() och BuildBottom() som egentligen bara returnerar ett stringbuilder objekt som görs om till en string. 

I klassen View så finns metoder för att displaya varje Menu. Det görs genom att varje metod skapar ett PageBuilder objekt som sedan kör de olika Build() metoderna och sparar dom i variabler. 
Dom skapar också ett MainMenu objekt så man kan komma åt varje specifik array och spara det i en variabel vid namn "content". Slutligen körs Build() metoden på pagebuilder objektet med variablerna top, content och bottom.

Skapade också upp en metod som skriver ut ett GoodByeMessage() när programmet avslutas. 

### Slutsats

Jag är inte speciellt nöjd med hur den här appen är strukturerad eller hur slutresultat blev men den fungerar iaf i slutändan. Från början ville jag undvika att använda switch satser så mycket jag kunde och jag hade en tanke 
att jag ville kunna byta ut arrayen med menyalternativ dynamiskt i min StringBuilder beroende på vad användaren väljer. Där fastnade jag alldeles för lång tid och jag fick det ändå inte att fungera som jag ville och fick 
ändå återgå till att använda en stor switch sats. Det kändes som ett misslyckande och jag tappade nog också lite motivation där tyvärr.

Skulle i efterhand strukturerat min tid lite bättre och kanske även bett om mer hjälp när jag körde fast istället för att stånga mig blodig. 
Men oavsett så lärde jag mig lite om användandet av abstrakta klasser och arv osv.

