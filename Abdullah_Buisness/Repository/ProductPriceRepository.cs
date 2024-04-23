using Abdullah_Buisness.Repository.IRepository;
using Abdullah_DataAccess;
using Abdullah_DataAccess.Data;
using Abdullah_Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdullah_Buisness.Repository
{
    public class ProductPriceRepository : IProductPriceRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ProductPriceRepository(ApplicationDbContext db,IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProductPriceDTO> Create(ProductPriceDTO objDTO)
        {
            var obj = _mapper.Map<ProductPriceDTO, ProductPrice1>(objDTO);
            var addedObj = _db.ProductPrices.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<ProductPrice1, ProductPriceDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj =await _db.ProductPrices.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.ProductPrices.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<ProductPriceDTO> Get(int id)
        {
            var obj =await _db.ProductPrices.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<ProductPrice1,ProductPriceDTO>(obj);
            }
            return new ProductPriceDTO();
        }

        public async Task<IEnumerable<ProductPriceDTO>> GetAll(int? id=null)
        {
            if (id != null && id > 0)
            {
                return _mapper.Map<IEnumerable<ProductPrice1>, IEnumerable<ProductPriceDTO>>
                    (_db.ProductPrices.Where(u=>u.ProductId==id));
            }
            else
            {
                return _mapper.Map<IEnumerable<ProductPrice1>, IEnumerable<ProductPriceDTO>>(_db.ProductPrices);
            }
        }

        public async Task<ProductPriceDTO> Update(ProductPriceDTO objDTO)
        {
            var objFromDb =await _db.ProductPrices.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if(objFromDb != null)
            {
                objFromDb.Price= objDTO.Price;
                objFromDb.Size = objDTO.Size;
                objFromDb.ProductId = objDTO.ProductId;
                _db.ProductPrices.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<ProductPrice1,ProductPriceDTO>(objFromDb);
            }
            return objDTO;
        }
    }
}
