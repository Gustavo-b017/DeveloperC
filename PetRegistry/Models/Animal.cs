using System;

namespace PetRegistry.Models
{
    public abstract class Animal
    {
        public Guid Id { get; init; }
        public string Name { get; private set; }
        public int Age { get; private set; }

        protected Animal(string name, int age)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age < 0 ? 0 : age;
        }

        public abstract decimal GetFee();

        // Propriedades auxiliares para o DataGrid
        public decimal Fee => GetFee();

        public string Tipo => this switch
        {
            Dog => "Cachorro",
            Cat => "Gato",
            _ => "Animal"
        };

        public override string ToString() => $"{Tipo}: {Name} ({Age} anos)";
    }
}