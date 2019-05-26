using BaiVeNhaQuanLyKhoHang.Models;
using BaiVeNhaQuanLyKhoHang.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Controllers
{
    [Route("api/NhapHang")]
    [ApiController]
    public class NhapHangsController : ControllerBase
    {
        private readonly INhapHangRepository _repository;
        public NhapHangsController(INhapHangRepository repository)
        {
            repository = _repository;
        }
        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAllNhapHang()
        {
            var result = _repository.GetAllNhapHangAsync();
            return Ok(result);
        }
        [Route("GetById")]
        [HttpGet]
        public ActionResult GetNhapHangById(int id)
        {
            if (id <= 0)
                return BadRequest();
            var result = _repository.GetNhapHangByIdAsync(id);
            return Ok(result);
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult CreateNhapHang(NhapHang nhapHang)
        {
            if (nhapHang == null)
                return BadRequest();
            _repository.CreateNhapHangAsync(nhapHang);
            return Ok("Add NhapHang Successful!");
        }
        [Route("Update")]
        [HttpPost]
        public ActionResult UpdateNhapHang(NhapHang nhapHang)
        {
            if (nhapHang == null)
                return BadRequest();
            _repository.UpdateNhapHangAsync(nhapHang);
            return Ok("Update NhapHang Successful!");
        }
        [Route("Delete")]
        [HttpGet]
        public ActionResult DeleteNhapHang(int id)
        {
            if (id <= 0)
                return BadRequest();
            _repository.DeleteNhapHangAsync(id);
            return Ok("Delete NhapHang Successful!");
        }
    }
}
