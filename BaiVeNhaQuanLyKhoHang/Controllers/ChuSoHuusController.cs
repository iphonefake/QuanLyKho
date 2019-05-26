using BaiVeNhaQuanLyKhoHang.Models;
using BaiVeNhaQuanLyKhoHang.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Controllers
{
    [Route("api/ChuSoHuu")]
    [ApiController]
    public class ChuSoHuusController : ControllerBase
    {
        private readonly IChuSoHuuRepository _repository;
        public ChuSoHuusController(IChuSoHuuRepository repository)
        {
            repository = _repository;
        }
        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAllChuSoHuu()
        {
            var result = _repository.GetAllChuSoHuuAsync();
            return Ok(result);
        }
        [Route("GetById")]
        [HttpGet]
        public ActionResult GetChuSoHuuById(int id)
        {
            if (id <= 0)
                return BadRequest();
            var result = _repository.GetChuSoHuuByIdAsync(id);
            return Ok(result);
        }
        
        [Route("Create")]
        [HttpPost]
        public ActionResult CreateChuSoHuu(ChuSoHuu chuSoHuu)
        {
            if (chuSoHuu == null)
                return BadRequest();
            _repository.CreateChuSoHuuAsync(chuSoHuu);
            return Ok("Add ChuSoHuu Successful!");
        }
        [Route("Update")]
        [HttpPost]
        public ActionResult UpdateChuSoHuu(ChuSoHuu chuSoHuu)
        {
            if (chuSoHuu == null)
                return BadRequest();
            _repository.UpdateChuSoHuuAsync(chuSoHuu);
            return Ok("Update ChuSoHuu Successful!");
        }
        [Route("Delete")]
        [HttpGet]
        public ActionResult DeleteChuSoHuu(int id)
        {
            if (id <= 0)
                return BadRequest();
            _repository.DeleteChuSoHuuAsync(id);
            return Ok("Delete ChuSoHuu Successful!");
        }
    }
}
