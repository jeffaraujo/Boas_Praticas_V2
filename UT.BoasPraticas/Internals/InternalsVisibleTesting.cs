using APP.AulaAtributo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UT.BoasPraticas.Internals
{

    [TestClass]
    public class InternalsVisibleTesting
    {
        [TestMethod]
        public void TestMethod_InternalsVisible()
        {
            AlunoDebugProxy alunoDebutProxy = new AlunoDebugProxy(new Aluno()); //AlunoDebugProxy visto graças ao AssemblyInfo do projeto
        }
    }
}
