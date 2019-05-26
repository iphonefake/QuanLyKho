using BaiVeNhaQuanLyKhoHang.Models;
using BaiVeNhaQuanLyKhoHang.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Controllers
{
    [Route("api/ChiTietNhapHang")]
    [ApiController]
    public class ChiTietNhapHangsController : ControllerBase
    {
        private readonly IChiTietNhapHangRepository _repository;
        public ChiTietNhapHangsController(IChiTietNhapHangRepository repository)
        {
            repository = _repository;
        }
        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAllChiTietNhapHang()
        {
            var result = _repository.GetAllChiTietNhapHangAsync();
            return Ok(result);
        }
        [Route("GetById")]
        [HttpGet]
        public ActionResult GetChiTietNhapHangById(int id)
        {
            if (id <= 0)
                return BadRequest();
            var result = _repository.GetChiTietNhapHangByIdAsync(id);
            return Ok(result);
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult CreateChiTietNhapHang(ChiTietNhapHang chiTietNhapHang)
        {
            if (chiTietNhapHang == null)
                return BadRequest();
            _repository.CreateChiTietNhapHangAsync(chiTietNhapHang);
            return Ok("Add ChiTietNhapHang Successful!");
        }
        [Route("Update")]
        [HttpPost]
        public ActionResult UpdateChiTietNhapHang(ChiTietNhapHang chiTietNhapHang)
        {
            if (chiTietNhapHang == null)
                return BadRequest();
            _repository.UpdateChiTietNhapHangAsync(chiTietNhapHang);
            return Ok("Update ChiTietNhapHang Successful!");
        }
        [Route("Delete")]
        [HttpGet]
        public ActionResult DeleteChiTietNhapHang(int id)
        {
            if (id <= 0)
                return BadRequest();
            _repository.DeleteChiTietNhapHangAsync(id);
            return Ok("Delete ChiTietNhapHang Successful!");
        }
    }
}
