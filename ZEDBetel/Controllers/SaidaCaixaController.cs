using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace ZEDBetel.Controllers
{
    public class SaidaCaixaController : Controller
    {
        // GET: SaidaCaixa
        public ActionResult Index()
        {
            VwTabSaidaCaixaBO BO = new VwTabSaidaCaixaBO();
            DataTable Dt = BO.FindBy_CodigoEmpresa(ClassesDiversas.UsuarioLogado.CodigoEmpresa).Tables[0];
            List<VwTabSaidaCaixaVO> tabSaidaCaixaVO = ClassesDiversas.ConvertDataTable<VwTabSaidaCaixaVO>(Dt);

            ViewBag.UsuarioLogado = ClassesDiversas.UsuarioLogado;

            ModelState.Clear();
            return View(tabSaidaCaixaVO);
        }

        // GET: SaidaCaixa/Details/5
        public ActionResult Details(int id)
        {
            TabSaidaCaixaBO BO = new TabSaidaCaixaBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            TabSaidaCaixaVO tabSaidaCaixaVO = ClassesDiversas.ConvertDataTable<TabSaidaCaixaVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(tabSaidaCaixaVO);
        }

        // GET: SaidaCaixa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SaidaCaixa/Create
        [HttpPost]
        public ActionResult Create(TabSaidaCaixaVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabSaidaCaixaBO BO = new TabSaidaCaixaBO();
                    collection.CodigoEmpresa = ClassesDiversas.UsuarioLogado.CodigoEmpresa;
                    collection.CodigoUsuarioCadastro = ClassesDiversas.CodigoUsuarioLogado;
                    if (BO.Insert(collection) == 1)
                    {
                        ViewBag.Mensagem = "Saída no caixa cadastrado com sucesso!";
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

        // GET: SaidaCaixa/Edit/5
        public ActionResult Edit(int id)
        {
            TabSaidaCaixaBO BO = new TabSaidaCaixaBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            TabSaidaCaixaVO tabSaidaCaixaVO = ClassesDiversas.ConvertDataTable<TabSaidaCaixaVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(tabSaidaCaixaVO);
        }

        // POST: SaidaCaixa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TabSaidaCaixaVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabSaidaCaixaBO BO = new TabSaidaCaixaBO();
                    collection.Codigo = id;
                    if (BO.Update(collection) == 1)
                    {
                        ViewBag.Mensagem = "Saída no caixa alterado com sucesso!";
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

        // GET: SaidaCaixa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SaidaCaixa/Delete/5
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
