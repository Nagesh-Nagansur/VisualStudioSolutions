namespace Generics
{
    class Generics3<T>
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            System.Console.WriteLine(d1 + d2);
        }
        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            System.Console.WriteLine(d1 - d2);
        }

    }
}
