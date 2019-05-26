using BaiVeNhaQuanLyKhoHang.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Repositories
{
    public interface IXuatHangRepository
    {
        Task<IEnumerable<XuatHang>> GetAllXuatHangAsync();
        Task<XuatHang> GetXuatHangByIdAsync(int id);

        Task CreateXuatHangAsync(XuatHang xuatHang);
        Task UpdateXuatHangAsync(XuatHang xuatHang);
        Task DeleteXuatHangAsync(int id);
    }
    public class XuatHangRepository : BaseEntityRepository<XuatHang>, IXuatHangRepository
    {
        public XuatHangRepository(DataContext db) : base(db) { }

        public async Task CreateXuatHangAsync(XuatHang xuatHang)
        {
            Create(xuatHang);
            await SaveAsync();
        }

        public async Task DeleteXuatHangAsync(int id)
        {
            var resutl = FindByCondition(n => n.Id == id).SingleOrDefault();
            Delete(resutl);
            await SaveAsync();
        }

        public async Task<IEnumerable<XuatHang>> GetAllXuatHangAsync()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<XuatHang> GetXuatHangByIdAsync(int id)
        {
            return await FindByCondition(n => n.Id == id).SingleOrDefaultAsync();
        }

        public async Task UpdateXuatHangAsync(XuatHang xuatHang)
        {
            var resutl = FindByCondition(n => n.Id == xuatHang.Id).SingleOrDefault();
            resutl = xuatHang;
            Update(resutl);
            await SaveAsync();
        }
    }
}
