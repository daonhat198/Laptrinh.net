internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so luong phan tu mang :");
        int n = int.Parse(Console.ReadLine());
        int[] A = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap phan tu mang :");
            A[i] = int.Parse(Console.ReadLine());
        }
        int max = A[0];
        for (int i = 0; i < n; i++)
        {
            if (A[i] > max)
            {
                max = A[i];

            }
        }
        Console.WriteLine("Phan tu lon nhat trong mang la :" +max);
    }
}
