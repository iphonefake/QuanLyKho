using BaiVeNhaQuanLyKhoHang.Models;
using BaiVeNhaQuanLyKhoHang.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Controllers
{
    [Route("api/KhoLuuTru")]
    [ApiController]
    public class KhoLuuTrusController : ControllerBase
    {
        private readonly IKhoLuuTruRepository _repository;

        public KhoLuuTrusController(IKhoLuuTruRepository repository)
        {
            repository = _repository;
        }

        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAllKhoLuuTru()
        {
            return Ok(_repository.GetAllKhoLuuTruAsync());
        }
        [Route("GetById")]
        [HttpGet]
        public ActionResult GetKhoLuuTruById(int id)
        {
            if (id <= 0)
                return BadRequest();
            return Ok(_repository.GetKhoLuuTruByIdAsync(id));
        }
        [Route("GetChild")]
        [HttpGet]
        public ActionResult GetKhoLuuTruChild(int id)
        {
            if (id <= 0)
                return BadRequest();
            return Ok(_repository.GetKhoLuuTruChildAsync(id));
        }
        [Route("Create")]
        [HttpPost]
        public ActionResult CreateKhoLuuTru([FromBody]KhoLuuTru khoLuuTru)
        {
            if (khoLuuTru == null)
                return BadRequest();
            _repository.CreateKhoLuuTruAsync(khoLuuTru);
            return Ok("Create KhoLuuTru Successful!");
        }
        [Route("Update")]
        [HttpPost]
        public ActionResult UpdateKhoLuuTru([FromBody]KhoLuuTru khoLuuTru)
        {
            if (khoLuuTru == null)
                return BadRequest();
            _repository.UpdateKhoLuuTruAsync(khoLuuTru);
            return Ok("Update KhoLuuTru Successful!");
        }
        [Route("Delete")]
        [HttpGet]
        public ActionResult DeleteKhoLuuTru(int id)
        {
            if (id <= 0)
                return BadRequest();
            _repository.DeleteKhoLuuTruAsync(id);
            return Ok("Delete KhoLuuTru Successful!");
        }
    }
}
