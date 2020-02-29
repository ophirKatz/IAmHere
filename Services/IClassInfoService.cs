using IAmHere.Blazor.Data;

namespace IAmHere.Blazor.Services
{
    public interface IClassInfoService
    {
         ClassInfo CreateNewClassSession(string classCode);
         ClassInfo GetClassInfo(string classCode);
         bool ClassExists(string classCode);
    }
}