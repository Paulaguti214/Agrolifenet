using Microsoft.AspNetCore.Components;

namespace Agrolifenet.FrontEnd.Pages
{
    public partial class Notificaciones : ComponentBase
    {
        private bool showNotification = false;

        public void Show()
        {
            showNotification = true;
            StateHasChanged();
        }

        public void Hide()
        {
            showNotification = false;
            StateHasChanged();
        }

        private Notification notificationComponent;

        private void ShowNotification()
        {
            notificationComponent.Show();
        }
    }
}
