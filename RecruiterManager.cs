using System.Runtime.InteropServices.JavaScript;

namespace PractiseProj1;

public class RecruiterManager
{
    public Dictionary<int, Recruiter> recruiters;
    
    public RecruiterManager()
    {
        this.recruiters = new Dictionary<int, Recruiter>();
    }

    public void AddRecruiters(Recruiter[] newRecruiters)
    {
        foreach (Recruiter newRecruiter in newRecruiters)
        {
            if (recruiters.ContainsKey(newRecruiter.id)) {throw new InvalidOperationException("Recruiter Id already exists");}
            else
            {
                newRecruiter.vacations = new List<Vacation>();
                recruiters.Add(newRecruiter.id, newRecruiter);
            }
        }
    }
    
    public void AssignVacation(Vacation[] vacations)
    {
        foreach(Vacation vacation in vacations)
        {
            recruiters[vacation.RecruiterId].vacations.Add(vacation);
        }
    }
    
    public List<List<Recruiter>> CreateRecruiterGroups (Recruiter[] recruiters)
    {
        
    }
}
