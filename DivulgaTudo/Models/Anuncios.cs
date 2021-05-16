using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DivulgaTudo.Models
{
    public class Anuncios
    {
        [Key]
        public int anuncioId { get; set; }

        [DisplayName("Anúncio")]
        public string nomeAnuncio { get; set; }

        [DisplayName("Cliente")]
        public string nomeCliente { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data Inicial")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public string dataInicial { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data Final")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public string dataFinal { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        //[RegularExpression(@"^\d+(\.|\,)\d{2}$", ErrorMessage = "{0} valor incorreto.")]
        [DisplayName("Investimento")]
        public decimal investimento { get; set; }
    }
}