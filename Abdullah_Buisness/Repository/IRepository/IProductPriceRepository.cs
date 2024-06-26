﻿using Abdullah_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Abdullah_Buisness.Repository.IRepository
{
    public interface IProductPriceRepository
    {
        public Task<ProductPriceDTO> Create(ProductPriceDTO objDTO);
        public Task<ProductPriceDTO> Update(ProductPriceDTO objDTO);
        public Task<int> Delete(int id);
        public Task<ProductPriceDTO>Get(int id);
        public Task<IEnumerable<ProductPriceDTO>> GetAll(int? id=null); 
    }
}
