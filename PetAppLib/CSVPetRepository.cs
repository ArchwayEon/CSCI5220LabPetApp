namespace PetAppLib;

public class CSVPetRepository : IPetRepository
{
    private string _filePath;

    public CSVPetRepository(string filePath)
    {
        _filePath = filePath;
    }

    public Pet Create(Pet pet)
    {
        StreamWriter sw = new(_filePath, append: true);
        sw.WriteLine(pet.AsCSV());
        sw.Close();
        return pet;
    }
}
