namespace PractiseProj1;

public class Intern 
{
    public int id { get; }
    public string name { get; }
    public int startDate { get; }
    public int endDate { get; }
    
    public Intern (int id, string name, int startDate, int endDate){
        this.id = id;
        this.name = name;
        this.startDate = startDate;
        this.endDate = endDate;
    }
        
}