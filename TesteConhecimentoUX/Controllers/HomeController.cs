using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using TesteConhecimentoUX.Models;
using static TesteConhecimentoUX.Models.Participante;

namespace TesteConhecimentoUX.Controllers
{
    public class HomeController : Controller
    {

        private Model1 db = new Model1();

        public ActionResult Index()
        {
            var listaPacotes = db.Pacote.ToList();
            var listaAtividades = db.Atividade.ToList();

            ViewBag.Pacotes = listaPacotes;
            ViewBag.Atividades = listaAtividades;

            return View();
        }

        [HttpPost]
        public ActionResult Salvar(Participante participante)
        {
            db.Participante.Add(participante);
            db.SaveChanges();

            Participante participanteSalvoBanco = db.Participante.ToList().LastOrDefault();

            if(participanteSalvoBanco != null)
            {
                AxParticipantePacote axParticipantePacote = new AxParticipantePacote()
                {
                    codParticipante = participanteSalvoBanco.codPar,
                    codPacote = participante.pacote
                };

                db.AxParticipantePacote.Add(axParticipantePacote);
                db.SaveChanges();
            }

            foreach (int atividade in participante.atividades)
            {
                AxParticipanteAtividade axParticipanteAtividade = new AxParticipanteAtividade()
                {
                    CodParticipante = participanteSalvoBanco.codPar,
                    CodAtividade = Convert.ToInt32(atividade)
                };

                db.AxParticipanteAtividade.Add(axParticipanteAtividade);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Confirmacao(FormCollection form)
        {
            string nome = form[0];
            DateTime dataNascimento = Convert.ToDateTime(form[1]);
            string telefone = form[2];
            int pacote = Convert.ToInt32(form[3].ToString().Replace("pacote+", ""));

            string[] atividades = new string[0];
            List<int> listaAtividades = new List<int>();
            List<EnumAtividade> EnumAtividades = new List<EnumAtividade>();

            if (form.AllKeys.Count() > 4)
            {
                atividades = form.GetValues("Atividade");
            }

            foreach (string atividade in atividades)
            {
                listaAtividades.Add(Convert.ToInt32(atividade));
                EnumAtividades.Add((EnumAtividade)Convert.ToInt32(atividade));
            }

            Participante participante = new Participante
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                Telefone = telefone,
                pacote = pacote,
                atividades = listaAtividades,
                nomePacote = (EnumPacote)pacote,
                nomeAtividades = EnumAtividades
            };

            return View("Confirmacao", participante);
        }
    }
}