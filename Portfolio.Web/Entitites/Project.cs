﻿namespace Portfolio.Web.Entitites
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string GithubUrl { get; set; }


        //Navigation property

        //public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
