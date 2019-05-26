using BaiVeNhaQuanLyKhoHang.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Repositories
{
    public interface IKhoLuuTruRepository
    {
        Task<IEnumerable<KhoLuuTru>> GetAllKhoLuuTruAsync();
        Task<KhoLuuTru> GetKhoLuuTruByIdAsync(int id);

        Task CreateKhoLuuTruAsync(KhoLuuTru khoLuuTru);
        Task UpdateKhoLuuTruAsync(KhoLuuTru khoLuuTru);
        Task DeleteKhoLuuTruAsync(int id);
        Task<IEnumerable<KhoLuuTru>> GetKhoLuuTruChildAsync(int id);

    }
    public class KhoLuuTruRepository : BaseEntityRepository<KhoLuuTru>, IKhoLuuTruRepository
    {
        public KhoLuuTruRepository(DataContext db) : base(db) { }

        public async Task CreateKhoLuuTruAsync(KhoLuuTru khoLuuTru)
        {
            Create(khoLuuTru);
            await SaveAsync();
        }

        public async Task DeleteKhoLuuTruAsync(int id)
        {
            var result = FindByCondition(k => k.Id == id).SingleOrDefault();
            Delete(result);
            await SaveAsync();

        }

        public async Task<IEnumerable<KhoLuuTru>> GetAllKhoLuuTruAsync()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<KhoLuuTru> GetKhoLuuTruByIdAsync(int id)
        {
            return await FindByCondition(k => k.Id == id).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<KhoLuuTru>> GetKhoLuuTruChildAsync(int id)
        {
            return await FindByCondition(k => k.IdCha == id).ToListAsync();
        }

        public async Task UpdateKhoLuuTruAsync(KhoLuuTru khoLuuTru)
        {
            var result = FindByCondition(k => k.Id == khoLuuTru.Id).SingleOrDefault();
            result = khoLuuTru;
            Update(result);
            await SaveAsync();
        }
    }
}
