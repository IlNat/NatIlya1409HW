// Пользователь вводит с клавиатуры показания температуры.
// В зависимости от выбора пользователя программа
// переводит температуру из Фаренгейта в Цельсий или наоборот.

Console.WriteLine("Добро пожаловать в программу перевода температур.");
int choice;
do
{
    Console.WriteLine("Введите температуру ввода: 1 - в Цельсиях, 2 - в Фаренгейтах: ");
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice != 1 && choice != 2)
        Console.WriteLine("Неправильно введены данные, повторите ввод.");
} while (choice != 1 && choice != 2);

Console.Write("Введите температуру в ");
if (choice == 1)
    Console.WriteLine("Цельсиях: ");
else
    Console.WriteLine("Фаренгейтах: ");

double startTemperature, finalTemperature;
startTemperature = Convert.ToDouble(Console.ReadLine()); 
if (choice == 1)
    finalTemperature = 1.8 * startTemperature + 32;
else
    finalTemperature = (startTemperature - 32) / 1.8;

Console.Write("Эта же температура, но в ");
if (choice == 2)
    Console.WriteLine($"Цельсиях: {finalTemperature}");
else
    Console.WriteLine($"Фаренгейтах: {finalTemperature}");


