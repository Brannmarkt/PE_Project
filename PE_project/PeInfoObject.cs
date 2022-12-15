using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PE_project
{
    class PeInfoObject 
    {
        string file_link;
        public string File_Link
        {
            get { return file_link; }
            set 
            {
                file_link = value;
            }
        }

        string sha_1;
        public string SHA_1
        {
            get { return sha_1; }
            set
            {
                sha_1 = value;
            }
        }

        string sha_256;
        public string SHA_256
        {
            get { return sha_256; }
            set
            {
                sha_256 = value;
            }
        }

        string size;
        public string Size
        {
            get { return size; }
            set
            {
                size = value;
            }
        }

        string type;
        public string Type
        {
            get { return type; }
            set
            {
                type = value;
            }
        }

        string bit_rate;
        public string Bit_Rate
        {
            get { return bit_rate; }
            set
            {
                bit_rate = value;
            }
        }

        string bites;
        public string Bites
        {
            get { return bites; }
            set
            {
                bites = value;
            }
        }

        public PeInfoObject()
        {
            File_Link = string.Empty;
            SHA_1 = string.Empty;
            SHA_256 = string.Empty;
            Size = string.Empty;
            Type = string.Empty;
            Bit_Rate = string.Empty;
            Bites = string.Empty;
        }

        public PeInfoObject(string link)
        {
            var pe_info = File.ReadAllBytes(@link);
            var result = new PeNet.PeFile(pe_info);
            
            SHA_1 = result.Sha1;

            SHA_256 = result.Sha256;

            Size = Convert.ToString(result.FileSize / 1000 + " kb");

            if (result.IsDll)
            {
                Type = "dll";
            }
            else if (result.IsDriver)
            {
                Type = "driver";
            }
            else if (result.IsExe)
            {
                Type = "exe";
            }

            if (result.Is32Bit)
            {
                Bit_Rate = "32-bit";
            }
            else if (result.Is64Bit)
            {
                Bit_Rate = "64-bit";
            }

            byte[] data = File.ReadAllBytes(link);
            StringBuilder bytes_info = new StringBuilder(data.Length * 2);

            foreach (byte b in data)
            {
                bytes_info.AppendFormat("{0:x2}", b);
                bytes_info.Append(' ');
            }
            
            Bites = bytes_info.ToString();

        }


        public void ConvertFromBinary(string link)
        {
            byte[] data = File.ReadAllBytes(link);
            StringBuilder result = new StringBuilder(data.Length * 2);
            
            foreach (byte b in data)
            {
                result.AppendFormat("{0:x2}", b);
                result.Append(' ');
            }

            Bites = result.ToString();
        }
        
    }
}
 