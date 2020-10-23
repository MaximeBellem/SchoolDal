namespace SchoolDal
{
    public class Address
    {
        public Address(string street, int number, string town)
        {
            Street = street;
            Number = number;
            Town = town;
        }
        


        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Town { get; set; }
        

        public override string ToString()
        {
            return 
                $"{nameof(Id)}: {Id}, {nameof(Street)}: {Street}, {nameof(Number)}: {Number}, {nameof(Town)}: {Town}";
        }
    }
}