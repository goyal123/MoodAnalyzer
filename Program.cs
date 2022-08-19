using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Analyze obj = new Analyze(null);
            Console.WriteLine(obj.Analyzemood());
        }
    }
}
