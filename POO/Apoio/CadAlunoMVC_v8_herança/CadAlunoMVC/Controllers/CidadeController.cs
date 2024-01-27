using CadAlunoMVC.DAO;
using CadAlunoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadAlunoMVC.Controllers
{
    public class CidadeController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var dao = new CidadeDAO();
                var lista = dao.Listagem();
                return View(lista);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Create()
        {
            try
            {
                ViewBag.Operacao = "I";
                var dao = new CidadeDAO();
                var c = new CidadeViewModel();
                c.Id = dao.ProximoId();
                return View("Form", c);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Salvar(CidadeViewModel cidade,
                                    string Operacao)
        {
            try
            {
                ValidaDados(cidade, Operacao);
                if (ModelState.IsValid)
                {
                    var dao = new CidadeDAO();
                    if (Operacao == "I")
                        dao.Insert(cidade);
                    else
                        dao.Update(cidade);
                    return RedirectToAction("index");
                }
                else
                {
                    ViewBag.Operacao = Operacao;
                    return View("Form", cidade);
                }
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }


        public IActionResult Edit(int id)
        {
            try
            {
                ViewBag.Operacao = "A";
                var dao = new CidadeDAO();
                var a = dao.Consulta(id);

                if (a == null)
                    return RedirectToAction("index");
                else
                    return View("Form", a);
            }
            catch (Exception erro)
            {
                return View("error",
                    new ErrorViewModel(erro.ToString()));
            }
        }


        private void ValidaDados(CidadeViewModel c, string operacao)
        {
            ModelState.Clear(); // limpa os erros criados automaticamente pelo Asp.net (que podem estar com msg em inglês)
            var dao = new CidadeDAO();
            if (operacao == "I" && dao.Consulta(c.Id) != null)
                ModelState.AddModelError("Id", "Código já está em uso.");
            if (operacao == "A" && dao.Consulta(c.Id) == null)
                ModelState.AddModelError("Id", "Registro não existe.");
            if (c.Id <= 0)
                ModelState.AddModelError("Id", "Id inválido!");
            if (string.IsNullOrEmpty(c.Nome))
                ModelState.AddModelError("Nome", "Preencha o nome.");
        }


        public IActionResult Delete(int id)
        {
            try
            {
                var dao = new CidadeDAO();
                dao.Delete(id);
                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

    }
}
