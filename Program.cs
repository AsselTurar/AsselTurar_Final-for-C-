// Задача 1: напишите программу, которая на вход принимает число и выдает его квадрат 
//int n = Convert.ToInt32(Console.ReadLine() );
//Console.WriteLine(n*n);


//Задача 2: напишите программу, которая на вход принимает два числа и проверяет является ли первое число квадратои второго
//int n1 = Convert.ToInt32(Console.ReadLine());
//int n2 = Convert.ToInt32(Console.ReadLine());

//if (n1==n2*n2)
 // Console.WriteLine("yes");
//else
 // Console.WriteLine("no");


 //Задача 3: напишите программу, которая будет выдавать название дня недели по заданному номеру
int DayNumber = Convert.ToInt32(Console.ReadLine());
if (DayNumber == 1)
  Console.WriteLine("понедельник");
else if (DayNumber == 2)
     Console.WriteLine("вторник");
else if (DayNumber == 3)
     Console.WriteLine("среда");
else if (DayNumber == 4)
     Console.WriteLine("четверг");
else if (DayNumber == 5)
     Console.WriteLine("пятница");
else if (DayNumber == 6)
     Console.WriteLine("суббота");
else if (DayNumber == 7)
     Console.WriteLine("воскресенье");
else
  Console.WriteLine("в неделе не больше семи дней");