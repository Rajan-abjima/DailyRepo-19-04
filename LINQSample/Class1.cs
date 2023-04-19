using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSample
{
    public class Employee1
    {
        public int emp_id
        {
            get;
            set;
        }

        public string emp_name
        {
            get;
            set;
        }
        public string emp_lang
        {
            get;
            set;
        }
    }

    // Employee department details
    public class Employee2
    {

        public int emp_id
        {
            get;
            set;
        }

        public string emp_dept
        {
            get;
            set;
        }
        public int emp_salary
        {
            get;
            set;
        }
    }


}

