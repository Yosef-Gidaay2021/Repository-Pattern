namespace Repository_Pattern.RepoPattern;

public class Blog:IAggregateRoot{

    public string Url{get;set;}
    public string Name{get;set;}
    public string? Description{get;set;}
    public List<BlogPost> BlogPost{get;set;}
    
    protected Blog(){}

    public Blog(string url, string name){
       this.Url=url;
       this.Name=name;
    }

     public Blog(string url, string name, string description)
         :this(url, name)
     {
       
       this.Description=description;
    }

}