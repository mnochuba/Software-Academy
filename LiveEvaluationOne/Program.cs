// See https://aka.ms/new-console-template for more information
using ProblemOne;

Console.WriteLine("Hello, World!");

var frontEnd = new FrontendProgramme();
var backEnd = new BackendProgramme();

var studentOne = new Student(frontEnd, "Student One");
var studentTwo = new Student(backEnd, "Student Two");
var studentThree = new Student(frontEnd, "Student Three");
var facilitatorOne = new Facilitator(frontEnd, "Facilitator One");
var facilitatirTwo = new Facilitator(backEnd, "Facilitator Two");

Human[] studentsAndFacilitators = { studentOne, studentTwo,
                                    facilitatorOne, facilitatirTwo};

foreach (var studentOrFacilitator in studentsAndFacilitators)
{
    studentOrFacilitator.AttendClass(WeekDay.Monday);
    studentOrFacilitator.AttendClass(WeekDay.Wednesday);

    studentOrFacilitator.AskQuestion(studentThree);
    studentOrFacilitator.AskQuestion(facilitatirTwo);

    studentOrFacilitator.AnswerQuestion();
}
