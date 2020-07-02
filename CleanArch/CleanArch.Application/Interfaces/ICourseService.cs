using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        IQueryable<CourseViewModel> GetCourses();
        void Create(CourseViewModel courseViewModel);
    }
}
