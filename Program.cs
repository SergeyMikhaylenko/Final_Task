string[] PrimaryArray = new string[5] {"1234", "1567", "Saratov", "one", "love"};
string[] SecondaryArray = new string[PrimaryArray.Length];
void SecondBranchedArray(string[]PrimaryArray, string[] SecondaryArray)
{
int count = 0;
for (int i = 0; i <PrimaryArray.Length; i++)
{
if(PrimaryArray[i].Length <= 3)
{
SecondaryArray[count] =PrimaryArray[i];
count++;
}
}
}
void PrintArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
SecondBranchedArray(PrimaryArray, SecondaryArray);
PrintArray(SecondaryArray);