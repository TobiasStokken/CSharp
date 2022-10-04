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
        Console.Clear();
        RandomTingDuKansjeLurerPå();
    } else if (valg == "2") {
        Console.Clear();
        Quiz();
    }
    /* avslutt program */
    else{
        Console.Clear();
        Environment.Exit(1);
    }
}




/* Ja eg vet det er et dårli navn men her kan du finne ut av random ting du lurer på, det er så lite program så tenker det går fint med litt dårli navn */
static void RandomTingDuKansjeLurerPå(){

    /* Fin meny om hva du vil vite */
    Console.WriteLine(@"
    █░█ █░█ ▄▀█   █░█ █ █░░   █▀▄ █░█   █░█ █ ▀█▀ █▀▀
    █▀█ ▀▄▀ █▀█   ▀▄▀ █ █▄▄   █▄▀ █▄█   ▀▄▀ █ ░█░ ██▄

            [1] Hvor gammel om X år
            [2] Hvor lenge til Jul
            [3] Nedtelling
            [4] Tilbake
    ");
    string svar = Console.ReadLine();


        /* Finner navnet ditt å alder */
    if (svar == "1"){
        Console.Clear();
        Console.WriteLine("Hva heter du?");
        string navn = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Hvor gammel er du? (tall)");
        string alderString = Console.ReadLine();
        int alder = Int32.Parse(alderString);

        /* Regner hvor gammel personen er etter x år */
        Console.Clear();
        Console.WriteLine("Hvor mange år? (tall)");
        string xÅrString = Console.ReadLine();
        int xÅr = Int32.Parse(xÅrString);
        int alderOmXÅr = (alder + xÅr);
        Console.Clear();
        Console.WriteLine("Du er " + alderOmXÅr + " år om " + xÅr + " år.");
        Console.WriteLine("Trykk enter for å fortsette...");
        Console.ReadLine();
        Console.Clear();
        RandomTingDuKansjeLurerPå();

        /* Finner ut hvor lenge til det er Jul */
    } else if (svar == "2"){
        Console.Clear();
        DateTime jul = new DateTime(DateTime.Now.Year, 12, 24);
        TimeSpan diff = (jul - DateTime.Now);
        Console.WriteLine(diff.Days + " Dager til Jul.");
        Console.WriteLine("Trykk enter for å fortsette...");
        Console.ReadLine();
        Console.Clear();
        RandomTingDuKansjeLurerPå();
    } 

    /* Teller ned fra 10 for å skremme deg */
    else if (svar == "3"){
        Console.Clear();
        Console.WriteLine("Hvor mange sekunder nedtelling hvil du ha? (tall)");
        string tidString = Console.ReadLine();
        int tid = Int32.Parse(tidString);
        int tidStatic = Int32.Parse(tidString);
        Console.Clear();
        while (tid != 0){
            Console.WriteLine("Tid igjen: " + tid + " sekunder.");
            Thread.Sleep(1000);
            tid--;
        }

        Console.Clear();
        Console.Beep();
        Console.WriteLine("Nedtelling på " + tidStatic + " sekunder er ferdig!");
        Console.WriteLine("Trykk enter for å fortsette...");
        Console.ReadLine();
        Console.Clear();
        start();


    } else{
        /* tømmer skjermen og starter startskjermen */
        Console.Clear();
        start();
    }

}



/* Her er Quizen */
static void Quiz(){
    Console.WriteLine(@"
    ░██████╗░██╗░░░██╗██╗███████╗
    ██╔═══██╗██║░░░██║██║╚════██║
    ██║██╗██║██║░░░██║██║░░███╔═╝
    ╚██████╔╝██║░░░██║██║██╔══╝░░
    ░╚═██╔═╝░╚██████╔╝██║███████╗
    ░░░╚═╝░░░░╚═════╝░╚═╝╚══════╝
            [1] Start
            [2] Tilbake
    ");
    string valg = Console.ReadLine();
    if (valg != "1"){
        start();
    } else{
        Console.WriteLine("Jobbes fortsatt med...");
        Console.ReadLine();
        start();
    /*
    ... QUIZ HER
    */
    }
}

start();


