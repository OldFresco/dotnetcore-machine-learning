using System.Collections.Generic;

namespace MLlib
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class NeuralNet
    {
        private Matrix _trainingData;

        public NeuralNet(Matrix trainingData)
        {
            _trainingData = trainingData;
        }

        public void Learn()
        {

        }

        private void ForwardPropagate()
        {
        }
        private void BackPropagate()
        {
        }
        private void UpdateWeights()
        {
        }

        public double RegularizationStrengh { get; set; }
        public double LearningRate { get; set; }
        public int NumberOfLayers { get; set; }   
        public IEnumerable<int> NumberOfNodesInEachLayer { get; set; }
    }
}
