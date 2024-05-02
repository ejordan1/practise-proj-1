namespace PractiseProj1;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        // Candidate ip = new Candidate(1, "hi", 2, 3);
        // Console.WriteLine(ip.endDate);

        Recruiter a = new Recruiter(1, "firstR");
        Recruiter b = new Recruiter(2, "secondR");
        RecruiterManager rM = new RecruiterManager();
        rM.AddRecruiters(new Recruiter[]{ a, b });
        
        Vacation v = new Vacation(1, 3, 5);
        rM.AssignVacation(new Vacation[]{v});
        
        Intern e = new Intern(1, "firstI", 4, 6);
        Intern f = new Intern(2, "secondI", 7, 9);
        Intern g = new Intern(3, "thirdI", 1, 3);
        rM.AssignCandadites(new Intern[]{e, f, g});
    }
}
