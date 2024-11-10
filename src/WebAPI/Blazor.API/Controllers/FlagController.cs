using AutoMapper;
using Blazor.API.Data.Entities;
using Blazor.API.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Lib.Dto;
using Shared.Lib.Helper;
using Shared.Lib.Resources;

namespace Blazor.API.Controllers
{
    public class FlagController : BaseController
    {
        private readonly IFlagService _FlagService;
        private readonly IMapper _mapper;
        public FlagController(IFlagService FlagService, IMapper mapper)
        {
            _FlagService = FlagService;
            _mapper = mapper;
        }


        #region [Flag]
        [HttpPost]
        public IActionResult GetFlags([FromBody] ListingFilterDto model)
        {
            try
            {
                List<FlagDto> responseModel = new List<FlagDto>();

                var predicate = PredicateBuilder.True<FlagMaster>();

                predicate = predicate.And(m => m.IsDeleted == false);

                if (!string.IsNullOrWhiteSpace(model.Search))
                {
                    model.Search = model.Search.ToLower()?.Trim();
                    predicate = predicate.And(m => m.FlagName.ToLower().StartsWith(model.Search!));
                }

                var result = _FlagService.GetFlags(predicate, model.OrderColumn, model.OrderDirection);

                responseModel = _mapper.Map<List<FlagDto>>(result);

                return SuccessResult(responseModel.ToPageList(model.PageIndex, model.PageSize));
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        [HttpGet]
        public IActionResult GetFlagById(int id)
        {
            try
            {
                FlagDto responseModel = new FlagDto();

                var result = _FlagService.GetFlagById(id);
                responseModel = _mapper.Map<FlagDto>(result);

                return SuccessResult(responseModel);
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        [HttpPost]
        public IActionResult ManageFlag([FromBody] FlagRequestDto model)
        {
            try
            {
                if (!_FlagService.FlagNameAvailabiltity(model.Id, model.FlagName))
                {
                    var category = _mapper.Map<FlagMaster>(model);
                    _FlagService.AddUpdate(category);

                    return SuccessResult(true);
                }
                return BadRequestErrorResult("Flag name already exist");
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        [HttpDelete]
        public IActionResult DeleteFlag([FromBody] int id)
        {
            try
            {
                _FlagService.DeleteFlagById(id);
                return SuccessResult(true);
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        [HttpGet]
        public IActionResult UpdateFlagStatus(int id, bool status)
        {
            try
            {
                _FlagService.UpdateFlagStatus(id, status);
                return SuccessResult(true);
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        #endregion
    }
}
