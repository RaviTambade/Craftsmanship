namespace Transflower.DesignPatterns.Strucutural.Flyweight.POC.Astronomy; 
  
  public class GalaxyFactory
    {
        private static Dictionary<PlanetaryType, IGalaxy> planetoryObjects = new Dictionary<PlanetaryType, IGalaxy>(); 

        public static IGalaxy GetPlanetoryObject(PlanetaryType planetoryObject)
        {
            if (planetoryObjects.ContainsKey(planetoryObject))
                return planetoryObjects[planetoryObject];

            else
            {
                IGalaxy NewObject = null;
                if (planetoryObject == PlanetaryType.Star)
                {
                    NewObject = new Star();
                    planetoryObjects.Add(PlanetaryType.Star, NewObject);
                }
                else
                {
                    NewObject = new Planet();
                    planetoryObjects.Add(PlanetaryType.Planet, NewObject);
                }
                return NewObject;
            }
        }
    }