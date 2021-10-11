using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace PArserExcelConsole
{
    public class InvoiceSettings
    {
        [JsonProperty("codEmpresa")]
        public string CodEmpresa { get; set; }

        [JsonProperty("codEstabelecimento")]
        public string CodEstabelecimento { get; set; }

        [JsonProperty("cnpjContribuinte")]
        public string CnpjContribuinte { get; set; }

        [JsonProperty("periodo")]
        public string Periodo { get; set; }

        [JsonProperty("nDocumento")]
        public string NDocumento { get; set; }

        [JsonProperty("serie")]
        public string Serie { get; set; }

        [JsonProperty("chaveDFe")]
        public string ChaveDFe { get; set; }

        [JsonProperty("tipoDocumento")]
        public string TipoDocumento { get; set; }

        [JsonProperty("codigoReceita")]
        public string CodigoReceita { get; set; }

        [JsonProperty("descricaoReceita")]
        public string DescricaoReceita { get; set; }

        [JsonProperty("tipoTributo")]
        public string TipoTributo { get; set; }

        [JsonProperty("cnpjFavorecido")]
        public string CnpjFavorecido { get; set; }

        [JsonProperty("ufFavorecida")]
        public string UfFavorecida { get; set; }

        [JsonProperty("detalheReceita")]
        public string DetalheReceita { get; set; }

        [JsonProperty("convenio")]
        public string Convenio { get; set; }

        [JsonProperty("produto")]
        public string Produto { get; set; }

        [JsonProperty("valorPrincipal")]
        public string ValorPrincipal { get; set; }

        [JsonProperty("valorJuros")]
        public string ValorJuros { get; set; }

        [JsonProperty("valorMulta")]
        public string ValorMulta { get; set; }

        [JsonProperty("valorAtualizacao")]
        public string ValorAtualizacao { get; set; }

        [JsonProperty("valorOutros")]
        public string ValorOutros { get; set; }

        [JsonProperty("valorTotal")]
        public string ValorTotal { get; set; }

        [JsonProperty("numeroControle")]
        public string NumeroControle { get; set; }

        [JsonProperty("codigoBarra")]
        public string CodigoBarra { get; set; }

        [JsonProperty("dataVencimento")]
        public string DataVencimento { get; set; }

        [JsonProperty("pagador")]
        public string Pagador { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("customInvoiceParameters")]
        public CustomInvoiceParameters CustomInvoiceParameters { get; set; }
    }


    public class CustomInvoiceParameters
    {
        [JsonProperty("businessUnit")]
        public string BusinessUnit { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("payGroup")]
        public string PayGroup { get; set; }

        [JsonProperty("flexContext")]
        public string FlexContext { get; set; }

        [JsonProperty("flexContextDisplayValue")]
        public string FlexContextDisplayValue { get; set; }

        [JsonProperty("laclsBrInputMethodBcode")]
        public string LaclsBrInputMethodBcode { get; set; }

        [JsonProperty("lineType")]
        public string LineType { get; set; }

    }
}
