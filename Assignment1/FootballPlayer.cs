namespace Assignment1
{
    public class FootballPlayer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public FootballPlayer()
        {
               
        }

        public FootballPlayer(int id, string name, int age, int shirtNumber)
        {
            this.id = id;
            Name = name;
            Age = age;
            ShirtNumber = shirtNumber;
        }

        public void ValidateName()
        {
            if (Name.Length < 2)
                throw new ArgumentOutOfRangeException("Name needs to be at least 2 characters");
        }
        public void ValidateAge()
        {
            if (Age <=1)
                throw new ArgumentOutOfRangeException("Age is to low. Must be over 1");
        }
        public void ValidateShirt()
        {
            if (ShirtNumber < 1 || ShirtNumber > 99)
                throw new ArgumentOutOfRangeException("Shirtnumber must be between 1 and 99");
        }
        public void Validate()
        {
            ValidateName();
            ValidateAge();
            ValidateShirt();
        }
    }
}