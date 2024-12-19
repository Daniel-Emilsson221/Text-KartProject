//Rullstol
class Vehicle
{
    public int VehicleSpeed { get; protected set; }
    public int VehicleAcceleration { get; protected set; }
    
    public int WheelRating { get; protected set; }
    public int EngineRating { get; protected set; }
    public int VehicleBodyRating { get; protected set; }
    public Vehicle(int wheelRating, int engineRating, int vehicleBodyRating)
    {
        WheelRating = wheelRating;
        EngineRating = engineRating;
        VehicleBodyRating = vehicleBodyRating;
    }

    public int GetRating()
    {
        return VehicleSpeed + VehicleAcceleration + WheelRating + EngineRating + VehicleBodyRating;
    }

}