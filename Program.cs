// See https://aka.ms/new-console-template for more information
using System.Linq;

//int[] testData = {1, 9, 2, 6, 7, 3, 4};
//int[] testData = {-50, -1, 4, -2, -3, 3, 2, 7, 3, 9, 2, 2, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2};
//int[] testData = {5, 6};
//int[] testData = {5};
int[] testData = {5,5};
Console.WriteLine("Used dataset:");
foreach (var item in testData)
{
    Console.Write($"{item} ");
}
Console.WriteLine("");

int result = 1;

if (testData.Length == 1)
{
    result = testData[0] > 1 ? 1 : testData[0];
}
else
{
    var sorted_dataset = testData.Where(i => i > 0).OrderBy(i => i).Distinct().ToList();
    if (sorted_dataset.Count == 1)
    {
        result = sorted_dataset[0] > 1 ? 1 : sorted_dataset[0];
    }
    else
    {
        foreach (var number in sorted_dataset)
        {
            if (sorted_dataset[0] > 1)
            {
                result = 1;
                break;
            }
            Console.WriteLine($"{number}, {number + 1} (in dataset: {sorted_dataset.Contains(number + 1)})");
            if (!sorted_dataset.Contains(number + 1))
            {
                result = number + 1;
                break;
            }
        }
    }
}

Console.WriteLine("");
Console.WriteLine($"Result: {result}");