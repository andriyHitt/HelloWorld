using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.HouseBuilding
{
    public class Team
    {
        private TeamLeader _teamLeader;
        private Worker[] _workers;
        public Team(ushort numbOfWorkers) 
        { 
            _workers = new Worker[numbOfWorkers];
            for (ushort i = 0; i < _workers.Length; i++)
            {
                _workers[i] = new Worker();
            }
            _teamLeader = new TeamLeader(); 
        }

        public TeamLeader MyTeamLeader { get => _teamLeader; }
        public Worker[] MyWorkers { get => _workers; /*set => _workers = value;*/ }
        public ref Worker[] workers()
        {
            return ref _workers;
        }
        public void IsWork(bool isWorking)
        {
            for (ushort i = 0; i < MyWorkers.Length; i++)
            {
                MyWorkers[i].isWorking = isWorking;
            }
        }
    }
}
