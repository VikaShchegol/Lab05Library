using Lab05Library;
using System;

namespace Lab05_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Enter the number of universities: ");
            int numUniversities = int.Parse(Console.ReadLine());

            ClassesLibShchegol[] universities = new ClassesLibShchegol[numUniversities];

            for (int i = 0; i < numUniversities; i++)
            {
                Console.WriteLine($"University {i + 1}:");
                Console.Write("Enter the university name: ");
                string name = Console.ReadLine();

                Console.Write("Enter the foundation year: ");
                int foundationYear = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of graduates: ");
                int numberOfGraduates = int.Parse(Console.ReadLine());

                Console.Write("Enter the university type (medical, economic, technical, financial, etc.): ");
                string type = Console.ReadLine();

                Console.Write("Does the university have doctoral programs (true/false): ");
                bool hasDoctoralPrograms = bool.Parse(Console.ReadLine());

                Console.Write("Does the university have a sports complex (true/false): ");
                bool hasSportsComplex = bool.Parse(Console.ReadLine());

                Console.Write("Enter the university ownership (public/private): ");
                string ownership = Console.ReadLine();

                Console.Write("Does the university have a pool (true/false): ");
                bool hasPool = bool.Parse(Console.ReadLine());

                ClassesLibShchegol university = new ClassesLibShchegol
                {
                    Name = name,
                    FoundationYear = foundationYear,
                    NumberOfGraduates = numberOfGraduates,
                    Type = type,
                    HasDoctoralPrograms = hasDoctoralPrograms,
                    HasSportsComplex = hasSportsComplex,
                    Ownership = ownership,
                    HasPool = hasPool
                };

                universities[i] = university;
            
                Console.WriteLine();
                Console.WriteLine($"\nUniversity {i + 1} Information:");
                Console.WriteLine($"University Name: {ClassesLibShchegol.FormatClassesLibShchegolName(university)}");
                Console.WriteLine($"Foundation Year: {university.FoundationYear}");
                Console.WriteLine($"Number of Graduates: {university.NumberOfGraduates}");
                Console.WriteLine($"Type: {university.Type}");
                Console.WriteLine($"Has Doctoral Programs: {(university.HasDoctoralPrograms ? "Yes" : "No")}");
                Console.WriteLine($"Has Sports Complex: {(university.HasSportsComplex ? "Yes" : "No")}");
                Console.WriteLine($"Ownership: {university.Ownership}");
                Console.WriteLine($"Has Pool: {(university.HasPool ? "Yes" : "No")}");

                double averageStudentsPerYear = university.NumberOfGraduates / (DateTime.Now.Year - university.FoundationYear);
                int roundedAverage = (int)Math.Round(averageStudentsPerYear); 

                Console.WriteLine($"Average number of students per year: {roundedAverage}");

                if (university.HasPool)
                {
                    Console.WriteLine("\u001b[3mThis university has a swimming pool.\u001b[0m");
                }
            }
    
            int totalGraduates = ClassesLibShchegol.CalculateTotalGraduates(universities);

            Console.WriteLine($"Total graduates from all universities: {totalGraduates}");

        }
    }
}

