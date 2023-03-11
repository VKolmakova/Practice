using z3;
Console.Write("Enter name: ");
string name = Console.ReadLine();
MyInfo myInfo = new MyInfo(name);
Console.Write($"{myInfo.Name} change to: ");
myInfo.Name = Console.ReadLine();

   

