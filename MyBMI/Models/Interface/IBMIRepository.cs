using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MyBMI.Models;

namespace MyBMI.Models.Interface
{
    public interface IBMIRepository
    {
        decimal ReturnWeight(WeightType type,decimal weight);  //統一轉成公斤

        decimal ReturnHight(HightType type,decimal hight); //統一轉成公分

        double CountYourBMI(decimal weight, decimal hight);

        string ComYourBody(double BMI, SexType sex);
    }
}