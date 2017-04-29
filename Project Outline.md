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
	-Population(params PopulationParameter[]) : Constructor
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
	-DisjointCoefficient : Float
	-WeightCoefficient : Float
	-SpeciesThreshold : Float

PopulationSize: PopulationParameter
	-PopulationSize(Int) : Constructor

InputNodes: PopulationParameter
	-InputNodes(Int) : Constructor

OutputNodes: PopulationParameter
	-OutputNodes(Int) : Constructor

InitialConnections: PopulationParameter
	-InitialConnections(Int) : Constructor

StagnationRate: PopulationParameter
	-StagnationRate(Int) : Constructor

WeightMutateRate: PopulationParameter
	-WeightMutateRate(Float) : Constructor

PerturbProbability: PopulationParameter
	-PerturbProbability(Float) : Constructor

PerturbAmmount: PopulationParameter
	-PerturbAmmount(Float) : Constructor

InheritDisable: PopulationParameter
	-InheritDisable(Float) : Constructor

CrossoverProbability: PopulationParameter
	-CrossoverProbability(Float) : Constructor

AddNodeProbability: PopulationParameter
	-AddNodeProbability(Float) : Constructor

AddLinkProbability: PopulationParameter
	-AddLinkProbability(Float) : Constructor

DisjointCoefficent: PopulationParameter
	-DisjoinCoefficient(Float) : Constructor

WeightCoefficient: PopulationParameter
	-WeightCoefficient(Float) : Constructor

SpeciesThreshold: PopulationParameter
	-SpeciesThreshold(Float) : Constructor