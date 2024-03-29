﻿using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
    public class HomeDetailViewModel
    {
        public Employee Employee { get; set; }
        public string PageTitle { get; set; }
        public IEnumerable<Employee> EmployeeList { get; set; }
    }
}
