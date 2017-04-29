using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcuProcessing.NeatNet
{
    class Population
    {
        public PopulationSettings Parameters;

        public Population(PopulationSettings parameters)
        {
            Parameters = parameters;
        }

        public Population(params PopulationParameter[] settings)
        {
            Parameters = new PopulationSettings();
            foreach(PopulationParameter param in settings)
            {
                param.UpdateSettings(Parameters);
            }
        }

        public Population()
        {
            Parameters = new PopulationSettings();
        }
    }
}
