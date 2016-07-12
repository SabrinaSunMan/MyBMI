using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MyBMI.Models.Interface;

namespace MyBMI.Models.Repositiry
{
    public class BMIRepository : IBMIRepository
    {
        public decimal ReturnWeight(WeightType type, decimal weight)
        {
            decimal Return = 0;
            switch(type)
            {
                case WeightType.Kilogram: 
                    return weight;
                case WeightType.Pound: 
                    return Math.Round(weight * 0.454m, 2);
            }
            return Return;
        }

        public decimal ReturnHight(HightType type, decimal hight)
        {
            decimal Return = 0;
            switch(type)
            {
                case HightType.公分:
                    return hight;
                case HightType.FT:
                    return Math.Round(hight * 30.48m, 2);
            }
            throw new NotImplementedException();
        }

        public double CountYourBMI(decimal weight, decimal hight)
        {
            hight = hight / 100;
            return Convert.ToDouble(weight / (hight * hight)); 
        }

        public string ComYourBody(double BMI,SexType sex) 
        {
            switch (sex)
                { 
                    case SexType.Man:
                        if (BMI < 20)
                        {
                            return "你是男人嗎?!太瘦了!";
                        }
                        else if (20 <= BMI && 25 >= BMI)
                        {
                            return "你是正常體重!";
                        }
                        else
                        {
                            return "你要注意一下體重囉!";
                        } 
                    case SexType.Femal:
                        if (BMI < 18)
                        {
                            return "妳是紙片人!";
                        }
                        else if (18 <= BMI && 22 >= BMI)
                        {
                            return "妳是正常體重!";
                        }
                        else
                        {
                            return "妳要注意一下體重囉!";
                        } 
                }
            throw new NotImplementedException();
        }

    }

    public class NewBMI : BMIRepository
    {
        public string ReturnNewBMI()
        {
            return ComYourBody(23, SexType.Femal);
        }
    }
}