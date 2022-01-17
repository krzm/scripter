namespace Scripter;

public class Folders
{
    private readonly string repoName;

    public Folders(string repoName)
    {
        this.repoName = repoName;
    }

    public string Root => @"C:\kmazanek@gmail.com";

    public string Code => @$"{Root}\Code";

    public string PowerShell => @$"{Code}\PowerShell";

    public string Script => @$"{PowerShell}\{repoName}}";

    public string Apps => @$"{Root}\Apps";
}