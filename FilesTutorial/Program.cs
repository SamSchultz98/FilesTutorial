using System.Threading.Tasks.Dataflow;
using static System.Console;
/*Reading and Writing Dierectories and Files
string foldername = @"c:\Users\max-s\Documents\MyNewFolder";

//Path.Combine(foldername, "MyNewSubFolder");               //Easiest way to combine dierectories

string[] files = Directory.GetFiles(foldername);
string[] dirs = Directory.GetDirectories(foldername);

foreach (DriveInfo drive in DriveInfo.GetDrives())      //DriveInfo.GetDrives will return an array of all the drives. 
{
   Console.WriteLine(files);
//Console.WriteLine($"{drive.Name} | {drive.DriveType} | {drive.DriveFormat} | {drive.TotalSize:N0} | {drive.AvailableFreeSpace}"); //Great drive info commands

                                                                        //System.IO.Directory.CreateDirectory($"{foldername}");         //This creates a new folder
                                                                        //This creates a new dierectory with the name MyFolder
                                                        //Delete(foldername);                                             //This deletes the folder that was just create
    
}

foreach (string file in files)
{
    Console.WriteLine(dirs);
}

*/


string FullFileName = @"C:\Users\max-s\Desktop\FilesTutorial.log";

List<string> log = new();

if (File.Exists(FullFileName))
{
    string[] lines = File.ReadAllLines(FullFileName);               //This opens a file, and reads all the lines on that file
    log.AddRange(lines);                                            //This will add all the lines from the file
}
WriteLog("Mutiples of 3");
for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        WriteLog($"i is {i}");
    }
}

File.WriteAllLines(FullFileName, log);

Console.WriteLine("Done");


void WriteLog(string message)
{
    string logmessage = $"{DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff")} {message}";
    log.Add(logmessage);
}
