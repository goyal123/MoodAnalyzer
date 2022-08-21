using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyserFactory
    {
        public static object CreateAnalyzer(string className, string ConstructorName)
        {
            try
            {
                Assembly currentAsembly = Assembly.GetExecutingAssembly();
                Type moodAnalyser = currentAsembly.GetType(className);
                Console.WriteLine(moodAnalyser);
                return Activator.CreateInstance(moodAnalyser);
            }
            catch (ArgumentNullException)
            {
                throw new CustomException("Class Not Found");
            }
        }

    }
}
