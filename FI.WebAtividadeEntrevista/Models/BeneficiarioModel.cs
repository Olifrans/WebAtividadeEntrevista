using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAtividadeEntrevista.Models
{
    /// <summary>
    /// Classe de Modelo de Cliente
    /// </summary>
    public class BeneficiarioModel
	{

		/// <summary>
		/// Id
		/// </summary>
		public long ID { get; set; }


		/// <summary>
		/// CPF
		/// </summary>
		//[RegularExpression(@"[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}", ErrorMessage = "Digite um CPF é válido - Exemplo: 999.999.999-07")]
		[RegularExpression(@"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}", ErrorMessage = "Digite um CPF é válido - Exemplo: 999.999.999-99")]
		public string CPF { get; set; }


		/// <summary>
		/// Nome
		/// </summary>
		[Required]
		public string NOME { get; set; }


		/// <summary>
		/// IDCLIENTE
		/// </summary>
		public long IDCLIENTE { get; set; }

    }    
}