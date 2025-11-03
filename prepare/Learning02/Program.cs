using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "company_name";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2000;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._company = "company2";
        job2._jobTitle = "Job title";
        job2._startYear = 2020;
        job2._endYear = 2021;

        List<Job> jobList = new List<Job>();
        jobList.Add(job1);
        jobList.Add(job2);

        Resume resume1 = new Resume();
        resume1._name = "name";
        resume1._jobs = jobList;
        resume1.Display();
    }
}