// Напишите программу, которая принимает на вход 
// трёхзначное число и возводит вторую цифру этого 
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999) // проверка числа на трёхзначность
{
    int secondDigit = number / 10 % 10; // получаем вторую цифру трёхзначного числа
    int thirdDigit = number % 10; // получаем третью цифру трёхзначного числа
    int result = 1;
    int count = 0; // счетчик

    while (count < thirdDigit)
    {
        result *= secondDigit; // result = result * secondDigit("*=" - составной оператор)
        count++; // увеличиваем значение счетчика, исходя из задданого условия "if"
    }
    Console.WriteLine(result);
}