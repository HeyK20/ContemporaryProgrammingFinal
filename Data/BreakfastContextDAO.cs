using ContemporaryProgrammingFinal.Interfaces;
using ContemporaryProgrammingFinal.Models;

namespace ContemporaryProgrammingFinal.Data
{
    public class BreakfastContextDAO : IBreakfastDAO
    {
        private TeamInfoContext _context;
        public BreakfastContextDAO(TeamInfoContext context)
        {
            _context = context;
        }

        public int? AddMember(Breakfast member)
        {
            var members = _context.Items.Where(x => x.Name.Equals(member.Name)).FirstOrDefault();
            if (members != null)
            {
                return null;
            }
            try
            {
                _context.Items.Add(member);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public List<Breakfast> GetAllMembers()
        {
            return _context.Items.ToList();
        }
        public List<Breakfast> GetFirstFive()
        {
            return _context.Items.Take(5).ToList();
        }

        public Breakfast GetMember(string name)
        {
            return _context.Items.Where(x => x.Name.Equals(name)).FirstOrDefault();
        }

        public int? RemoveMember(string name)
        {
            var member = this.GetMember(name);
            if (member == null) return null;
            try
            {
                _context.Items.Remove(member);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public int? UpdateMember(Breakfast member)
        {
            var memberToUpdate = this.GetMember(member.Name);
            if (memberToUpdate == null) return null;
            memberToUpdate.Id = member.Id;
            memberToUpdate.Name = member.Name;
            memberToUpdate.Hot = member.Hot;
            memberToUpdate.Cold = member.Cold;
            memberToUpdate.Refridgerated = member.Refridgerated;
            memberToUpdate.Calories = member.Calories;
            memberToUpdate.FatContent = member.FatContent;
            try
            {
                _context.Items.Update(memberToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}
