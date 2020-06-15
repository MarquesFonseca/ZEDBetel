using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace ZEDBetel.Controllers
{
    public class MembroController : Controller
    {
        // GET: Membro
        public ActionResult Index()
        {
            VwTabMembroBO BO = new VwTabMembroBO();
            DataTable Dt = BO.FindBy_CodigoEmpresa(ClassesDiversas.UsuarioLogado.CodigoEmpresa).Tables[0];
            List<VwTabMembroVO> tabMembroVO = ClassesDiversas.ConvertDataTable<VwTabMembroVO>(Dt);

            ViewBag.UsuarioLogado = ClassesDiversas.UsuarioLogado;

            ModelState.Clear();
            return View(tabMembroVO);
        }

        // GET: Membro/Details/5
        public ActionResult Details(int id)
        {
            TabMembroBO BO = new TabMembroBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            TabMembroVO tabMembroVO = ClassesDiversas.ConvertDataTable<TabMembroVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(tabMembroVO);
        }

        // GET: Membro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Membro/Create
        [HttpPost]
        public ActionResult Create(TabMembroVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabMembroBO BO = new TabMembroBO();
                    collection.CodigoEmpresa = ClassesDiversas.UsuarioLogado.CodigoEmpresa;
                    collection.CodigoUsuarioCadastro = ClassesDiversas.CodigoUsuarioLogado;
                    if (BO.Insert(collection) == 1)
                    {
                        ViewBag.Mensagem = "Membro cadastrado com sucesso!";
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

        // GET: Membro/Edit/5
        public ActionResult Edit(int id)
        {
            TabMembroBO BO = new TabMembroBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            TabMembroVO tabMembroVO = ClassesDiversas.ConvertDataTable<TabMembroVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(tabMembroVO);
        }

        // POST: Membro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TabMembroVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabMembroBO BO = new TabMembroBO();
                    collection.Codigo = id;
                    if (BO.Update(collection) == 1)
                    {
                        ViewBag.Mensagem = "Membro alterado com sucesso!";
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

        // GET: Membro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Membro/Delete/5
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
