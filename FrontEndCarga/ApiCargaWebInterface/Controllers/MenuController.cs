using ApiCargaWebInterface.Models.Services;
using ApiCargaWebInterface.Models.Services.VirtualPathProvider;
using ApiCargaWebInterface.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCargaWebInterface.Controllers
{
    
    public class MenuController : Controller
    {
        CallApiVirtualPath _documentationApi;
        private static string RUTA_MENU = "/Views/Shared/_menupersonalizado.cshtml";

        public MenuController(CallApiVirtualPath documentationApi)
        {
            _documentationApi = documentationApi;
        }
        public IActionResult Index()
        {
            var page = _documentationApi.GetPage(RUTA_MENU);
            if (page != null)
            {
                ConfigUrlService configUrlService = new ConfigUrlService();
                string routeProxy = $"{configUrlService.GetProxy()}{page.Route}";
                PageViewModel pageViewModel = new PageViewModel()
                {
                    RouteProxyLess = page.Route,
                    Route = routeProxy,
                    LastModified = page.LastModified,
                    PageId = page.PageId
                };
                return View(pageViewModel);
            }
            else 
            {
                return View(null);
            }
           
        }

        [HttpPost]
        [Route("Set")]
        public IActionResult SetMenu(IFormFile menu_personalizado)
        {
            var page = _documentationApi.GetPage(RUTA_MENU);
            Guid menuID = Guid.Empty;
            if (page != null)
            {
                menuID = page.PageId;
            }
            _documentationApi.CreatePage(menuID, RUTA_MENU, menu_personalizado);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("download")]
        public IActionResult DownloadHtml()
        {
            var page = _documentationApi.GetPage(RUTA_MENU);
            if (page != null)
            {
                string name = RUTA_MENU.Split("/").Last();
                var content = new System.IO.MemoryStream(Encoding.UTF8.GetBytes(page.Content));
                string contentType = "APPLICATION/octet-stream";
                var fileName = $"{name}.cshtml";
                return File(content, contentType, fileName);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
