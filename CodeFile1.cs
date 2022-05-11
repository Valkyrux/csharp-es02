namespace es02
{
    public static class myMethods
    {
        public static int somma(int number1, int number2)
        {
            return number1 + number2;
        }
        
        public static int sottrazione(int number1, int number2)
        {
            return number1 - number2;
        }

        public static int moltiplicazione (int number1, int number2)
        {
            return number1 * number2;
        }

        public static float divisione(float number1, float number2)
        {
            return number1 / number2;
        }

        public static int quadrato (int number)
        {
            return number * number;
        }

        public static float media(float[] arrayNumber)
        {
            float media = 0;
            foreach (float value in arrayNumber)
            {
                media += value;
            }
            return media/arrayNumber.Length;
        }

        public static int potenza(int value, int esponente)
        {
            int potenza = 1;
            for (int i = 0; i < esponente; i++)
            {
                potenza *= value;
            }
            return potenza;
        }

        public static int trovaMaxInVettore(int[] arrayNumber)
        {
            int maxNumber = arrayNumber[0];
            foreach(int value in arrayNumber)
            {
                if (value > maxNumber)
                {
                    maxNumber = value;
                }
            }
            return maxNumber;
        }

        public static int trovaMinInVettore(int[] arrayNumber)
        {
            int minNumber = arrayNumber[0];
            foreach (int value in arrayNumber)
            {
                if (value < minNumber)
                {
                    minNumber = value;
                }
            }
            return minNumber;
        }

        public static float trovaMediano(float[] arrayNumber)
        {
            float media = myMethods.media(arrayNumber);
            float scarto = Math.Abs((float)arrayNumber[0] - media);
            int medianoIndex = 0;

            for (int i = 0; i < arrayNumber.Length; i++)
            {
                if ((float)arrayNumber[i] - media < scarto)
                {
                    scarto = Math.Abs((float)arrayNumber[i] - media);
                    medianoIndex = i;
                }
            }

            return arrayNumber[medianoIndex];
        }
    }
}