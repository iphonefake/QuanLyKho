using BaiVeNhaQuanLyKhoHang.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Repositories
{
    public interface IHangHoaRepository
    {
        Task<IEnumerable<HangHoa>> GetAllHangHoaAsync();
        Task<HangHoa> GetHangHoaByIdAsync(int id);

        Task CreateHangHoaAsync(HangHoa hangHoa);
        Task UpdateHangHoaAsync(HangHoa hangHoa);
        Task DeleteHangHoaAsync(int id);
    }
    public class HangHoaRepository : BaseEntityRepository<HangHoa>, IHangHoaRepository
    {
        public HangHoaRepository(DataContext db) : base(db) { }
        public async Task CreateHangHoaAsync(HangHoa hangHoa)
        {
            Create(hangHoa);
            await SaveAsync();
        }

        public async Task DeleteHangHoaAsync(int id)
        {
            var resutl = FindByCondition(h => h.Id == id).SingleOrDefault();
            Delete(resutl);
            await SaveAsync();
        }

        public async Task<IEnumerable<HangHoa>> GetAllHangHoaAsync()
        {
            return await FindAll().ToListAsync();
        }

        public async Task<HangHoa> GetHangHoaByIdAsync(int id)
        {
            return await FindByCondition(h => h.Id == id).SingleOrDefaultAsync();
        }

        public async Task UpdateHangHoaAsync(HangHoa hangHoa)
        {
            var resutl = FindByCondition(h => h.Id == hangHoa.Id).SingleOrDefault();
            resutl = hangHoa;
            Update(resutl);
            await SaveAsync();
        }
    }
}
