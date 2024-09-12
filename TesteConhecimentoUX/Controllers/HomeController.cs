using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using TesteConhecimentoUX.Models;

namespace TesteConhecimentoUX.Controllers
{
    public class HomeController : Controller
    {

        private ModeloBanco db = new ModeloBanco();

        public ActionResult Index()
        {
            var listaPacotes = db.Pacote.ToList();
            var listaAtividades = db.Atividade.ToList();

            ViewBag.Pacotes = listaPacotes;
            ViewBag.Atividades = listaAtividades;

            return View();
        }

        [HttpPost]
        public ActionResult Salvar(FormCollection form)
        {
            string nome = form[0];
            DateTime dataNascimento = Convert.ToDateTime(form[1]);
            string telefone = form[2];
            int pacote = Convert.ToInt32(form[3].ToString().Replace("pacote+",""));

            
            Participante participante = new Participante 
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                Telefone = telefone,
            };


            db.Participante.Add(participante);
            db.SaveChanges(); 

            return RedirectToAction("Index");
        }

    }
}