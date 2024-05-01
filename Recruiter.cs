namespace PractiseProj1;

public class Recruiter
{
    public int id { get; }
    public string name { get; }
    public List<Vacation> vacations { get; set; }
    public List<Intern> interns { get; set; }
    
    public Recruiter(int id, string name)
    {
        this.id = id;
        this.name = name;
        vacations = new List<Vacation>();
        interns = new List<Intern>();
    }
        
    public bool CanRecruitIntern(Intern intern)
    {
        foreach (Vacation vacation in vacations)
        {
            if (vacation.StartDate <= intern.startDate && vacation.EndDate >= intern.startDate || 
                vacation.StartDate <= intern.endDate && vacation.EndDate >= intern.endDate)
                
            {
                return false;
            }
        }
        return true;
    }
}