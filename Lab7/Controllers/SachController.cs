using Lab7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab7.Controllers
{
    public class SachController : ApiController
    {
        QuanLiSach[] saches = new QuanLiSach[]
        {
            new QuanLiSach{Id = 1, Title="abcxyzzzz",AuthorName="Nguyen Minh Son",Price=1,Content="shfagfugfuygafyugasuydfgauysdg"},
            new QuanLiSach{Id = 2, Title="abcxyzzzz",AuthorName="Nguyen Minh Son",Price=1,Content="shfagfugfuygafyugasuydfgauysdg"},
        };
        public IEnumerable<QuanLiSach> GetAll()
        {
            return saches;
        }
        public IHttpActionResult GetSach(int Id)
        {
            var sach = saches.FirstOrDefault((p) => p.Id == Id);
            if(sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}
