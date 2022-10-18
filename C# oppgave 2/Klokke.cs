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
            setSekund(klSekund);
            setMinutt(klMinutt);
            setTime(klTime);
        }

        public void setSekund(int nySekund)
        {
            if (nySekund > 60 || nySekund < 0)
            {
                throw new Exception("Dette er ikke en gyldig verdi for sekund.");
            }
            sekund = nySekund;
        }

        public int getSekund() => sekund;

        public void leggTilSekunder(int antallSekund)
        {
            sekund += antallSekund;
            while (sekund > 59)
            {
                sekund = 0;
                leggTilMinutter(1);
            }
        }

        public void setMinutt(int nyMinutt)
        {
            if (nyMinutt > 60 || nyMinutt < 0)
            {
                throw new Exception("Dette er ikke en gyldig verdi for minutt.");
            }
            minutt = nyMinutt;
        }

        public int getMinutt() => minutt;

        public void leggTilMinutter(int antallMinutter)
        {
            minutt += antallMinutter;
            while (minutt > 59)
            {
                minutt = 0;
                leggTilTimer(1);
            }
        }

        public void setTime(int nyTime)
        {
            if (nyTime > 23 || nyTime < 0)
            {
                throw new Exception("Dette er ikke en gyldig verdi for time.");
            }
            time = nyTime;
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
