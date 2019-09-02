using System;

namespace carro.Models
{
    public class Carro
    {

        public Carro(){}



        public Carro(int id, int ano_fabricacao, int portas, string cor, string tipo_banco, string marca)
        {
            this.id = id;
            this.ano_fabricacao = ano_fabricacao;
            this.portas = portas;
            this.cor = cor;
            this.tipo_banco = tipo_banco;
            this.marca = marca;

        }

    

        public int id { get; set; }
        public int ano_fabricacao { get; set; }
        public int portas { get; set; }
        public string cor { get; set; }

        public string tipo_banco { get; set; }

        public string marca { get; set; }
        internal object FindIndex(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        
    }
}