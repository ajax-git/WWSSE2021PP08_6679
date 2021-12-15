/*
    Napisz program, który dla wprowadzonej reprezentacji binarnej (jako ciąg znaków) sprawdza, 
    czy wprowadzony ciąg znaków jest poprawną reprezentacją binarną a następnie oblicza jej reprezentację dziesiętną.
*/

static bool IsBin(string s)
{
    foreach (var c in s)
        if (c != '0' && c != '1')
            return false;
    return true;
}

Console.Write("Wprowadź reprezentację binarną (jako ciąg znaków): ");

string binary = Convert.ToString(Console.ReadLine());

while(!IsBin(binary))
{
    Console.WriteLine("Wprowadzony ciąg znaków nie jest poprawną reprezentacją binarną.");
    Console.Write("Wprowadź reprezentację binarną (jako ciąg znaków): ");

    binary = Convert.ToString(Console.ReadLine());
}

int binaryNumber = Convert.ToInt32(binary);
int decimalValue = 0;
int base1 = 1;

while (binaryNumber > 0)
{
    int reminder = binaryNumber % 10;
    binaryNumber = binaryNumber / 10;
    decimalValue += reminder * base1;
    base1 = base1 * 2;
}
Console.Write("Reprezentacja dziesiętna: {0}", decimalValue);


