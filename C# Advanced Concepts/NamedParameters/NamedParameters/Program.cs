using System;

namespace NamedParameters
{
    public enum Mode
    {
        OBL, PARC
    }
    public enum Track
    {
        JAVA, DOTNET
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetCohortDetails("Vraj", 100, Mode.OBL, Track.DOTNET, "Data Structures");
            program.GetCohortDetails(name: "Vraj", module: "Data Structures", count: 100, mode: Mode.OBL, track: Track.DOTNET);
            Console.ReadLine();
        }

        public void GetCohortDetails(string name, int count, Mode mode, Track track, string module)
        {
            Console.WriteLine($"It is {name} with {count} GenCs undergoing training for {track} thru {mode}. The current module of training is {module}");
        }
    }
}
