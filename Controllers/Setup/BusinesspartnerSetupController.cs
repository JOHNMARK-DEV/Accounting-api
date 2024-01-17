using accounting_api.Data.Unitofwork;
using accounting_api.Models.Setup;
using accounting_api.Models.Setup.Book;
using accounting_api.Models.Setup.Chart;
using accounting_api.Models.Setup.Others;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace accounting_api.Controllers.Setup
{ 
    [ApiController]
    [Route("api/[controller]")]
    public class BusinesspartnerSetupController : ControllerBase
    {
        private UnitOfWork _unitOfWork;
        public BusinesspartnerSetupController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<Setup_Businesspartner_model>> getAll()
        { 
            return await _unitOfWork.Setup_Businesspartner_model.GetAll();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Setup_Businesspartner_model model)
        {
            try
            {
                Setup_Businesspartner_model_at at_table = new();
                at_table.CopyFromBase(model);

                //ADDITIONAL INFORMATION 
                at_table.AT_ACTION = "INSERT";
                at_table.AT_USER_ID = 1;
                at_table.IP_ADDRESS = HttpContext.Connection.RemoteIpAddress.ToString();

                _unitOfWork.Setup_Businesspartner_model.Add(model, at_table);

                _unitOfWork.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update(Setup_Businesspartner_model model)
        {
            try
            {
                Setup_Businesspartner_model_at at_table = new();
                at_table.CopyFromBase(model);
                at_table.AT_ACTION = "UPDATE";

                _unitOfWork.Setup_Businesspartner_model.Update(model, at_table);

                _unitOfWork.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
