using System.Runtime.CompilerServices;


Book minbog = new Book("Programerings noter");

List<Page> VariablePages = new List<Page>();
List<Page> DataTypePages = new List<Page>();
List<Page> ConditionalsPages = new List<Page>();

Page Side1 = new Page (MyNotes.Variabler);
Page side2 = new Page (MyNotes.Datatyper);
Page side3 = new Page (MyNotes.Betingelser);



VariablePages.Add (Side1);
DataTypePages.Add (side2);
ConditionalsPages.Add (side3);

Chapter kapitel1 = new Chapter("Variabler", VariablePages);

Chapter kapitel2 = new Chapter("Datatyper", DataTypePages);

Chapter kapitel3 = new Chapter("Betingelser", ConditionalsPages);

minbog.Chapters.Add(kapitel1);
minbog.Chapters.Add(kapitel2);
minbog.Chapters.Add(kapitel3);

minbog.Start();

//pause
Console.ReadLine();