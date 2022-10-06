// See https://aka.ms/new-console-template for more information
Console.WriteLine("РАбота сделана незнаю как но я сделал это я думал что он не запустится но оно запустилась магия вне хогварса");
bool Stop = false;
int operation;
double a;
double b;


while (Stop == false)
{
    Console.WriteLine("Угадай число");
    Console.WriteLine("Таблица умножения");
    Console.WriteLine("Вывод делителей числа");


    operation = Convert.ToInt32(Console.ReadLine());
    switch (operation)
    {
        case 1:
            {
                Console.WriteLine("угадайте число от 0 до 100");
                Random ran = new Random();
                int value = ran.Next(0, 100);
                int c = 0;
                Console.WriteLine("вставьте число ");
               

                do
                {
                    b = Convert.ToInt32(Console.ReadLine());

                    if (b < value)
                        Console.WriteLine("число больше");
                    if (b > value)
                        Console.WriteLine("число меньше");

                    c++;
                } while (b != value);
                Console.WriteLine("угадал");

            }
            break;


        case 2:
            {
                for (int i = 2; i <= 9; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write(i * j + "\t");
                    }
                    Console.WriteLine("\r\n");
                }
                
                break;
            }
        case 3:
            {
                
                
                    Console.WriteLine("введи число брат и узнаешь на что делится: ");
                    int numb = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i < numb; i++)
                    {

                        if (numb % i == 0)
                            Console.Write(i + "\t");
                    }
                    break;
            }
        case 4:
            {
                string e;



                    Console.WriteLine("Закрыть? или передумаешь?");
                    e = Console.ReadLine();

                Environment.Exit(0);


                break;
            }
    }
}