using System.Threading.Tasks;

namespace Stashify.Services
{
    public interface IAlertService
    {
        Task ShowAlertAsync(string title, string message, string cancel);
    }
}