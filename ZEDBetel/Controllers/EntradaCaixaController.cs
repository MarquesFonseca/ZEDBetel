using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace ZEDBetel.Controllers
{
    public class EntradaCaixaController : Controller
    {
        DataTable Dt = new DataTable();

        // GET: EntradaCaixa
        public ActionResult Index()
        {
            VwTabEntradaCaixaBO BO = new VwTabEntradaCaixaBO();
            DataTable Dt = BO.FindBy_CodigoEmpresa(ClassesDiversas.UsuarioLogado.CodigoEmpresa).Tables[0];
            List<VwTabEntradaCaixaVO> tabEntradaCaixaVO = ClassesDiversas.ConvertDataTable<VwTabEntradaCaixaVO>(Dt);

            ViewBag.UsuarioLogado = ClassesDiversas.UsuarioLogado;

            ModelState.Clear();
            return View(tabEntradaCaixaVO);
        }

        // GET: EntradaCaixa/Details/5
        public ActionResult Details(int id)
        {
            TabEntradaCaixaBO BO = new TabEntradaCaixaBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            TabEntradaCaixaVO tabEntradaCaixaVO = ClassesDiversas.ConvertDataTable<TabEntradaCaixaVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(tabEntradaCaixaVO);
        }

        // GET: EntradaCaixa/Create
        public ActionResult Create()
        {
            TabEventoReferenciaBO BO1 = new TabEventoReferenciaBO();
            Dt = BO1.FindBy_CodigoEmpresa(ClassesDiversas.UsuarioLogado.CodigoEmpresa).Tables[0];
            List<TabEventoReferenciaVO> tabEventoReferenciaVO = ClassesDiversas.ConvertDataTable<TabEventoReferenciaVO>(Dt);
            SelectList lista = new SelectList(tabEventoReferenciaVO, "Codigo", "Descricao");
            ViewBag.listaEventoReferencia = lista;

            TabTipoEntradaCaixaBO BO2 = new TabTipoEntradaCaixaBO();
            Dt = BO2.FindBy_CodigoEmpresa(ClassesDiversas.UsuarioLogado.CodigoEmpresa).Tables[0];
            List<TabTipoEntradaCaixaVO> tabTipoEntradaCaixaVO = ClassesDiversas.ConvertDataTable<TabTipoEntradaCaixaVO>(Dt);
            ViewBag.listaTipoEntradaCaixa = new SelectList(tabTipoEntradaCaixaVO, "Codigo", "Descricao");

            TabMembroBO BO3 = new TabMembroBO();
            Dt = BO3.FindBy_CodigoEmpresa(ClassesDiversas.UsuarioLogado.CodigoEmpresa).Tables[0];
            List<TabMembroVO> tabMembroVO = ClassesDiversas.ConvertDataTable<TabMembroVO>(Dt);
            ViewBag.listaMembro = new SelectList(tabMembroVO, "Codigo", "Nome");

            return View();
        }

        // POST: EntradaCaixa/Create
        [HttpPost]
        public ActionResult Create(TabEntradaCaixaVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabEntradaCaixaBO BO = new TabEntradaCaixaBO();
                    collection.CodigoEmpresa = ClassesDiversas.UsuarioLogado.CodigoEmpresa;
                    collection.CodigoUsuarioCadastro = ClassesDiversas.CodigoUsuarioLogado;
                    if (BO.Insert(collection) == 1)
                    {
                        ViewBag.Mensagem = "Entrada no caixa cadastrado com sucesso!";
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

        // GET: EntradaCaixa/Edit/5
        public ActionResult Edit(int id)
        {
            TabEntradaCaixaBO BO = new TabEntradaCaixaBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            TabEntradaCaixaVO tabEntradaCaixaVO = ClassesDiversas.ConvertDataTable<TabEntradaCaixaVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(tabEntradaCaixaVO);
        }

        // POST: EntradaCaixa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TabEntradaCaixaVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabEntradaCaixaBO BO = new TabEntradaCaixaBO();
                    collection.Codigo = id;
                    if (BO.Update(collection) == 1)
                    {
                        ViewBag.Mensagem = "Entrada no caixa alterado com sucesso!";
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

        // GET: EntradaCaixa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EntradaCaixa/Delete/5
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
