## VendingMachine

S� min tanke n�r jag b�rjade med det h�r projektet var att testa anv�nda n�tt Design Pattern som vi hade g�tt igenom i skolan. Testade att anv�nda mig av Decorator m�nstret 
d�r man har en abstrakt klass, en konkret klass och ett interface. Sedan adderade man varje produkt som en "tempproduct". Men efter ha omv�rderat s� k�ndes det on�digt och jag valde strukturen 
med en abstract klass Product med ett Interface IProduct ist�llet. Varje individuell Product �rver sedan fr�n Product och overridar dess metoder med egna v�rden. 

Anlendningen till att Product fick namnet ProductItem var f�r jag fick ett problem med namespaces n�r jag strukturerade upp projektet med mappar och flyttade runt filerna, f�rs�kte l�sa det men hann inte riktigt med sista dagen.

N�r jag b�rjade ville jag f�rs�ka undvika att anv�nda s� mycket switch satser och Console.Writelines och ist�llet anv�nda mig av StringBuilder f�r att kunna komponera ihop en 
meny som jag ville skulle inneh�lla en "statisk" top och bottom del som var likadan hela tiden och kunna byta ut arrayen med "content"
som skulle visa menyalterativen dynamiskt. Detta lyckades jag inte riktigt l�sa som jag t�nkt fr�n b�rjan utan fick anv�nda StringBuildern och h�rdkoda de olika menyerna i olika metoder.

Detta gjorde att jag �nd� fick anv�nda en stor switch sats i min ConsoleHelper klass och metoden MenuHelper() som fick styra appens menyval. 
D�r anv�nder tar jag ett View objekt som jag anv�nder f�r att displaya de olika h�rdkodade menyerna. 

N�r en produkt k�ps och skapas s� skapas den i Factory klassen och returneras till MenuHelper d�r jag sedan kan skriva ut varje produkts beskrivning, kostnad och namn via dess overriden metoder.
Kallar ocks� p� TestUserInput() metoden som parsar till en Int och kollar att den inte �r h�gre �n menyvalen som existerar. 

I klassen MenuHelper s� byggs de olika menyerna. I MenuOptions klassen har jag en string[] Options som �r tom. MainMenu klassen skapar olika objekt av MenuOptions och skriver �ver Options[] med olika h�rdkodade string arrays.

PageBuilder klassen anv�nds sedan till att "Bygga" ihop en meny med Top, en Mid(content) och en Bottom del via Build() metoden, som tar in en string f�r top, en string[] f�r content och en string f�r bottom.
D�r Appendar metoden alla delarna och k�r en ForEach loop f�r att skriva ut varje string ur arrayen som skicktats in.

Det finns ocks� en metod f�r BuildTop() och BuildBottom() som egentligen bara returnerar ett stringbuilder objekt som g�rs om till en string. 

I klassen View s� finns metoder f�r att displaya varje Menu. Det g�rs genom att varje metod skapar ett PageBuilder objekt som sedan k�r de olika Build() metoderna och sparar dom i variabler. 
Dom skapar ocks� ett MainMenu objekt s� man kan komma �t varje specifik array och spara det i en variabel vid namn "content". Slutligen k�rs Build() metoden p� pagebuilder objektet med variablerna top, content och bottom.

Skapade ocks� upp en metod som skriver ut ett GoodByeMessage() n�r programmet avslutas. 

### Slutsats

Jag �r inte speciellt n�jd med hur den h�r appen �r strukturerad eller hur slutresultat blev men den fungerar iaf i slut�ndan. Fr�n b�rjan ville jag undvika att anv�nda switch satser s� mycket jag kunde och jag hade en tanke 
att jag ville kunna byta ut arrayen med menyalternativ dynamiskt i min StringBuilder beroende p� vad anv�ndaren v�ljer. D�r fastnade jag alldeles f�r l�ng tid och jag fick det �nd� inte att fungera som jag ville och fick 
�nd� �terg� till att anv�nda en stor switch sats. Det k�ndes som ett misslyckande och jag tappade nog ocks� lite motivation d�r tyv�rr.

Skulle i efterhand strukturerat min tid lite b�ttre och kanske �ven bett om mer hj�lp n�r jag k�rde fast ist�llet f�r att st�nga mig blodig. 
Men oavsett s� l�rde jag mig lite om anv�ndandet av abstrakta klasser och arv osv.

