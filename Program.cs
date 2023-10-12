//Imprimir 1-255​
static void PrintNumbers()
{
    // Print all of the integers from 1 to 255.
    for (int i = 1; i <= 255; i++)
    {
        Console.WriteLine(i);
    }
}
PrintNumbers();
Console.WriteLine("-------");
//Imprimir números impares entre 1-255​
static void PrintOdds()
{
    // Print all of the odd integers from 1 to 255.
    for (int i = 1; i <= 255; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }

    }
}
PrintOdds();
Console.WriteLine("--------");
static void PrintSum()
{
    // Print all of the numbers from 0 to 255, 
    // but this time, also print the sum as you go. 
    // For example, your output should be something like this:
    int sum = 0;
    for (int i = 0; i <= 255; i++)
    {
        sum += i;
        Console.WriteLine($"New number: {i} Sum: {sum}");
    }
    // New number: 0 Sum: 0
    // New number: 1 Sum: 1
    // New number: 2 Sum: 3
}
PrintSum();
Console.WriteLine("--------");

static void LoopArray(int[] numbers)
{
    // Write a function that would iterate through each item of the given integer array and 
    // print each value to the console. 
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }
}
LoopArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
Console.WriteLine("--------");

static void FindMax(int[] numbers)
{
    // Write a function that takes an integer array and prints and returns the maximum value in the array. 
    // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
    // or even a mix of positive numbers, negative numbers and zero.
    int max = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    Console.WriteLine(max);
}
FindMax(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, -3, -5, -7, 0 });
Console.WriteLine("--------");
static void GetAverage(int[] numbers)
{
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.
    int Suma = 0;
    int promedio;
    for (int i = 0; i < numbers.Length; i++)
    {
        Suma += numbers[i];
    }
    promedio = Suma / numbers.Length;
    Console.WriteLine($"Promedio: {promedio}");
}
GetAverage(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, -3, -5, -7, 0 });
Console.WriteLine("--------");

static List<int> OddList()
{
    // Write a function that creates, and then returns, a List that contains all the odd numbers between 1 to 255. 
    // When the program is done, the List should have the values of [1, 3, 5, 7, ... 255].
    List<int> OddLista = new List<int>();
    for (int i = 1; i <= 255; i++)
    {
        if (i % 2 != 0)
        {
            OddLista.Add(i);
        }
    }
    for (var i = 0; i < OddLista.Count; i++)
    {
        Console.WriteLine(OddLista[i]);
    }
    return OddLista;
}
OddList();
Console.WriteLine("--------");

static int GreaterThanY(List<int> numbers, int y)
{
    // Write a function that takes an integer List, and an integer "y" and returns the number of values 
    // That are greater than the "y" value. 
    // For example, if our List contains 1, 3, 5, 7 and y is 3. Your function should return 2 
    // (since there are two values in the List that are greater than 3).
    int count = 0;
    for (var i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] > y)
        {
            count++;
        }
    }

    return count;
}
Console.WriteLine(GreaterThanY(new List<int> { 1, 3, 5, 7 }, 3));
Console.WriteLine("--------");

static void SquareArrayValues(List<int> numbers)
{
    // Write a function that takes a List of integers called "numbers", and then multiplies each value by itself.
    // For example, [1,5,10,-10] should become [1,25,100,100]
    int SquareArr;
    for (var i = 0; i < numbers.Count; i++)
    {
        SquareArr = numbers[i] * numbers[i];

        Console.WriteLine(SquareArr);
    }

}
SquareArrayValues(new List<int>() { 1, 5, 10, -10 });
Console.WriteLine("--------");
static void EliminateNegatives(List<int> numbers)
{
    // Given a List of integers called "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
    // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].

    for (var i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] < 0)
        {
            numbers[i] = 0;
        }
        Console.WriteLine(numbers[i]);
    }

}
EliminateNegatives(new List<int>() { 1, 5, -35, 10, -2 });
Console.WriteLine("--------");

