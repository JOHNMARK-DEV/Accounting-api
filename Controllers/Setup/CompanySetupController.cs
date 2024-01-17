using accounting_api.Data.Unitofwork;
using accounting_api.Models.Setup;
using accounting_api.Models.Setup.Book;
using accounting_api.Models.Setup.Others;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace accounting_api.Controllers.Setup 
{ 
    [ApiController]
    [Route("api/[controller]")]
    public class CompanySetupController : ControllerBase
    {
        private UnitOfWork _unitOfWork;
        public CompanySetupController(UnitOfWork unitOfWork)
        { 
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public Setup_Company_model getAll()
        {
            return _unitOfWork.Setup_Company_model.GetById(1);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Setup_Company_model model)
        {
            try
            {
                Setup_Company_model_at at_table = new();
                at_table.CopyFromBase(model);
                at_table.AT_ACTION = "UPDATE";

                _unitOfWork.Setup_Company_model.Update(model, at_table);

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
