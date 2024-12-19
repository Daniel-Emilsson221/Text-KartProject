//Kan välja mellan olika
class Engine
{
    public int TopSpeed { get; private set; }
    public int Acceleration { get; private set; }
    public string EngineName { get; private set; }
    public Engine(int topSpeed, int acceleration, string engineName)
    {
        TopSpeed = topSpeed;
        Acceleration = acceleration;
        EngineName = engineName;
    }
}