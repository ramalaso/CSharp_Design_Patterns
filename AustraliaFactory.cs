namespace abstract_factory_pattern
{
   class AustraliaFactory : ContinentFactory
   {
      public override Carnivore CreateCarnivore()
      {
         return new Dingo();
      }

      public override Herbivore CreateHerbivore()
      {
         return new Kangaroo();
      }
   }
}