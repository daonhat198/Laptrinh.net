internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so pha tu mang :");
        int n = int.Parse(Console.ReadLine());
        int[] A = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap cac phan tu mang :");
            A[i] = int.Parse(Console.ReadLine());
        }
        bool kiemtra = true;
        for (int i = 0; i < n; i++)
        {
            if (A[i] != A[n - i - 1])
            {
                kiemtra = false;
                break;
            }
        }
        if (kiemtra)
        {
            Console.WriteLine("Mang  doi xung ");
        }
        else
        {
            Console.WriteLine("Mang khong do xung ");
        }

    }
}
