namespace ZH20200423
{
    public delegate void LengthChanged(int o, int n);
    class Section
    {
        private int l;
        public event LengthChanged lengthChange;
        public int Length
        {
            set
            {
                if(value < 0)   {
                    throw new System.ArgumentException("Nem lehet negativ a length erteke!");
                }           
                else{
                    lengthChange(l, value);
                    l = value;
                }
            }
            //Feladat szövege nem írta, hogy kell getter, csak setter.
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Section s = new Section();
            s.lengthChange += Change;
            s.Length = 20;
            s.Length = 40;
            s.Length = -30; //Exceptiont kell dobni.
            Console.ReadLine();
        }

        static  void Change(int o, int n)
        {
           Console.WriteLine("Regi ertek:{0}", o );
           Console.WriteLine("Uj ertek:  {1}", n );

        }
    }
}
