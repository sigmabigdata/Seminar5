/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/




Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


    string str = number.ToString();
    {
        int sum = 0;
        for (int i = 0; i < str.Length; i++)
        {
            string str2 = Convert.ToString(str[i]);
            sum = sum + int.Parse(str2);
        }
    

        Console.WriteLine($"Сумма цифр в числе {number} = {sum}");
    }
