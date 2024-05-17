namespace TRY1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, x2;

            Console.WriteLine("請輸入第一個數字：");
            while (!int.TryParse(Console.ReadLine(), out x1))
            {
                Console.WriteLine("無效的輸入。請輸入一個數字。");
            }

            Console.WriteLine("請輸入第二個數字：");
            while (!int.TryParse(Console.ReadLine(), out x2))
            {
                Console.WriteLine("無效的輸入。請輸入一個數字。");
            }

            int result = x1 * x2;
            Console.WriteLine($"兩數的乘積是：{result}");

            // 調用 Calculate_CharCount 方法
            Calculate_CharCount();
        }

        // 將 Calculate_CharCount 方法移至 Main 方法外部
        static void Calculate_CharCount()
        {
            Console.WriteLine("請輸入一行文字：");
            string? line = Console.ReadLine();
            int charCount = line?.Length ?? 0;
            Console.WriteLine($"{charCount} 是文字的長度。");
        }
    }
}