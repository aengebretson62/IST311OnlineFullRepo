using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoster
{
    class RosterModel
    {   // Instructor
        Instructor myTeacher;
        // List of students
        List<Student> myClass;

        public RosterModel ()
        {
            myTeacher = new Instructor();
            myClass = new List<Student>();
        }

        public void addInstructor (String firstName, String lastName, String contactInfo)
        {
            myTeacher.FirstName = firstName;
            myTeacher.LastName = lastName;
            myTeacher.ContactInfo = contactInfo;
        }

        public void addStudent(String firstName, String lastName, String classRank)
        {
            Student newStudent = new Student(firstName, lastName, classRank);
            myClass.Add(newStudent);
        }

        public Instructor getInstructor()
        {
            return myTeacher;
        }

        public List<Student> getMyClass()
        {
            return myClass;
        }

    }
}
