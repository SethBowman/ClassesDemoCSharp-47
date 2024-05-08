using ClassesDemoCSharp_47;

//Instance of a class (object)
var cSharp47 = new Classroom();

//Instance of a class (object)
var seth = new Person();

//Dot notation
seth.Name = "Seth";
seth.Age = 30;
seth.HairColor = "dark brown";
seth.wallet = 20;
seth.clothes = "track suit";

cSharp47.CodingClass.Add(seth);

//Object initializer syntax
var mack = new Person() 
{ 
    Name = "Mack",
    Age = 24,
    HairColor = "brown"
};

cSharp47.CodingClass.Add(mack);

//using a custom constuctor
var cruz = new Person("Cruz", 32, "black");

cSharp47.CodingClass.Add(cruz);

cSharp47.GreetEveryone();

