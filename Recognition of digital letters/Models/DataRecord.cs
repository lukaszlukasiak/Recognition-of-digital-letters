using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecognitionOfDigitalLetters.Models
{
    public class DataRecord
    {
        public int[] Observations = new int[24];
        public char Letter { get; set; }

    }
}
