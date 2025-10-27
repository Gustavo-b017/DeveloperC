namespace PetRegistry.Models
{
    public sealed class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override decimal GetFee()
        {
            // Cat: R$40 + R$5 por ano de idade
            return 40m + (5m * Age);
        }
    }
}