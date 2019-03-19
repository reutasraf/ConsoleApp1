using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        
        private List<FunctionsContainer.MyDelegate> arrayOfFuncs;
        public event EventHandler<double> OnCalculate;

        public ComposedMission(string name1)
        {
            
            this.Type = "Composed";
            this.Name = name1;
            this.arrayOfFuncs = new List<FunctionsContainer.MyDelegate>();
        }

        public string Name {
            get;
        }


        public string Type {
            get;
        }


        public double Calculate(double value)
        {
            double ans = value;
            foreach (FunctionsContainer.MyDelegate funcs in this.arrayOfFuncs)
            {
                ans = funcs(ans);
            }
            if (this.OnCalculate != null)
            {
                OnCalculate(this, ans);
            }
            return ans;
        }
        
        public ComposedMission Add(FunctionsContainer.MyDelegate del)
        {
            this.arrayOfFuncs.Add(del);
            return this;
        }
    }
}
