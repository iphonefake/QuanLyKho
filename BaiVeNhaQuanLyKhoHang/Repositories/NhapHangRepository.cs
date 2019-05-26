using BaiVeNhaQuanLyKhoHang.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Repositories
{
    public interface INhapHangRepository
    {
        Task<IEnumerable<NhapHang>> GetAllNhapHangAsync();
        Task<NhapHang> GetNhapHangByIdAsync(int id);

        Task CreateNhapHangAsync(NhapHang nhapHang);
        Task UpdateNhapHangAsync(NhapHang nhapHang);
        Task DeleteNhapHangAsync(int id);
    }
    public class NhapHangRepository : BaseEntityRepository<NhapHang>, INhapHangRepository
    {
        public NhapHangRepository(DataContext db) : base(db) { }

        public async Task CreateNhapHangAsync(NhapHang nhapHang)
        {
            Create(nhapHang);
            await SaveAsync();
        }

        public async Task DeleteNhapHangAsync(int id)
        {
            var resutl = FindByCondition(n => n.Id == id).SingleOrDefault();
            Delete(resutl);
            await SaveAsync();
        }

        public async Task<IEnumerable<NhapHang>> GetAllNhapHangAsync()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<NhapHang> GetNhapHangByIdAsync(int id)
        {
            return await FindByCondition(n => n.Id == id).SingleOrDefaultAsync();
        }

        public async Task UpdateNhapHangAsync(NhapHang nhapHang)
        {
            var resutl = FindByCondition(n => n.Id == nhapHang.Id).SingleOrDefault();
            resutl = nhapHang;
            Update(resutl);
            await SaveAsync();
        }
    }
}
