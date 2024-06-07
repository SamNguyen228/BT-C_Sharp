using System;
using System.Text;

public class AgeOutOfRangeException : Exception
{
    public AgeOutOfRangeException(string message) : base(message)
    {
    }
}

public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {
    }
}

public class NegativeAmountException : Exception
{
    public NegativeAmountException(string message) : base(message)
    {
    }
}

public class BankAccount
{
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new NegativeAmountException("Số tiền gửi không thể là số âm.");
        }

        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new NegativeAmountException("Số tiền rút không thể là số âm.");
        }

        if (balance - amount < 0)
        {
            throw new InsufficientFundsException("Số dư tài khoản không đủ.");
        }

        balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        bool running = true;
        while (running)
        {
            Console.WriteLine("Vui lòng chọn một tùy chọn:");
            Console.WriteLine("1. Kiểm tra tuổi sinh viên");
            Console.WriteLine("2. Quản lý tài khoản ngân hàng");
            Console.WriteLine("3. Thoát");

            Console.Write("Nhập lựa chọn: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CheckStudentAge();
                    break;
                case "2":
                    ManageBankAccount();
                    break;
                case "3":
                    running = false;
                    Console.WriteLine("Đã thoát khỏi chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }

    static void CheckStudentAge()
    {
        try
        {
            Console.Write("Nhập tuổi của sinh viên: ");
            int age = int.Parse(Console.ReadLine());

            if (age < 18 || age > 25)
            {
                throw new AgeOutOfRangeException($"Tuổi {age} không nằm trong khoảng từ 18 đến 25.");
            }
            Console.WriteLine();
            Console.WriteLine("Sinh viên đủ điều kiện để được nhập học.");
            Console.WriteLine("----------------------------------------");
        }
        catch (AgeOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Đã xảy ra lỗi: " + e.Message);
        }
    }

    static void ManageBankAccount()
    {
        BankAccount account = new BankAccount();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Vui lòng chọn một tùy chọn:");
            Console.WriteLine("1. Gửi tiền");
            Console.WriteLine("2. Rút tiền");
            Console.WriteLine("3. Xem số dư tài khoản");
            Console.WriteLine("4. Quay lại");

            Console.Write("Nhập lựa chọn: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("Nhập số tiền cần gửi: ");
                    decimal depositAmount = decimal.Parse(Console.ReadLine());
                    try
                    {
                        account.Deposit(depositAmount);
                        Console.WriteLine($"Số dư tài khoản: {account.Balance}");
                    }
                    catch (NegativeAmountException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Đã xảy ra lỗi: " + e.Message);
                    }
                    break;
                case "2":
                    Console.Write("Nhập số tiền cần rút: ");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                    try
                    {
                        account.Withdraw(withdrawAmount);
                        Console.WriteLine($"Số dư tài khoản: {account.Balance}");
                    }
                    catch (InsufficientFundsException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (NegativeAmountException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Đã xảy ra lỗi: " + e.Message);
                    }
                    break;
                case "3":
                    Console.WriteLine($"Số dư tài khoản: {account.Balance}");
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }
}