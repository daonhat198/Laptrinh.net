internal class Program
{
   static void Main(string[] args)
    {
        Console.WriteLine("Nhap mot chuoi :");
        string input = Console.ReadLine();
        char[] A = input.ToCharArray();
        Array.Reverse(A);
       
        string output = new string(A);
        Console.WriteLine("Chuoi sau khi dao nguoc :" +output);
    }
}