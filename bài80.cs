using System;
using System.Text;
using System.Threading;

class bài80
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Tạo và bắt đầu một luồng mới để thực thi phương thức ff
        Thread thread = new Thread(ff);
        thread.Start();

        // Đợi luồng kết thúc
        thread.Join();

        // Hiển thị thông báo khi luồng kết thúc
        Console.WriteLine("Đã thực hiện xong");
    }

    static void ff()
    {
        Random random = new Random();

        while (true)
        {
            // Tạo một số nguyên ngẫu nhiên
            int n = random.Next();

            // Kiểm tra nếu n chia hết cho 2025
            if (n % 2025 == 0)
            {
                break;
            }

            // Hiển thị số ngẫu nhiên
            Console.WriteLine(n);

            // Delay 100 milliseconds
            Thread.Sleep(100);
        }
    }
}
