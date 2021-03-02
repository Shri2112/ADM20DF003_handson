using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameter
{
    public enum Mode
    {
        OBL,PARC
    }
    public enum Track
    {
        JAVA,DOTNET
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.GetCohortDetails("Dhanshri Nande", 100, Mode.OBL, Track.DOTNET, "ASP.NET");
            obj.GetCohortDetails(name: "Dhanshri Nande", module: "ASP.NET", count: 100, mode: Mode.OBL, track: Track.DOTNET);
            Console.ReadLine();
        }
        public void GetCohortDetails(string name,int count,Mode mode,Track track,string module)
        {
            Console.WriteLine($"It is {name} with {count} Gencs undergoing training for {track} through {mode}. The current module of training is {module}.");
        }
    }
}
