using System;
namespace API.Models
{

    public class Pessoa 
    {       

            //Construtor
            public Pessoa() => CriadoEm = DateTime.Now;

            public int Id{ get; set; }
 
            public string Nome {get; set;}

            public string Cpf {get; set;}

            public string Descricao { get; set;}

            public DateTime CriadoEm { get; set; }

            public override string ToString()
            {
                return $"Nome: {Nome} | Preço: {Preco.ToString("C2")} | Criado em:{ CriadoEm}";

            } 

    }
}