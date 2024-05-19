namespace RomanNumber
{
    public class RomanNumbers
    {
        static void Main(string[] args)
        {
            int num, val = 0;
            Console.WriteLine("Please enter number to generate Roman Number");
            num = int.Parse(Console.ReadLine()!);
            string ans = "";
            while (num > 0)
            {
                if (num <= 3)
                {
                    for (int i = 0; i < num; i++)
                    {
                        ans = ans + "I";
                    }
                    num = num % num;
                }
                else if (num >= 1000)
                {
                    if (num == 1000)
                    {
                        ans = ans + "M";
                        num = num % 1000;
                    }
                }
                else if (num >= 900)
                {
                    if (num == 900)
                    {
                        ans = ans + "CM";
                        num = num % 900;
                    }
                    else
                    {
                        val = num / 900;
                        num = num % 900;
                        for (int i = 0; i < val; i++) ans = ans + "CM";
                    }
                }
                else if (num >= 500)
                {
                    if (num == 500)
                    {
                        ans = ans + "D";
                        num = num % 500;
                    }
                    else
                    {
                        val = num / 500;
                        num = num % 500;
                        for (int i = 0; i < val; i++) ans = ans + "D";
                    }
                }
                else if (num >= 400)
                {
                    if (num == 400)
                    {
                        ans = ans + "CD";
                        num = num % 400;
                    }
                    else
                    {
                        val = num / 400;
                        num = num % 400;
                        for (int i = 0; i < val; i++) ans = ans + "CD";
                    }
                }
                else if (num >= 100)
                {
                    if (num == 100)
                    {
                        ans = ans + "C";
                        num = num % 100;
                    }
                    else
                    {
                        val = num / 100;
                        num = num % 100;
                        for (int i = 0; i < val; i++) ans = ans + "C";
                    }
                }
                else if (num >= 90)
                {
                    if (num == 90)
                    {
                        ans = ans + "XC";
                        num = num % 90;
                    }
                    else
                    {
                        val = num / 90;
                        num = num % 90;
                        for (int i = 0; i < val; i++) ans = ans + "XC";
                    }
                }
                else if (num >= 50)
                {
                    if (num == 50)
                    {
                        ans = ans + "L";
                        num = num % 50;
                    }
                    else
                    {
                        val = num / 50;
                        num = num % 50;
                        for (int i = 0; i < val; i++) ans = ans + "L";
                    }
                }
                else if (num >= 40)
                {
                    if (num == 40)
                    {
                        ans = ans + "XL";
                        num = num % 40;
                    }
                    else
                    {
                        val = num / 40;
                        num = num % 40;
                        for (int i = 0; i < val; i++) ans = ans + "XL";
                    }
                }
                else if (num >= 10)
                {
                    if (num == 10)
                    {
                        ans = ans + "X";
                        num = num % 10;
                    }
                    else
                    {
                        val = num / 10;
                        num = num % 10;
                        for (int i = 0; i < val; i++) ans = ans + "X";
                    }
                }
                else if (num == 9)
                {
                    ans = ans + "IX";
                    num = num % 9;
                }
                else if (num >= 5)
                {
                    if (num == 5)
                    {
                        ans = ans + "V";
                        num = num % 5;
                    }
                    else
                    {
                        num = num % 5;
                        ans = ans + "V";
                    }
                }
                else if (num == 4)
                {
                    ans = ans + "IV";
                    num = num % 4;
                }
            }
            Console.WriteLine(ans);
        }
    }
}



