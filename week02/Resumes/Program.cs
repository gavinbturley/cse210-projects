using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2023;
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Microsoft";
        
        Resume resume = new Resume();
        resume._name = "Gavin Turley";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayResume();
    }
}