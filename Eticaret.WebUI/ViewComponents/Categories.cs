using Eticaret.Core.Entities;
using Eticaret.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.WebUI.ViewComponents
{
    public class Categories:ViewComponent
    {
        //private readonly DatabaseContext _context;

        //public Categories(DatabaseContext context)
        //{
        //    _context = context;
        //}
        private readonly IService<Category> _service;

        public Categories(IService<Category> service)
        {
            _service = service;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _service.GetAllAsync(c => c.IsTopMenu && c.IsActive));
        }
    }
}
