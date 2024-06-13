﻿using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CourseServices : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseServices(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public IEnumerable<CourseViewModel> GetCourses()
        {
            throw new NotImplementedException();
        }
    }
}
