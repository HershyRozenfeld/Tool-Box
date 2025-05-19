using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Tool
    {
        private string _name;
        private int _weight;
        protected bool use = false;
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
    }
}
