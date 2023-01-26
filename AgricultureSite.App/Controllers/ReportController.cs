using AgricultureSite.App.Models;
using ClosedXML.Excel;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AgricultureSite.App.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<ContactModel> ContactList()
        {
            List<ContactModel> model = new();
            using (AgricultureContext context = new())
            {
                model = context.Contacts.Select(x => new ContactModel
                {
                    ContactID = x.ID,
                    Name = x.Name,
                    Mail = x.Mail,
                    Date = x.Date,
                    Message = x.Message
                }).ToList();
            }

            return model;
        }

        public IActionResult ContactReport()
        {

            using var workBook = new XLWorkbook();
            var workSheet = workBook.Worksheets.Add("Message List");
            workSheet.Cell(1, 1).Value = "Message ID";
            workSheet.Cell(1, 2).Value = "From";
            workSheet.Cell(1, 3).Value = "Mail Address";
            workSheet.Cell(1, 4).Value = "Message Content";
            workSheet.Cell(1, 5).Value = "Message Date";

            int contactRowCount = 2;
            foreach (var item in ContactList())
            {
                workSheet.Cell(contactRowCount, 1).Value = item.ContactID;
                workSheet.Cell(contactRowCount, 2).Value = item.Name;
                workSheet.Cell(contactRowCount, 1).Value = item.Mail;
                workSheet.Cell(contactRowCount, 1).Value = item.Message;
                workSheet.Cell(contactRowCount, 1).Value = item.Date;

                contactRowCount++;
            }

            using var stream = new MemoryStream();
            workBook.SaveAs(stream);
            var content = stream.ToArray();
            return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "MessageReport.xlsx");
        }

        public List<AnnouncementModel> AnnouncementList()
        {
            List<AnnouncementModel> model = new();
            using (AgricultureContext context = new())
            {
                model = context.Informations.Select(x => new AnnouncementModel
                {
                    ID = x.ID,
                    Title = x.Title,
                    Description = x.Description,
                    Date = x.Date,
                    Status = x.Status
                }).ToList();
            }

            return model;
        }

        public IActionResult AnnouncementModel()
        {

            using var workBook = new XLWorkbook();
            var workSheet = workBook.Worksheets.Add("Announcement List");
            workSheet.Cell(1, 1).Value = "Announcement ID";
            workSheet.Cell(1, 2).Value = "Title";
            workSheet.Cell(1, 3).Value = "Description";
            workSheet.Cell(1, 4).Value = "Date";
            workSheet.Cell(1, 5).Value = "Status";

            int contactRowCount = 2;
            foreach (var item in AnnouncementList())
            {
                workSheet.Cell(contactRowCount, 1).Value = item.ID;
                workSheet.Cell(contactRowCount, 2).Value = item.Title;
                workSheet.Cell(contactRowCount, 1).Value = item.Description;
                workSheet.Cell(contactRowCount, 1).Value = item.Date;
                workSheet.Cell(contactRowCount, 1).Value = item.Status;

                contactRowCount++;
            }

            using var stream = new MemoryStream();
            workBook.SaveAs(stream);
            var content = stream.ToArray();
            return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "AnnouncementReport.xlsx");
        }
    }
}
