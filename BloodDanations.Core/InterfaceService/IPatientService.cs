﻿using blood_donations.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDanations.Core.InterfaceRepository
{
    public interface IPatientService
    {
        List<Patient> GetServies();

        Patient GetByIdService(int id);


        bool PostServies(Patient d);

        bool PutServies(int id, Patient dose);

        bool DeleteServies(int id);
    }
}