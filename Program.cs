using System.Runtime.CompilerServices;


Book minbog = new Book("Programerings noter");

List<Page> pages = new List<Page>();
Page Side1 = new Page (MyNotes.Variabler);
Page side2 = new Page (MyNotes.Datatyper);
Page side3 = new Page (MyNotes.Kapitel3);

pages.Add (Side1);
pages.Add (side2);
pages.Add (side3);

Chapter kapitel1 = new Chapter("kapitel 1 Variabler");
kapitel1.Pages = pages;
Chapter kapitel2 = new Chapter("kapitel 2 Datatyper", pages);


kapitel1.Read();




minbog.Start();

//pause
Console.ReadLine();