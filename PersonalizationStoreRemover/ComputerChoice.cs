using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalizationStoreRemover
{
    public class ComputerChoice
    {
        public bool UseLocalComputer { get; set; }

        public string RemoteComputerName { get; set; }

        public ComputerChoice()
        {
            UseLocalComputer = true;
            RemoteComputerName = string.Empty;
        }

    }
}
