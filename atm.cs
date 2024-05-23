using System;
using System.Collections.Generic;
public class MyData
{
    public long Number1 { get; set; }
    public int Number2 { get; set; }
    public string Name { get; set; }
    public int Currency { get; set; }

    public MyData(long number1, int number2, string name, int currency)
    {
        Number1 = number1;
        Number2 = number2;
        Name = name;
        Currency = currency;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<MyData> listmydata = new List<MyData>();

        listmydata.Add(new MyData(2223232321, 23323, "John", 200));
        listmydata.Add(new MyData(22324123412, 23422, "hari", 600));
        bool invalid = false;
        while (!invalid)
        {
            try
            {
                Console.Write("enter the atmcard number : ");
                long inputValue = long.Parse(Console.ReadLine());
                foreach (MyData mydata in listmydata)
                {
                    if (inputValue == mydata.Number1)
                    {
                        invalid = true;
                        Console.WriteLine("enter the pin number : ");
                        int pin = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 10; i++)
                        {
                            if (pin == mydata.Number2)
                            {
                                Console.WriteLine("welcome " + mydata.Name);
                                Console.WriteLine("1 : whithdraw");
                                Console.WriteLine("2 : deposit");
                                Console.WriteLine("3 : balance");
                                Console.WriteLine("4 : exit");
                                int choice = int.Parse(Console.ReadLine());
                                if (choice == 1)
                                {
                                    Console.Write("enter the amount you want to witdraw : ");
                                    int amount = int.Parse(Console.ReadLine());
                                    int whithdraw = mydata.Currency - amount;
                                    Console.WriteLine("your balance is : " + whithdraw + "$");
                                }
                                else if (choice == 2)
                                {
                                    Console.Write("Enter the value you want to deposite : ");
                                    int amount1 = int.Parse(Console.ReadLine());
                                    int deposit = mydata.Currency + amount1;
                                    Console.WriteLine("your balance is : " + deposit + "$");
                                }
                                else if (choice == 3)
                                {
                                    Console.WriteLine("your balance is : " + mydata.Currency + "$");
                                }
                                else
                                {
                                    Console.WriteLine("thank you for using our atm  " + mydata.Name);
                                    break;
                                }
                            }

                        }
                    }
                }
            }

            catch
            {
                Console.WriteLine("invalid input");
            }

        }

    }

}
