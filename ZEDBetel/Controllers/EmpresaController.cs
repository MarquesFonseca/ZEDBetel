using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace ZEDBetel.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        public ActionResult Index()
        {
            VwTabEmpresaBO BO = new VwTabEmpresaBO();
            DataTable Dt = BO.FindAll().Tables[0];
            List<VwTabEmpresaVO> tabEmpresaVO = ClassesDiversas.ConvertDataTable<VwTabEmpresaVO>(Dt);

            ViewBag.UsuarioLogado = ClassesDiversas.UsuarioLogado;

            ModelState.Clear();
            return View(tabEmpresaVO);
        }

        // GET: Empresa/Details/5
        public ActionResult Details(int id)
        {
            VwTabEmpresaBO BO = new VwTabEmpresaBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            VwTabEmpresaVO tabEmpresaVO = ClassesDiversas.ConvertDataTable<VwTabEmpresaVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            
            return View(tabEmpresaVO);
        }

        // GET: Empresa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empresa/Create
        [HttpPost]
        public ActionResult Create(TabEmpresaVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabEmpresaBO BO = new TabEmpresaBO();
                    if (BO.Insert(collection) == 1)
                    {
                        ViewBag.Mensagem = "Empresa cadastrado com sucesso!";
                    }
                }
                //return View("Index");
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: Empresa/Edit/5
        public ActionResult Edit(int id)
        {
            TabEmpresaBO BO = new TabEmpresaBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            TabEmpresaVO tabEmpresaVO = ClassesDiversas.ConvertDataTable<TabEmpresaVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(tabEmpresaVO);
        }

        // POST: Empresa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TabEmpresaVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabEmpresaBO BO = new TabEmpresaBO();
                    collection.Codigo = id;
                    //collection.SituacaoLicenca = 
                    if (BO.Update(collection) == 1)
                    {
                        ViewBag.Mensagem = "Empresa alterado com sucesso!";
                    }
                }
                return RedirectToAction("Details", new { id = id });
            }
            catch (Exception er)
            {
                ViewBag.Mensagem = er.Message;
                return RedirectToAction("Details", new { id = id });
            }
        }

        // GET: Empresa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empresa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
