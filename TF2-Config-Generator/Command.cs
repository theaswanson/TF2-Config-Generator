using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Config_Generator
{
    public class Command
    {
        public string command;
        public string value;
        public string defaultValue;
        public string minValue;
        public string maxValue;
        public string type;
        public string helpText;
        public string description;
    }

    public class TF2
    {
        public Command sensitivity = new Command { command = "sensitivity", value = "3", defaultValue = "3", minValue = "0.0001", maxValue = "10000000", type = "client archive", helpText = "Mouse sensitivity" };


    }
}
