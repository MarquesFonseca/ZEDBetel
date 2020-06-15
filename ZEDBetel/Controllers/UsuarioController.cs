using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace ZEDBetel.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            VwTabUsuarioBO BO = new VwTabUsuarioBO();
            DataTable Dt = BO.FindBy_CodigoEmpresa(ClassesDiversas.UsuarioLogado.CodigoEmpresa).Tables[0];
            List<VwTabUsuarioVO> vwTabUsuarioVO = ClassesDiversas.ConvertDataTable<VwTabUsuarioVO>(Dt);

            ViewBag.UsuarioLogado = ClassesDiversas.UsuarioLogado;

            ModelState.Clear();
            return View(vwTabUsuarioVO);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            VwTabUsuarioBO BO = new VwTabUsuarioBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            VwTabUsuarioVO vwTabUsuarioVO = ClassesDiversas.ConvertDataTable<VwTabUsuarioVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(vwTabUsuarioVO);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(TabUsuarioVO _vo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabUsuarioBO BO = new TabUsuarioBO();
                    _vo.CodigoUsuarioCadastro = ClassesDiversas.CodigoUsuarioLogado;
                    _vo.CodigoEmpresa = ClassesDiversas.UsuarioLogado.CodigoEmpresa;
                    if (BO.Insert(_vo) == 1)
                    {
                        ViewBag.Mensagem = "Usuário cadastrado com sucesso!";
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

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            TabUsuarioBO BO = new TabUsuarioBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            TabUsuarioVO tabUsuarioVO = ClassesDiversas.ConvertDataTable<TabUsuarioVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(tabUsuarioVO);
        }


        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TabUsuarioVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabUsuarioBO BO = new TabUsuarioBO();
                    collection.Codigo = id;                    
                    if (BO.Update(collection) == 1)
                    {
                        ViewBag.Mensagem = "Usuário alterado com sucesso!";
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

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
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
