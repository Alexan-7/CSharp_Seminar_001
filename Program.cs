Console.WriteLine("Введите число");         // лайфхак - дает команду по буквам CW

string Input = Console.ReadLine ();         // ввод пользователя

//Input = Console.ReadLine (number);          // ввод числа. ReadLine только внутри Console

int number = int.Parse (Input);             // преобразовать строку в число

int Square = number * number;               // квадрат числа

Console.WriteLine($"Число в квадрате равно {Square}");