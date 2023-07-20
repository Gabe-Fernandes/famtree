namespace famtree.Data.Models;

public class FamilyMember
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DOB { get; set; }
    public DateTime DOP { get; set; }
    public string Occupation { get; set; }
    public string Pfp { get; set; }
    public string BirthLocation { get; set; }
    public string Interests { get; set; }
    public string Anecdotes { get; set; }
    public string Bio { get; set; }
    public string CitiesLived { get; set; }
    public string Photos { get; set; }
    public string LanguagesSpoken { get; set; }
}
