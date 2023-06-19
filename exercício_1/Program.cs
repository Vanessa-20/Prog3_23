using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

SectionTitle("* Handling cross-platform environments and filesystems");
Console.WriteLine("{0,-33} {1}", arg0: "Path.PathSeparator",
  arg1: PathSeparator);
Console.WriteLine("{0,-33} {1}", arg0: "Path.DirectorySeparatorChar",
  arg1: DirectorySeparatorChar);
Console.WriteLine("{0,-33} {1}", arg0: "Directory.GetCurrentDirectory()",
  arg1: GetCurrentDirectory());
Console.WriteLine("{0,-33} {1}", arg0: "Environment.CurrentDirectory",
  arg1: CurrentDirectory);
Console.WriteLine("{0,-33} {1}", arg0: "Environment.SystemDirectory",
  arg1: SystemDirectory);
Console.WriteLine("{0,-33} {1}", arg0: "Path.GetTempPath()",
  arg1: GetTempPath());
Console.WriteLine("GetFolderPath(SpecialFolder");
Console.WriteLine("{0,-33} {1}", arg0: " .System)",
  arg1: GetFolderPath(SpecialFolder.System));
Console.WriteLine("{0,-33} {1}", arg0: " .ApplicationData)",
  arg1: GetFolderPath(SpecialFolder.ApplicationData));
Console.WriteLine("{0,-33} {1}", arg0: " .MyDocuments)",
  arg1: GetFolderPath(SpecialFolder.MyDocuments));
Console.WriteLine("{0,-33} {1}", arg0: " .Personal)",
  arg1: GetFolderPath(SpecialFolder.Personal));

SectionTitle("Managing drives");
Console.WriteLine("{0,-30} | {1,-10} | {2,-7} | {3,18} | {4,18}",
  "NAME", "TYPE", "FORMAT", "SIZE (BYTES)", "FREE SPACE");

foreach (DriveInfo drive in DriveInfo.GetDrives())
{
  if (drive.IsReady)
  {
    Console.WriteLine(
    "{0,-30} | {1,-10} | {2,-7} | {3,18:N0} | {4,18:N0}",
    drive.Name, drive.DriveType, drive.DriveFormat,
    drive.TotalSize, drive.AvailableFreeSpace);
  }
  else
  {
    Console.WriteLine("{0,-30} | {1,-10}", drive.Name, drive.DriveType);
  }
}

SectionTitle("Managing directories");

// define a directory path for a new folder
// starting in the user's folder
string newFolder = Combine(
  GetFolderPath(SpecialFolder.Personal), "NewFolder");

WriteLine($"Working with: {newFolder}");

// check if it exists
WriteLine($"Does it exist? {Path.Exists(newFolder)}");

// create directory
WriteLine("Creating it...");
CreateDirectory(newFolder);
WriteLine($"Does it exist? {Path.Exists(newFolder)}");
Write("Confirm the directory exists, and then press ENTER: ");
ReadLine();

// delete directory
WriteLine("Deleting it...");
Delete(newFolder, recursive: true);
WriteLine($"Does it exist? {Path.Exists(newFolder)}");