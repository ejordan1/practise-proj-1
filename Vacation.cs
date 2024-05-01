namespace PractiseProj1;

public class Vacation{
        
    public int RecruiterId { get; set; }
    public int StartDate { get; set; }
    public int EndDate { get; set; }
        
    public Vacation (int recruiterId, int startDate, int endDate)
    {
        this.RecruiterId = recruiterId;
        this.StartDate = startDate;
        this.EndDate = endDate;
    }
}