using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NestedType
{
    struct Digitalize
    {
        private long bit;

        public string Bit => $"{(bit / bitsInBit):N0} Bit";
        public string Byte => $"{(bit / bitsInByte):N0} Byte";
        public string KB => $"{(bit / bitsInKB):N0} KB";
        public string MB => $"{(bit / bitsInMB):N0} MB";
        public string GB => $"{(bit / bitsInGB):N0} GB";
        public string TB => $"{(bit / bitsInTB):N0} TB";


        private const long bitsInBit = 1;
        private const long bitsInByte = 8;
        private const long bitsInKB = bitsInByte * 1024;
        private const long bitsInMB = bitsInKB * 1024;
        private const long bitsInGB = bitsInMB * 1024;
        private const long bitsInTB = bitsInGB * 1024;

        public Digitalize(long iniatialValue)
        {
            this.bit = iniatialValue;  
        }
    }
}
