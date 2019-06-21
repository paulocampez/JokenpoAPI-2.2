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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public List<Jogo> Getjogo()
        {
            List<Jogo> lstJogo = new List<Jogo>();
            string url = "http://localhost:59279/api/Home/";
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
                    client.BaseAddress = new Uri("http://localhost:59279/api/Home");

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
