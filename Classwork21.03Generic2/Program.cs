namespace Classwork21._03Generic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generic <int> generic = new Generic<int> {};
            generic.Meth1(5);
            generic.Meth2(7, false);
        }
    }
}