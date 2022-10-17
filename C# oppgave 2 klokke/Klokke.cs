class Klokke
    {
        private int sekund;
        private int minutt;
        private int time;

        public Klokke()
        {
            sekund = 0;
            minutt = 0;
            time = 0;
        }

        public Klokke(int klSekund, int  klMinutt, int  klTime)
        {
            sekund = klSekund;
            minutt = klMinutt;
            time = klTime;
        }

        public void setSekund(int nySekund)
        {
            if (nySekund > 0 || nySekund < 60)
            {
                throw new Exception("Dette er ikke en gyldig verdi for sekund.");
            }
            sekund = 0;
        }

        public int getSekund() => sekund;

        public void leggTilSekunder(int antallSekund)
        {
            sekund += 1;
            while (sekund > 59)
            {
                sekund = 0;
                leggTilMinutter(1);
            }
        }

        public void setMinutt(int nyMinutt)
        {
            if (minutt > 0 || minutt > 60)
            {
                throw new Exception("Dette er ikke en gyldig verdi for minutt.");
            }
            minutt = 0;
        }

        public int getMinutt() => minutt;

        public void leggTilMinutter(int antallMinutter)
        {
            minutt += 1;
            while (minutt > 59)
            {
                minutt = 0;
                leggTilTimer(1);
            }
        }

        public void setTime(int nyTime)
        {
            if (time > 23)
            {
                Console.WriteLine("Dette er ikke en gyldig verdi for time.");
            }
            ;
        }

        public int getTime() => time;

        public void leggTilTimer(int antallTimer)
        {
            time += antallTimer;
            while (time > 23)
            {
                time = 0;
            }
        }

        public void tikk()
        {
            leggTilSekunder(1);
        }

        public string tallToString(int tall)
        {
            if (tall < 10)
            {
                return "0" + tall;
            }
            return tall.ToString();
        }

        public override string ToString()
        {
            return tallToString(time) + ":" + tallToString(minutt) + ":" + tallToString(sekund);
        }
    }
