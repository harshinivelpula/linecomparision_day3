namespace LineComparion
{
    public static class program
    { 
       public static void Main(string[] args)
           {

            Console.WriteLine("welcome to line comparision computation problem");
            greater Greater = new greater();
            Greater.length_line();
           
            Greater.Comparelines();
            Console.ReadLine();
        }
    }
}