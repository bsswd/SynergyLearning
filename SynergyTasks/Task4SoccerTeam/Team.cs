using System;

namespace Task4SoccerTeam
{
        class Team
        {
            private Player[] _team;

            public Team(Player[] team) => _team = team;

            public Player this[int index]
            {
                get
                {
                if (_team.Length != 11)
                    throw new ArgumentException("Игроков должно быть 11");
                else
                    return _team[index];
                }
                set => _team[index] = value;
            } 
        }
}

