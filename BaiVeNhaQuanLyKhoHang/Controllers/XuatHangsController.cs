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
    [Route("api/XuatHang")]
    [ApiController]
    public class XuatHangsController : ControllerBase
    {
        private readonly IXuatHangRepository _repository;
        public XuatHangsController(IXuatHangRepository repository)
        {
            repository = _repository;
        }
        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAllXuatHang()
        {
            var result = _repository.GetAllXuatHangAsync();
            return Ok(result);
        }
        [Route("GetById")]
        [HttpGet]
        public ActionResult GetXuatHangById(int id)
        {
            if (id <= 0)
                return BadRequest();
            var result = _repository.GetXuatHangByIdAsync(id);
            return Ok(result);
        }

        [Route("Create")]
        [HttpPost]
        public ActionResult CreateXuatHang(XuatHang xuatHang)
        {
            if (xuatHang == null)
                return BadRequest();
            _repository.CreateXuatHangAsync(xuatHang);
            return Ok("Add XuatHang Successful!");
        }
        [Route("Update")]
        [HttpPost]
        public ActionResult UpdateXuatHang(XuatHang xuatHang)
        {
            if (xuatHang == null)
                return BadRequest();
            _repository.UpdateXuatHangAsync(xuatHang);
            return Ok("Update XuatHang Successful!");
        }
        [Route("Delete")]
        [HttpGet]
        public ActionResult DeleteXuatHang(int id)
        {
            if (id <= 0)
                return BadRequest();
            _repository.DeleteXuatHangAsync(id);
            return Ok("Delete XuatHang Successful!");
        }
    }
}