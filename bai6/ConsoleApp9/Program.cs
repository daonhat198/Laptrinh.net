internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap mot chuoi :");
        string input = Console.ReadLine();

        Console.WriteLine("Nhap ky tu can dem :");
        char kt = char.Parse(Console.ReadLine());

        int dem = 0;
        foreach(char c in input)
        {
            if(c == kt)
            {
                dem++;
            }
        }
        Console.WriteLine("So lan ky tu xuat hien la :" +dem);  
    }
}
