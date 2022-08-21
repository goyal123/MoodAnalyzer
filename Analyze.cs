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

        public Analyze()
        {
            this.str = null;
        }

        public Analyze(string str)
        {
            this.str = str;
        }
        public string Analyzemood()
        {
            try
            {
                if (str == null)
                    throw new CustomException("Empty Mood");
                
                if (str.Contains("Sad") && !str.Contains("Happy"))
                    return "Sad";
                else if (str.Contains("Happy") && !str.Contains("Sad"))
                    return "Happy";
                else if (str.Contains("Happy") && (str.Contains("Sad")))
                    return "Neutral";
                else if (str==" ")
                    throw new CustomException("Empty Mood");
                else if (!(str.Contains("Happy")) && !(str.Contains("Sad")))
                    return "unknown";
                else
                    return "Can't determined";

            }
            
            catch(CustomException Ex)
            { 
                return Ex.Message;
            }
            
            
        }
    }
}
