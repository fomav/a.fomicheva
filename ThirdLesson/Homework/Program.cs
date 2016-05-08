using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Считать строку с консоли.Создать словарь, где ключом будет символ строки, а значением - количество данных символов в считанной строке. 
            Console.WriteLine("Введите строку:");
            string stringDictionary = Console.ReadLine();
            int stringLength= stringDictionary.Length;
            Dictionary<char, int> myDictionary = new Dictionary<char, int>();
            char symbol;
            int countSymbol = 0;
            for (int i=0; i<stringLength;i++)
            {
                symbol = stringDictionary[i];
                countSymbol = 0;
                if (!myDictionary.ContainsKey(symbol))
                {
                    for (int j = 0; j < stringLength; j++)
                    {
                        if (stringDictionary[j] == symbol)
                        {
                            countSymbol++;
                        }
                    }
                    myDictionary.Add(symbol, countSymbol);
                    
                }
            }
            Console.WriteLine("Словарь:");
            foreach (KeyValuePair<char, int> pair in myDictionary)
            {
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }
            Console.ReadLine();

            //Считывать с консоли числа, пока не будет введено число “-1”, среди введенных чисел вывести все дублирующиеся.             
             List<int> numberList = new List<int>();
             Console.WriteLine("Вводите числа");
             int number;
             do
             {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    numberList.Add(number);
                }
                else
                {
                    Console.WriteLine("Вы ввели не число");
                    break;
                }
             }

            while (!(number == -1));

            Dictionary<int, int> doubleNumbers = new Dictionary<int, int>();
            int countNumber = 0;
            for (int i = 0; i < numberList.Count - 1; i++)
            {
                if (!doubleNumbers.ContainsKey(numberList[i]))
                {
                    countNumber = 0;
                    for (int j = 0; j < numberList.Count - 1; j++)
                    {
                        if (numberList[i]==numberList[j])
                        { countNumber++; }
                        
                      }
                    doubleNumbers.Add(numberList[i], countNumber);
                    if (countNumber > 1)
                    {
                        Console.Write(numberList[i] + " ");
                        continue;
                    }
                }
                    
                }
            Console.ReadLine();
        }
           

            
            
            

        }
    }

