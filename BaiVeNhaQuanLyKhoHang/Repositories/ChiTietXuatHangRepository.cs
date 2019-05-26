using BaiVeNhaQuanLyKhoHang.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Repositories
{
    public interface IChiTietXuatHangRepository
    {
        Task<IEnumerable<ChiTietXuatHang>> GetAllChiTietXuatHangAsync();
        Task<ChiTietXuatHang> GetChiTietXuatHangByIdAsync(int id);

        Task CreateChiTietXuatHangAsync(ChiTietXuatHang chiTietXuatHang);
        Task UpdateChiTietXuatHangAsync(ChiTietXuatHang chiTietXuatHang);
        Task DeleteChiTietXuatHangAsync(int id);
    }
    public class ChiTietXuatHangRepository : BaseEntityRepository<ChiTietXuatHang>, IChiTietXuatHangRepository
    {
        public ChiTietXuatHangRepository(DataContext db) : base(db) { }

        public async Task CreateChiTietXuatHangAsync(ChiTietXuatHang chiTietXuatHang)
        {
            Create(chiTietXuatHang);
            await SaveAsync();
        }

        public async Task DeleteChiTietXuatHangAsync(int id)
        {
            var resutl = FindByCondition(n => n.Id == id).SingleOrDefault();
            Delete(resutl);
            await SaveAsync();
        }

        public async Task<IEnumerable<ChiTietXuatHang>> GetAllChiTietXuatHangAsync()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<ChiTietXuatHang> GetChiTietXuatHangByIdAsync(int id)
        {
            return await FindByCondition(n => n.Id == id).SingleOrDefaultAsync();
        }

        public async Task UpdateChiTietXuatHangAsync(ChiTietXuatHang chiTietXuatHang)
        {
            var resutl = FindByCondition(n => n.Id == chiTietXuatHang.Id).SingleOrDefault();
            resutl = chiTietXuatHang;
            Update(resutl);
            await SaveAsync();
        }
    }
}
