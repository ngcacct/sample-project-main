using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        //***Alternative Connection to RavenDB***
        /*private datainstance db = new datainstance()
        #region index
        public ActionResult Index()
        {
            using(var store = new DocumentStore
            {Url = "http://localhost:8080/", DefaultDatabase = "SampleProject"})
            {
                store.Initialize();
                using(var session = store.OpenSession()
                {
                    session.Store(new UserModel)
                    {
                        //***Test***
                        Name = "John Doe",
                        Email = "246@xyz.com",
                        Type = "1",
                        AnnualSalary= "200000",
                        Tags = "B"

                        //***Connected to RavenDB***
                        //Name = db.name,
                        //Email = db.email,
                        //Type = db.type,
                        //AnnualSalary= db.annualSalary,
                        //Tags = db.tags

                    }
                });
                session.SaveChanges();
            }
            ViewBag.Title = "Home Page";
            return View();
        }
        #endregion
        public ActionResult store()
        {
            return View();
        }*/
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
    }  

}
