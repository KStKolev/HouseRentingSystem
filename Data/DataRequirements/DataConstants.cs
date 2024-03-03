namespace HouseRentingSystem.Data.DataRequirements
{
    public static class DataConstants
    {
        public const int CategoryMaxNameLength = 50;

        public const int MinHouseTitleLength = 10;
        public const int MaxHouseTitleLength = 50;

        public const int MinHouseAddressLength = 30;
        public const int MaxHouseAddressLength = 150;

        public const int MinHouseDescriptionLength = 50;
        public const int MaxHouseDescriptionLength = 500;

        public const string MinHousePricePerMonth = "0";
        public const string MaxHousePricePerMonth = "2000";

        public const int MinAgentPhoneNumberLength = 7;
        public const int MaxAgentPhoneNumberLength = 15;
    }
}
