Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minAmount = 0;
int amount = amountElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempAmount = amountElements(array, i);
  if (amount > tempAmount)
  {
    amount = tempAmount;
    minAmount = i;
  }
}

Console.WriteLine($"\n{minAmount + 1} - строкa с наименьшей суммой ({amount}) элементов ");


int amountElements(int[,] array, int i)
{
  int amount = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    amount += array[i,j];
  }
  return amount;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}