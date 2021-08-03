using System;

namespace SingleResponsibilityPrinciple
{
    ref struct PersonDataCapture
    {
        public Person Capture()
        {
            var person = new Person();
            CaptureFirstName(person);
            CaptureLastName(person);
            return person;
        }

        public void CaptureFirstName(Person person)
        {
            Console.Write("Input the First name: ");
            person.FirstName = CaptureConsoleInput();
        }

        public void CaptureLastName(Person person)
        {
            Console.Write("Input the Last name: ");
            person.LastName = CaptureConsoleInput();
        }

        private string? CaptureConsoleInput()
        {
            return Console.ReadLine();
        }
    }
}
