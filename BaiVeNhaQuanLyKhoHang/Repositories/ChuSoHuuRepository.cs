using BaiVeNhaQuanLyKhoHang.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Repositories
{
    public interface IChuSoHuuRepository
    {
        Task<IEnumerable<ChuSoHuu>> GetAllChuSoHuuAsync();
        Task<ChuSoHuu> GetChuSoHuuByIdAsync(int id);

        Task CreateChuSoHuuAsync(ChuSoHuu chuSoHuu);
        Task UpdateChuSoHuuAsync(ChuSoHuu chuSoHuu);
        Task DeleteChuSoHuuAsync(int id);
    }
    public class ChuSoHuuRepository : BaseEntityRepository<ChuSoHuu>, IChuSoHuuRepository
    {
        public ChuSoHuuRepository(DataContext db) : base(db) { }
        public async Task CreateChuSoHuuAsync(ChuSoHuu chuSoHuu)
        {
            Create(chuSoHuu);
            await SaveAsync();
        }

        public async Task DeleteChuSoHuuAsync(int id)
        {
            var result = FindByCondition(c => c.Id == id).SingleOrDefault();
            Delete(result);
            await SaveAsync();
        }

        public async Task<IEnumerable<ChuSoHuu>> GetAllChuSoHuuAsync()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<ChuSoHuu> GetChuSoHuuByIdAsync(int id)
        {
            return await FindByCondition(c => c.Id == id).SingleOrDefaultAsync();
        }

        public async Task UpdateChuSoHuuAsync(ChuSoHuu chuSoHuu)
        {
            var result = FindByCondition(c => c.Id == chuSoHuu.Id).SingleOrDefault();
            result = chuSoHuu;
            Update(result);
            await SaveAsync();
        }
    }
}
