Console.WriteLine("--Array with ForEeach--");

string[] month =
{
    "JAN",
    "FEV",
    "MARS",
    "AVRIL",
    "MAI",
    "JUIN",
    "JUILLET",
    "AOUT",
    "SEPT",
    "OCT",
    "NOV",
    "DEC",
};

string tab = "\t";

foreach (var moi in month)
{
    Console.WriteLine(tab + moi);
    tab += "\t";
}
