namespace Generics
{
    class Generics2
    {
        public void Add<T>(T a,T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            System.Console.WriteLine(d1+d2);
        }
        public void Sub<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            System.Console.WriteLine(d1-d2);
        }




    }
}
