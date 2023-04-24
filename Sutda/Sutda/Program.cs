// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/////////index num[0    1    2    3    4    5    6    7    8    9]
///////////////////1    2    3    4    5    6    7    8    9   10
string[] deck = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                  "A", "B", "C", "B", "E", "F", "G", "H", "I", "J",};



//List 사용해서 playrr0 만들고, 카드 2장 넣어보기.
List<string> player0 = new List<string>();
List<string> computer1 = new List<string>();

player0.Add(deck[0]);
player0.Add(deck[10]);

computer1.Add(deck[3]);
computer1.Add(deck[9]);

Console.WriteLine(player0[0]);
Console.WriteLine(player0[1]);

Console.WriteLine(computer1[0]);
Console.WriteLine(computer1[1]);

// A a=1000 aA = 1000
