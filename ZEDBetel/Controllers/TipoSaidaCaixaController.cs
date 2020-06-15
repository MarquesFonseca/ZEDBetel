using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace ZEDBetel.Controllers
{
    public class TipoSaidaCaixaController : Controller
    {
        // GET: TipoSaidaCaixa
        public ActionResult Index()
        {
            TabTipoSaidaCaixaBO BO = new TabTipoSaidaCaixaBO();
            DataTable Dt = BO.FindBy_CodigoEmpresa(ClassesDiversas.UsuarioLogado.CodigoEmpresa).Tables[0];
            List<TabTipoSaidaCaixaVO> tabTipoSaidaCaixaVO = ClassesDiversas.ConvertDataTable<TabTipoSaidaCaixaVO>(Dt);

            ViewBag.UsuarioLogado = ClassesDiversas.UsuarioLogado;

            ModelState.Clear();
            return View(tabTipoSaidaCaixaVO);
        }

        // GET: TipoSaidaCaixa/Details/5
        public ActionResult Details(int id)
        {
            TabTipoSaidaCaixaBO BO = new TabTipoSaidaCaixaBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            TabTipoSaidaCaixaVO tabTipoSaidaCaixaVO = ClassesDiversas.ConvertDataTable<TabTipoSaidaCaixaVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(tabTipoSaidaCaixaVO);
        }

        // GET: TipoSaidaCaixa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoSaidaCaixa/Create
        [HttpPost]
        public ActionResult Create(TabTipoSaidaCaixaVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabTipoSaidaCaixaBO BO = new TabTipoSaidaCaixaBO();
                    collection.CodigoEmpresa = ClassesDiversas.UsuarioLogado.CodigoEmpresa;
                    collection.CodigoUsuarioCadastro = ClassesDiversas.CodigoUsuarioLogado;
                    if (BO.Insert(collection) == 1)
                    {
                        ViewBag.Mensagem = "Tipo de saída no caixa cadastrado com sucesso!";
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

        // GET: TipoSaidaCaixa/Edit/5
        public ActionResult Edit(int id)
        {
            TabTipoSaidaCaixaBO BO = new TabTipoSaidaCaixaBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            TabTipoSaidaCaixaVO tabTipoSaidaCaixaVO = ClassesDiversas.ConvertDataTable<TabTipoSaidaCaixaVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(tabTipoSaidaCaixaVO);
        }

        // POST: TipoSaidaCaixa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TabTipoSaidaCaixaVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabTipoSaidaCaixaBO BO = new TabTipoSaidaCaixaBO();
                    collection.Codigo = id;
                    if (BO.Update(collection) == 1)
                    {
                        ViewBag.Mensagem = "Tipo de saída alterado com sucesso!";
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

        // GET: TipoSaidaCaixa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoSaidaCaixa/Delete/5
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
