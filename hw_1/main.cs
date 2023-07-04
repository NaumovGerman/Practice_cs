// See https://aka.ms/new-console-template for more information

using hw_first;

var person = new Student("No_info", "No_info", "No_info", "No_info", "No_info");

try
{
    var a = new Student("Наумов", "Герман", "Константинович", "М8О-213Б-21", "C#");
    person.Surname = a.Surname;
    person.Name = a.Name;
    person.Patronomyc = a.Patronomyc;
    person.Group = a.Group;
    person.Choice = a.Choice;
}
catch (ArgumentNullException)
{
    Console.WriteLine("Были переданы не все значения, пожалуйста, заполните все поля");
}

Console.WriteLine("---Проверка свойств---");
Console.WriteLine(person.Patronomyc);
Console.WriteLine(person.CourseNumber);
person.Group = "М8О-313Б-21";
Console.WriteLine(person.CourseNumber);

Console.WriteLine("---Проверка переопределния Equals---");
var who = new Student("Наумов", "Боб", "Боооб", "ууу", "44444");
Console.WriteLine($"Сравнение person и who - {person.Equals(who)}");
var noone = new Student("Наумов", "Герман", "Константинович", "М8О-313Б-21", "C#");
Console.WriteLine($"Сравнение person и noone - {person.Equals(noone)}");
Console.WriteLine($"Сравнение Наумов и Наумов - {who.Surname.Equals(noone.Surname)}");
Console.WriteLine($"Сравнение Боооб и Наумов - {who.Patronomyc.Equals(person.Surname)}");
Console.WriteLine($"Сравнение 3 и 3 - {person.CourseNumber.Equals(noone.CourseNumber)}");

Console.WriteLine("---Проверка переопределния ToString---");
Console.WriteLine($"До - {person.CourseNumber.GetType()}, после - {person.CourseNumber.ToString().GetType()}");

Console.WriteLine("---Проверка переопределния GetHashCode---");
Console.WriteLine(person.Patronomyc.GetHashCode());

Console.WriteLine("---Проверка IEquatable---");
// var areEqual = ((IEquatable<object>)person).Equals(who);
Console.WriteLine($"Сравнение person и who - {((IEquatable<object>)person).Equals(who)}");
Console.WriteLine($"Сравнение person и noone - {((IEquatable<object>)person).Equals(noone)}");
