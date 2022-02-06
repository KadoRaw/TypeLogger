using TypeLogger;

Console.WriteLine("Hello, World! :) ");
var typeLogger = new TypeLogger.TypeLogger();
Type type = typeof(Hoodie);


Console.WriteLine(typeLogger.DisplayInfo<Hoodie>());