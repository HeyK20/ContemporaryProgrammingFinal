using ContemporaryProgrammingFinal.Interfaces;
using ContemporaryProgrammingFinal.Models;

namespace ContemporaryProgrammingFinal.Data
{
    public class BreakfastContextDAO : IBreakfastDAO
    {
        private BreakfastInfoContext _context;
        public BreakfastContextDAO(BreakfastInfoContext context)
        {
            _context = context;
        }

        public int? AddMember(Breakfast member)
        {
            var members = _context.Members.Where(x => x.Name.Equals(member.Name)).FirstOrDefault();
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
            catch (Exception)
            {
                return 0;
            }

        }

        public List<Breakfast> GetAllMembers()
        {
            return _context.Members.ToList();
        }
        public List<Breakfast> GetFirstFive()
        {
            return _context.Members.Take(5).ToList();
        }

        public Breakfast GetMember(string name)
        {
            return _context.Members.Where(x => x.Name.Equals(name)).FirstOrDefault();
        }

        public int? RemoveMember(string name)
        {
            var member = this.GetMember(name);
            if (member == null) return null;
            try
            {
                _context.Members.Remove(member);
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

            memberToUpdate.Name = member.Name;
            memberToUpdate.Hot = member.Hot;
            memberToUpdate.Cold = member.Cold;
            memberToUpdate.Refridgerated = member.Refridgerated;
            memberToUpdate.Calories = member.Calories;
            memberToUpdate.FatContent = member.FatContent;
            try
            {
                _context.Members.Update(memberToUpdate);
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
