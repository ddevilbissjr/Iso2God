namespace Chilano.Iso2God.Ftp;

public class FtpUploaderArgs
{
    public IsoEntryPlatform Platform;

    public string Ip;

    public string User;

    public string Pass;

    public string Port;

    public string GameDirectory;

    public string ContainerID;

    public string SourcePath;

    public string ftpPath;

    public FtpUploaderArgs(string Ip, string User, string Pass, string Port, string ftpPath, string GameDirectory, string ContainerID, string SourcePath, IsoEntryPlatform Platform)
    {
        this.Ip = Ip;
        this.User = User;
        this.Pass = Pass;
        this.Port = Port;
        this.ftpPath = ftpPath;
        this.GameDirectory = GameDirectory;
        this.ContainerID = ContainerID;
        this.SourcePath = SourcePath;
        this.Platform = Platform;
    }
}
