using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "addCliente/{nome};{cpf}")]
        bool Add(string nome, string cpf);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Xml, UriTemplate = "findCliente/{nome}")]
        Cliente FindByName(string nome);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Xml, UriTemplate = "selectAllClientes/")]
        List<Cliente> getAllClientes();        
    }
}
