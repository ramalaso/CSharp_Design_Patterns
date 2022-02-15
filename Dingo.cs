namespace abstract_factory_pattern
{
   class Dingo : Carnivore
   {
      public override void Eat(Herbivore herbivore)
      {
         System.Console.WriteLine($"{this.GetType().Name} eats {herbivore}");
      }
   }
}