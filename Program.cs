// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
string strNum=Console.ReadLine();
int num=int.Parse(strNum);

if(num>0&&num<8)
{
    if(num==1||num==2||num==3||num==4||num==5)
    {
        Console.WriteLine("День не является выходным");
    }

    else
    {
        Console.WriteLine("ВЫХОДНОЙ!");
    }
}
else
{
   Console.WriteLine("Не верно введено число"); 
}