using System.Collections.Generic;

namespace carro.Models
{
    public class CarroRepository
    {
        
   public static List<Carro> carros = new List<Carro>();
    
        public CarroRepository()
        {           
        }

        public void Create(Carro carro)
        {
            carros.Add(carro);
        }
        public List<Carro> GetAll()
        {
            return carros;
        }
        
        public Carro GetById(int id)
        {
            return carros.Find(i=>i.id == id);
        }
        
        public void Delete(int id)
        {
            carros.Remove(GetById(id));

        }
        public void Update(Carro carro)
        {
            var index  = carros.FindIndex(x=>x.id == carro.id);
            carros[index].ano_fabricacao = carro.ano_fabricacao;
            carros[index].portas = carro.portas;
            carros[index].cor = carro.cor;
            carros[index].tipo_banco = carro.tipo_banco;
            carros[index].marca = carro.marca;      

        }




        
    }
}