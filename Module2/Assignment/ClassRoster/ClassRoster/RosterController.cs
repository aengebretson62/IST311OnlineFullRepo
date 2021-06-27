using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoster
{
    class RosterController
    {
        RosterModel myModel;
        RosterView myView;
        public RosterController ()
        {

            myModel = new RosterModel();
            myView = new RosterView();

                // Get the instructor

                myView.writeString("Please enter the instructor's first name: ");
                String firstName = myView.readString();
                myView.writeString("Please enter the instructor's last name: ");
                String lastName = myView.readString();
                myView.writeString("Please enter the instructor's contact email: ");
                String contactInfo = myView.readString();

                myModel.addInstructor(firstName, lastName, contactInfo);


                // Initialize the flag for looping
                bool loopFlag = true;
                // Declare the user choice
                string userChoice;

                while (loopFlag)
                {
                    // Print the menu
                    myView.writeString("1. Add a student to the roster.");
                    myView.writeString("2. Print the roster.");
                    myView.writeString("3. Quit.");
                    myView.writeString("Please enter a 1 or 2 or 3: ");
                    userChoice = myView.readString();

                    if (userChoice == "1")
                    {
                      myView.writeString("Please enter the student's first name: ");
                      firstName = myView.readString();
                      myView.writeString("Please enter the student's last name: ");
                      lastName = myView.readString();
                      myView.writeString("Please enter the student's class rank: ");
                      String classRank = myView.readString();

                    // now add student to the array
                    myModel.addStudent(firstName, lastName, classRank);
                    }
                    else if (userChoice == "2")
                    {
                        myView.writeString(myModel.getInstructor().ToString());
                        foreach (Student aStudent in myModel.getMyClass())
                            myView.writeString(aStudent.ToString());
                    }
                    else if (userChoice == "3")
                    {
                        myView.writeString("Bye bye!");
                        loopFlag = false;
                    }
                    else myView.writeString("Um, I have nothing...");
                } // while

           
        } // constructor
    }  // class
} // namespace

