using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{

    public class FunctionsContainer
    {
        public delegate double MyDelegate(double value);
        private Dictionary<string, MyDelegate> missionsDict; 
        public FunctionsContainer()
        {
            this.missionsDict = new Dictionary<string, MyDelegate>();
        }
        
        public MyDelegate this[string key]
        {
            get
            {
                if (!this.missionsDict.ContainsKey(key))
                {
                    this.missionsDict.Add(key, val => val);
                    
                }
                return this.missionsDict[key];
            }

            set
            {
                if (this.missionsDict.ContainsKey(key))
                {
                    this.missionsDict[key] = value;
                }
                else
                {
                    this.missionsDict.Add(key, value);
                }

            }

        }


        public List<string> getAllMissions()
        {
            List<string> allMis = new List<string>();
            foreach (KeyValuePair<string, MyDelegate> entry in this.missionsDict)
            {
                allMis.Add(entry.Key);
                
            }
            return allMis;
        }

    }
}
