using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    public class ToDoController : ApiController
    {
        //readonly ToDoService toDoService = new ToDoService();
        readonly IToDoService toDoService;


    }
}