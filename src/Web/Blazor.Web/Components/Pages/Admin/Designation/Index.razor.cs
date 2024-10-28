using Blazor.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Shared.Lib.Dto;

namespace Blazor.Web.Components.Pages.Admin.Designation
{
    public partial class Index : ComponentBase
    {
        [Inject]
        public IMasterService masterService { get; set; }

        public AddEdit createRef;
        public List<DesignationResponseDto> DesignationList { get; set; } = new List<DesignationResponseDto>();
        private PaginationState pagination = new PaginationState() { ItemsPerPage = 2};
        protected override async Task OnInitializedAsync()
        {
            await GetList();
        }

        private async Task GetList()
        {
            var responce = await masterService.GetDesignations();
            DesignationList = responce.Data;
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
