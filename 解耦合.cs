using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //我們來解耦合吧!!
            var persion = new International(new American());

            Console.WriteLine(persion.Status());
        }
    }

    class International
    {
        private IPersion persion;
        public International(IPersion _persion)
        {
            persion = _persion;
        }

        public string Status()
        {
            string eyes = persion.EyesColor();
            string hair = persion.HairColor();
            string lang = persion.SpeakLan();
            return $"eyes color is {eyes} and hair is {hair} and speak {lang}";
        }
    }

    interface IPersion
    {
        string EyesColor();
        string HairColor();
        string SpeakLan();
    }

    class Taiwanese : IPersion
    {
        public string EyesColor()
        {
            return "Black";
        }

        public string HairColor()
        {
            return "Black";
        }

        public string SpeakLan()
        {
            return "Speak Chianese";
        }
    }

    class American : IPersion
    {
        public string EyesColor()
        {
            return "Blue";
        }

        public string HairColor()
        {
            return "Gold";
        }

        public string SpeakLan()
        {
            return "English";
        }
    }
}
