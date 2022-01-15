
int lenght = 16; // lenght of random string
var range = "123AbCcDdEeFfGgHhIiJjKkLlMm789NnOoPpQqRrSsTt0UuVvWwXxYyZz456";
var GenerujRandomowyString = new Random();
string Nitro;

Nitro = "https://discord.gift/"+ new string(
Enumerable.Repeat(range, lenght)
Select(s => s[GenerujRandomowyString.Next(s.Length)])
.ToArray());

//a piece of my code                                                                        
