using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Activity8_2
{
    class  Logger
    {
        public static string LogWrite(string logPath, string logInfo)
        
        {
            try
            {
                FileStream oFileStream = new FileStream(logPath, FileMode.Open, FileAccess.Write);
                StreamWriter oStreamwriter = new StreamWriter(oFileStream);
                oFileStream.Seek(0, SeekOrigin.End);
                oStreamwriter.WriteLine(DateTime.Now);
                oStreamwriter.WriteLine(logInfo);
                oStreamwriter.WriteLine();
                oStreamwriter.Close();
                return "info Logged";
            }
            catch (FileNotFoundException ex)
            {
                return ex.Message;
            }
            catch (IOException ex)
            {
                return ex.Message;
            }
            catch
            {
                return "Logging Failed";
            }

            
        }
        
    }
}
