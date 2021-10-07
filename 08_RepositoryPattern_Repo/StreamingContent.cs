using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_RepositoryPattern_Repo
{
    public enum MaturityRating
    {
        G=1, PG, PG_13, R, NC_17, TV_MA, NR
    }
    public enum GenreType
    {
        Horror=1, Thriller, Documentary, RomCom, Romance, Drama, Action, Comedy
    }
    public class StreamingContent
    {
        //This is going to be our object that we will create a collection of
        //Get method = retrieving value of property
        //Set Method= giving value of the property
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public GenreType TypeOfGenre { get; set; }
        //user can NOT set this property - only retrieve it
        public bool IsFamilyFriendly 
        {
            get
            {
                //return true or false based upon a maturity rating
                //Give my computer a maturity and it then needs to decide if its family friendly - create a conditional
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.PG_13:
                        return true;
                    case MaturityRating.NC_17:
                    case MaturityRating.R:
                    case MaturityRating.NR:
                    case MaturityRating.TV_MA:
                    default:
                        return false;
                }

                //Another Way to use less code
                //if ((int)MaturityRating > 3)
                //{
                //    return false;
                //}
                //else
                //{
                //    return true;
                //}
            }
        }
        //constructors - tell developers what they need to create an instance of that class/object
        //default constructor - that you don't have to give ANY value to create this object
        public StreamingContent()
        {

        }
        //overloaded constructor - meaning you DO have to give some value to create this object
        public StreamingContent(string title, string description, double starRating, MaturityRating maturityRating, GenreType typeOfGenre)
        {
            //overloaded constructor is going to be: PROPERTY NAME = parameter name/value
            Title = title;
            Description = description;
            StarRating = starRating;
            MaturityRating = maturityRating;
            TypeOfGenre = typeOfGenre;
        }
    }
}
