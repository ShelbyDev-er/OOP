using System;
using System.Text;

namespace ThienAn88
{
    public class Program
    {
        public static void Main()
        {
            if (Authentication())
            {
                Console.OutputEncoding = Encoding.UTF8;
                int totalMoney = 1000000, choice;
                bool active = true;
                while (active)
                {
                    choice = MainMenu(totalMoney);
                    switch (choice)
                    {
                        case 1:
                            TaiXiuGame(ref totalMoney);
                            break;
                        case 2:
                            Console.WriteLine(" Đang Cập Nhật..");
                            break;
                        case 3:
                            Console.WriteLine(" Đang Cập Nhật..");
                            break;
                        case 4:
                            Console.WriteLine(" Đang Cập Nhật..");
                            break;
                        case 5:
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine(" Bạn Đã Nhập Sai Tài Khoản Hoặc Mật Khẩu\nVui Lòng Ấn Enter Để Trở Lại..");
            }
        }
        public static void TaiXiuGame(ref int totalMoney)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rdm = new Random();
            bool active = true;
            int choice = 0, xucxac1 = 0, xucxac2 = 0, xucxac3 = 0;
            while (active)
            {
                choice = TaiXiuMenu(totalMoney);
                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                        xucxac1 = rdm.Next(0, 7);
                    else if (i == 1)
                        xucxac2 = rdm.Next(0, 7);
                    else
                        xucxac3 = rdm.Next(0, 7);
                }
                if (choice == 1)
                {
                    Console.WriteLine("==================================");
                    Console.WriteLine($" VÍ TIỀN: {totalMoney}");
                    Console.WriteLine("==================================");
                    Console.Write(" Nhập Số Tiền Muốn Cược: ");
                    int betMoney = Convert.ToInt32(Console.ReadLine());
                    if (betMoney > totalMoney)
                    {
                        Console.WriteLine("Hãy Chắc Rằng Bạn Còn Đủ Tiền Để Cược");
                        TaiXiuGame(ref totalMoney);
                    }
                    Console.WriteLine(" Bạn Đã Đặt Cược Tài!");
                    if (xucxac1 + xucxac2 + xucxac3 > 10)
                    {
                        Console.Write(" Nhấn Enter Để Mở Bát..");
                        Console.ReadKey();
                        Console.WriteLine($"\n\n Xúc xắc 1: {xucxac1}\n Xúc xắc 2: {xucxac2}\n Xúc xắc 3: {xucxac3}\n");
                        Console.WriteLine(" Chúc Mừng Bạn!");
                        totalMoney = totalMoney + betMoney;
                        Console.ReadKey();
                        Console.Write("\n Tiền Đã Được Cộng Vào Tài Khoản!\n Nhấn Enter Để Tiếp Tục..");
                        Console.ReadKey();
                    }
                    else
                    {
                        totalMoney = totalMoney - betMoney;
                        Console.Write(" Nhấn Enter Để Mở Bát..");
                        Console.ReadKey();
                        Console.WriteLine($"\n\n Xúc xắc 1: {xucxac1}\n Xúc xắc 2: {xucxac2}\n Xúc xắc 3: {xucxac3}\n");
                        if (totalMoney <= 0)
                        {
                            Console.WriteLine(" Vui Lòng Nạp Thêm Tiền!\n Nhấn Enter Để Tiếp Tục..");
                            Console.ReadKey();
                            return;
                        }
                        Console.Write("\n Chúc Bạn May Mắn Lần Sau\n Nhấn Enter Để Tiếp Tục..");
                        Console.ReadKey();
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("==================================");
                    Console.WriteLine($" VÍ TIỀN: {totalMoney}");
                    Console.WriteLine("==================================");
                    Console.Write(" Nhập Số Tiền Muốn Cược: ");
                    int betMoney = Convert.ToInt32(Console.ReadLine());
                    if (betMoney > totalMoney)
                    {
                        Console.WriteLine("Hãy Chắc Rằng Bạn Còn Đủ Tiền Để Cược");
                        TaiXiuGame(ref totalMoney);
                    }
                    Console.WriteLine(" Bạn Đã Đặt Cược Xỉu!");
                    if (xucxac1 + xucxac2 + xucxac3 <= 10)
                    {
                        Console.Write(" Nhấn Enter Để Mở Bát..");
                        Console.ReadKey();
                        Console.WriteLine($"\n\n Xúc xắc 1: {xucxac1}\n Xúc xắc 2: {xucxac2}\n Xúc xắc 3: {xucxac3}\n");
                        Console.WriteLine(" Chúc Mừng Bạn!");
                        totalMoney = totalMoney + betMoney;
                        Console.Write("\n Tiền Đã Được Cộng Vào Tài Khoản!\n Nhấn Enter Để Tiếp Tục..");
                        Console.ReadKey();
                    }
                    else
                    {
                        totalMoney = totalMoney - betMoney;
                        Console.Write(" Nhấn Enter Để Mở Bát..");
                        Console.ReadKey();
                        Console.WriteLine($"\n\n Xúc xắc 1: {xucxac1}\n Xúc xắc 2: {xucxac2}\n Xúc xắc 3: {xucxac3}\n");
                        if (totalMoney <= 0)
                        {
                            Console.WriteLine(" Vui Lòng Nạp Thêm Tiền!\n Nhấn Enter Để Tiếp Tục..");
                            Console.ReadKey();
                            return;
                        }
                        Console.Write("\n Chúc Bạn May Mắn Lần Sau\n Nhấn Enter Để Tiếp Tục..");
                        Console.ReadKey();
                    }
                }
                else if (choice == 3)
                {
                    return;
                }
                else if (totalMoney <= 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine(" Vui Lòng Nhập Lại!");
                }
            }
        }
        public static int TaiXiuMenu(int totalMoney)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("==================================");
            Console.WriteLine("             TÀI XỈU");
            Console.WriteLine("==================================");
            Console.WriteLine($" VÍ TIỀN: {totalMoney}đ");
            Console.WriteLine("==================================");
            Console.WriteLine(" 1. TÀI");
            Console.WriteLine(" 2. XỈU");
            Console.WriteLine(" 3. TRỞ VỀ SẢNH");
            Console.WriteLine("==================================");
            Console.Write(" Lựa chọn (1-3): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        public static int MainMenu(int totalMoney)
        {
            int choice = 0;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("==================================");
            Console.WriteLine("           THIEN AN 88");
            Console.WriteLine("==================================");
            Console.WriteLine($" VÍ TIỀN: {totalMoney}đ");
            if (totalMoney <= 0)
            {
                Console.WriteLine("==================================");
                Console.WriteLine(" Vui Lòng Nạp Thêm Tiền!");
                Console.WriteLine("==================================");
                Console.WriteLine(" 1. NẠP TIỀN");
                Console.WriteLine(" 2. EXIT");
                Console.WriteLine("==================================");
                Console.Write(" Lựa chọn: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            else if (totalMoney > 0)
            {
                Console.WriteLine("==================================");
                Console.WriteLine(" 1. TÀI XỈU");
                Console.WriteLine(" 2. TIẾN LÊN MIỀN NAM");
                Console.WriteLine(" 3. OM 3 CÂY");
                Console.WriteLine(" 4. NẠP TIỀN");
                Console.WriteLine(" 5. EXIT");
                Console.WriteLine("==================================");
                Console.Write(" Lựa chọn (1-5): ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            return choice;
        }
        public static bool Authentication()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("==================================");
            Console.WriteLine("               AN88");
            Console.WriteLine("==================================");
            Console.Write(" TÀI KHOẢN: ");
            string? account = Console.ReadLine();
            Console.Write(" MẬT KHẨU:  ");
            string? password = Console.ReadLine();
            if (account == "abc123" && password == "123456")
            {
                return true;
            }
            return false;
        }
    }
}