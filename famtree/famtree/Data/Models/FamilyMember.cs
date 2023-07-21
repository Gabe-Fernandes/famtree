﻿namespace famtree.Data.Models;

public class FamilyMember
{
  public int Id { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Nickname { get; set; }
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
  public string Education { get; set; }
  public string PartnersName { get; set; }
  public int PartnerId { get; set; }
  //public int Child { get; set; } figure out how to handle an arr of chldren
}
