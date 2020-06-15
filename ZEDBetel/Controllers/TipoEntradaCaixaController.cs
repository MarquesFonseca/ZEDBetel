using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZEDBetel.Controllers
{
    public class TipoEntradaCaixaController : Controller
    {
        // GET: TipoEntradaCaixa
        public ActionResult Index()
        {
            TabTipoEntradaCaixaBO BO = new TabTipoEntradaCaixaBO();
            DataTable Dt = BO.FindBy_CodigoEmpresa(ClassesDiversas.UsuarioLogado.CodigoEmpresa).Tables[0];
            List<TabTipoEntradaCaixaVO> tabTipoEntradaCaixaVO = ClassesDiversas.ConvertDataTable<TabTipoEntradaCaixaVO>(Dt);

            ViewBag.UsuarioLogado = ClassesDiversas.UsuarioLogado;

            ModelState.Clear();
            return View(tabTipoEntradaCaixaVO);
        }       
        
        // GET: TipoEntradaCaixa/Details/5
        public ActionResult Details(int id)
        {
            TabTipoEntradaCaixaBO BO = new TabTipoEntradaCaixaBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            TabTipoEntradaCaixaVO tabTipoEntradaCaixaVO = ClassesDiversas.ConvertDataTable<TabTipoEntradaCaixaVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(tabTipoEntradaCaixaVO);
        }

        // GET: TipoEntradaCaixa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEntradaCaixa/Create
        [HttpPost]
        public ActionResult Create(TabTipoEntradaCaixaVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabTipoEntradaCaixaBO BO = new TabTipoEntradaCaixaBO();
                    collection.CodigoEmpresa = ClassesDiversas.UsuarioLogado.CodigoEmpresa;
                    collection.CodigoUsuarioCadastro = ClassesDiversas.CodigoUsuarioLogado;
                    if (BO.Insert(collection) == 1)
                    {
                        ViewBag.Mensagem = "Tipo de entrada no caixa cadastrado com sucesso!";
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

        // GET: TipoEntradaCaixa/Edit/5
        public ActionResult Edit(int id)
        {
            TabTipoEntradaCaixaBO BO = new TabTipoEntradaCaixaBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            TabTipoEntradaCaixaVO tabTipoEntradaCaixaVO = ClassesDiversas.ConvertDataTable<TabTipoEntradaCaixaVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(tabTipoEntradaCaixaVO);
        }

        // POST: TipoEntradaCaixa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TabTipoEntradaCaixaVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabTipoEntradaCaixaBO BO = new TabTipoEntradaCaixaBO();
                    collection.Codigo = id;
                    if (BO.Update(collection) == 1)
                    {
                        ViewBag.Mensagem = "Tipo de entrada alterado com sucesso!";
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

        // GET: TipoEntradaCaixa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoEntradaCaixa/Delete/5
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
