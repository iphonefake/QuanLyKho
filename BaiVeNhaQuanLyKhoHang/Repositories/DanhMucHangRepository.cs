using BaiVeNhaQuanLyKhoHang.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiVeNhaQuanLyKhoHang.Repositories
{

    public interface IDanhMucHangRepository
    {
        Task<IEnumerable<DanhMucHang>> GetAllDanhMucHangAsync();
        Task<DanhMucHang> GetDanhMucHangByIdAsync(int id);

        Task CreateDanhMucHangAsync(DanhMucHang danhMucHang);
        Task UpdateDanhMucHangAsync(DanhMucHang danhMucHang);
        Task DeleteDanhMucHangAsync(int id);

        Task<IEnumerable<DanhMucHang>> GetDanhMucHangChildAsync(int id);


    }
    public class DanhMucHangRepository : BaseEntityRepository<DanhMucHang>, IDanhMucHangRepository
    {
        public DanhMucHangRepository(DataContext db) : base(db) { }
        
        public async Task CreateDanhMucHangAsync(DanhMucHang danhMucHang)
        {
            Create(danhMucHang);
            await SaveAsync();
        }

        public async Task DeleteDanhMucHangAsync(int id)
        {
           
            var result = FindByCondition(d => d.Id == id).SingleOrDefault();
            Delete(result);
            await SaveAsync();
        }

        public async Task<IEnumerable<DanhMucHang>> GetAllDanhMucHangAsync()
        {
            return await FindAll().OrderBy(d => d.Ten).ToListAsync();
        }

        public async Task<DanhMucHang> GetDanhMucHangByIdAsync(int id)
        {
            return await FindByCondition(d => d.Id == id).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<DanhMucHang>> GetDanhMucHangChildAsync(int id)
        {
            return await FindByCondition(d => d.IdCha == id).ToListAsync();
        }

        public async Task UpdateDanhMucHangAsync(DanhMucHang danhMucHang)
        {
            var result = FindByCondition(d => d.Id == danhMucHang.Id).SingleOrDefault();
            result = danhMucHang;
            Update(result);
            await SaveAsync();

        }

    }
}
