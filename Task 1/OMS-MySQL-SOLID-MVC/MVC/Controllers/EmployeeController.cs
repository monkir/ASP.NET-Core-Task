using BLL.DTO;
using BLL.DTO.BaseDTO;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var EmployeeList = EmployeeService.All();
            return View(EmployeeList);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var Obj = EmployeeService.Get(id);
            return View(Obj);
        }
        [HttpGet]
        public IActionResult Add() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddEmployeeDTO Obj)
        {
            if(ModelState.IsValid)
            {
                var mapper = MapperService.GetMapper<AddEmployeeDTO, EmployeeBaseDTO>();
                var convObj = mapper.Map<EmployeeBaseDTO>(Obj);
                bool result = EmployeeService.Add(convObj);
                if(result)
                {
                    TempData["Message"] = "New Employee is added successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "New Employee is not added";
                }
            }
            return View(Obj);
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            var Obj = EmployeeService.Get(id);
            var mapper = MapperService.GetMapper<EmployeeDTO, EditEmployeeDTO>();
            var convObj = mapper.Map<EditEmployeeDTO>(Obj);
            return View(convObj);
        }
        [HttpPost]
        public IActionResult Edit(EditEmployeeDTO Obj)
        {
            if(ModelState.IsValid)
            {
                var mapper = MapperService.GetMapper<EditEmployeeDTO, EmployeeBaseDTO>();
                var convObj = mapper.Map<EmployeeBaseDTO>(Obj);
                bool result = EmployeeService.Update(convObj);
                if(result)
                {
                    TempData["Message"] = "Employee is Edited successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "Employee is not edited";
                }
            }
            return View(Obj);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            if(ModelState.IsValid)
            {
                bool result = EmployeeService.Delete(id);
                if(result)
                {
                    TempData["Message"] = "Employee is Deleted successfully";
                }
                else
                {
                    TempData["Message"] = "Employee is not Deleted";
                }
            }
            return RedirectToAction("Index");
        }
    }
}
