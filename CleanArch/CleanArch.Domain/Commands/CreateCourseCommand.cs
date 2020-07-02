using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CleanArch.Domain.Commands
{
   public class CreateCourseCommand :CourseCommand
    {
        public CreateCourseCommand(string name,string description,string imageurl)
        {
            Name = name;
            Description = description;
            ImageURL = imageurl;
        }
    }
}
