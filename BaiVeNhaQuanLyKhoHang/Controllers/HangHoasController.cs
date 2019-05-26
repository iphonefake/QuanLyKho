using BaiVeNhaQuanLyKhoHang.Models;
using BaiVeNhaQuanLyKhoHang.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Controllers
{
    [Route("api/HangHoa")]
    [ApiController]
    public class HangHoasController : ControllerBase
    {
        private readonly IHangHoaRepository _repository;

        public HangHoasController(IHangHoaRepository repository)
        {
            repository = _repository;
        }
        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAllHangHoa()
        {
            var result = _repository.GetAllHangHoaAsync();
            return Ok(result);
        }
        [Route("GetById")]
        [HttpGet]
        public ActionResult GetHangHoaById(int id)
        {
            if (id <= 0)
                return BadRequest();
            var result = _repository.GetHangHoaByIdAsync(id);
            return Ok(result);
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult CreateHangHoa(HangHoa hangHoa)
        {
            if (hangHoa == null)
                return BadRequest();
            _repository.CreateHangHoaAsync(hangHoa);
            return Ok("Add HangHoa Successful!");
        }
        [Route("Update")]
        [HttpPost]
        public ActionResult UpdateHangHoa(HangHoa hangHoa)
        {
            if (hangHoa == null)
                return BadRequest();
            _repository.UpdateHangHoaAsync(hangHoa);
            return Ok("Update HangHoa Successful!");
        }
        [Route("Delete")]
        [HttpGet]
        public ActionResult DeleteHangHoa(int id)
        {
            if (id <= 0)
                return BadRequest();
            _repository.DeleteHangHoaAsync(id);
            return Ok("Delete HangHoa Successful!");
        }
    }
}
