class Player
{
    public Vehicle PlayerVehicle { get; set; }
    public string PlayerName { get; set; }
    public Player(Vehicle playerVehicle, string playerName)
    {
        PlayerVehicle = playerVehicle;
        PlayerName = playerName;
    }
}