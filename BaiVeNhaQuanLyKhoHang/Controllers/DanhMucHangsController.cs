using BaiVeNhaQuanLyKhoHang.Models;
using BaiVeNhaQuanLyKhoHang.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Controllers
{
    [Route("api/DanhMucHang")]
    [ApiController]
    public class DanhMucHangsController : ControllerBase
    {
        private readonly IDanhMucHangRepository _repository;
        public DanhMucHangsController(IDanhMucHangRepository repository)
        {
            repository = _repository;
        }

        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAllDanhMucHang()
        {
            var result = _repository.GetAllDanhMucHangAsync();
            return Ok(result);
        }
        [Route("GetById")]
        [HttpGet]
        public ActionResult GetDanhMucHangById(int id)
        {
            if (id <= 0)
                return BadRequest();
            var result = _repository.GetDanhMucHangByIdAsync(id);
            return Ok(result);
        }
        [Route("GetChild")]
        [HttpPost]
        public ActionResult GetDanhMucHangChild(int id)
        {
            if (id <= 0)
                return BadRequest();
            var result = _repository.GetDanhMucHangChildAsync(id);
            return Ok(result);
        }
        [Route("Create")]
        [HttpPost]
        public ActionResult CreateDanhMucHang(DanhMucHang danhMucHang)
        {
            if (danhMucHang == null)
                return BadRequest();
            _repository.CreateDanhMucHangAsync(danhMucHang);
            return Ok("Add DanhMucHang Successful!");
        }
        [Route("Update")]
        [HttpPost]
        public ActionResult UpdateDanhMucHang(DanhMucHang danhMucHang)
        {
            if (danhMucHang == null)
                return BadRequest();
            _repository.UpdateDanhMucHangAsync(danhMucHang);
            return Ok("Update DanhMucHang Successful!");
        }
        [Route("Delete")]
        [HttpGet]
        public ActionResult DeleteDanhMucHang(int id)
        {
            if (id <= 0)
                return BadRequest();
            _repository.DeleteDanhMucHangAsync(id);
            return Ok("Delete DanhMucHang Successful!");
        }
    }
}
