//Kan välja mellan olika
class Wheel
{
    public int SpeedBoost { get; private set; }
    public int AccelerationBoost { get; private set; }
    public string WheelName { get; private set; }
    public Wheel(int speedBoost, int accelerationBoost, string wheelName)
    {
        SpeedBoost = speedBoost;
        AccelerationBoost = accelerationBoost;
        WheelName = wheelName;
    }
}