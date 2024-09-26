namespace VirtualPet {
    public static class LocationFactory {
        public static LocationInterface Create(LocationMethod locationMethod) {
            switch(locationMethod) {
                case LocationMethod.ParkLocation:
                    return new ParkLocation();
                case LocationMethod.CityLocation:
                    return new CityLocation();
                case LocationMethod.VetLocation:
                    return new VetLocation();
                default:
                    Console.Write("That location isn't available.");
                    return null;
            }
        }
    }
}