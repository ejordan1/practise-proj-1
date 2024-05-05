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
    
    // last group could be less
    public List<List<Recruiter>> CreateRecruiterGroups (Recruiter[] recruiters, int groupSize)
    {
        List<List<Recruiter>> recruiterGroups = new List<List<Recruiter>>();

        List<Recruiter> newGroup = new List<Recruiter>();
        recruiterGroups.Add(newGroup);
        foreach(Recruiter r in recruiters){
            
            if (newGroup.Count < groupSize)
            {
                newGroup.Add(r);
            }
            else
            {
                newGroup = new List<Recruiter>();
                recruiterGroups.Add(newGroup);
                newGroup.Add(r);
            }
        }

        return recruiterGroups;
    }

    public void AssignToGroups(List<List<Recruiter>> recruiterGroups, Intern[] interns)
    {
        // assign first groups according to regular, then last will start at pointa nd end at end
        int internsPerGroup = interns.Length / recruiterGroups.Count;
        for (int i = 0; i < recruiterGroups.Count; i++)
        {
            int startingIndex = i * internsPerGroup;
            // last group takes all the remaining interns
            int endingIndex = i == recruiterGroups.Count - 1 ? interns.Length : startingIndex + internsPerGroup;
            
            
        }
    }
}
