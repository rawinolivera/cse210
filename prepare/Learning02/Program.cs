using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Support Specialist";
        job1._jobTitle = "ASOV";
        job1._startYear = 2015;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._jobTitle = "Assistent";
        job2._jobTitle = "ANKA ANDINA";
        job2._startYear = 2016;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Rawin Olivera";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}