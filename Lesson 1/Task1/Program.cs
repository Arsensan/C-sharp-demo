// //Console.WriteLine("Hello, World!");

//  int a = 115;
// Console.WriteLine(a);

// double d = 5.55;
// char c = '!';
// Boolean b = true;
// Console.WriteLine(d);
// Console.WriteLine(c);
// Console.WriteLine(b);



// int[] arr = new int[5];
// arr[0] = 5;
// arr[1] = 544;
// arr[2] = 13;
// arr[3] = 525;
// arr[4] = 515;


// // Задайте массив из 10 элементов, заполненный числами из
// // промежутка [-10, 10]. Замените отрицательные элементы на
// // положительные, а положительные на отрицательные.


// int [] array = {1,-9,7,4,-5,9,-3,-4,-2,2};
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * -1;
//     Console.Write(array[i] + "," + " ");
// }

// // Найдите произведения пар чисел в одномерном массиве. Парой
// // считаем первый и последний элемент, второй и предпоследний и
// // т.д. Результат запишите в новый массив.
// Console.WriteLine();

// Console.WriteLine("*******************");

// int [] numbers2 = {1,2,3,4,5,6,7};
// int [] numbers3 = new int[numbers2.Length/2];
// int count = 1;
// int multiply;
// for (int i = 0; i < numbers2.Length/2; i++)
// {
//     multiply = numbers2[i]*numbers2[numbers2.Length-count];
//     numbers3[i] = multiply;
//     count ++;
// }
// foreach (int item in numbers3)
// {
//     Console.Write(item);
//     Console.Write(" ");
// }





// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
  
//     // Подсчет количества элементов массива, попадающих в заданный диапазон
//     // numbers - массив, в котором ведется подсчет
//     // minRange - минимальная граница диапазона
//     // maxRange - максимальная граница диапазона
//     public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
//     {
//         int count = 0;
// for (int i = 0; i < numbers.Length; i++)
// { 
//     if (numbers[i]>=minRange & numbers[i] <= maxRange){
//         count++;
//     }
// }
//        return count;
//     }
    
//     public static void PrintResult(int[] array)
//     { int count = 0;
        
//          for (int i = 0; i < array.Length; i++)
// { 
//     if (array[i]>=10 & array[i] <= 90){
//         count++;
//     }

// }
// Console.Write(count);
//     }

// }


// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;
        

//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();
            
//             // Теперь arr содержит преобразованные в целые числа из командной строки
        
//         } else {
//            // Если аргументов на входе нет
//             array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
//
//}

class UserInputToCompileForTest
{ 
    // Подсчет количества четных элементов массива
    // numbers - массив, в котором ведется подсчет
    public static int CountEvenItems(int[] numbers)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]%2==0){
                count++;
            }
        }
       return count;
    }
    
    public static void PrintResult(int[] array)
    {
      int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]%2==0){
                count++;
            }
            
        }
        Console.Write(count);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}
















