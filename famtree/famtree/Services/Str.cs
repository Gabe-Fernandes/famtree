namespace famtree.Services;

public static class Str
{
  // Fam Tree Controller
  public const string FamTree = "FamTree";

  // ViewData
  public const string Fam = "Fam";
  public const string AspAction = "AspAction";
  public const string BtnText = "FamBtnText";

  // Array storage in strings
  public const string delimiter = "_____&_____";

  public static List<string> ExtractData(string data)
  {
    if (string.IsNullOrEmpty(data)) { return null; }

    List<string> extractedList = new();
    string extractedElement = "";

    for (int i = 0; i < data.Length; i++)
    {
      if (CheckForDivider(data, i))
      {
        i += 10;
        extractedList.Add(extractedElement);
        extractedElement = "";
      }
      else
      {
        extractedElement += data[i];
      }
    }

    return extractedList;
  }

  private static bool CheckForDivider(string data, int index)
  {
    for (int i = 0; i < delimiter.Length; i++)
    {
      if (delimiter[i] != data[index]) { return false; }
      index++;
    }
    return true;
  }

}
