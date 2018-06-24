using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            var ListOutput = GetAnswerToTheTask(numberOfOperations);
            PrintList(ListOutput);

        }

        private static void PrintList(List<char> listOutput)
        {
            foreach (var item in listOutput)
            {
                Console.WriteLine(item);
            }
        }

        private static List<char> GetAnswerToTheTask(int number)
        {
            var tempList = new List<char>();
            var text = "";
            var previousCommand = new Stack<string>();

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var action = input[0];
               
                switch (action)
                {
                    case "1":
                        var temp = input[1];
                        text += temp;
                        previousCommand.Push(text);
                        break;
                    case "2":
                        var temp2 = int.Parse(input[1]);
                        text = text.Substring(0, text.Length - temp2);
                        previousCommand.Push(text);
                        break;
                    case "3":
                        var temp3 = int.Parse(input[1]);
                        temp3 -= 1;
                        tempList.Add(text[temp3]);                      
                        break;
                    case "4":
                        previousCommand.Pop();
                        text = previousCommand.Peek();
                        break;
                }
            }

            return tempList;
        }
    }
}
