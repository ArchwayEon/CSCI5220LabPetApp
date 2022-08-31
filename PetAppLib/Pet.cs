namespace PetAppLib;

public class Pet
{
    private string _name = String.Empty;
    private string _type = String.Empty;
    private int _yearOfBirth;
    private decimal _weight;

    public string Name 
    { 
        get 
        { 
            return _name; 
        } 
        set 
        { 
            if(value.Trim() == String.Empty)
            {
                throw new ArgumentException("The pet's name cannot be blank!");
            }
            _name = value; 
        } 
    }

    public string AsCSV()
    {
        return $"{Name},{Type},{YearOfBirth},{Weight}";
    }

    public string Type
    {
        get
        {
            return _type;
        }
        set
        {
            if (value.Trim() == String.Empty)
            {
                throw new ArgumentException("The pet's type cannot be blank!");
            }
            _type = value;
        }
    }

    public int YearOfBirth
    {
        get
        {
            return _yearOfBirth;
        }
        set
        {
            if (value < 2000)
            {
                throw new ArgumentException("The pet's year of birth cannot be before " +
                    "2000.");
            }
            if(value > DateTime.Now.Year)
            {
                throw new ArgumentException("The pet's year of birth cannot be after " +
                    "this year.");
            }
            _yearOfBirth = value;
        }
    }

    public decimal Weight
    {
        get
        {
            return _weight;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("The pet’s weight cannot be less than zero.");
            }
            if(value > 1000)
            {
                throw new ArgumentException("The pet’s weight cannot be more than 1000.");
            }
            _weight = value;
        }
    }
}