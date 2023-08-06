using Microsoft.AspNetCore.Mvc;

namespace CRUD.Areas.CRUDadmin.Controllers;

[Area("crudadmin")]
public class DashboardController : Controller
{
    public string Index()
    {
        return "Hello from Admin Dashboard";
    }
}
