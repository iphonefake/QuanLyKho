using BaiVeNhaQuanLyKhoHang.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Repositories
{
    public interface IChiTietKiemHangRepository
    {
        Task<IEnumerable<ChiTietKiemHang>> GetAllChiTietKiemHangAsync();
        Task<ChiTietKiemHang> GetChiTietKiemHangByIdAsync(int id);

        Task CreateChiTietKiemHangAsync(ChiTietKiemHang chiTietKiemHang);
        Task UpdateChiTietKiemHangAsync(ChiTietKiemHang chiTietKiemHang);
        Task DeleteChiTietKiemHangAsync(int id);
    }
    public class ChiTietKiemHangRepository : BaseEntityRepository<ChiTietKiemHang>, IChiTietKiemHangRepository
    {
        public ChiTietKiemHangRepository(DataContext db) : base(db) { }

        public async Task CreateChiTietKiemHangAsync(ChiTietKiemHang chiTietKiemHang)
        {
            Create(chiTietKiemHang);
            await SaveAsync();
        }

        public async Task DeleteChiTietKiemHangAsync(int id)
        {
            var resutl = FindByCondition(n => n.Id == id).SingleOrDefault();
            Delete(resutl);
            await SaveAsync();
        }

        public async Task<IEnumerable<ChiTietKiemHang>> GetAllChiTietKiemHangAsync()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<ChiTietKiemHang> GetChiTietKiemHangByIdAsync(int id)
        {
            return await FindByCondition(n => n.Id == id).SingleOrDefaultAsync();
        }

        public async Task UpdateChiTietKiemHangAsync(ChiTietKiemHang chiTietKiemHang)
        {
            var resutl = FindByCondition(n => n.Id == chiTietKiemHang.Id).SingleOrDefault();
            resutl = chiTietKiemHang;
            Update(resutl);
            await SaveAsync();
        }
    }
}
