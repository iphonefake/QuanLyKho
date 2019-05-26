using BaiVeNhaQuanLyKhoHang.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Repositories
{
    public interface IKiemHangRepository
    {
        Task<IEnumerable<KiemHang>> GetAllKiemHangAsync();
        Task<KiemHang> GetKiemHangByIdAsync(int id);

        Task CreateKiemHangAsync(KiemHang kiemHang);
        Task UpdateKiemHangAsync(KiemHang kiemHang);
        Task DeleteKiemHangAsync(int id);
    }
    public class KiemHangRepository : BaseEntityRepository<KiemHang>, IKiemHangRepository
    {
        public KiemHangRepository(DataContext db) : base(db) { }

        public async Task CreateKiemHangAsync(KiemHang kiemHang)
        {
            Create(kiemHang);
            await SaveAsync();
        }

        public async Task DeleteKiemHangAsync(int id)
        {
            var resutl = FindByCondition(n => n.Id == id).SingleOrDefault();
            Delete(resutl);
            await SaveAsync();
        }

        public async Task<IEnumerable<KiemHang>> GetAllKiemHangAsync()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<KiemHang> GetKiemHangByIdAsync(int id)
        {
            return await FindByCondition(n => n.Id == id).SingleOrDefaultAsync();
        }

        public async Task UpdateKiemHangAsync(KiemHang kiemHang)
        {
            var resutl = FindByCondition(n => n.Id == kiemHang.Id).SingleOrDefault();
            resutl = kiemHang;
            Update(resutl);
            await SaveAsync();
        }
    }
}
