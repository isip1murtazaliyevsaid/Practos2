using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Я загадал(а) число от 0 до 100. Попробуйте угадать.");

        Random random = new Random();
        int загаданное_число = random.Next(0, 101);
        int введенное_число;

        do
        {
            Console.Write("Введите число: ");
            string ввод = Console.ReadLine();

            if (!int.TryParse(ввод, out введенное_число))
            {
                Console.WriteLine("Пожалуйста, введите корректное число.");
                continue;
            }

            if (введенное_число < 0 || введенное_число > 100)
            {
                Console.WriteLine("Число должно быть от 0 до 100 больше не нужно.");
                continue;
            }

            if (введенное_число < загаданное_число)
            {
                Console.WriteLine("Загаданное число больше. Попробуйте еще раз.");
            }
            else if (введенное_число > загаданное_число)
            {
                Console.WriteLine("Загаданное число меньше. Попробуйте еще раз.");
            }
            else
            {
                Console.WriteLine("Поздравляю! Вы угадали число!");
                break;
            }

        } while (true);

        Console.WriteLine("Спасибо за игру!");
    }
}
