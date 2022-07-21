using PracticeLinq;

var listOfGames = VideoGames.MakeVideoGameList();

listOfGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));