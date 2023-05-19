using System;

class Program
{
    static void Main()
    {
        int rowNumber;
        while (true)
        {
            Console.Write("Enter the row number of Pascal's triangle: ");
            if (int.TryParse(Console.ReadLine(), out rowNumber))
            {
                if (rowNumber >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Pascal's triangle row number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        Console.WriteLine("Pascal's triangle:");

        for (int i = 0; i <= rowNumber; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(CalculatePascalValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculatePascalValue(int row, int column)
    {
        if (column == 0 || column == row)
        {
            return 1;
        }
        else
        {
            return CalculatePascalValue(row - 1, column - 1) + CalculatePascalValue(row - 1, column);
        }
    }
}
