namespace LineComparion
{
    public static class program
    { 
       public static void Main(string[] args)
           {

            Console.WriteLine("welcome to line comparision computation problem");
            length Length = new length();
            length.Length();
            Console.ReadLine();
            equal lc = new equal();
            lc.length_line();
            lc.function_check();
            Console.ReadLine();
        }
    }
}