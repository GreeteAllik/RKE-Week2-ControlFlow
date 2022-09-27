// rakendus küsib kasutaja sugu ja perekonnanime, loob lähtuvalt sisendist tervituse
Console.WriteLine("Please enter your surname: ");
string userSurname = Console.ReadLine();
Console.WriteLine("Please select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine());
if(userGender=='m')
{
    Console.WriteLine($"Welcome, Mr. {userSurname}!");
}
else if(userGender=='f')
{
    Console.WriteLine($"Welcome, Ms. {userSurname}!");
}
else
{
    Console.WriteLine($"Welcome, {userSurname}!");
}