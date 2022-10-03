using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class WriteFile
    {
        string path1 = "C:/Users/ei13074/Documents/Files/new.txt";
        string path2 = "C:/Users/ei13074/Documents/Files/new2.txt";
        string path3 = "C:/Users/ei13074/Documents/new2.txt";
        public void Write()
        {
            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
          

            FileInfo fileInfo = new FileInfo(path1);
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
                for(int i=1; i<11; i++)
                {
                    for(int j=1; j<11; j++)
                    {
                        writer.WriteLine($"{i} * {j} = {i * j}");
                    }
                }

                //File.Move(path3, path2);
                //File.Copy(path1, path3);
                //File.Delete(path2);
                      
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }

        }
        public void read()
        {

            //Specify the filename and the path of the file to be created 
            //Fileinfo - class
            FileInfo fileInfo = new FileInfo(path1);
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fileStream);
            try
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine(contents);
                Console.WriteLine(".................................................................");
                string[] lines = File.ReadAllLines(path2);
                Console.Write(lines[0]);
                Console.WriteLine(".................................................................");
                using (StreamReader sr = File.OpenText(path2))
                {
                    int count = 0;
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        count++;
                    }
                    Console.WriteLine(count);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }

        }

    }
    internal class Files
    {
      public static void Main()
        {
            WriteFile w = new WriteFile();
            w.Write();
            w.read();
        }
    }
}
