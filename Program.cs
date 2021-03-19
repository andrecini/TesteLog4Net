using System;

namespace TesteLog4Net
{
    class Program
    {                                                                                                                     //Aqui no System.Reflexion, ele pega o método atual e declara o seu tipo
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Main(string[] args)
        {

            log.Info("Bem vindos á nossa Demo de Log4Net!");
            Console.Write("Digite um numero: ");
            double num; 
            bool sucesso = double.TryParse(Console.ReadLine(), out num);
            if (!sucesso)
                log.Error("Número digitado incorretamente!");

            Console.ReadLine();


        }
    }
}
