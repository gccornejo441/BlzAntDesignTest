using BlzAntDesignTest.Models;
using BlzAntDesignTest.Services;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlzAntDesignTest.Pages.Account.Settings
{
    public partial class BaseView
    {
        private CurrentUser _currentUser = new CurrentUser();

        [Inject] protected IUserService UserService { get; set; }

        private void HandleFinish()
        {
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            _currentUser = await UserService.GetCurrentUserAsync();
        }
    }
}