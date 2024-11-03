using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videoPlayer
{
    internal class Controller
    {
        public static bool StopVisualizing(bool isRunning)
        {
            return !isRunning; 
        }
    }
}
