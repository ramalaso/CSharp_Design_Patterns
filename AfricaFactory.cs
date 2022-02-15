namespace abstract_factory_pattern
{
   class AfricaFactory : ContinentFactory
   {
      public override Carnivore CreateCarnivore()
      {
         return new Lion();
      }

      public override Herbivore CreateHerbivore()
      {
         return new Zebra();
      }
   }
}