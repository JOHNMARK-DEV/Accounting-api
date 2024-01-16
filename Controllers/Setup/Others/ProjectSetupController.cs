﻿using accounting_api.Data.Unitofwork;
using accounting_api.Models.Setup.Others;
using accounting_api.Models.Setup.Tax;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace accounting_api.Controllers.Setup.Tax
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProjectSetupController : ControllerBase 
    {
        private UnitOfWork _unitOfWork;
        public ProjectSetupController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IEnumerable<Setup_Project_model>> getAll()
        {
            return await _unitOfWork.Setup_Project_model.GetAll();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Setup_Project_model model)
        {
            try
            {
                Setup_Project_model_at at_table = new();
                at_table.CopyFromBase(model);

                //ADDITIONAL INFORMATION 
                at_table.AT_ACTION = "INSERT";
                at_table.AT_USER_ID = 1;
                at_table.IP_ADDRESS = "INSERT";

                _unitOfWork.Setup_Project_model.Add(model, at_table);

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
                var model = _unitOfWork.Setup_Project_model.GetById(id);
                Setup_Project_model_at at_table = new();
                at_table.CopyFromBase(model);
                at_table.AT_ACTION = "REMOVE";

                _unitOfWork.Setup_Project_model.Remove(model, at_table);

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
        public async Task<IActionResult> Update(Setup_Project_model model)
        {
            try
            {
                Setup_Project_model_at at_table = new();
                at_table.CopyFromBase(model);
                at_table.AT_ACTION = "UPDATE";

                _unitOfWork.Setup_Project_model.Update(model, at_table);

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


    }
}
