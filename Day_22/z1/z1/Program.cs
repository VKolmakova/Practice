using z1;

ClassLoner classLoner = ClassLoner.GetInstance();
classLoner.Name = "classLoner1";
Console.WriteLine(classLoner.Name);
ClassLoner classLoner2 = ClassLoner.GetInstance();
classLoner2.Name = "classLoner2";
Console.WriteLine(classLoner2.Name);
Console.WriteLine(classLoner.Name);