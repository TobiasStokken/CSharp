DateTime klokken = DateTime.Now;
Klokke klokke = new Klokke(klokken.Second, klokken.Minute, klokken.Hour);
while (true) {
    klokke.tikk();
    Console.WriteLine(klokke.ToString());
    Thread.Sleep(1000);
}