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

        public int? AddMember(TeamInfo member)
        {
            var members = _context.Members.Where(x => x.FullName.Equals(member.FullName)).FirstOrDefault();
            if (members != null)
            {
                return null;
            }
            try
            {
                _context.Members.Add(member);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
            
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

        public int? RemoveMember(int id)
        {
            var member = this.GetMember(id);
            if (member == null) return null;
            try
            {
                _context.Members.Remove(member);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
            
        }

        public int? UpdateMember(TeamInfo member)
        {
            var memberToUpdate = this.GetMember(member.Id);
            if (memberToUpdate == null) return null;

            memberToUpdate.FullName= member.FullName;
            memberToUpdate.BirthDate= member.BirthDate;
            memberToUpdate.YearInProgram = member.YearInProgram;
            memberToUpdate.CollegeProgram = member.CollegeProgram;
            memberToUpdate.Id= member.Id;
            memberToUpdate.BirthDate = member.BirthDate;
            try
            {
                _context.Members.Update(memberToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
            
        }
    }
}
