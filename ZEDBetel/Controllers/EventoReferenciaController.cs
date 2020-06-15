using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace ZEDBetel.Controllers
{
    public class EventoReferenciaController : Controller
    {
        // GET: EventoReferencia
        public ActionResult Index()
        {
            TabEventoReferenciaBO BO = new TabEventoReferenciaBO();
            DataTable Dt = BO.FindBy_CodigoEmpresa(ClassesDiversas.UsuarioLogado.CodigoEmpresa).Tables[0];
            List<TabEventoReferenciaVO> tabEventoReferenciaVO = ClassesDiversas.ConvertDataTable<TabEventoReferenciaVO>(Dt);

            ViewBag.UsuarioLogado = ClassesDiversas.UsuarioLogado;

            ModelState.Clear();
            return View(tabEventoReferenciaVO);
        }

        // GET: EventoReferencia/Details/5
        public ActionResult Details(int id)
        {
            TabEventoReferenciaBO BO = new TabEventoReferenciaBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            TabEventoReferenciaVO tabEventoReferenciaVO = ClassesDiversas.ConvertDataTable<TabEventoReferenciaVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(tabEventoReferenciaVO);
        }

        // GET: EventoReferencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventoReferencia/Create
        [HttpPost]
        public ActionResult Create(TabEventoReferenciaVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabEventoReferenciaBO BO = new TabEventoReferenciaBO();
                    collection.CodigoEmpresa = ClassesDiversas.UsuarioLogado.CodigoEmpresa;
                    collection.CodigoUsuarioCadastro = ClassesDiversas.CodigoUsuarioLogado;
                    if (BO.Insert(collection) == 1)
                    {
                        ViewBag.Mensagem = "Evento referência cadastrado com sucesso!";
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

        // GET: EventoReferencia/Edit/5
        public ActionResult Edit(int id)
        {
            TabEventoReferenciaBO BO = new TabEventoReferenciaBO();
            DataTable Dt = BO.FindBy_Codigo(id).Tables[0];
            TabEventoReferenciaVO tabEventoReferenciaVO = ClassesDiversas.ConvertDataTable<TabEventoReferenciaVO>(Dt).FirstOrDefault();
            ModelState.Clear();
            return View(tabEventoReferenciaVO);
        }

        // POST: EventoReferencia/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TabEventoReferenciaVO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TabEventoReferenciaBO BO = new TabEventoReferenciaBO();
                    collection.Codigo = id;
                    if (BO.Update(collection) == 1)
                    {
                        ViewBag.Mensagem = "Evento referência alterado com sucesso!";
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

        // GET: EventoReferencia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventoReferencia/Delete/5
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
