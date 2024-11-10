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
        public QuickGrid<UserDto> grid;
        private GridItemsProvider<UserDto>? _userResponseProvider;
        private PaginationState pagination = new PaginationState() { ItemsPerPage = 5 };
        private string Search { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await GetList();
        }

        private async Task GetList()
        {
            _userResponseProvider = async req =>
            {
                int pageNumber = (req.StartIndex / pagination.ItemsPerPage) + 1;
                ListingFilterDto filterDto = new()
                {
                    PageSize = req.Count ?? 10,
                    PageIndex = pageNumber,
                    Search = Search
                };
                var response = await userService.GetUsers(filterDto);

                return GridItemsProviderResult.From(
                    items: response.Data!.Items,
                    totalItemCount: response!.Data.TotalCount
                    );
            };
        }

        public async Task OnPageChange(ChangeEventArgs e)
        {
            if (e.Value != null && !string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                pagination.ItemsPerPage = Convert.ToInt32(e.Value);
            }
        }

        public async Task OnSearchChange(ChangeEventArgs e)
        {
            if (e.Value != null && !string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                Search = e.Value.ToString();
            }
            else
            {
                Search = string.Empty;
            }
            await grid!.RefreshDataAsync();
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
