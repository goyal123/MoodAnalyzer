using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class Analyze
    {
        string str;
        public Analyze(string str)
        {
            this.str = str;
        }
        public string Analyzemood()
        {
            try
            {
                if (str.Contains("Sad") && !str.Contains("Happy"))
                    return "Sad";
                else if (str.Contains("Happy") && !str.Contains("Sad"))
                    return "Happy";
                else if (str.Contains("Happy") && (str.Contains("Sad")))
                    return "Neutral";
                else if (str.Length < 1)
                    return "String is Empty";
                else if (!str.Contains("Happy") && !(str.Contains("Sad")))
                    return "unknown";
                else
                    throw new Exception("wrong input");

            }
            
            catch(Exception Ex)
            {
                return Ex.Message;
            }
            
            
        }
    }
}
