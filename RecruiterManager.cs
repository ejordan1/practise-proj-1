namespace PractiseProj1;

public class RecruiterManager
{
    public Dictionary<int, Recruiter> recruiters; 
    
    public RecruiterManager(Recruiter[] newRecruiters)
    {
        this.recruiters = new Dictionary<int, Recruiter>();

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
        // was about to use the ConvertAll method to turn them into candadites
    }
}





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
