// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

bool IsPalindrome(int number)
{
    int firstNumber = number;
    int reversedNumber = 0;
    while (firstNumber > 0)
    {
        reversedNumber = reversedNumber * 10 + firstNumber % 10;
        firstNumber /= 10;
    }
    
    bool res = reversedNumber == number;
    if(res)
    {
        return true;
    }
    return false;
}

int number = ReadInt("Input a 5-digit number");
bool result = IsPalindrome(number);
System.Console.WriteLine($"The number {number} is " + (result == true ? "a palindrome." : "not a palindrome."));
