using System.Threading.Tasks;

namespace IAmHere.Blazor.Services
{
    public interface IBrowserSessionHandler
    {
         Task<bool> IsStudentRegisteredToClass(string classCode);

         Task RegisterStudentToClass(string classCode);
    }
}