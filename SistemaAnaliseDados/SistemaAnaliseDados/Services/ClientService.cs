using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaAnaliseDados.Models;

namespace SistemaAnaliseDados.Services
{
    public class ClientService
    {
        public List<ClientModel> ClientInfo()
        {
            List<ClientModel> clientList = new List<ClientModel>();
            var fileClients = GetFilesDirectoryService.ClientFiles();
            foreach (var client in fileClients)
            {
                String[] clientData = client.ToString().Split(new string[] { "ç" }, StringSplitOptions.None);

                clientList.Add(new ClientModel
                {
                    ClientName = clientData[2].ToString(),
                    CNPJ = clientData[1].ToString(),
                    BussinesArea = clientData[3].ToString()

                });
            }

            return clientList;
        }
    }
}