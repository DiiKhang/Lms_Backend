﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LMS.Domain.ViewModels
{
    public class AssignSectionViewModel
    {
        
        public int ClassSection_Id { get; set; }
        
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        
        public int SectionId { get; set; }
        public string SectionName { get; set; }


        public List<Class> Classes = new List<Class>();
        public List<Section> Sections = new List<Section>();
        public List<ClassSection> ClassSections = new List<ClassSection>();
        
        

    }
}
