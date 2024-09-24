using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume cv = new Resume();
        cv._personName = "Santiago Franco Delgado ";
        cv._jobs.Add(job1);
        cv._jobs.Add(job2);

        cv.DisplayJobDetails();
    }
}