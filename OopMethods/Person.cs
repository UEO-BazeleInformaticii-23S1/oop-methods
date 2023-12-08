namespace OopMethods
{
    internal class Person
    {
        static Person()
        {
            Console.Write("PopulationCount=");
            string populationCountAsText = Console.ReadLine();
            int populationCount = Convert.ToInt32(populationCountAsText);

            PopulationCount = populationCount;
        }

        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public static int PopulationCount { get; private set; }
    }
}
