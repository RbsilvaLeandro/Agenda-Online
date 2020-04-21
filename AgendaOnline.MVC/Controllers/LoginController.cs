using AgendaOnline.Aplicacao.Interface;
using AgendaOnline.Dominio.Entidades;
using AgendaOnline.MVC.ViewModels;
using AutoMapper;
using System.Web.Mvc;

namespace AgendaOnline.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginAppServico _loginApp;
        public LoginController(ILoginAppServico loginApp)
        {
            _loginApp = loginApp;
        }

        // GET: Login/Create
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LogViewModel loginUsuario)
        {
            if (ModelState.IsValid)
            {
                var Login = Mapper.Map<LogViewModel, Usuarios>(loginUsuario);
                Usuarios usuario = _loginApp.Login(Login);
                if (usuario != null)
                {
                    Session["UsuarioLogado"] = usuario;
                    return RedirectToAction("Index", "MenuPrincipal");
                }
                else
                {
                    ModelState.AddModelError("Erro de Login", "Login ou Senha inválidos");
                    return View("Index");
                }
            }
            else
            {               
                return View("Index");
            }

        }

    }
}
