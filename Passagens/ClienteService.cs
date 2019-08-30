using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public void Add(Cliente cliente)
        {
            ClienteDao dao = new ClienteDao();
            dao.Add(cliente);
        }

        public Cliente FindByName(string nome)
        {
            ClienteDao dao = new ClienteDao();
            return dao.FindByName(nome);
        }
    }
}
