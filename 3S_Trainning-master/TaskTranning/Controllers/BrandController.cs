using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using TaskTranning.Resources;
using TaskTranning.Services;
using TaskTranning.ViewModels;

namespace TaskTranning.Controllers
{
    [Authorize]
    public class BrandController : Controller
    {
        /// <summary>
        /// declare brand services
        /// </summary>
        private readonly IBrandServices _brandServices;
        
        /// <summary>
        /// declare brand resource file
        /// </summary>
        private readonly ResourcesServices<BrandResource> _resourcesServices;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="brandServices">declare brandServices</param>
        /// <param name="resourcesServices"></param>
        public BrandController(IBrandServices brandServices, ResourcesServices<BrandResource> resourcesServices)
        {
            _brandServices = brandServices;
            _resourcesServices = resourcesServices;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Index</returns>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            Log.Information("List Brands");
            var listBrands = await _brandServices.GetListAsync();
            if (listBrands == null)
            {
                return NotFound();
            }
            ViewBag.Count = listBrands.Count;
            return View(listBrands);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Create Brand</returns>
        [HttpGet]
        public IActionResult Create()
        {
            Log.Information("Create Brand");
            return View();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="createBrand"></param>
        /// <returns>Create Brand</returns>
        [HttpPost]
        public async Task<IActionResult> Create(BrandViewModel createBrand)
        {
            if (ModelState.IsValid)
            {
                if (await _brandServices.CreateBrand(createBrand))
                {
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_NewBrandSuccess").ToString();
                    return RedirectToAction("Index");
                }
                ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("err_NewBrand");
                return View(createBrand);
            }
            return View(createBrand);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Edit Brand</returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Log.Information("Update Brand");
            if (id == 0)
            {
                return BadRequest();
            }
            var getId = await _brandServices.GetById(id);
            if (getId == null)
            {
                return NotFound();
            }
            return View(getId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="updateBrand"></param>
        /// <returns>Update Brand</returns>
        [HttpPost]
        public async Task<IActionResult> Edit(BrandViewModel updateBrand)
        {
            if (ModelState.IsValid)
            {
                if (await _brandServices.EditBrand(updateBrand))
                {
                    TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_EditBrandSuccess").ToString();
                    return RedirectToAction("Index");
                }
                ViewData["errorMessage"] = _resourcesServices.GetLocalizedHtmlString("err_EditBrand");
                return View(updateBrand);
            }
            return View(updateBrand);
        }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="id"></param>
       /// <returns>Delete Brand</returns>
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            Log.Information("Delete Brand");
            if (id == 0)
            {
                return BadRequest();
            }
            if (await _brandServices.DeleteBrand(id))
            {
                TempData["succcessMessage"] = _resourcesServices.GetLocalizedHtmlString("msg_DeleteBrandSuccess").ToString();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}