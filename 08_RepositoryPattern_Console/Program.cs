using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RepositoryPattern_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client wants a console app for her users that allow them to store a collection of streaming content.
            //List<string>, List<StreamingContent>
            //StreamingContent.cs
            //Point of Application is for the users to interact with their collection so that they can keep an up to date collection of their fav streaming content at that time.
            //Interact with my users inside my console app - User Interface - ProgramIU.cs
            //Users interact with collection - business logic - Repository Pattern - Repo.cs > CRUD methods (thats what belongs in repo class)

            //Single Resposibility Principle
            //Console app project: be the application/user interface
            //Program.cs
            //ProgramUI.cs

            //Class Library - users interact with collection - business logic
            //Repo.cs
            //StreamingContent.cs
            ProgramUI ui = new ProgramUI();
            ui.RunMenu();
            Console.ReadKey();
        }
    }
}
