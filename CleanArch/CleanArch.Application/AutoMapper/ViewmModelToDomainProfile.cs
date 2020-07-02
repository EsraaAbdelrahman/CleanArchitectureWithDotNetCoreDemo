using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.AutoMapper
{
    public class ViewmModelToDomainProfile : Profile
    {

        public ViewmModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>().ConstructUsing
                (
                C => new CreateCourseCommand(C.Name, C.Description, C.ImageUrl
                ));
        }

    }
}
