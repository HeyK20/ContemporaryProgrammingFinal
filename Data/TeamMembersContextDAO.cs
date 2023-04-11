using ContemporaryProgrammingFinal.Interfaces;
using ContemporaryProgrammingFinal.Models;

namespace ContemporaryProgrammingFinal.Data
{
    public class TeamMembersContextDAO : ITeamMembersContextDAO
    {
        private TeamInfoContext _context;
        public TeamMembersContextDAO(TeamInfoContext context) 
        {
            _context= context;
        }

        public List<TeamInfo> GetAllMembers()
        {
            return _context.Members.ToList();
        }
        public List<TeamInfo> GetFirstFive() 
        {
            return _context.Members.Take(5).ToList();
        }

       public TeamInfo GetMember(int id)
        {
            return _context.Members.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
    }
}
