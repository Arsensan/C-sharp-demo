int[] SumRows(int[,] array)
{
  int[] sumarray = new int[array.GetLength(0)];
  int sum;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum = sum + array[i, j];
    }
    sumarray[i] = sum;
  }
  return sumarray;
}

// Получение индекса минимального элемента в одномерном массиве
int MinIndex(int[] array)
{
  int min = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < min)
    {
      min = array[i];
    }
  }
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == min)
    {
      count = i;
      break;
    }
    
  }
  return count;
}


void PrintResult(int[,] numbers)
{
  int[] sumOfNums = SumRows(numbers);
  int index = MinIndex(sumOfNums);
  Console.Write(index);
}

int[,] numbers = new int[,] {
                {1, 23, 3},
                {1, 1, 23},
                {7, 8, 2},
                {0, 10, 0}
    };
int[] sumRows = SumRows(numbers);

for (int i = 0; i < sumRows.Length; i++)
{
  Console.Write(sumRows[i] + " ");
}
PrintResult(numbers);

