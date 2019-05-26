using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaiVeNhaQuanLyKhoHang.Models;
using BaiVeNhaQuanLyKhoHang.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BaiVeNhaQuanLyKhoHang.Controllers
{
    [Route("api/ChiTietKiemHang")]
    [ApiController]
    public class ChiTietKiemHangsController : ControllerBase
    {
        private readonly IChiTietKiemHangRepository _repository;
        public ChiTietKiemHangsController(IChiTietKiemHangRepository repository)
        {
            repository = _repository;
        }

        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAllChiTietKiemHang()
        {
            var result = _repository.GetAllChiTietKiemHangAsync();
            return Ok(result);
        }
        [Route("GetById")]
        [HttpGet]
        public ActionResult GetChiTietKiemHangById(int id)
        {
            if (id <= 0)
                return BadRequest();
            var result = _repository.GetChiTietKiemHangByIdAsync(id);
            return Ok(result);
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult CreateChiTietKiemHang(ChiTietKiemHang chiTietKiemHang)
        {
            if (chiTietKiemHang == null)
                return BadRequest();
            _repository.CreateChiTietKiemHangAsync(chiTietKiemHang);
            return Ok("Add ChiTietKiemHang Successful!");
        }
        [Route("Update")]
        [HttpPost]
        public ActionResult UpdateChiTietKiemHang(ChiTietKiemHang chiTietKiemHang)
        {
            if (chiTietKiemHang == null)
                return BadRequest();
            _repository.UpdateChiTietKiemHangAsync(chiTietKiemHang);
            return Ok("Update ChiTietKiemHang Successful!");
        }
        [Route("Delete")]
        [HttpGet]
        public ActionResult DeleteChiTietKiemHang(int id)
        {
            if (id <= 0)
                return BadRequest();
            _repository.DeleteChiTietKiemHangAsync(id);
            return Ok("Delete ChiTietKiemHang Successful!");
        }
    }
}