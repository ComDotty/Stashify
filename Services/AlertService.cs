using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace Stashify.Services
{
    public class AlertService : IAlertService
    {
        public Task ShowAlertAsync(string title, string message, string cancel)
        {
            // Use Application.Current.MainPage to display the alert
        #pragma warning disable CS8602 // Dereference of a possibly null reference.
            return Application.Current.MainPage.DisplayAlert(title, message, cancel);
        #pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}