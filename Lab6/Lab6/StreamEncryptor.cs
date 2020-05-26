using System;
using System.IO;

namespace Lab6
{
    public class StreamEncryptor
    {
        public StreamEncryptor(StreamReader reader, StreamWriter writer, bool Decrypt = false)
        {


            // StreamReader reader = new StreamReader(inputStream);
            //StreamWriter writer = new StreamWriter(outputStream);

            int symbol = reader.Read();
            int key = 25;
            while (symbol != -1)
            {
                if (Decrypt)
                {
                    writer.Write((char)(symbol - key));
                }
                else
                {
                    writer.Write((char)(symbol + key));
                }
                symbol = reader.Read();
            }
            writer.Close();
        }



    }


}
