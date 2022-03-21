// See https://aka.ms/new-console-template for more information

/*
int[] value = { 5, 12, 3, 54,25, };

Console.WriteLine("Print out first value:" + value[0]);
Console.WriteLine($"Print out last value:{value[value.Length - 1]}");
Console.WriteLine("Print out third value:" + value[2]);
int sum = value.Sum();
Console.WriteLine($"Print all five elements:{sum}");
Console.WriteLine($"The length of array is:{value.Length}");
for (int i = 0;i<5; i++)
{
    Console.WriteLine($"The elements of array are:{value[i]}");
}
Console.WriteLine("Set first element in array:"); 
Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Set the last element of array:");
Console.ReadLine();
Console.WriteLine();*/


/*Console.WriteLine("Print out the value of second row and third column");
Console.WriteLine("Print out the value of third row and first column");
Console.WriteLine(array2D[2,0]);
Console.WriteLine("Print out the value of second row and second column");
Console.WriteLine(array2D[1,1]);*/

/*int[,] array2D = { { 43, 13, 12, 58, 3 }, { 7, -48, 152, 69, -51 }, { 60, 72, 7, 67, 3 } };

float[,] newArray = { { 43, 13, 12, 58, 3 }, { 7, -48, 152, 69, -51 }, { 60, 72, 7, 67, 3 } };
double sumofRow = 0;
double[] sumofCol = new double[array2D.GetLength(1)];
for (int row = 0; row < newArray.GetLength(0); row++)
{
    for (int col = 0; col < newArray.GetLength(1); col++)
    {
        Console.Write($"|{newArray[row, col]}|");
        sumofRow += newArray[row, col];
        Console.Write("  ");
    }
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        sumofCol[j] += array2D[row, j];
    }
    Console.Write($" = {sumofRow}");
    sumofRow = 0;
    Console.WriteLine();
}
Console.WriteLine("The sum of each column are:");
foreach (var sum in sumofCol)
{
    Console.Write($"={sum} |");
    
}
double sumofElements = 0;
Console.WriteLine();
foreach (double element in array2D)
    sumofElements += element;
{
    Console.WriteLine($"The sum of elements of the array is:{sumofElements}");
} 
*/
//Practical task day 11
Console.WriteLine("                ");
Console.WriteLine($"**********************Practical Task day 11");
Console.WriteLine();
double number;

for (number = -30; number < 100; number++)
{
    if (number % 2 !=0)
    {
        Console.Write($" {number} ;");
    }
}
Console.WriteLine();
double[] myArray = { -30, 1, 25, 99, };
string[] newArray = new string[4];
newArray[0] = "minusThirty";
newArray[1] = "one";
newArray[2] = "twentyFive";
newArray[3] = "ninetyNine";
for (int i = 0; i < 4; i++)
{ 
Console.WriteLine($"{newArray[i]}");
}

double sum = myArray.Sum();
Console.WriteLine(  );
Console.WriteLine($"Print sum of all elements:{sum}");
Console.WriteLine();
for (int i = 0; i <1; i++)
{ 
    Console.WriteLine($"Print out first number: {myArray[0]}");
}

int[,] Array = { { -30, 1, 25, 99},{ 25, 10, 5 ,1} };
for (int row = 0; row < Array.GetLength(0); row++)
{ 
   for (int col = 0; col < Array.GetLength(1); col++)
    {
        Console.Write($" {Array[row,col]}/");
    }
   Console.WriteLine();
}