using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TaskTranning.Models;
using TaskTranning.ViewModels;

namespace TaskTranning.Services
{
    public class BrandServices : IBrandServices
    {
        /// <summary>
        /// declare datacontext
        /// </summary>
        private readonly CodeFirstDataContext _context;

        /// <summary>
        /// declare mapper
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        public BrandServices(CodeFirstDataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>GetBrands</returns>
        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brand;
        }
        
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <returns>GetListAsync</returns>
        public async Task<List<BrandViewModel>> GetListAsync()
        {
            var brands = await _context.Brand.ToListAsync();
            var viewModel = _mapper.Map<List<BrandViewModel>>(brands);
            return viewModel;
            
        }
        
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="createBrand"></param>
        /// <returns>CreateBrand</returns>
        public async Task<bool> CreateBrand(BrandViewModel createBrand)
        {
            try
            {
                var brand = new Brand
                {
                    BrandName = createBrand.BrandName        
                };
                _context.Brand.Add(brand);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }           
        }
        
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>GetById</returns>
        public async Task<BrandViewModel> GetById(int id)
        {
            var brand = await _context.Brand.FindAsync(id);
            var viewModel = _mapper.Map<BrandViewModel>(brand);
            return viewModel;
            
        }
        
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="updateBrand"></param>
        /// <returns>EditBrand</returns>
        public async Task<bool> EditBrand(BrandViewModel updateBrand)
        {
            try
            {
                var brand = await _context.Brand.FindAsync(updateBrand.Id);
                brand.BrandName = updateBrand.BrandName;
                _context.Brand.Update(brand);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }           
        }
        
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>DeleteBrand</returns>
        public async Task<bool> DeleteBrand(int id)
        {
            try
            {
                var brand = await _context.Brand.FindAsync(id);
                _context.Remove(brand);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return false;
            }    
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns>IsExistedName</returns>
        public bool IsExistedName(string name, int id)
        {
            return _context.Brand.Any(x => x.BrandName == name && x.Id != id);
        }


    }
}