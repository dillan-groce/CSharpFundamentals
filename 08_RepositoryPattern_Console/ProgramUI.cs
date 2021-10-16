using _08_RepositoryPattern_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RepositoryPattern_Console
{
    public class ProgramUI
    {
        private readonly StreamingContentRepository _streamingRepo = new StreamingContentRepository();
        //User Interface
        //Host User Interactions<-- Only responsibility
        //Point of Application is for the users to interact with their collection so that they can keep an up to date collection of their fav streaming content at that time.
        //CRUD
        //creating new streamimng content - add that to my collection
        //read the collection
        //update their collection
        //delete contents from their collection
        public void Run()
        {
            SeedContentList();
            RunMenu();
        }
        public void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Hello! Welcome to your application! \n" +
                    "Here is where you can create a and interact with a list of your favorite TV shows and movies. \n" +
                    "Please select an option below by entering the corresponding number:\n" +
                    "1. Show all streaming content \n" +
                    "2. Find streaming content by title \n" +
                    "3. Add new streaming content \n" +
                    "4. Remove streaming content \n" +
                    "5. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //show all
                        break;
                    case "2":
                        //find by title
                        break;
                    case "3":
                        //add new
                        CreateNewContent();
                        break;
                    case "4":
                        //remove some content
                        break;
                    case "5":
                        //exit durrrr
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid selection between 1 and 5./n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }

            }
        }
        private void CreateNewContent()
        {
            StreamingContent content = new StreamingContent();
            //The user is going to have to create this streaming content object
            //Title
            Console.WriteLine("Time to add your streaming content to your collection.\n" +
                "Let's get started:\n" +
                "Please enter the title of the content:");
            content.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Please enter the description:");
            content.Description = Console.ReadLine();

            //StarRating
            Console.WriteLine("Please enter the star rating (1-5):");
            string starRatingInput = Console.ReadLine();
            //try catch
            //allow your application to capture an error and instead of breaking down, continue on
            try
            {
                content.StarRating = double.Parse(starRatingInput);
            }
            catch
            {
                Console.WriteLine("Sorry. You need to enter in a valid rating.");
            }
            content.StarRating = double.Parse(Console.ReadLine());
            //MaturityRating
            Console.WriteLine("Please select a maturity rating (1-7):\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. NC_17\n" +
                "6. TV_MA\n" +
                "7. NR");
            string maturityRating = Console.ReadLine();
            try
            {
                switch (maturityRating.ToUpper())
                {
                    case "1":
                    case "G":
                        content.MaturityRating = MaturityRating.G;
                        break;
                    case "2":
                    case "PG":
                        content.MaturityRating = MaturityRating.PG;
                        break;
                                                
                    case "3":
                    case "PG_13":
                        content.MaturityRating = MaturityRating.PG_13;
                        break;
                    case "4":
                    case "R":
                        content.MaturityRating = MaturityRating.R;
                        break;
                    case "5":
                    case "NC_17":
                        content.MaturityRating = MaturityRating.NC_17;
                        break;
                    case "6":
                    case "TV_MA":
                        content.MaturityRating = MaturityRating.TV_MA;
                        break;
                    case "7":
                    case "NR":
                        content.MaturityRating = MaturityRating.NR;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option.");
                        break;
                }
            }
            catch
            {

            }

            //TypeOfGenre
            Console.WriteLine("Please select a Genre:\n" +
                "1. Horror\n" +
                "2. Thriller\n" +
                "3. Documentary\n" +
                "4. RomCom\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy");
            string genreInput = Console.ReadLine();
            try
            {
                int genreID = int.Parse(genreInput);
                content.TypeOfGenre = (GenreType)genreID;
            }
            catch
            {
                Console.WriteLine("Please enter a valid number between 1-8.");
            }

            //AddContentToDirectory take in streamimng content object and add it to my collection
            _streamingRepo.AddContentToDirectory(content);
        }
        private void ShowAllContent()
        {
            List<StreamingContent> listOfContent = _streamingRepo.GetAllContents();
            foreach(StreamingContent contentVariable in listOfContent)
            {
                Console.WriteLine((contentVariable.Title));
            }
        }
        private void SeedContentList()
        {
            StreamingContent movieOne = new StreamingContent("Jaws", "Fish eats man", 3.5, MaturityRating.R, GenreType.Horror);
            _streamingRepo.AddContentToDirectory(movieOne);
            StreamingContent movieTwo = new StreamingContent("Halloween", "Neglected child gets revenge.", 4.7, MaturityRating.R, GenreType.Horror);
            _streamingRepo.AddContentToDirectory(movieTwo);
        }
    }
}
