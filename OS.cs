using System.Runtime.InteropServices;
public class OS {
    [DllImport("msvcrt.dll")]
    public static extern int system(string Command);
    public static void mkdir(string dir) {
        try {
            if (!System.IO.Directory.Exists(dir)) {
                System.IO.Directory.CreateDirectory(dir);
            }
        }
        catch (IOException) {
            Console.WriteLine("Error: an exception occurred while trying to create the directory");
        }
    }
    public static void chdir(string dir) {
        try {
            System.IO.Directory.SetCurrentDirectory(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), dir));
        }
        catch (System.IO.DirectoryNotFoundException) {
            Console.WriteLine($"Error: no such directory ({dir})");
        }
    }
    public static string getcwd() {
        return System.IO.Directory.GetCurrentDirectory();
    }
    public static void rmdir (string dir) {
        if (!System.IO.Directory.Exists(dir)) {
             Console.WriteLine($"Error: Directory ({dir}) does not exist");
        }
        try {
            System.IO.Directory.Delete(dir);
        }
        catch (System.IO.DirectoryNotFoundException) {
            Console.WriteLine($"Error: no such directory ({dir})");
        }
    }
    public static void remove (string file) {
        if (System.IO.File.Exists(file)) {
            Console.WriteLine($"Error: File ({file}) does not exist");
        }
        else {
            System.IO.File.Delete(file);
        }
    }
    public static void create (string file) {
        if(System.IO.File.Exists(file)) {
            Console.WriteLine($"Error: File ({file}) already exists");
        }
        else {
            System.IO.File.Create(file);
        }
    }
    public static void copy (string source, string destination) {
        try {
            System.IO.File.Copy(source, destination);
        }
        catch (System.IO.IOException) {
            Console.WriteLine($"Error: Cant copy {source} to {destination}");
        }
    }
}
