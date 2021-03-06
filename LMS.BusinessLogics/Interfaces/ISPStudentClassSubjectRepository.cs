﻿using LMS.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.BusinessLogics.Interfaces
{
    public interface ISPStudentClassSubjectRepository
    {
        IQueryable<StudentClassViewModel> GetStudentClassSubjectstDistinctByStudentId(int StudentId);
    }
}
