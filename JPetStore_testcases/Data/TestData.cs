namespace JPetStore_testcases.Data
{
    class TestData
    {
        public static string Login { get; set; } = "yumi";
        public static string Password { get; set; } = "Pa$$w0rd!";
        public static string IncorrectPassword { get; set; } = "qwerty123!!";
        public static string LoginSuccess { get; set; } = "Sign Out";
        public static string SignOutSuccess { get; set; } = "Sign In";
        public static string RegisterSuccess { get; set; } = "Sign In";
        public static string CheckoutSuccess { get; set; } = "Thank you, your order has been submitted";
        public static string ErrorFailedLogin { get; set; } = "Signon failed.";
        public static string ErrorFailedRegistation { get; set; } = "NOT NULL check constraint";
        public static string ErrorFailedCheckout { get; set; } = "NOT NULL check constraint";
        public static string SearchText { get; set; } = "Parrot";
        public static string RandomUserId { get; set; } = Faker.RandomNumber.Next(1, 99999).ToString();
        public static string RandomPassword { get; set; } = Faker.Internet.UserName();
        public static string FirstName { get; set; } = Faker.Name.First();
        public static string LastName { get; set; } = Faker.Name.Last();
        public static string Email { get; set; } = Faker.Internet.Email();
        public static string Phone { get; set; } = Faker.Phone.Number();
        public static string Address { get; set; } = Faker.Address.StreetAddress();
        public static string City { get; set; } = Faker.Address.City();
        public static string State { get; set; } = Faker.Address.UsState();
        public static string Zip { get; set; } = Faker.Address.ZipCode();
        public static string Country { get; set; } = Faker.Name.First();
        public static string expiryDate { get; set; } = "01/25";
        
        public static string creditCard { get; set; } = Faker.RandomNumber.Next(0000000000000000, 9999999999999999).ToString();
        public static string Quantity { get; set; } = Faker.RandomNumber.Next(2, 100).ToString();
    }
}