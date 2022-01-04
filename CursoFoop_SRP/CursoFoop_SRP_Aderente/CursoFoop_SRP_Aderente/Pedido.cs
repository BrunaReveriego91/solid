using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoFoop_SRP_Aderente
{
    class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }
        private ILogger infoLogger;
        private EnviarEmail enviaEmail;

        public Pedido()
        {
            enviaEmail = new EnviarEmail();
            infoLogger = new RegistraLog();
        }

        public void IncluirPedido()
        {
            try
            {
                infoLogger.Info("Incluir pedido");
                enviaEmail.EmailFrom = "123@gmail.com";
                enviaEmail.EmailTo = "456@gmail.com";
                enviaEmail.EmailSubject = "test";
                enviaEmail.EmailBody = "teste";

                enviaEmail.Enviar();

            }
            catch (Exception ex)
            {
                infoLogger.Info("Erro ao enviar email: " + ex.Message);
            }
        }
        public void DeletaPedido()
        {
            try
            {
                //Codigo para deletar o pedido gerado
                infoLogger.Info("Pedido deletado em " + DateTime.Now);
            }
            catch (Exception ex)
            {
                infoLogger.Info("Erro ao deletar pedido " + ex.Message);
            }
        }
    }
}
