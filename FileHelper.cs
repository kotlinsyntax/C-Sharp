public class FileHelper {
    public static void EncryptFile(string file) {
        if(!System.IO.File.Exists(file)) {
            Console.WriteLine($"Error: File ({file}) does not exist");
        }
        else {
            System.IO.File.Encrypt(file);
        }
    }
    public static void DecryptFile(string file) {
        if(!System.IO.File.Exists(file)) {
            Console.WriteLine($"Error: File ({file}) does not exist");
        }
        else {
            System.IO.File.Decrypt(file);
        }
    }
}
