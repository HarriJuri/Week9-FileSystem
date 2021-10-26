using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\source\repos\TITpe21\sample";

            Console.WriteLine("Enter directory name");
            string userFolder = Console.ReadLine();

            string newDirectoryFullPath = @$"{rootDirectory}\{userFolder}";
            bool directoryExists = Directory.Exists(newDirectoryFullPath); 

            if(directoryExists)
            {
                Console.WriteLine($"{userFolder} directory already exists.");
                Console.WriteLine("Would you like to create a folder? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if(userInput == 'y')
                {
                    Console.WriteLine("Enter file name:");
                    string userFile = Console.ReadLine() + ".txt";
                    string userFileFullPath = @$"{rootDirectory}\{userFolder}";
                    File.Create(userFileFullPath);
                }
                else
                {
                    Console.WriteLine("Take care!");
                }

            }else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory {userFolder} has been created.");
            }

            


        }
    }
}
