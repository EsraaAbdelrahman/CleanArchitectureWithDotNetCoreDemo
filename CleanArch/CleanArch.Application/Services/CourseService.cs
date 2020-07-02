using AutoMapper;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper.QueryableExtensions;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _automapper; 

        public CourseService(ICourseRepository courseRepository,IMediatorHandler handler,IMapper mapper)
        {
            _courseRepository = courseRepository;
            _bus = handler;
            _automapper = mapper;
        }

        public IQueryable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses().
                ProjectTo<CourseViewModel>(_automapper.ConfigurationProvider);
            
        }

        public void Create(CourseViewModel courseViewModel)
        {
            _bus.SendCommand(_automapper.Map<CreateCourseCommand>(courseViewModel));
        }
    }
}
