using Blazor.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Shared.Lib.Dto;

namespace Blazor.Web.Components.Pages.Admin.User
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public IUserService userService { get; set; }

        public AddEdit createRef;
        public List<UsersDto> UserList { get; set; } = new List<UsersDto>();
        private PaginationState pagination = new PaginationState() { ItemsPerPage = 2};
        protected override async Task OnInitializedAsync()
        {
            await GetList();
        }

        private async Task GetList()
        {
            var responce = await userService.GetUsers();
            UserList = responce.Data ?? new List<UsersDto>();
        }

        public void AddUser()
        {
            createRef.AddUser();
        }
        public void EditUser(UsersDto model)
        {
            createRef.EditUser(model);
        }

        public async Task SaveChanges(bool isSuccess)
        {
            if (isSuccess)
            {
               await GetList();
            }
        }

        private async Task OnDelete(int id, string name)
        {
            var response = await userService.DeleteUser(id);
            if (response.Data)
            {
                await GetList();
            }
        }

    }
}
