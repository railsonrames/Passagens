using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteService : IClienteService
    {
        public bool Add(string nome, string cpf)
        {
            Cliente cliente = new Cliente { Nome = nome, Cpf = cpf };
            ClienteDao dao = new ClienteDao();
            dao.Add(cliente);
            return true;
        }

        public Cliente FindByName(string nome)
        {
            ClienteDao dao = new ClienteDao();
            return dao.FindByName(nome);
        }

        public List<Cliente> getAllClientes()
        {
            return ClienteDao.clientes;
        }
    }
}
