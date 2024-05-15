using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    // public IActionResult Download()
    //     {
    //         //Name the file when downloading
    //         var fileName = "YourFileName" + ".xlsx";
    //         using(ExcelPackage excelPackage = new ExcelPackage())
    //         {
    //             ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet 1");
    //             //Add some text to cell A1
    //             worksheet.Cells["A1"].Value = "PersonID";
    //             worksheet.Cells["B1"].Value = "FullName";
    //             worksheet.Cells["C1"].Value = "Address";
    //              //get all Person
    //             var personList = _context.Person.ToList();
    //             //fill data to worksheet
    //             worksheet.Cells["A2"].LoadFromCollection(personList);
    //             var stream = new MemoryStream(excelPackage.GetAsByteArray());
    //             //download file
    //             return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                
    //         return View();
    //         }
    //     }

    //     public async Task<IActionResult>Upload()
    //     {
    //         return View();
    //     } 
    //     [HttpPost]
    //     [ValidateAntiForgeryToken]
    //     public async Task<IActionResult> Upload(IFormFile file)
    //     {
    //         if (file!=null)
    //         {
    //             string fileExtension = Path.GetExtension(file.FileName);
    //             if (fileExtension != ".xls" && fileExtension != ".xlsx")
    //             {
    //                 ModelState.AddModelError("", "Please choose excel file to upload!");
    //             }
    //             else
    //             {
    //                 //rename file when upload to server
    //                 var fileName = DateTime.Now.ToShortTimeString() + fileExtension;
    //                 var filePath = Path.Combine(Directory.GetCurrentDirectory() + "/Uploads/Excels", fileName);
    //                 var fileLocation = new FileInfo(filePath).ToString();
    //                 using (var stream = new FileStream(filePath, FileMode.Create))
    //                 {
    //                     //save file to server
    //                     await file.CopyToAsync(stream);
    //                     // read data from excel file fill  DataTable
    //                     var dt = _excelProcess.ExcelToDataTable(fileLocation);
    //                     // using for loop to read data fron dt
    //                     for (int i = 0; i < dt.Rows.Count; i++)
    //                     {
    //                         // create new Person object
    //                         var ps = new Person();
    //                         // set value to attributes
    //                         ps.PersonId = dt.Rows[i] [0].ToString();
    //                         ps.FullName = dt.Rows[i] [1].ToString();
    //                         ps.Address = dt.Rows[i] [2].ToString();
    //                         // add object to context
    //                         _context.Add(ps);
    //                     }
    //                     await _context.SaveChangesAsync();
    //                     return RedirectToAction(nameof(Index));
    //                 }
    //             }
    //         }
    //         return View();
    //     }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
