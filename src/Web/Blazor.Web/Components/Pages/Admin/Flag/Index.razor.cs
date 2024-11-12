using Blazor.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Shared.Lib.Dto;

namespace Blazor.Web.Components.Pages.Admin.Flag
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public IFlagService flagService { get; set; }

        public AddEdit createRef;

        public QuickGrid<FlagDto> grid;
        private GridItemsProvider<FlagDto>? FlagResponseProvider;
        private PaginationState pagination = new PaginationState() { ItemsPerPage = 5 };
        private string Search { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await GetList();
        }

        private async Task GetList()
        {
            FlagResponseProvider = async req =>
            {
                int pageNumber = (req.StartIndex / pagination.ItemsPerPage) + 1;
                ListingFilterDto filterDto = new()
                {
                    PageSize = req.Count ?? 10,
                    PageIndex = pageNumber,
                    Search = Search
                };
                var response = await flagService.GetFlags(filterDto);

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

        public void AddFlag()
        {
            createRef.AddFlag();
        }
        public void EditFlag(FlagDto model)
        {
            createRef.EditFlag(model);
        }

        public async Task SaveChanges(bool isSuccess)
        {
            if (isSuccess)
            {
                await GetList();
            }
        }

        private async Task OnDelete(long id, string name)
        {
            var response = await flagService.DeleteFlag(id);
            if (response.Data)
            {
                await GetList();
            }
        }

    }
}
