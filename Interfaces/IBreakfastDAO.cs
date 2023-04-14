using ContemporaryProgrammingFinal.Models;

namespace ContemporaryProgrammingFinal.Interfaces
{
    public interface IBreakfastDAO
    {
        List<Breakfast> GetAllMembers();
        Breakfast GetMember(string name);
        List<Breakfast> GetFirstFive();
        int? RemoveMember(string name);
        int? UpdateMember(Breakfast member);
        int? AddMember(Breakfast member);
    }
}
