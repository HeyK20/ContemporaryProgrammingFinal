using ContemporaryProgrammingFinal.Models;

namespace ContemporaryProgrammingFinal.Interfaces
{
    public interface ITeamMembersContextDAO
    {
        List<TeamInfo> GetAllMembers();
        TeamInfo GetMember(int id);

        List<TeamInfo> GetFirstFive();
    }
}
