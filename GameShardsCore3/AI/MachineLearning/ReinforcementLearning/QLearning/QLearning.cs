using System;
using GameShardsCore3.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GameShardsCore3.AI.MachineLearning.ReinforcementLearning.QLearning {

    [DevelopedBy("SmokeyTheBandicoot")]
    [MaintainedBy("SmokeyTheBandicoot")]
    [Version(1, 0, 0)]
    /* Class representing reinforcement learning through Q-learning
     */

    public class QLearning<State, Action> {

        // General parameters
        public bool deterministic = false;
        public float learningRate = 0.5f;
        public float ditchingRate = 0.5f;
        public uint maxEpochs = 1000;
        public float explorationRate = 0.05f;

        // Information about states, actions and rewards
        public State currentState;
        public State nextState;
        public Action lastAction;
        public Action newAction;
        public double lastReward;
        public double newReward;

        // System evolution procedures
        // Used template method design pattern to get hooks to allow the system to evolve
        IQLearningCallback<State, Action> callback;

        // In the current state S, doing action A will bring the system to a new state S' (stochastically)
        public Dictionary<(State, Action), Dictionary<State, float>> EvolutionRule;

        // In the current state S, all actions that is possible to take and their reward
        public Dictionary<(State, Action), Dictionary<double, float>> RewardSystem;

        // The real QFunction score, the model
        public Dictionary<(State, Action), double> QFunction;

        // Init all variables
        public QLearning(IQLearningCallback<State, Action> callback) {
            EvolutionRule = new Dictionary<(State, Action), Dictionary<State, float>>();
            RewardSystem = new Dictionary<(State, Action), Dictionary<double, float>>();
            QFunction = new Dictionary<(State, Action), double>();
            this.callback = callback;
        }



        public void Train() {

            // Init QFunction
            Random rand = new Random();
            foreach ((State s, Action a) in QFunction.Keys) {
                QFunction[(s, a)] = rand.NextDouble();
            }

            // Get all the possible actions for the current state, in order of QFunction score
            List<(Action, double)> actionList = new List<(Action, double)>();

            // Populate the list based on the action that the system can take
            foreach ((State s, Action a) in QFunction.Keys) {
                if (s.Equals(currentState)) {
                    actionList.Add((a, QFunction[(s, a)]));
                }
            }

            // Sort list by discounted reward
            actionList.Sort((x, y) => x.Item2.CompareTo(y.Item2));

            // Get the first action and execute it
            // Have a probability to execute the action, according to the exploration rate
            // With 95% probability choose the best action, otherwise, with 95% probability choose 
            // the next best action, and so on..
            for (int x = 0; x < actionList.Count; x++)
                if (!(rand.NextDouble() < explorationRate))
                    newAction = actionList[x].Item1;
                else break;

            // TODO: Get hooks for:

            // ------------------- EXECUTE ACTION
            // makes system evolve to new State
            callback.executeAction(newAction);

            // ------------------- GET REWARD
            // gets lastReward
            newReward = callback.getReward();

            // ------------------- GET NEW STATE
            // gets nextState
            nextState = callback.getNewState();

            // Update QFunction value
            double prevQValue = QFunction[(currentState, newAction)];
            double newQValue = prevQValue + learningRate * (lastReward + ditchingRate * getMaxQFunction(nextState) - prevQValue);
            QFunction[(currentState, newAction)] = newQValue;

            // ------------------ GET IF GAME OVER
            // increases iteration number
            if (callback.getEpisodeEnd())
                callback.resetEpisode();



        }

        public double getMaxQFunction(State state) {
            double? max = null;
            foreach ((State s, Action a) in QFunction.Keys) {
                if (s.Equals(nextState)) {
                    if (max == null) max = QFunction[(s, a)];
                    if (QFunction[(s, a)] > max) max = QFunction[(s, a)];
                }    
            }
            if (max != null) return (double)max; else return 0; ;
        }




        




    }

}
