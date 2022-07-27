namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stepplayer1 = "Ход первого игрока";
            string stepplayer2 = "Ход второго игрока";
            char[,] myArray;
            char player1 = 'x';
            char player2 = '0';
            int nomX;
            int nomY;

            game();
            Console.WriteLine(stepplayer1);
            step1();

            printArray();

            Console.WriteLine(stepplayer2);
            step2();
            printArray();

            void game()
            {
                myArray = new char[3, 3]
                {
                {' ',' ',' '},
                {' ',' ',' '},
                {' ',' ',' '},
                    };
                printArray();
            }

            void step1()
            {
                Console.Write("\n Введите номер столбца от 0 до  2 \n" );
                nomX= Int32.Parse(Console.ReadLine());
                
                Console.Write("\n Введите номер ряда от 0 до 2: \n ");
                nomY = Int32.Parse(Console.ReadLine());
                myArray[nomX,nomY] = player1;   
            }

            void step2()
            {
                Console.Write("\n Введите номер столбца от 0 до  2 \n");
                nomX = Int32.Parse(Console.ReadLine());

                Console.Write("\n Введите номер ряда от 0 до 2: \n ");
                nomY = Int32.Parse(Console.ReadLine());
                myArray[nomX, nomY] = player2;
            }

            void printArray()
            { 
            int hight = myArray.GetLength(0);
            int width = myArray.GetLength(1);
                for (int y = 0; y < hight; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Console.Write("| " + myArray[y, x]);
                    }
                    Console.WriteLine("|" + "\n" + "---+--+---");
                }
            }
        }
    }
}