using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestYourEyes
{
    /// <summary>
    /// Holds the timer duration and a user friendly name.
    /// </summary>
    public class TimeOption
    {
        public string Name { get; set; }
        public int Duration { get; set; }

        public TimeOption(string name, int duration)
        {
            this.Name = name;
            this.Duration = duration;
        }
    }
}
