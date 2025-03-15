namespace IvanLesson;

internal class Program
{
    static (int Row, int Col) GetArraySize()
    {
        int row = 3;
        int col = 4;

        return (row, col);
    }

    static int[,] GenerateArray((int Row, int Col) size)
    {
        int[,] array = new int[size.Row, size.Col];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Random.Shared.Next();
            }
        }

        return array;
    }

    static void Main(string[] args)
    {
        (int Row, int Col) size = GetArraySize();

        int[,] array = GenerateArray(size);

        /*string text = "abcde";

        for (int i = 0; i < text.Length; i++)
        {
            Console.WriteLine(text[i]);
        }*/
    }
}