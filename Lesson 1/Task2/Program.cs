// int i1 = 5;
// int i2 = 6;
// int sum = i1 + i2;
// Console.WriteLine(sum);

// long  l1 =  6;
// long sum2 = l1+i1;
// Console.WriteLine(sum);

class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива
    
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        double min = numbers[0];
        foreach (double item in numbers)
        {
            if(item < min){
                min = item;
            }
        }
        return min;
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
       double max = numbers[0];
        foreach (double item in numbers)
        {
            if(item > max){
                max = item;
            }
        }
        return max;
    }
    
    
    
    public static void PrintResult(double[] array)
    { 
        double min = array[0];
        double max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] < min){
                min = array[i];
            }
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        Console.Write(max - min);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}