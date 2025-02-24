const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";

// Your work here
// First Part:

string span = "<span>";
string spanFinal = "</span>";

int spanPosition = input.IndexOf(span);
int spanPositionFinal = input.IndexOf(spanFinal);

spanPosition += span.Length;

int length = spanPositionFinal - spanPosition;

quantity = input.Substring(spanPosition, length);

// Second Part: 

string updated = input;

updated = updated.Replace("trade", "reg");

string div = "<div>";
string divFinal = "</div>";

updated = updated.Remove(updated.IndexOf(div), div.Length);
updated = updated.Remove(updated.IndexOf(divFinal), divFinal.Length);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine(updated);
