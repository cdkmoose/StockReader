using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace DavinSys.StockReader.Comm
{
    public class NetComm
    {
        static private string[] ReadResponse(HttpWebResponse resp)
        {
            StringBuilder sb = new StringBuilder();

            // Gets the stream associated with the response.
            Stream receiveStream = resp.GetResponseStream();
            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
            // Pipes the stream to a higher level stream reader with the required encoding format. 
            StreamReader readStream = new StreamReader(receiveStream, encode);
            System.Diagnostics.Trace.Write("Response stream received.\n");
            Char[] read = new Char[256];
            // Reads 256 characters at a time.    
            int count = readStream.Read(read, 0, 256);
            while (count > 0)
            {
                // Dumps the 256 characters on a string and appends to stringbu.
                String str = new String(read, 0, count);
                sb.Append(str);
                count = readStream.Read(read, 0, 256);
            }
            // Releases the resources of the response.
            resp.Close();
            // Releases the resources of the Stream.
            readStream.Close();

            //return sb.ToString().Split(new string[] { "\r\n" }, StringSplitOptions.None);
            return sb.ToString().Split(new string[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

        }

        public static string[] GetDataResponse(string request)
        {
            string[] response;

            response = new string[1];
            response[0] = "";
            try
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(request);
                HttpWebResponse resp;

                resp = (HttpWebResponse)req.GetResponse();

                response = ReadResponse(resp);

                return response;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.Write("Exception reading data: " + ex.Message);

                return response;
            }
            
        }
    }
}
