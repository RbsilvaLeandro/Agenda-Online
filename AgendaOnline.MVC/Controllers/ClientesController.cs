using AgendaOnline.Aplicacao.Interface;
using AgendaOnline.Dominio.Entidades;
using AgendaOnline.MVC.ViewModels;
using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AgendaOnline.MVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppServico _ClienteAplicacao;
        private readonly IHistoricoAppServico _HistoricoAplicacao;


        public ClientesController(IClienteAppServico ClienteAplicacao, IHistoricoAppServico HistoricoAplicacao)
        {
            _ClienteAplicacao = ClienteAplicacao;
            _HistoricoAplicacao = HistoricoAplicacao;
        }

        // GET: Clientes
        public ActionResult Index()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Clientes>, IEnumerable<ClienteViewModel>>(_ClienteAplicacao.ListaClientes());
            return View(clienteViewModel);       
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
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
