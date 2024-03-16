using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.ModelsJson
{
    internal class TransacaoJsonTDO
    {

        [JsonProperty("tra_id")]
        public long TraId { get; set; }

        [JsonProperty("tra_descricao")]
        public string TraDescricao { get; set; }

        [JsonProperty("tra_valor")]
        public long TraValor { get; set; }

        [JsonProperty("tra_data")]
        public DateTimeOffset TraData { get; set; }

        [JsonProperty("tra_fk_categoria_id")]
        public long TraFkCategoriaId { get; set; }

        [JsonProperty("tra_fk_usuario_id")]
        public long TraFkUsuarioId { get; set; }

        [JsonProperty("tra_tipo")]
        public string TraTipo { get; set; }
    }
}
