using System.ComponentModel;

namespace WinFormsApp1
{
    internal class Calculator
    {
        //instance variables
        private int prize = 0;
        private int payment = 0;

        private int fiveHundredCounter = 0;
        private int twoHundredCounter = 0;
        private int oneHundredCounter = 0;
        private int fiftyCounter = 0;
        private int twentyCounter = 0;
        private int tenCounter = 0;
        private int fiveCounter = 0;
        private int oneCounter = 0;

        //getters and setters
        public int GetPrize()
        {
            return prize;
        }
        public void SetPrize(int value)
        {
            if (value >= 0)
                prize = value;
        }
        public int GetPayment()
        {
            return payment;
        }
        public void SetPayment(int value)
        {
            if (value >= 0)
                payment = value;
        }
        //getters for money counters
        public int GetFiveHundreds()
        { 
            return fiveHundredCounter; 
        }
        public int GetTwoHundreds()
        {
            return twoHundredCounter;
        }
        public int GetOneHundreds()
        {
            return oneHundredCounter;
        }
        public int GetFifties()
        {
            return fiftyCounter;
        }
        public int GetTwenties()
        {
            return twentyCounter;
        }
        public int GetTens()
        {
            return tenCounter;
        }
        public int GetFives()
        {
            return fiveCounter;
        }
        public int GetOnes()
        {
            return oneCounter;
        }

        //calculate change
        public void CalculateChange()
        {
            int changeTotal = payment - prize;

            while (changeTotal > 0)
            {
                if (changeTotal >= 500)
                {
                    while (changeTotal >= 500)
                    {
                        changeTotal -= 500;
                        fiveHundredCounter++;
                    }
                }
                else if (changeTotal >= 200)
                {
                    while (changeTotal >= 200)
                    {
                        changeTotal -= 200;
                        twoHundredCounter++;
                    }
                }
                else if (changeTotal >= 100)
                {
                    while (changeTotal >= 100)
                    {
                        changeTotal -= 100;
                        oneHundredCounter++;
                    }
                }
                else if (changeTotal >= 50)
                {
                    while (changeTotal >= 50)
                    {
                        changeTotal -= 50;
                        fiftyCounter++;
                    }
                }
                else if (changeTotal >= 20)
                {
                    while (changeTotal >= 20)
                    {
                        changeTotal -= 20;
                        twentyCounter++;
                    }
                }
                else if (changeTotal >= 10)
                {
                    while (changeTotal >= 10)
                    {
                        changeTotal -= 10;
                        tenCounter++;
                    }
                }
                else if (changeTotal >= 5)
                {
                    while (changeTotal >= 5)
                    {
                        changeTotal -= 5;
                        fiveCounter++;
                    }
                }
                else if (changeTotal >= 1)
                {
                    while (changeTotal >= 1)
                    {
                        changeTotal -= 1;
                        oneCounter++;
                    }
                }

            };
        }

        //adjusts bill and coin to plural, bills and coins, if the amount calls for it
        public string MoneyTypePlural(int value)
        {
            string pluralType = "";

            if (value > 1)
            {
                pluralType += "s";
            }

            return pluralType;
        }

    }
}
