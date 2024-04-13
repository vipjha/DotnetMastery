namespace Oops
{
    //var is the implicity type variable introduced in c# 8.0
    public class TypesDemo
    {
        public void TypesDemoMehtod()
        {
            // float: Represents a single - precision floating - point number.
            // Occupies 4 bytes(32 bits) in memory.
            // Approximate range: ±1.5 x 10 ^ -45 to ±3.4 x 10 ^ 38.
            // Suitable for scenarios where memory usage is a concern and a higher degree of precision is not required, such as graphics processing or scientific computations where approximate values are acceptable.
            var f = 3.14f; //Use float for scenarios where memory is a concern and precision isn't critical.
            Console.WriteLine(f.GetType());

            //Represents a double-precision floating-point number.
            //Occupies 8 bytes(64 bits) in memory.
            //Approximate range: ±5.0 × 10 ^−324 to ±1.7 × 10 ^ 308.
            //Offers higher precision compared to float.It's commonly used for general-purpose floating-point calculations.
            var d = 3.14; // Use double for general-purpose floating-point calculations.
            Console.WriteLine(d.GetType());

            //Represents a decimal floating-point number.
            //Occupies 16 bytes(128 bits) in memory.
            //Exact range: ±1.0 × 10 ^ -28 to ±7.9 × 10 ^ 28.
            //Offers higher precision and a wider range compared to float and double.It's typically used in financial and monetary calculations or applications where precision is critical.
            var de = 3.14m; //Use decimal for financial and monetary calculations or when exact decimal representation without rounding errors is required.
            Console.WriteLine(de.GetType());
            
            var s = "Hello";
            Console.WriteLine(s.GetType());
        }
    }
}
