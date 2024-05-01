namespace PractiseProj1;

public class Candidate : Intern
{
    public int Skipped { get; set; }   
    public Candidate(int id, string name, int startDate, int endDate):base(id, name, startDate, endDate)
    {

    }

}