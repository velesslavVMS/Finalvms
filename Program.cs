Console.Write("Введите размер исходного массива: n=");
int n = Convert.ToInt32(Console.ReadLine());  // вводим кол-во эл-тов массива
//Console.Write("Введите элементы исходного массива ");
string[] array = new string[n]; // вводим кол-во эл-тов массива
for (int i = 0; i < n; i++)
array[i] = Convert.ToString(Console.ReadLine());
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");

