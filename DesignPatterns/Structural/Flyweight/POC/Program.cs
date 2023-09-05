using  Transflower.DesignPatterns.Strucutural.Flyweight.POC.Astronomy;
using  Transflower.DesignPatterns.Strucutural.Flyweight.POC.AngryBirds;
/*IGalaxy star = GalaxyFactory.GetPlanetoryObject(PlanetaryType.Star);
star.SetBrightness(10);
star.SetPosition(20, 80);
Console.WriteLine(star);
IGalaxy planet = GalaxyFactory.GetPlanetoryObject(PlanetaryType.Planet);
planet.SetBrightness(67);
planet.SetPosition(120, 85);
Console.WriteLine(planet);
IGalaxy star2 = GalaxyFactory.GetPlanetoryObject(PlanetaryType.Star);
star2.SetBrightness(65);
star2.SetPosition(67, 23);
Console.WriteLine(star2); 
*/


 
//Creating Circle Objects with Red Color
Console.WriteLine("\n Red color Circles ");
for (int i = 0; i < 3; i++)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Red");
    circle.Draw();
}

//Creating Circle Objects with Green Color
Console.WriteLine("\n Green color Circles ");
for (int i = 0; i < 3; i++)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Green");
    circle.Draw();
}

//Creating Circle Objects with Blue Color
Console.WriteLine("\n Blue color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Green");
    circle.Draw();
}

//Creating Circle Objects with Orange Color
Console.WriteLine("\n Orange color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Orange");
    circle.Draw();
}

//Creating Circle Objects with Black Color
Console.WriteLine("\n Black color Circles");
for (int i = 0; i < 3; ++i)
{
    Circle circle = (Circle)ShapeFactory.GetShape("circle");
    circle.SetColor("Black");
    circle.Draw();
}

Console.ReadKey();
