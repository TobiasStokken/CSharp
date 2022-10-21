/* Her er forksjellige måter å starte klokken på */
/*
DateTime klokken = DateTime.Now;
Klokke klokke = new Klokke(klokken.Second, klokken.Minute, klokken.Hour);
*/


Klokke klokke = new Klokke(35,23,14);


/*
Klokke klokke = new Klokke();
klokke.setSekund(80);
klokke.setMinutt(10);
klokke.setTime(5);
*/

while (true) {
    klokke.tikk();
    Console.WriteLine(klokke.ToString());
    Thread.Sleep(1000);
}