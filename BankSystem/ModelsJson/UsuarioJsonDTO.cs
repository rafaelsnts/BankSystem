using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.ModelsJson
{
    internal class UsuarioJsonDTO
    {       
        [JsonProperty("usu_id")]
        public long UsuId { get; set; }

        [JsonProperty("usu_nome")]
        public string UsuNome { get; set; }

        [JsonProperty("usu_email")]
        public string UsuEmail { get; set; }

        [JsonProperty("usu_senha")]
        
        public string UsuSenha { get; set; }

        [JsonProperty("tb_transacoes")]
        public object[] TbTransacoes { get; set; }
    }
}

