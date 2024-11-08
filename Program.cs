using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
                    var data = new[]
                   {
            new { Id = 1, Name = "Alice", Score = 3.0 },
            new { Id = 2, Name = "Bob", Score = 7.87 },
            new { Id = 3, Name = "Charlie", Score = 9.001 },
            new { Id = 4, Name = "David", Score = 11.0 },
            new { Id = 5, Name = "Eve", Score = 13.0 },
            new { Id = 6, Name = "Frank", Score = 8.0 },
            new { Id = 7, Name = "Grace", Score = 9.0 },
            new { Id = 8, Name = "Hannah", Score = 9.2 },
            new { Id = 9, Name = "Isaac", Score = 8.86 }
        };

        foreach (var student in data)
        {
            int roundedScore = (int)Math.Round(student.Score);

            if (roundedScore > 8)
            {
                Console.WriteLine("accept{0}",student);
            }
            else
            {
                Console.WriteLine("Fail{0}", student);
            }

        }
        Console.ReadKey();
    }
}

        }
    

