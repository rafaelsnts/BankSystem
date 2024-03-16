using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.ModelsJson
{
    internal class CategoriaJsonTDO
    {
        [JsonProperty("cat_id")]
        public long CatId { get; set; }

        [JsonProperty("cat_descricao")]
        public string CatDescricao { get; set; }

        [JsonProperty("tb_transacoes")]
        public object[] TbTransacoes { get; set; }
    }
}

