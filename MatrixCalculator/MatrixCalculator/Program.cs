using System;

namespace MatrixOperations

{
    class Program
    {
        static void Swap<swap>(ref swap elem1, ref swap elem2) // Swap for Sort
        {
            swap temp = elem1;
            elem1 = elem2;
            elem2 = temp;
        }

        static void Block1()
        {
            Console.WriteLine("Input amount of Rows and Columns: ");
            string[] value = Console.ReadLine().Trim().Split();
            int rows = Convert.ToInt32(value[1]);
            int columns = Convert.ToInt32(value[0]);
            string answer = null;
            string firstMatrix = null;
            int counter = 0;
            int[,] matrix = new int[rows, columns]; //Create matrix
            Console.WriteLine("Which way do you prefer: \n\"random\" - Input by Random;\n\"hand\" - Input by hand");
            string key = Convert.ToString(Console.ReadLine().Trim());
            switch (key)
            {
                case "random":
                    Random random = new Random();
                    for (int j = 0; j < columns; j++)
                    {
                        counter = 0;
                        for (int i = 0; i < rows; i++)
                        {
                            matrix[i, j] = random.Next(-100, 100);
                            if (matrix[i, j] >= 0) // Count positive members
                            {
                                counter++;
                            }
                            firstMatrix = firstMatrix + matrix[i, j] + ' ';
                        }
                        firstMatrix = firstMatrix + '\n';
                        answer = answer + "Amount of positive numbers of " + j + " columns = " + counter + " \n";
                    }
                    break;
                case "hand":
                    Console.WriteLine("Input matrix {0} x {1}", columns, rows);
                    for (int j = 0; j < columns; j++)
                    {
                        counter = 0;
                        value = Console.ReadLine().Trim().Split();
                        for (int i = 0; i < rows; i++)
                        {
                            matrix[i, j] = Convert.ToInt32(value[i]);
                            if (matrix[i, j] >= 0) // Count positive members
                            {
                                counter++;
                            }
                            firstMatrix = firstMatrix + matrix[i, j] + ' ';
                        }
                        firstMatrix = firstMatrix + '\n';
                        answer = answer + "Amount of positive numbers of " + j + " columns = " + counter + " \n";
                    }
                    break;
            }
            Console.WriteLine("Primary matrix: "); //Output
            Console.WriteLine(firstMatrix);
            Console.WriteLine("Answer: ");
            Console.WriteLine(answer);
        }

        static void Block2()
        {
            Console.WriteLine("Input amount of Rows and Columns: ");
            string[] value = Console.ReadLine().Trim().Split();
            int rows = Convert.ToInt32(value[1]);
            int columns = Convert.ToInt32(value[0]);
            string answer = null;
            string firstMatrix = null;
            Console.WriteLine("Which way do you prefer: \n\"random\" - Input by Random;\n\"hand\" - Input by hand");
            string key = Convert.ToString(Console.ReadLine().Trim());
            switch (key)
            {
                case "random":
                    Random random = new Random();
                    for (int i = 0; i < rows; i++)
                    {
                        int[] array = new int[columns]; //Create array
                        array[0] = random.Next(-100, 100);
                        firstMatrix = firstMatrix + array[0] + ' ';
                        int min = array[0];
                        int max = array[0];
                        int maxPlace = 0;
                        int minPlace = 0;
                        for (int j = 1; j < columns; j++)
                        {
                            array[j] = random.Next(-100, 100);
                            firstMatrix = firstMatrix + array[j] + ' ';
                            if (array[j] < min) //Checking for inequality
                            {
                                min = array[j];
                                minPlace = j;
                            }
                            if (array[j] > max) //Checking for inequality
                            {
                                max = array[j];
                                maxPlace = j;
                            }
                        }
                        Program.Swap<int>(ref array[maxPlace], ref array[minPlace]); //Replace
                        for (int j = 0; j < columns; j++) //Create outoput
                        {
                            answer = answer + array[j] + ' ';
                        }
                        firstMatrix = firstMatrix + '\n';
                        answer = answer + '\n';
                    }
                    Console.WriteLine("\nPrimary matrix: ");
                    Console.WriteLine(firstMatrix);
                    break;
                case "hand":
                    Console.WriteLine("Input matrix {0} x {1}", rows, columns);
                    for (int i = 0; i < rows; i++)
                    {
                        string[] data = Console.ReadLine().Trim().Split();
                        int[] array = new int[columns];
                        array[0] = Convert.ToInt32(data[0]);
                        int min = array[0];
                        int max = array[0];
                        int maxPlace = 0;
                        int minPlace = 0;
                        for (int j = 1; j < columns; j++)
                        {
                            array[j] = Convert.ToInt32(data[j]); //Create array
                            if (array[j] < min) //Checking for inequality
                            {
                                min = array[j];
                                minPlace = j;
                            }
                            if (array[j] > max) //Checking for inequality
                            {
                                max = array[j];
                                maxPlace = j;
                            }
                        }
                        Program.Swap<int>(ref array[maxPlace], ref array[minPlace]); //Replace
                        for (int j = 0; j < columns; j++) //Create outoput
                        {
                            answer = answer + array[j] + ' ';
                        }
                        answer = answer + '\n';
                    }
                    break;
            }
            Console.WriteLine("\nAnswer: "); // Output
            Console.WriteLine(answer);
        }

        static int Block3()
        {
            Console.WriteLine("Input amount of Rows and Columns: ");
            string[] value = Console.ReadLine().Trim().Split();
            int rows = Convert.ToInt32(value[0]);
            int columns = Convert.ToInt32(value[1]);
            int[,] matrix = new int[rows, columns]; //Create Matrix
            int min = 0;
            int minPos = 0;
            string answer = null;
            string firstMatrix = null;
            bool flag1 = true;
            Console.WriteLine("Which way do you prefer: \n\"random\" - Input by Random;\n\"hand\" - Input by hand");
            string key = Convert.ToString(Console.ReadLine().Trim());
            switch (key)
            {
                case "random":
                    Random random = new Random();
                    for (int i = 0; i < rows; i++)
                    {
                        int temp = 0;
                        for (int j = 0; j < columns; j++) //Filling Matrix
                        {
                            matrix[i, j] = random.Next(-100, 100);
                            temp += matrix[i, j];
                            firstMatrix = firstMatrix + matrix[i, j] + ' ';
                        }
                        firstMatrix = firstMatrix + '\n';
                        if (flag1)
                        {
                            min = temp;
                            flag1 = false;
                        }
                        if (temp < min) //Checking for inequality
                        {
                            min = temp;
                            minPos = i;
                        }
                    }
                    break;
                case "hand":
                    Console.WriteLine("Input matrix {0} x {1}", rows, columns);
                    for (int i = 0; i < rows; i++)
                    {
                        string[] data = Console.ReadLine().Trim().Split();
                        int temp = 0;
                        for (int j = 0; j < columns; j++)
                        {
                            matrix[i, j] = Convert.ToInt32(data[j]); //Filling Matrix
                            temp += matrix[i, j];
                            firstMatrix = firstMatrix + matrix[i, j] + ' ';
                        }
                        firstMatrix = firstMatrix + '\n';
                        if (flag1)
                        {
                            min = temp;
                            flag1 = false;
                        }
                        if (temp < min) //Checking for inequality
                        {
                            min = temp;
                            minPos = i;
                        }
                    }
                    break;
            }
            Console.WriteLine("Primary matrix: ");
            Console.WriteLine(firstMatrix);
            for (int i = 0; i < columns; i++) //Sort
            {
                for (int j = 0; j < columns - 1; j++)
                {
                    if (matrix[minPos, j] > matrix[minPos, j + 1])
                    {
                        Program.Swap<int>(ref matrix[minPos, j], ref matrix[minPos, j + 1]);
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) //Output
                {
                    answer = answer + matrix[i, j] + ' ';
                }
                answer = answer + '\n';
            }

            Console.WriteLine("Answer: ");
            Console.WriteLine(answer);
            return 0;
        }

        static int Block4()
        {
            Console.WriteLine("Input amount of Rows and Columns: ");
            string[] value = Console.ReadLine().Trim().Split();
            int rows = Convert.ToInt32(value[0]);
            int columns = Convert.ToInt32(value[1]);
            string firstMatrix = null;
            string answer = null;
            int max = 0;
            int[] arr = new int[columns]; //Create Array
            int[,] matrix = new int[rows, columns]; //Create Matrix
            Console.WriteLine("Which way do you prefer: \n\"random\" - Input by Random;\n\"hand\" - Input by hand");
            string key = Convert.ToString(Console.ReadLine().Trim());
            switch (key)
            {
                case "random":
                    for (int i = 0; i < rows; i++) //Filling Matrix
                    {
                        Random random = new Random();
                        matrix[i, 0] = random.Next(-100, 100);
                        max = matrix[i, 0];
                        firstMatrix = firstMatrix + matrix[i, 0] + ' ';
                        for (int j = 1; j < columns; j++)
                        {
                            matrix[i, j] = random.Next(-100, 100);
                            firstMatrix = firstMatrix + matrix[i, j] + ' ';
                            if (max < matrix[i, j])
                                max = matrix[i, j];
                        }
                        firstMatrix = firstMatrix + '\n';
                        arr[i] = max; //Filling Array
                    }
                    break;
                case "hand":
                    Console.WriteLine("Input matrix {0} x {1}", rows, columns);
                    for (int i = 0; i < rows; i++)
                    {
                        value = Console.ReadLine().Trim().Split(); //Filling Matrix
                        matrix[i, 0] = Convert.ToInt32(value[i]);
                        max = matrix[i, 0];
                        firstMatrix = firstMatrix + matrix[i, 0] + ' ';
                        for (int j = 1; j < columns; j++)
                        {
                            matrix[i, j] = Convert.ToInt32(value[j]);
                            firstMatrix = firstMatrix + matrix[i, j] + ' ';
                            if (max < matrix[i, j])
                                max = matrix[i, j];
                        }
                        firstMatrix = firstMatrix + '\n';
                        arr[i] = max; //Filling Array
                    }
                    break;
            }
            for (int i = 0; i < rows - 1; i++) //Sort
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        Program.Swap<int>(ref arr[j], ref arr[j + 1]);
                        for (int k = 0; k < columns; k++)
                        {
                            Program.Swap<int>(ref matrix[j, k], ref matrix[j + 1, k]);
                        }
                    }
                }
            }
            Console.WriteLine("\nPrimary matrix: ");
            Console.WriteLine(firstMatrix);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    answer = answer + matrix[i, j] + ' ';
                }
                answer = answer + '\n';
            }
            Console.WriteLine("Answer: ");
            Console.WriteLine(answer);
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1 - Amount of positive numbers\n2 - Swap max end min element of every column\n3 - Sort rows by sum\n4 - Sort rows by max element");
            Console.WriteLine("Сhoose block: ");
            int key = Int32.Parse(Console.ReadLine());
            switch (key)
            {
                case 1: Program.Block1(); break; // Block 1. Find and output the number of positive elements in each column.
                case 2: Program.Block2(); break; // Block 2. Swap the first of the maximum and the first of the minimum elements matrices; "first" is counted according to the standard order "line by line from top to bottom, within lines from left to right".
                case 3: Program.Block3(); break; // Block 3. Sort the row with the minimum sum of elements in non-descending order (if there are several rows with the same minimum sum, then sort each of them).
                case 4: Program.Block4(); break; // Block 4. Arrange the rows of the matrix in descending order of the maximum element.
                default: break;
            }
        }
    }
}
