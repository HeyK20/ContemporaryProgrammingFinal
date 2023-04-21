using ContemporaryProgrammingFinal.Models;

namespace ContemporaryProgrammingFinal.Interfaces
{
    public interface IBreakfastDAO
    {
        List<Breakfast> GetAllMembers();
        Breakfast GetMember(int id);
        List<Breakfast> GetFirstFive();
        int? RemoveMember(int id);
        int? UpdateMember(Breakfast member);
        int? AddMember(Breakfast member);
    }
}
