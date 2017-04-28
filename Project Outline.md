# Project Design Document

## Public API

### Organization

Main Namspace: CalcuProcessing.NeatNet

Population:
	-NetworkType : Enum
		-FFN
		-RNN
		-LSTM
	-Parameters : PopulationSettings
	-MaxFitness : Float
	-FittestGenome : Genome
	-Population(PopulationSettings) : Constructor
	-Population() : Constructor
	-InitializePopulation(NetworkType) : Void
	-NextGeneration() : Void

PopulationSettings: 
	-Size : Int
	-InputNodes : Int
	-OutputNodes : Int
	-InitialConnections : Int
	-StagnationRate : Int
	-WeightMutateRate : Float
	-PerturbProbability : Float
	-PerturbAmt : Float
	-InheritDisable : Float
	-CrossoverProbability : Float
	-AddNodeProbability : Float
	-AddLinkProbability : Float
	-DisjoinCoefficient : Float
	-WeightCoefficient : Float
	-SpeciesThreshold : Float