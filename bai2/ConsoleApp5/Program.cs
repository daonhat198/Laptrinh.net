internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap mot chuoi :");
        string input = Console.ReadLine();
        int dem = 0;
        foreach(char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                dem++;
            }
        }
        Console.WriteLine("So luong ki tu trong chuoi la :" +dem);
    }
}
