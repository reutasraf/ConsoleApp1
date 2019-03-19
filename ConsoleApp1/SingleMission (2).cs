using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        
        private FunctionsContainer.MyDelegate delig;
        public event EventHandler<double> OnCalculate;

        public SingleMission( FunctionsContainer.MyDelegate del, string name)
        {
            this.delig = del;
            this.Name = name;
            this.Type = "Single";
        }

        public string Name {
            get;
        }

        public string Type {
            get;
        }
        

        public double Calculate(double value)
        {
            double ans = this.delig(value);
            this.OnCalculate?.Invoke(this, ans);
            return ans;
        }
    }
}
