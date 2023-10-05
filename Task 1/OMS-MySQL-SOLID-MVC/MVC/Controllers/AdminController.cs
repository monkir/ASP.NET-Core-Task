using BLL.DTO;
using BLL.DTO.BaseDTO;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var AdminList = AdminService.All();
            return View(AdminList);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var Obj = AdminService.Get(id);
            return View(Obj);
        }
        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddAdminDTO Obj)
        {
            if(ModelState.IsValid)
            {
                var mapper = MapperService.GetMapper<AddAdminDTO, AdminBaseDTO>();
                var convObj = mapper.Map<AdminBaseDTO>(Obj);
                bool result = AdminService.Add(convObj);
                if(result)
                {
                    TempData["Message"] = "New admin is added successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "New admin is not added";
                }
            }
            return View(Obj);
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var Obj = AdminService.Get(id);
            var mapper = MapperService.GetMapper<AdminDTO, EditAdminDTO>();
            var convObj = mapper.Map<EditAdminDTO>(Obj);
            return View(convObj);
        }
        [HttpPost]
        public IActionResult Edit(EditAdminDTO Obj)
        {
            if(ModelState.IsValid)
            {
                var mapper = MapperService.GetMapper<EditAdminDTO, AdminBaseDTO>();
                var convObj = mapper.Map<AdminBaseDTO>(Obj);
                bool result = AdminService.Update(convObj);
                if(result)
                {
                    TempData["Message"] = "Admin is Edited successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "Admin is not edited";
                }
            }
            return View(Obj);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            if(ModelState.IsValid)
            {
                bool result = AdminService.Delete(id);
                if(result)
                {
                    TempData["Message"] = "Admin is Deleted successfully";
                }
                else
                {
                    TempData["Message"] = "Admin is not Deleted";
                }
            }
            return RedirectToAction("Index");
        }
    }
}
