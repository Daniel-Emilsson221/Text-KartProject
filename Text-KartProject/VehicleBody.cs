//Storlek
class VehicleBody
{
    public int SpeedReduction { get; protected set; }
    public int AccelerationReduction { get; protected set; }
    public string BodyName { get; protected set; }
    public VehicleBody(int speedReduction, int accelerationReduction, string bodyName)
    {
        SpeedReduction = speedReduction;
        AccelerationReduction = accelerationReduction;
        BodyName = bodyName;
    }
}