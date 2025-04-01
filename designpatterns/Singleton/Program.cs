// Make constructor public to test this
// var object1 = new Singleton.Singleton();
// var object2 = new Singleton.Singleton();

// Console.WriteLine(object1 == object2 ? "Same object" : "Different object");
// Result : "Different object"

var object3 = Singleton.Singleton.GetInstance();
var object4 = Singleton.Singleton.GetInstance();

Console.WriteLine(object3 == object4 ? "Same object" : "Different object");
// Result : "Same object"
