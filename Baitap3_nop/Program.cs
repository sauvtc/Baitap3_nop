using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3_nop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string yes = "y";
            while (yes == "y")
            {
                Console.Write("Nhập vào bài tập bạn muốn kiểm tra: ");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Bài 1: Viết chương tình nhập vào số nguyên và kiểm tra  xem  số đó có chia hết cho 3 hay không. Hiển thị kết quả ra màn hình");
                        Console.Write("Nhập  vào số nguyên a: ");
                        int numberA = int.Parse(Console.ReadLine());
                        string result = "Chia hết cho 3";
                        if (numberA % 3 != 0) result = "Không chia hết cho 3";
                        Console.WriteLine(result);
                        break;
                    case 2:
                        Console.WriteLine("Bài 2 Nhập vào số  nguyên dương n, hiển thị bảng cưu  chương từ 1 đến n ra màn hình");
 
                         Console.Write("Nhập  vào số nguyên n: ");
                        int number2 = int.Parse(Console.ReadLine());
                        for (int i2 = 0; i2 <= number2; i2++)
                        {
                            for (int j = 0; j < 10; j++)
                            {
                                int result2 = i2 * j;
                                Console.WriteLine("{0} x {1} = {1}", i2, j, result2);
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Bài 3 Nhập vào số nguyên dương n từ bàn  phím,  tính tổng giai thừa từ 1 đến n và hiển thị kết quả ra màn hình");
                        Console.WriteLine("tong= 1! + 2! +3!");
                        Console.Write("Nhập  vào số nguyên n: ");
                        int number3 = int.Parse(Console.ReadLine());
                        int summary = 0;
                        for (int i3 = 1; i3 <= number3; i3++)
                        {
                            int factorial = 1;
                            for (int j = 1; j <= i3; j++)
                            {
                                factorial *= j;
                            }
                            Console.WriteLine("Giai thừa của {0} là {1}", i3, factorial);
                            summary += factorial;
                        }
                        Console.WriteLine("Tổng giai thưa của số nguyên {0} là {1}", number3, summary);
                        break;
                    case 4:
                        Console.WriteLine("Bài 4 viết chương trình nhập  vào số nguyên từ bàn phím, kiểm tra xem số đó có phải là số chính phương hay không. Hiển  thị kết quả đó ra màn hình");
                        Console.Write("Nhập  vào số nguyên n: ");
                        int number4 = int.Parse(Console.ReadLine());
                        string result4 = "không phải số chính phương";
                        for (int i4 = 1; i4 * i4 <= number4; i4++)
                        {
                            if (i4 * i4 == number4) result = "số chính phương";
                        }
                        Console.WriteLine("{0} là {1}", number4, result4);
                        break;
                    case 5:
                        Console.WriteLine("Bài 5 viết chương trình nhập vào tháng bất kỳ  từ bàn phím, hiển thị số ngày có trong tháng ra màn hình");
                        Console.Write("Nhập  vào năm: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Nhập  vào tháng bất kỳ trong năm: ");
                        int monthInyear = int.Parse(Console.ReadLine());
                        switch (monthInyear)
                        {
                            case 2:
                                int dayInmonth = 28;
                                if (DateTime.IsLeapYear(year)) dayInmonth = 29;
                                Console.WriteLine(" Tháng {0} năm {1} có {2} ngày", monthInyear, year, dayInmonth);
                                break;
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                Console.WriteLine(" Tháng {0} năm {1} có 31 ngày", monthInyear, year);
                                break;
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                Console.WriteLine(" Tháng {0} năm {1} có 30 ngày", monthInyear, year);
                                break;
                            default:
                                Console.WriteLine("Bạn đã nhập tháng không  hợp lệ");
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Bài 6 Viết chương trình nhập vào số nguyên n, tính tổng s theo công thức sau và hiển thị kết quả ra màn hình");
                        Console.WriteLine("s= 1 +  2^2  + 3^3...");
                        Console.Write("Nhập  vào số nguyên n: ");
                        int number6 = int.Parse(Console.ReadLine());
                        double summary6 = 0;
                        for (int i6 = 1; i6 <= number6; i6++)
                        {
                            summary6 += Math.Pow(i6, i6);
                        }
                        Console.WriteLine(summary6);
                        break;
                    case 7:
                        Console.WriteLine("Bài 7 Viết chương trình nhập vào số nguyên n, tính tổng các số lẻ từ 1 đến n và hiển  thị kết quả ra màn hình");
                        Console.Write("Nhập  vào số nguyên n: ");
                        int number7 = int.Parse(Console.ReadLine());
                        int i7 = 1;
                        int sumary7 = 0;
                        while (i7 <= number7)
                        {
                            sumary7 += i7;
                            i7 = i7 + 2;
                        }
                        Console.WriteLine(sumary7);
                        break;
                    case 8:
                        Console.WriteLine("Bài 8 Nhập vào số nguyên dương n,  hiển thị ra màn hình các số nguyên tó từ 1 đến n");
                        Console.WriteLine("số nguyên tố là số chỉ chia được cho 1 và chính nó");
                        Console.Write("Nhập  vào số nguyên n: ");
                        int number8 = int.Parse(Console.ReadLine());
                        int i8 = 1;
                        int count = 0;
                        while (i8 <= number8)
                        {
                            for (int j = 1; j <= i8; j++)
                            {
                                if (i8 % j == 0)
                                    count++;
                            }
                            if (count < 3) Console.WriteLine("Số nguyên tố {0}", i8);
                            count = 0;
                            i8++;
                        }
                        break;
                    case 9:
                        Console.WriteLine("Bài 9: Viết chương trình nhập vào số hàng n, vẽ tam giác * với số hàng tương ứng. ");
                        Console.WriteLine("Ví dụ, nhập vào 10 hàng, thì ta sẽ được 1 tam giác như hình bên dưới. Có thể thử vẽ thêm với");
                        Console.WriteLine("hình tam giác đều, tam giác xoay ngược.");
                        Console.Write("Nhập  vào số hàng n: ");
                        int number9 = int.Parse(Console.ReadLine());
                        for (int i9 = 1; i9 <= number9; i9++)
                        {
                            for (int j = 1; j <= i9; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();

                        }
                        break;
                    case 10:
                        Console.WriteLine("Bài 10: Nhập vào số nguyên dương n, tính toán và hiển thị dãy Fibonacci ra màn hình.");
                        Console.WriteLine("Fibonacci là một dãy số quen thuộc trong Toán học, nó rất đơn giản nhưng lại đầy tinh tế");
                        Console.WriteLine("1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946,…");
                        Console.Write("Nhập  vào số hàng n: ");
                        int numberN = int.Parse(Console.ReadLine());
                        int pre1 = 0;
                        int pre2 = 1;
                        int i = pre2;
                        while (i <= numberN)
                        {
                            Console.Write("{0} ", i);
                            i = pre1 + pre2;
                            pre1 = pre2;
                            pre2 = i;
                        }

                        break;
                    default :
                        Console.WriteLine("Bạn đã nhập sai vui lòng nhập lại");
                        break;

                }
                Console.WriteLine("Nhấn Y  để tiếp tục, Nhấn N để dừng lại");
                yes = Console.ReadLine();
            }
            Console.ReadLine();

        }








            
    }
}
