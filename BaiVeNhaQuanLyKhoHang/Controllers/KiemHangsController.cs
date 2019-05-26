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
    [Route("api/KiemHang")]
    [ApiController]
    public class KiemHangsController : ControllerBase
    {
        private readonly IKiemHangRepository _repository;
        public KiemHangsController(IKiemHangRepository repository)
        {
            repository = _repository;
        }

        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAllKiemHang()
        {
            var result = _repository.GetAllKiemHangAsync();
            return Ok(result);
        }
        [Route("GetById")]
        [HttpGet]
        public ActionResult GetKiemHangById(int id)
        {
            if (id <= 0)
                return BadRequest();
            var result = _repository.GetKiemHangByIdAsync(id);
            return Ok(result);
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult CreateKiemHang(KiemHang kiemHang)
        {
            if (kiemHang == null)
                return BadRequest();
            _repository.CreateKiemHangAsync(kiemHang);
            return Ok("Add KiemHang Successful!");
        }
        [Route("Update")]
        [HttpPost]
        public ActionResult UpdateKiemHang(KiemHang kiemHang)
        {
            if (kiemHang == null)
                return BadRequest();
            _repository.UpdateKiemHangAsync(kiemHang);
            return Ok("Update KiemHang Successful!");
        }
        [Route("Delete")]
        [HttpGet]
        public ActionResult DeleteKiemHang(int id)
        {
            if (id <= 0)
                return BadRequest();
            _repository.DeleteKiemHangAsync(id);
            return Ok("Delete KiemHang Successful!");
        }
    }
}