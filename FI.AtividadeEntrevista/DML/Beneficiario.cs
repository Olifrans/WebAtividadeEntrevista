using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.DML
{
    /// <summary>
    /// Classe de cliente que representa o registo na tabela Cliente do Banco de Dados
    /// </summary>
    public class Beneficiario
	{
        /// <summary>
        /// Id
        /// </summary>
        public long ID { get; set; }
        
        
        /// <summary>
        /// CPF
        /// </summary>
        public string CPF { get; set; }   
        
         
        /// <summary>
        /// NOME
        /// </summary>
        public string NOME { get; set; }


		/// <summary>
		/// IDCLIENTE
		/// </summary>
		public long IDCLIENTE { get; set; }   
        


    }    
}
