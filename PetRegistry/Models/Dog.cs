namespace PetRegistry.Models
{
    public sealed class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override decimal GetFee()
        {
            // Dog: R$50 + R$10 por ano de idade
            return 50m + (10m * Age);
        }
    }
}