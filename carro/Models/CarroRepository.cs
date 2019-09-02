using System.Collections.Generic;

namespace carro.Models
{
    public class CarroRepository
    {
        
   public static List<Carro> carro = new List<Carro>();
    
        public CarroRepository()
        {           
        }

        public void Create(Carro carro)
        {
            Carro.Add(carro);
        }
        public List<Carro> GetAll()
        {
            return carro;
        }
        
        public Carro GetById(int id)
        {
            return carro.Find(i=>i.id == id);
        }
        
        public void Delete(int id)
        {
            carro.Remove(GetById(id));

        }
        public void Update(Carro carro)
        {
            var index  = carro.FindIndex(x=>x.id == carro.id);
            //people[index].name = person.name;
            //people[index].address = person.address;

        }




        
    }
}