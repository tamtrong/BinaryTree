using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BinarySearchTree;

namespace BinarySearchTreeDemo.Controllers
{
    public class BSTController : Controller
    {
        // GET: BST
        public ViewResult Index()
        {
            return View();
        }
        public JsonResult GetTree()
        {
            BinaryTreeImp BST = new BinaryTreeImp();
            BST.insertNode(13);
            //BST.insertNode(5);
            //BST.insertNode(66);
            //BST.insertNode(9);
            //BST.insertNode(17);
            //BST.insertNode(20);
            
            return Json(BST, JsonRequestBehavior.AllowGet);
        }
    }
}