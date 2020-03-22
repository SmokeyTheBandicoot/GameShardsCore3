using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShardsCore3.AI.MachineLearning.ReinforcementLearning.QLearning {
    
    public interface IQLearningCallback<State, Action> {

        public State getNewState();

        public double getReward();

        public void executeAction(Action a);

        public bool getEpisodeEnd();

        public void resetEpisode();

    }
}
