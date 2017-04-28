using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcuProcessing.NeatNet
{
    class Population
    {
        public PopulationSettings Parameters;

        public Population(PopulationSettings Parameters)
        {
            this.Parameters = Parameters;
        }

        public Population()
        {
            Parameters = new PopulationSettings();
        }
    }
}
