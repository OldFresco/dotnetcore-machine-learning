﻿using System.Collections.Generic;

namespace MLlib
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class NeuralNet
    {
        public NeuralNet()
        {
        }

        public double RegularizationStrengh { get; set; }
        public double LearningRate { get; set; }
        public int NumberOfLayers { get; set; }   
        public IEnumerable<int> NumberOfNodesInEachLayer { get; set; }
    }
}