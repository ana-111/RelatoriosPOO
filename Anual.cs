using System;

namespace RelatoriosPOO
{
    public class Anual : Relatorio
    {
         public override void MostrarRelatorio(){
           
            base.MostrarRelatorio();
           
            System.Console.WriteLine("Mostrando relatório por ano");

         }

        internal void relatorio()
        {
            throw new NotImplementedException();
        }
    }
}