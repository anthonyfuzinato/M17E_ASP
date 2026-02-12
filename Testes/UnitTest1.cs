using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using M17E_intro.Classes;
namespace Testes
{
    [TestClass]
    public class UnitTest1
    {
        // testa se o login devolve verdadeiro
        [TestMethod]
        public void TestaLoginVerdadeiro()
        {
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.email = "admin@gmail.com";
            utilizadores.palavra_passe = "12345";
            Assert.IsTrue(utilizadores.VerificaLogin()); 
        }
        // teste se o login devolve falso
        [TestMethod]
        public void TestaLoginFalso()
        {
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.email = "seila@gmail.com";
            utilizadores.palavra_passe = "12345";
            Assert.IsFalse(utilizadores.VerificaLogin());
        }
        // teste se o login com admin maiscula devolve verdadeiro
        [TestMethod]
        public void TestaLoginVerdadeiroComMaiscula()
        {
            Utilizadores utilizadores = new Utilizadores();
            utilizadores.email = "admin@gmail.com";
            utilizadores.palavra_passe = "12345";
            Assert.IsTrue(utilizadores.VerificaLogin());
        }
    }
}
