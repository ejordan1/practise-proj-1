namespace PractiseProj1;

public class Candidate : Intern
{
    public int Skipped { get; set; }   
    public Candidate(Intern intern):base(intern.id, intern.name, intern.startDate, intern.endDate)
    {

    }

}