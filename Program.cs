using System.Runtime.CompilerServices;

Random random = new Random();

int[] arr = new int[10];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = random.Next(0, 20);
}

foreach (int i in arr)
{
    Console.Write(i + " ");
}

int min = arr[0], max = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
    if (arr[i] > max) {
        max = arr[i];
    }   
}

int[] repArr = new int[max + 1];

foreach (int element in arr)
{
    repArr[element]++;
}

for (int i = 1; i < repArr.Length; i++)
{
    repArr[i] += repArr[i - 1];
}

Console.WriteLine("");

//foreach (int i in repArr)
//{
//    Console.Write(i + " ");
//}

int[] sortedArr = new int[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    sortedArr[repArr[arr[i]] - 1] = arr[i];
    repArr[arr[i]]--;
}

foreach (int i in sortedArr)
{
    Console.Write(i + " ");
}