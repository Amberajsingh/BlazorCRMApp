using AutoMapper;
using Blazor.API.Data.Entities;
using Blazor.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Lib.Dto;
using Shared.Lib.Helper;
using Shared.Lib.Resources;

namespace Blazor.API.Controllers
{
    [Route("[controller]/[action]")]
    public class MasterController : BaseController
    {
        private readonly IMasterService _masterService;
        private readonly IMapper _mapper;
        public MasterController(IMasterService masterService, IMapper mapper)
        {
            _masterService = masterService;
            _mapper = mapper;
        }


        #region [Designation Master]
        [HttpPost]
        public IActionResult GetDesignations([FromBody] ListingFilterDto model)
        {
            try
            {
                List<DesignationResponseDto> responseModel = new List<DesignationResponseDto>();

                var predicate = PredicateBuilder.True<DesignationMaster>();

                predicate = predicate.And(m => m.IsDeleted == false);

                if (!string.IsNullOrWhiteSpace(model.Search))
                {
                    model.Search = model.Search.ToLower()?.Trim();
                    predicate = predicate.And(m => m.Name.ToLower().StartsWith(model.Search!));
                }

                var result = _masterService.GetDesignations(predicate, model.OrderColumn, model.OrderDirection);

                responseModel = _mapper.Map<List<DesignationResponseDto>>(result);

                return SuccessResult(responseModel.ToPageList(model.PageIndex, model.PageSize));
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        [HttpGet]
        public IActionResult GetDesignationById(int id)
        {
            try
            {
                DesignationResponseDto responseModel = new DesignationResponseDto();

                var result = _masterService.GetDesignationById(id);
                responseModel = _mapper.Map<DesignationResponseDto>(result);

                return SuccessResult(responseModel);
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        [HttpPost]
        public IActionResult ManageDesignation([FromBody] DesignationRequestDto model)
        {
            try
            {
                if (!_masterService.DesignationNameAvailabiltity(model.Id, model.Name))
                {
                    var category = _mapper.Map<DesignationMaster>(model);
                    _masterService.AddUpdate(category);

                    return SuccessResult(true);
                }
                return BadRequestErrorResult("Designation name already exist");
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        [HttpDelete]
        public IActionResult DeleteDesignation([FromBody] int id)
        {
            try
            {
                _masterService.DeleteDesignationById(id);
                return SuccessResult(true);
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        [HttpGet]
        public IActionResult UpdateDesignationStatus(int id, bool status)
        {
            try
            {
                _masterService.UpdateDesignationStatus(id, status);
                return SuccessResult(true);
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        #endregion

        #region[Country State City]
        [HttpGet]
        public IActionResult GetCountries()
        {
            try
            {
                List<SelectListDto> responseModel = new List<SelectListDto>();

                var result = _masterService.GetCountries();
                responseModel = _mapper.Map<List<SelectListDto>>(result);

                return SuccessResult(responseModel);
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        [HttpGet]
        public IActionResult GetStates(int countryId)
        {
            try
            {
                List<SelectListDto> responseModel = new List<SelectListDto>();

                var result = _masterService.GetStates(countryId);
                responseModel = _mapper.Map<List<SelectListDto>>(result);

                return SuccessResult(responseModel);
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        [HttpGet]
        public IActionResult GetCities(int stateId)
        {
            try
            {
                List<SelectListDto> responseModel = new List<SelectListDto>();

                var result = _masterService.GetCities(stateId);
                responseModel = _mapper.Map<List<SelectListDto>>(result);

                return SuccessResult(responseModel);
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }

        [HttpGet]
        public IActionResult GetTimeZones()
        {
            try
            {
                List<SelectListDto> responseModel = new List<SelectListDto>();
                var result = _masterService.GetTimeZones();
                responseModel = _mapper.Map<List<SelectListDto>>(result);

                return SuccessResult(responseModel);
            }
            catch (Exception exception)
            {
                return ExceptionErrorResult(BaseResponseMessages.EXCEPTION, exception);
            }
        }
        #endregion
    }
}
