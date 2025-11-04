

class Program
{
    static void Main()
    {
        Planet testPlanet = new Planet();
        testPlanet._name = "test name1";
        testPlanet._diameter = 123.456;

        Planet testPlanet2 = new Planet();
        testPlanet2._name = "test name 2";
        testPlanet2._diameter = 1234234.23235;

        SolarSystem testSystem = new SolarSystem();
        testSystem._solarSystem = new List<Planet> { testPlanet, testPlanet2 };
        testSystem.Display();
    }
}