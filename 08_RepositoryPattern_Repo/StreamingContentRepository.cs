using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using statements are there to reference other FOLDERS (aka peojects/assemblies/namespaces)
namespace _08_RepositoryPattern_Repo
{
    public class StreamingContentRepository
    {
        //new instance of the list class
        //new list object that contains streamcontent objects
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        //REPO - Holds my "business logic"
        //allowing transfer of info from my collection to my user interface
        //CRUD METHODS
        //Create
        //create method is going to take in a streaming content object and add it to my list
        //refactor - where you change code to either be better or to adjust for breaking changes
        //refactor just means changing your code
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            //Did my startingCount change?
            bool wasAdded = _contentDirectory.Count > startingCount ? true : false;
            return wasAdded;
        }
        //Read
        //this is going to give me every item in my collection
        public List<StreamingContent> GetAllContents()
        {
            return _contentDirectory;
        }
        //find the old streaming content by title
        public StreamingContent GetContentByTitle(string title)
        {
            //searching my collection for a title
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
        //Update
        //Need to update a streaming content object to have new values for its properties
        //find the old streaming content object BY A UNIQUE IDENTIFIER(title) in my list and then update its properties
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            //returns null or streamingcontent object with value
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;
                return true;
            }
            else
            {
                return false;
            }
        }
        //update its properties
        //Delete
        //needs to take in existing streaming content object and delete it from my list
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }
    }
}
