using blood_donations.Entities;
using blood_donations.Subjects;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace BloodDanations.Data.Data
{


    public class DataContext<T>
    {
        public List<T> data { get; set; }
        //public List<Patient> Patients { get; set; }

        //public List<Employee> employees { get; set; }

        //public List<BloodDose> bloodDoses { get; set; }

        //public List<CompatibilityCheck> CompatibilityChecks { get; set; }

        public DataContext()
        {



            string path = Path.Combine(AppContext.BaseDirectory, "Data", "Patient.csv");

            if (new FileInfo(path).Length > 0)
                    {
                       var reader = new StreamReader(path);
                       var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                        {
                            data = csv.GetRecords<T>().ToList();
                        }
                    }
                    else
                    {
                        data = new List<T>();
                    }
        }
        public bool SaveData<T>(List<T> data)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "Patient.csv");

            try
            {
                if (File.Exists(path))
                    File.Delete(path);
                using (var writer = new StreamWriter(path))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(data);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }


}

