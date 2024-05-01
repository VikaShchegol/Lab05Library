namespace Lab05Library
{
    public class ClassesLibShchegol
    {
        public string Name;
        public int FoundationYear;
        public int NumberOfGraduates;
        public string Type;
        public bool HasDoctoralPrograms;
        public bool HasSportsComplex;
        public string Ownership;
        public bool HasPool;

        public static int CalculateTotalGraduates(ClassesLibShchegol[] universities)
        {
            return universities.Sum(u => u.NumberOfGraduates);
        }
        public static string FormatClassesLibShchegolName(ClassesLibShchegol university)
        {
            switch (university.Type)
            {
                case "medical":
                    return $"\u001b[1;31m{university.Name}\u001b[0m";
                case "economic":
                    return $"\u001b[1;33m{university.Name}\u001b[0m";
                case "technical":
                    return $"\u001b[1;34m{university.Name}\u001b[0m";
                case "financial":
                    return $"\u001b[1;32m{university.Name}\u001b[0m";
                default:
                    return university.Name;
            }
        }
    }
}
