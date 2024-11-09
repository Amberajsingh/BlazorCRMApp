using Blazor.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Shared.Lib.Dto;
using static System.Net.WebRequestMethods;

namespace Blazor.Web.Components.Pages.Admin.Designation
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public IMasterService masterService { get; set; }

        public AddEdit createRef;
        //public List<DesignationResponseDto> DesignationList { get; set; } = new List<DesignationResponseDto>();

        public QuickGrid<DesignationResponseDto> grid;
        private GridItemsProvider<DesignationResponseDto>? DesignationResponseProvider;
        private PaginationState pagination = new PaginationState() { ItemsPerPage = 5 };
        private string Search { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await GetList();
        }

        private async Task GetList()
        {
            DesignationResponseProvider = async req =>
            {
                int pageNumber = (req.StartIndex / pagination.ItemsPerPage) + 1;
                ListingFilterDto filterDto = new()
                {
                    PageSize = req.Count ?? 10,
                    PageIndex = pageNumber,
                    Search = Search
                };
                var response = await masterService.GetDesignations(filterDto);

                return GridItemsProviderResult.From(
                    items: response.Data.Items,
                    totalItemCount: response!.Data.TotalCount
                    );
            };
        }

        public async Task OnPageChange(ChangeEventArgs e)
        {
            if (e.Value != null && !string.IsNullOrWhiteSpace(e.Value.ToString()))
            {
                pagination.ItemsPerPage = Convert.ToInt32(e.Value);
                //await grid!.RefreshDataAsync();

                //StateHasChanged();
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

        public void AddDesignation()
        {
            createRef.AddDesignation();
        }
        public void EditDesignation(DesignationResponseDto model)
        {
            createRef.EditDesignation(model);
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
            var response = await masterService.DeleteDesignation(id);
            if (response.Data)
            {
                await GetList();
            }
        }

    }
}
