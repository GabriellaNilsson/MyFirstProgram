namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Gabriella Nilsson, NET23


            // 1
            int num = 25;
            // Comments: In this part of the code, I declare a variable "num", short for number and is of the data type integer and have given it a value. 
            // The declared variable is then used as an argument for the if-statement down below. If the value of the integer is higher than 10, the text "Talet är stort" is printed. But is it's lower, the Console will print "Oj, vad lågt!".

            if (num > 10)
            {
                Console.WriteLine("Talet är stort!");
            }

            else
            {
                Console.WriteLine("Oj! lågt tal!");
            }
            


            // 2
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();

            Console.WriteLine("Hej " + name + "!");

            // Comment: I declared a string variable and used it as an argument for the second Console.WriteLine();. At first the Console will print "Vad heter du?" the user will enter their name and when it's done, the Console will print "Hej " and the name the user entered, as to greet the user. 


            // 3
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(i);
            }
            // Comments: The declared integer "int num = 25" in the beginning of the code, is used as an argument for this for loop. 
            // Also, in this for loop, another integer, "int i", is declared. 
            // The first part of the iteration, int i, is used as a loop control variable and controls the iteration and usually starts at 0. 
            // The second part of the loop, the second iteration, is a conditonal statement. The loop continues as long as is is less than the value of the variable "num".
            // In the third part, i++, the value of the variable increases by 1 and it becomes a greater number each time. 
            // Console.WriteLine(i); prints the value of i to the Console, in which turn prints all numbers from 0 - 25 in the Console. 



        }
    }
}