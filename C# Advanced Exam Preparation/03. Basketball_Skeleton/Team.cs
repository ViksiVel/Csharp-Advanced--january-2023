using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace Basketball
{
    public class Team
    {
        //Next, a class named Team is given, that has a collection (players) of type Player. 
        private List<Player> players;
        public Team(string name, int openPositions, char group)
        {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
            players = new List<Player>();
        }

        public string Name { get; private set; }
        public int OpenPositions { get; private set; }
        public char Group { get; private set; }

        public IReadOnlyCollection<Player> Players => players;
        public int Count => Players.Count;

        public string AddPlayer(Player player)
        {
            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return $"Invalid player's information.";
            }
            else if (OpenPositions == 0)
            {
                return $"There are no more open positions.";
            }
            else if (player.Rating < 80)
            {
                return $"Invalid player's rating.";
            }
            else
            {
                players.Add(player);
                OpenPositions--;
                return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
            }

        }

        public bool RemovePlayer(string name)
        {
            var targetPlayer = Players.FirstOrDefault(x => x.Name == name);
            if (targetPlayer == null)
            {
                return false;
                
            }
            OpenPositions++;
            players.Remove(targetPlayer);
            return true;
        }

        public int RemovePlayerByPosition(string position)
        {
            int countRemoved = 0;
            
            while (players.FirstOrDefault(x => x.Position == position) != null)
            {
                var targetPlayer = players.FirstOrDefault(x => x.Position == position);
                OpenPositions++;
                players.Remove(targetPlayer);
                countRemoved++;
            }
            return countRemoved;
        }
        //•	Player RetirePlayer(string name) method – retire (set his Retired property to true, without removing him from the collection) the player with the given name, if he exists. As a result, return the player, or null, if he don't exist
        public Player RetirePlayer(string name)
        {
            var targetPlayer = Players.FirstOrDefault(x => x.Name == name);

            if (targetPlayer == null)
            {
                return null;

            }
            targetPlayer.Retired = true;
            return targetPlayer;
        }
        //•	List<Player> AwardPlayers (int games) method – return a list with all players that have participated in games games or more.
        public List<Player> AwardPlayers(int games)
        {
            List<Player> awardedPlayers = new List<Player>();

            foreach (var player in Players.Where(x => x.Games >= games))
            {
                awardedPlayers.Add(player);
            }

            return awardedPlayers;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Active players competing for Team {Name} from Group {Group}:");

            foreach (var player in this.Players.Where(x => x.Retired != true))
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
