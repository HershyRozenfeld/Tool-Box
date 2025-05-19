using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toolbox
{
    internal class Toolbox
    {
        private List<Tool> wareHouse = new List<Tool>();
        public void AddTool(Tool tool)
        {
            wareHouse.Add(tool);
        }
        public void printTools()
        {
            var grouped = wareHouse.GroupBy(tool => tool.category);
            foreach (var group in grouped)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (Tool tool in group)
                {
                    tool.Describe();
                }
                Console.WriteLine();
            }
        }
    }
}
