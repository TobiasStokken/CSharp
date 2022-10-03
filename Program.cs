/* Her er en fancy start side som spør om du vil fortsette eller avslutte */
static void start(){

Console.WriteLine(@"

░██████╗████████╗░█████╗░██████╗░████████╗
██╔════╝╚══██╔══╝██╔══██╗██╔══██╗╚══██╔══╝
╚█████╗░░░░██║░░░███████║██████╔╝░░░██║░░░
░╚═══██╗░░░██║░░░██╔══██║██╔══██╗░░░██║░░░
██████╔╝░░░██║░░░██║░░██║██║░░██║░░░██║░░░
╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░
    [1] Random ting du kansje lurer på
    [2] Quiz
    [3] Exit

");

/* leser svar å bestemmer hva som skal skje */
string valg = Console.ReadLine();
if (valg == "1")
{
    RandomTingDuKansjeLurerPå();
} else if (valg == "2") {
    Quiz();
}
/* avslutt program */
else{
    Environment.Exit(1);
}
}

/* Ja eg vet det er et dårli navn men her kan du finne ut av random ting du lurer på */
static void RandomTingDuKansjeLurerPå()
{


/* Fin meny om hva du vil vite */
Console.WriteLine(@"

█░█ █░█ ▄▀█   █░█ █ █░░   █▀▄ █░█   █░█ █ ▀█▀ █▀▀
█▀█ ▀▄▀ █▀█   ▀▄▀ █ █▄▄   █▄▀ █▄█   ▀▄▀ █ ░█░ ██▄

        [1] Hvor gammel om X år
        [2] Hvor lenge til Jul
        [3] Når dør du?
        [4] Tilbake


");
string svar = Console.ReadLine();


    /* Finner navnet ditt å alder */
if (svar == "1"){
Console.Clear();
Console.WriteLine("Hva heter du?");
string navn = Console.ReadLine();

Console.Clear();
Console.WriteLine("Hvor gammel er du");
string alderString = Console.ReadLine();
int alder = Int32.Parse(alderString);

/* Regner hvor gammel personen er etter x år */
Console.Clear();
Console.WriteLine("Hvor mange år?");
string xÅrString = Console.ReadLine();
int xÅr = Int32.Parse(xÅrString);
int alderOmXÅr = (alder + xÅr);
Console.Clear();
Console.WriteLine("Du er " + alderOmXÅr + " år om " + xÅr + " år.");
Console.WriteLine("Trykk enter for å fortsette...");
Console.ReadLine();
RandomTingDuKansjeLurerPå();

    /* Finner ut hvor lenge til det er Jul */
} else if (svar == "2"){
    Console.Clear();
    DateTime jul = new DateTime(DateTime.Now.Year, 12, 24);
    TimeSpan diff = (jul - DateTime.Now);
    Console.WriteLine(diff.Days + " Dager til Jul.");
    Console.WriteLine("Trykk enter for å fortsette...");
    Console.ReadLine();
    RandomTingDuKansjeLurerPå();
} 

/* Teller ned fra 10 for å skremme deg */
else if (svar == "3"){
int tid = 10;
while (tid != 0){
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Du dør om " + tid);
    Thread.Sleep(1000);
    tid--;
}
Console.ResetColor(); 

} else{
    start();
}

}

/* Her er Quizen */
static void Quiz(){
    Console.WriteLine("Jobbes fortsatt med...");
    Console.ReadLine();
    start();
}


start();