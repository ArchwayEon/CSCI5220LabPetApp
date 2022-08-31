using PetAppLib;
using PetConsoleApp;

ConsoleMenu mainMenu = new("M A I N   M E N U");
mainMenu.AddOption("1", "Enter Pet data");
mainMenu.AddOption("X", "Exit");

IPetRepository petRepo = new CSVPetRepository("PetData.csv");

string userInput;
bool isValid;
do
{
    mainMenu.Show();
    userInput = ConsoleInput.GetString("Make a choice: ");
    isValid = mainMenu.ValidateChoice(userInput);
    if (isValid)
    {
        ProcessUserInput(userInput);
    }
    else
    {
        Console.WriteLine("Invalid choice!\n");
    }
}while(userInput != "X");

void ProcessUserInput(string userInput)
{
    switch (userInput)
    {
        case "1":
            Pet pet = InputPetData();
            StorePet(pet);
            break;
    }
}

Pet InputPetData()
{
    Pet pet = new();
    Console.WriteLine("\nE N T E R   P E T   D A T A\n");
    InputPetName(pet);
    InputPetType(pet);
    InputPetYearOfBirth(pet);
    InputPetWeight(pet);
    return pet;
}

void StorePet(Pet pet)
{
    try
    {
        petRepo.Create(pet);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

void InputPetName(Pet pet)
{
    string petName;
    do
    {
        petName = ConsoleInput.GetString("Pet's name: ").Trim();
        try
        {
            pet.Name = petName;
            break;
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    } while (true);
}

void InputPetType(Pet pet)
{
    string petType;
    do
    {
        petType = ConsoleInput.GetString("Pet's type: ").Trim();
        try
        {
            pet.Type = petType;
            break;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    } while (true);
}

void InputPetYearOfBirth(Pet pet)
{
    int yearOfBirth;
    do
    {
        yearOfBirth = ConsoleInput.GetInteger("Pet's year of birth: ");
        try
        {
            pet.YearOfBirth = yearOfBirth;
            break;
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    } while (true);
}

void InputPetWeight(Pet pet)
{
    int weight;
    do
    {
        weight = ConsoleInput.GetInteger("Pet's weight: ");
        try
        {
            pet.Weight = weight;
            break;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    } while (true);
}