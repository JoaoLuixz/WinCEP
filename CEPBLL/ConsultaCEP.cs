using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace CEPBLL
{
    public class ConsultaCEP
    {
        private readonly HttpClient _httpClient;
        public ConsultaCEP()
        {
            _httpClient = new HttpClient();
        }
        public CEP Consultar(string CepConsulta)
        {
            //CEP cepRetorno = new CEP();
            //cepRetorno.Bairro = "Boqueirão";
            //cepRetorno.Logradouro = "Rua Oswaldo Cruz";
            //cepRetorno.Complemento = "lado par";
            //cepRetorno.ddd = "13";
            //cepRetorno.Localidade = "Santos";
            //cepRetorno.Cep = "11045-907";
            //cepRetorno.Uf = "SP";
            return _httpClient.GetFromJsonAsync<CEP>($"https://viacep.com.br/ws/{CepConsulta}/json/").Result;
            
        }
    }
}
