using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fiap.Exemplo02.MVC.Dominio.Models;
using Fiap.Exemplo02.MVC.Web.Repositories;

namespace Fiap.Exemplo02.Persistencia.Test
{
    [TestClass]
    public class GenericRepositoryTest
    {
        private GenericRepository<Aluno> _repository;
        private PortalContext _context;

        [TestInitialize]
        public void Inicializacao()
        {
            _context = new PortalContext();
            _repository = new GenericRepository<Aluno>(_context);
        }

        [TestMethod]
        public void Cadastrar_OK()
        {
            var aluno = new Aluno()
            {
                Nome = "Teste",
                Bolsa = false,
                DataNascimento = DateTime.Now,
                Desconto = 10,
                Grupo = new Grupo() { Nome = "Grupo Teste" }
            };


            _repository.Cadastrar(aluno);

            int r = _context.SaveChanges(); // retorna qtd de linhas afetadas

            Assert.AreEqual(1, r); 

            //oou Assert.AreNotEqual(aluno.Id,0);


        }
    }
}
