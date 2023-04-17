using ContemporaryProgrammingFinal.Models;

namespace ContemporaryProgrammingFinal.Interfaces
{
    public interface IGamesContextDAO
    {
        List<Game> GetAllGames();
        Game GetGame(int id);
        List<Game> GetFirstFive();
        int? RemoveGame(int id);
        int? UpdateGame(Game game);
        int? AddGame(Game game);
    }
}
