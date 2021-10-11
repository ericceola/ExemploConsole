using System;
using System.Collections.Generic;
using System.Text;
using LinqToExcel.Attributes;

namespace PArserExcelConsole
{
    public class SpreadSheet
    {
        [ExcelColumn("Cod Empresa")]
        public string CodEmpresa { get; set; }

        [ExcelColumn("Cod Estabelecimento")]
        public string CodEstabelecimento { get; set; }

        [ExcelColumn("CNPJ Contribuinte")]
        public string CnpjContribuinte { get; set; }

        [ExcelColumn("Período")]
        public string Periodo { get; set; }

        [ExcelColumn("Nº Documento")]
        public string NDocumento { get; set; }

        [ExcelColumn("Série")]
        public string Serie { get; set; }

        [ExcelColumn("Chave DFe")]
        public string ChaveDFe { get; set; }

        [ExcelColumn("Tipo Documento")]
        public string TipoDocumento { get; set; }

        [ExcelColumn("Código Receita")]
        public string CodigoReceita { get; set; }

        [ExcelColumn("Descrição Receita")]
        public string DescricaoReceita { get; set; }

        [ExcelColumn("Tipo de Tributo")]
        public string TipoTributo { get; set; }

        [ExcelColumn("CNPJ Favorecido")]
        public string CnpjFavorecido { get; set; }

        [ExcelColumn("UF Favorecida")]
        public string UfFavorecida { get; set; }

        [ExcelColumn("Detalhe Receita")]
        public string DetalheReceita { get; set; }

        [ExcelColumn("Convênio")]
        public string Convenio { get; set; }

        [ExcelColumn("Produto")]
        public string Produto { get; set; }

        [ExcelColumn("Valor Principal")]
        public string ValorPrincipal { get; set; }

        [ExcelColumn("Valor Juros")]
        public string ValorJuros { get; set; }

        [ExcelColumn("Valor Multa")]
        public string ValorMulta { get; set; }

        [ExcelColumn("Valor Atualização")]
        public string ValorAtualizacao { get; set; }

        [ExcelColumn("Valor Outros")]
        public string ValorOutros { get; set; }

        [ExcelColumn("Valor Total")]
        public string ValorTotal { get; set; }

        [ExcelColumn("Número de Controle")]
        public string NumeroControle { get; set; }

        [ExcelColumn("Código de Barras")]
        public string CodigoBarra { get; set; }

        [ExcelColumn("Data Vencimento")]
        public string DataVencimento { get; set; }

        [ExcelColumn("Pagador")]
        public string Pagador { get; set; }

        [ExcelColumn("Status")]
        public string Status { get; set; }

        public override string ToString()
        {
            return $"{CodEmpresa},{CodEstabelecimento},{CnpjContribuinte},{Periodo}," +
                $"{NDocumento},{Serie},{ChaveDFe},{TipoDocumento},{ CodigoReceita}," +
                $"{DescricaoReceita},{TipoTributo},{CnpjFavorecido},{UfFavorecida},{DetalheReceita}," +
                $"{Convenio},{Produto},{ValorPrincipal},{ValorJuros},{ValorMulta},{ValorAtualizacao}," +
                $"{ValorOutros},{ValorTotal},{NumeroControle},{CodigoBarra},{DataVencimento},{Pagador},{Status}";
             
        }

    }
}
