using BaiVeNhaQuanLyKhoHang.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Repositories
{
    public interface IChiTietNhapHangRepository
    {
        Task<IEnumerable<ChiTietNhapHang>> GetAllChiTietNhapHangAsync();
        Task<ChiTietNhapHang> GetChiTietNhapHangByIdAsync(int id);

        Task CreateChiTietNhapHangAsync(ChiTietNhapHang chiTietNhapHang);
        Task UpdateChiTietNhapHangAsync(ChiTietNhapHang chiTietNhapHang);
        Task DeleteChiTietNhapHangAsync(int id);
    }
    public class ChiTietNhapHangRepository : BaseEntityRepository<ChiTietNhapHang>, IChiTietNhapHangRepository
    {
        public ChiTietNhapHangRepository(DataContext db) : base(db) { }
        public async Task CreateChiTietNhapHangAsync(ChiTietNhapHang chiTietNhapHang)
        {
            Create(chiTietNhapHang);
            await SaveAsync();
        }

        public async Task DeleteChiTietNhapHangAsync(int id)
        {
            var resutl = FindByCondition(c => c.Id == id).SingleOrDefault();
            Delete(resutl);
            await SaveAsync();
        }

        public async Task<IEnumerable<ChiTietNhapHang>> GetAllChiTietNhapHangAsync()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<ChiTietNhapHang> GetChiTietNhapHangByIdAsync(int id)
        {
            return await FindByCondition(c => c.Id == id).SingleOrDefaultAsync();
        }

        public async Task UpdateChiTietNhapHangAsync(ChiTietNhapHang chiTietNhapHang)
        {
            var result = FindByCondition(c => c.Id == chiTietNhapHang.Id).SingleOrDefault();
            Update(result);
            await SaveAsync();
        }
    }
}
