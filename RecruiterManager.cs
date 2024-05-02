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
            // if (recruiters.ContainsKey(newRecruiter.id)) throw new InvalidOperationException("Recruiter Id already exists");
            recruiters.TryAdd(newRecruiter.id, newRecruiter);
        }
    }

    public void CreateVacation(Recruiter[] newRecruiters)
    {
        foreach(Recruiter recruiter in newRecruiters)
        {
            recruiter.vacations = new List<Vacation>();
            this.recruiters.Add(recruiter.id, recruiter);
        }
    }
    
    public void AssignVacation(Vacation[] vacations)
    {
        foreach(Vacation vacation in vacations)
        {
            recruiters[vacation.RecruiterId].vacations.Add(vacation);
        }
    }

    public void AssignCandadites(Intern[] newInterns)
    {
        Candidate[] candidates = Array.ConvertAll(newInterns, intern => new Candidate(intern));
        Stack<Candidate> candidateStack = new Stack<Candidate>(candidates);
        Console.WriteLine("candidates count = " + candidateStack.Count);
    
        // had to change to double here, not sure why
        double averageCandidates = Math.Ceiling((double)candidateStack.Count / recruiters.Count);

        // make recruiter candidate dictionary
        Dictionary<int, HashSet<Candidate>> recruiterCandidates = new Dictionary<int, HashSet<Candidate>>();
        foreach (KeyValuePair<int, Recruiter> r in recruiters)
        {
            recruiterCandidates.Add(r.Key, new HashSet<Candidate>());
        }
        
        foreach (Recruiter recruiter in recruiters.Values)
        {
            List<Candidate> overlapped = new List<Candidate>();
            for (int i = 0; i < averageCandidates; i++)
            {
                if (candidateStack.Count > 0)
                {
                    bool addedCandidate = false;
                    while (!addedCandidate && candidateStack.Count > 0)
                    {
                        Candidate attemptingCandidate = candidateStack.Pop();
                        if (recruiter.CanRecruitIntern(attemptingCandidate))
                        {
                            // verify that recruiter doesn't already have that candidate
                            if (!recruiterCandidates[recruiter.id].Contains(attemptingCandidate))
                            {
                                recruiterCandidates[recruiter.id].Add(attemptingCandidate);
                                addedCandidate = true;
                            }
                        }
                        else // candidate overlapped with vacation
                        {
                            attemptingCandidate.Skipped++;
                            overlapped.Add(attemptingCandidate);
                        }
                    }

                }
            }

            // adds the candidates that overlapped with vacation back to the stack
            foreach (Candidate c in overlapped)
            {
                candidateStack.Push(c);
            }
        }
    }
}

// next step: was going to abstract out the part of going through the stack, and return only "attempted candidates"
// so then it can go through next time with the same method, but do it in reverse... 




// // Online C# Editor for free
// // Write, Edit and Run your C# code using C# Online Compiler
//
// using System;
//
// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine ("Try programiz.pro");
//         
//     }
//     
//     class Intern 
//     {
//         public  id;
//         public  name;
//         public startDate;
//         public endDate;
//         public Intern (int id, string name, int startDate, int endDate){
//     this.id = id;
//     this.name = name;
//     this.startDate = startDate;
//     this.endDate = endDate;
//         }
//         
//     }
//     
//     
//     class Recruiter
//     {
//         public int id;
//         public int name;
//         public List<Vacations> vacations;
//         public List<Intern> interns;
//         public Recruiter(int id, string name)
//         {
//             this.id = id;
//             this.name = name;
//         }
//         
//         public bool canRecruitIntern(Intern intern)
//         {
//             foreach (Vacation vacation in vacations)
//             {
//                 if (vacation.startDate <= intern.startDate && vacation.endDate >= intern.startDate || 
//                     vacation.startDate <= intern.endDate && vacation.endDate >= intern.endDate)
//                 )
//                 {
//                     return false;
//                 }
//             }
//             return true;
//         }
//     }
//     
//     class Vacation{
//         
//         public int recruiterId;
//         public int startDate;
//         public int endDate;
//         
//         public Vacation (int recruiterId, int startDate, int endDate)
//         {
//             this.recruiterId = recruiterId;
//             this.startDate = startDate;
//             this.endDate = endDate;
//         }
//     }
//     
//     class RecruiterManager
//     {
//         public Dictionary<int, Recruiter> recruiters;
//         public RecruiterManager(Recruiter[] recruiters)
//         {
//             this.recruiters = new Dictionary<int, Recruiter>();
//             foreach(Recruiter recruiter in recruiters)
//             {
//                 recruiter.vacations = new List<Vacations>();
//                 this.recruiters.Add(recruiter.id, recruiter);
//                 
//             }
//         }
//         
//         public void assignVacation(Vacation[] vacations)
//         {
//             foreach(Vacation vacation in vacations)
//             {
//                 recruiters[vacation.recruiterId].vacations.Add(vacation);
//             }
//         }
//         
//         public void assignInterns(Intern[] interns)
//         
//         {
//             
//             foreach(Intern intern in interns)
//             {
//                 Recruiter r = 
//             }
//         // Queue<Intern> failedToAssign = new Queue<Intern>();
//         // int internIndex = 0;
//         // int averageInterns = interns.Length / recruiters.Count;
//         // foreach(Recruiter recruiter in recruiters.Values())
//         // {
//         //     // 
//             
//         //     int internIndex = 0;
//         //     for (int i = 0; i < averageInterns; i++)
//         //     {
//         //         if (internIndex < interns.Length)
//         //         {
//         //             if (recruiter.canRecruitIntern())
//         //             {
//         //                 recruiter.interns.Add(interns[internIndex]);
//         //             }
//         //             else 
//         //             {
//         //                 failedToAssign.Add(intern);
//         //             }
//         //         }
//         //         internIndex++;
//          //   }
//         }
//         
//         RecruiterComparer : ICompare<Recruiter>
//         {
//             public int Compare (Recruiter r1, Recruiter r2)
//             {
//                 if (r1.interns.Count < r2.interns.Count)
//                 {
//                     return -1;
//                 } else if (r1.interns.Count < r2.interns.Count)
//                 {
//                     return 1;
//                 } else {
//                     return 0;
//                 }
//             }
//         }
//         
//     }
//
// }
