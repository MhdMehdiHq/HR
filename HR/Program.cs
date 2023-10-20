namespace HR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //برای استفاده از ویژگی های این برنامه،ابتدا باید کارمند تعرییف کنید
            //در غیر اینصورت،برنامه کار نخواهد کرد
            while (true)
            {
                try
                {
                    Console.WriteLine("Which one do you want ? ");
                    Thread.Sleep(500);
                    Console.WriteLine("1. Hire employee");
                    Thread.Sleep(500);
                    Console.WriteLine("2. Fire employee");
                    Thread.Sleep(500);
                    Console.WriteLine("3. Show employee details");
                    Thread.Sleep(500);
                    Console.WriteLine("4. Update employee information");
                    Thread.Sleep(500);

                    Console.Write("Enter your answer: ");
                    int answer;
                    bool flag = int.TryParse(Console.ReadLine(), out answer);
                    Console.Clear();
                    if (flag == true)
                    {
                        switch (answer)
                        {
                            case 1:
                                HireRemove.HireEmployee();
                                break;

                            case 2:
                                HireRemove.FireEmployee();
                                break;

                            case 3:
                                HireRemove.ShowEmployeeInfo();
                                break;

                            case 4:
                                HireRemove.UpdateEmployee();
                                break;

                            default:
                                Console.WriteLine("Invalid answer!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter true number!");
                        Thread.Sleep(2000);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("---------------------------");
                    throw;
                }
            }

            Console.ReadKey();
        }
    }
}