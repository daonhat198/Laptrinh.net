internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong phan tu cua mang :");
        int n = int.Parse(Console.ReadLine());
        int[] A = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap cac phan tu mang :");
            A[i] = int.Parse(Console.ReadLine());
        }
        int tong = 0;
        for (int i = 0; i < n; i++)
        {
            tong += A[i];
        }
        Console.WriteLine("Tong cac phan tu cua mang la:" + tong);
    }
}