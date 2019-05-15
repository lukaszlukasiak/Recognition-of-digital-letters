using RecognitionOfDigitalLetters.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recognition_of_digital_letters.ServiceClasses
{
    public static class GeneralServices
    {
        public static List<DataRecord> ReturnDataRecords(string fullTrainingFilename)
        {
            const int NUM_OF_VALUES = 64;
            List<DataRecord> records = new List<DataRecord>();
            using (var reader = new StreamReader(fullTrainingFilename))
            {
                int lineNum = 0;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    records.Add(new DataRecord());

                    for (int i = 0; i < NUM_OF_VALUES; i++)
                    {
                        records[lineNum].Observations[i] = int.Parse(values[i]);
                    }
                    records[lineNum].Letter = int.Parse(values[NUM_OF_VALUES]);
                    lineNum++;
                }
            }
            return records;
        }

    }
}
