namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Test test = new Test();
            int[]arr = {1,2,3,2,4};
            int[]arr1 = {1,2,3,4};

            test.Exception(arr);
            Console.WriteLine("================");
            test.Exception(arr1);
            Console.WriteLine("================");
            test.Exception("Sky");
            Console.WriteLine("================");
            test.Exception("Ahmed");

        }

    }
}
