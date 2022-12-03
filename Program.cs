// Честное Казино
Console.WriteLine("Добро пожаловать в честное казино!!");
Console.WriteLine("Итак, начнём игру! Чтобы было на что играть, мы подарим Вам начальную сумму от 1000 до 5000р");
int cash = new Random().Next(1000, 5000);
Console.WriteLine("Случайным образом Вам было начислено: " + cash + "р");


while (cash > 0)
{
    Console.WriteLine("Если желаете остановиться поставьте 0"); 
    Console.WriteLine("Ваша ставка: ");
    int bet = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ваша ставка  " + bet + "р принята");

    if (bet == 0)
    {
            Console.WriteLine("Вы вовремя остановились и забрали: " + cash + "р");    
            return;
    }
    int number1 = new Random().Next(1, 9);
    int number2 = new Random().Next(1, 9);
    int number3 = new Random().Next(1, 9);
    Thread.Sleep(2000);
    Console.Write("-= " + number1 + " =-   ");
    Thread.Sleep(2000);
    Console.Write("-= " + number2 + " =-  ");
    Thread.Sleep(2000);
    Console.WriteLine("-= " + number3 + " =-");
    Thread.Sleep(2000);
    
    if (number1 == number2 && number2 == number3 && number3 == 7)
    {
        Console.WriteLine("Три топора");
        Console.WriteLine("Суперприз");
        Console.WriteLine("Ваша ставка умножается на 100");
        cash = cash + bet * 99;
        Console.WriteLine("Теперь у Вас: " + cash + "р");
    }
    else if (number1 == number2 && number2 == number3)
    {
        Console.WriteLine("Трио");
        Console.WriteLine("Суперприз");
        Console.WriteLine("Ваша ставка умножается на 10");
        cash = cash + bet * 9;
        Console.WriteLine("Теперь у Вас: " + cash + "р");
    }
    else if (number1 == number2 || number2 == number3 || number1 == number3)
    {
        Console.WriteLine("Диплет");
        Console.WriteLine("Вы выиграли!");
        Console.WriteLine("Ваша ставка умножается на 2");
        cash = cash + bet;
        Console.WriteLine("Теперь у Вас: " + cash + "р");
    }

    else
    {
        Console.WriteLine("Ваша ставка проиграла!");
        cash = cash - bet;
        Console.WriteLine("Теперь у Вас: " + cash + "р");
    }

}

if (cash == 0)
{
    Console.WriteLine("Вы проиграли ВСЁ!!!");    
}
else if (cash < 0)
{
    Console.WriteLine("Вы поставили больше чем у Вас было... Теперь вы должны казино: " + (-cash) + "р");  
}
