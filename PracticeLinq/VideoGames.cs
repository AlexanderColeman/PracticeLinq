using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLinq
{
    public class VideoGames
    {
        public static List<string> MakeVideoGameList()
        {
            List<string> listOfGames = new List<string>()
            {
                "Apex Legends",
                "Call of Duty",
                "League of Legends",
                "Fallout",
                "Zelda",
                "Super smash bros",
                "Mario Cart"
            };

            return listOfGames;
        }
    }
}
