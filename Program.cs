// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Espero q funcione esta vez");
var user= new User();
user.Name = "Gonzalo";
user.Surname = "Calderon";


Console.WriteLine(user.Fullname());


var yo = new Yo();
yo.Ciudad= "San Luis";
yo.Pais= "Argentina";

Console.WriteLine(yo.DondeVive());
