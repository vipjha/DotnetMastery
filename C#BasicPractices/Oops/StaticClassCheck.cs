namespace Oops
{
    public static class StaticClassCheck
    {
        public static void StaticMethodOne()
        {
            Console.WriteLine("Static class cannot call non-static method");
        }
    }

    public  class NonStaticClassCheck
    {
        public static void StaticMethodOne()
        {
            Console.WriteLine("Static class cannot call non-static method");
        }

        public void NonStaticMethodOne()
        {
            Console.WriteLine("Static class cannot call non-static method");
        }
    }
}
