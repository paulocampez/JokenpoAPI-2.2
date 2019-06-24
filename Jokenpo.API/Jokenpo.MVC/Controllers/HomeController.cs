using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Jokenpo.MVC.Models;
using Microsoft.AspNetCore.Http;
using Jokenpo.Model;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;

namespace Jokenpo.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BuscaJogos()
        {
            var jogos = GetJogo();

            return View(jogos);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult Jokenpo(Jogo model)
        {
            ViewBag.EncerrarJogo = false;
            model.Jogador2 = "Computador";
            model.DataInicio = DateTime.Now;
            return View(model);
        }
        [HttpPost]
        public ActionResult Jokenpo(IFormCollection collection, string resposta)
        {
            var tempInt = 0;
            Jogo model = new Jogo();
            model.Jogadas = Int32.Parse(collection["Jogadas"]);
            model.Jogador1 = collection["Jogador1"].ToString();
            model.Jogador2 = collection["Jogador2"].ToString();
            if (Int32.TryParse(collection["RodadaAtual"].ToString(), out tempInt))
                model.RodadaAtual = tempInt;
            else
                model.RodadaAtual = 0;

            if (Int32.TryParse(collection["VitoriaJogador1"].ToString(), out tempInt))
                model.VitoriaJogador1 = tempInt;
            else
                model.VitoriaJogador1 = 0;

            if (Int32.TryParse(collection["VitoriaJogador2"].ToString(), out tempInt))
                model.VitoriaJogador2 = tempInt;
            else
                model.VitoriaJogador2 = 0;

            if (Int32.TryParse(collection["Jogadas"].ToString(), out tempInt))
                model.Jogadas = tempInt;
            else
                model.Jogadas = 0;


            model.JogadaJogador1 = resposta;
            model = Resultado(model);
            model.RodadaAtual = model.RodadaAtual + 1;
            bool podeSalvarJogo = false;

            model.Vencedor = model.VitoriaJogador1 > model.VitoriaJogador2 ? model.Jogador1 : model.VitoriaJogador2 > model.VitoriaJogador1 ? model.Jogador2 : "Empate";
            ViewBag.Vencedor = model.Vencedor;
            if (podeSalvarJogo = model.RodadaAtual == model.Jogadas)
            {
                model.DataInicio = DateTime.Now;
                SalvaJogo(model);
            }
            ViewBag.EncerrarJogo = podeSalvarJogo;

            model.Vencedor = model.VitoriaJogador1 > model.VitoriaJogador2 ? model.Jogador1 : model.VitoriaJogador2 > model.VitoriaJogador1 ? model.Jogador2 : "Empate";
            ViewBag.Vencedor = model.Vencedor;
            return View(model);
        }
        public List<Jogo> GetByUrl(string url)
        {
            List<Jogo> lstJogo = new List<Jogo>();
            HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(url);
            getRequest.Method = "GET";
            try
            {
                var getResponse = (HttpWebResponse)getRequest.GetResponse();
                Stream newStream = getResponse.GetResponseStream();
                StreamReader sr = new StreamReader(newStream);
                var result = sr.ReadToEnd();
                lstJogo = JsonConvert.DeserializeObject<List<Jogo>>(result);
                return lstJogo;
            }
            catch (Exception ex)
            {
                throw new Exception("erro api");
            }

        }

        public List<Jogo> GetJogo()
        {
            List<Jogo> lstJogo = new List<Jogo>();
            string url = "https://localhost:44384/api/Values/";
            HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(url);
            getRequest.Method = "GET";
            try
            {
                var getResponse = (HttpWebResponse)getRequest.GetResponse();
                Stream newStream = getResponse.GetResponseStream();
                StreamReader sr = new StreamReader(newStream);
                var result = sr.ReadToEnd();
                lstJogo = JsonConvert.DeserializeObject<List<Jogo>>(result);
                return lstJogo;
            }
            catch (Exception ex)
            {
                throw new Exception("erro api");
            }

        }
        private bool SalvaJogo(Jogo jogo)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44384/api/Values");

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<Jogo>("Values", jogo);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return true;
                    }
                }
                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
                return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public Jogo Resultado(Jogo model)
        {
            model.JogadaJogador2 = GetJogadaComputador();
            model.Resultado = GetResultado(model.JogadaJogador1, model.JogadaJogador2);
            if (model.Resultado == "Jogador1")
                model.VitoriaJogador1 = model.VitoriaJogador1 + 1;
            else if (model.Resultado == "Jogador2")
                model.VitoriaJogador2 = model.VitoriaJogador2 + 1;

            return model;
        }

        public string GetResultado(string jogadaJogador1, string jogadaJogador2)
        {
            string vencedor;
            if (jogadaJogador1 == "Pedra" && jogadaJogador2 == "Papel")
                vencedor = "Jogador2";
            else if (jogadaJogador1 == "Papel" && jogadaJogador2 == "Pedra")
                vencedor = "Jogador1";
            else if (jogadaJogador1 == "Papel" && jogadaJogador2 == "Tesoura")
                vencedor = "Jogador2";
            else if (jogadaJogador1 == "Tesoura" && jogadaJogador2 == "Papel")
                vencedor = "Jogador1";
            else if (jogadaJogador1 == "Tesoura" && jogadaJogador2 == "Pedra")
                vencedor = "Jogador2";
            else if (jogadaJogador1 == "Pedra" && jogadaJogador2 == "Tesoura")
                vencedor = "Jogador1";
            else
                vencedor = "Empate";

            return vencedor;
        }

        public string GetJogadaComputador()
        {
            string jogadaComputador = "";
            Random rnd = new Random();
            int jogo = rnd.Next(1, 4);
            switch (jogo)
            {
                case 1:
                    jogadaComputador = "Tesoura";
                    break;
                case 2:
                    jogadaComputador = "Pedra";
                    break;
                case 3:
                    jogadaComputador = "Papel";
                    break;
            }
            return jogadaComputador;
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            DateTime dateCad = new DateTime();
            double salario = new double();
            Jogo jogo = new Jogo();
            jogo.JogadaJogador1 = collection["JogadaJogador1"].ToString();
            jogo.JogadaJogador2 = collection["JogadaJogador2"].ToString();
            jogo.Jogador1 = collection["Jogador1"].ToString();
            jogo.Jogador2 = collection["Jogador2"].ToString();
            jogo.Resultado = collection["Resultado"].ToString();
            jogo.Status = collection["Status"].ToString();
            if (DateTime.TryParse(collection["DataInicio"].ToString(), out dateCad))
                jogo.DataInicio = dateCad;
            else
                jogo.DataInicio = DateTime.MinValue;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:52325/api/Home");

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<Jogo>("Home", jogo);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
