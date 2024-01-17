﻿using accounting_api.Data.Unitofwork;
using accounting_api.Models.Setup.Book;
using accounting_api.Models.Setup.Chart; 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace accounting_api.Controllers.Setup.Chart
{

    [ApiController]
    [Route("api/[controller]")]
    public class ChartgroupSetupController : ControllerBase
    {
        private UnitOfWork _unitOfWork;
        public ChartgroupSetupController(UnitOfWork unitOfWork)
        { 
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IEnumerable<Setup_Chartgroup_model>> getAll()
        {
            return await _unitOfWork.Setup_Chartgroup_model.GetAll();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Setup_Chartgroup_model model)
        {
            try
            {
                Setup_Chartgroup_model_at at_table = new();
                at_table.CopyFromBase(model);

                //ADDITIONAL INFORMATION 
                at_table.AT_ACTION = "INSERT";
                at_table.AT_USER_ID = 1;
                at_table.IP_ADDRESS = HttpContext.Connection.RemoteIpAddress.ToString();

                _unitOfWork.Setup_Chartgroup_model.Add(model, at_table);

                _unitOfWork.SaveChanges(); 

                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult Remove(int id)
        {
            try
            {
                var model = _unitOfWork.Setup_Chartgroup_model.GetById(id);
                Setup_Chartgroup_model_at at_table = new();
                at_table.CopyFromBase(model);
                at_table.AT_ACTION = "REMOVE";

                _unitOfWork.Setup_Chartgroup_model.Remove(model, at_table);

                _unitOfWork.SaveChanges();
                _unitOfWork.Dispose();

                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update(Setup_Chartgroup_model model)
        {
            try
            {
                Setup_Chartgroup_model_at at_table = new();
                at_table.CopyFromBase(model);
                at_table.AT_ACTION = "UPDATE";

                _unitOfWork.Setup_Chartgroup_model.Update(model, at_table);

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
