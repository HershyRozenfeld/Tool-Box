using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Tool
    {
        protected string name;
        protected int weight;
        protected bool use = false;
        public string category;
        public int UseCount = 0;

        public Tool()
        {
            name = "Tool";
            weight = 0;
            use = false;
            category = "General";
        }
        public Tool(string Name, int Weight, bool Use, string Category)
        {
            name = Name;
            weight = Weight;
            use = Use;
            category = Category;
        }
        public virtual void Describe()
        {

        }
        public void Use()
        {
            if (use)
            {
                Console.WriteLine("Tool is being used!");
            }
            else
            {
                Console.WriteLine("The tool is loose!");
            }
        }
        public void pickUpDropOff(string action)
        {
            if (action == "pickUp" && !use)
            {
                use = true;
                UseCount++;
            }
            else if (action == "dropOff" && use)
            {
                use = false;
            }
            else
            {
                Console.WriteLine("Invalid action or tool state.");
            }
        }
    }
}
