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
    [Route("api/ChiTietXuatHang")]
    [ApiController]
    public class ChiTietXuatHangsController : ControllerBase
    {
        private readonly IChiTietXuatHangRepository _repository;
        public ChiTietXuatHangsController(IChiTietXuatHangRepository repository)
        {
            repository = _repository;
        }
        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAllChiTietXuatHang()
        {
            var result = _repository.GetAllChiTietXuatHangAsync();
            return Ok(result);
        }
        [Route("GetById")]
        [HttpGet]
        public ActionResult GetChiTietXuatHangById(int id)
        {
            if (id <= 0)
                return BadRequest();
            var result = _repository.GetChiTietXuatHangByIdAsync(id);
            return Ok(result);
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult CreateChiTietXuatHang(ChiTietXuatHang chiTietXuatHang)
        {
            if (chiTietXuatHang == null)
                return BadRequest();
            _repository.CreateChiTietXuatHangAsync(chiTietXuatHang);
            return Ok("Add ChiTietXuatHang Successful!");
        }
        [Route("Update")]
        [HttpPost]
        public ActionResult UpdateChiTietXuatHang(ChiTietXuatHang chiTietXuatHang)
        {
            if (chiTietXuatHang == null)
                return BadRequest();
            _repository.UpdateChiTietXuatHangAsync(chiTietXuatHang);
            return Ok("Update ChiTietXuatHang Successful!");
        }
        [Route("Delete")]
        [HttpGet]
        public ActionResult DeleteChiTietXuatHang(int id)
        {
            if (id <= 0)
                return BadRequest();
            _repository.DeleteChiTietXuatHangAsync(id);
            return Ok("Delete ChiTietXuatHang Successful!");
        }
    }
}