string[] array = {"Moscow","All","4","France","U","Great"};
int x = array.Length;
string result = "random_string";
for (int i = 0; i < x; i++)
{
    if (array[i].Length <= 3)
    {
        result = array[i];
        Console.Write(result + " ");
    }
}



