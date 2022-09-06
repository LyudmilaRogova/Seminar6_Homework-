// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int PositiveEl(int quantity){
    int count = 0; //количество чисел > 0
    for(int i = 1; i <= quantity; i++){
        Console.Write($"Введите {i}-е число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) count++; 
    }
    return count;
}

Console.Write("Сколько чисел будет введено? ");
int  quan = Convert.ToInt32(Console.ReadLine());
if(quan<=0) Console.WriteLine("Некорректный ввод");
else Console.WriteLine($"Количество чисел больше 0: {PositiveEl(quan)}");


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// decimal[] IntersectionPoint(decimal b1, decimal k1, decimal b2, decimal k2){
//     decimal[] pointCoordinates = new decimal[2]; // координаты точки пересечения прямых
//     pointCoordinates[0] = (b2 - b1) / (k1 - k2);
//     pointCoordinates[1] = k1 * (b2 - b1) / (k1 - k2) + b1;
//     return pointCoordinates;
// }

// Console.Write("Введите b1: ");
// decimal b1 = Convert.ToDecimal(Console.ReadLine());
// Console.Write("Введите k1: ");
// decimal k1 = Convert.ToDecimal(Console.ReadLine());
// Console.Write("Введите b2: ");
// decimal b2 = Convert.ToDecimal(Console.ReadLine());
// Console.Write("Введите k2: ");
// decimal k2 =Convert.ToDecimal(Console.ReadLine());

// if(k1==k2 && b1 != b2) Console.WriteLine("Прямы параллельны");
// else if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
// else {
//     decimal[] resultPoint = IntersectionPoint(b1, k1, b2, k2);
//     Console.WriteLine($"Прямые y = {k1}x + {b1} и y = {k2}x + {b2} пересекаются в точке с координатами ({resultPoint[0]}; {resultPoint[1]})");
// }


