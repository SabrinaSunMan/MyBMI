using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MyBMI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Script.Serialization;


using System.Collections;
using System.IO;
using MyBMI.Models.Repositiry;


namespace MyBMI
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

             int SexCount =  Enum.GetNames(typeof(SexType)).Length;
  
            foreach (var Sexitem in Enum.GetValues(typeof(SexType))) { 
                drop_Sex.Items.Add(new ListItem { Value = Convert.ToInt16(Sexitem).ToString(), Text = ((SexType)Sexitem).ToString() });
            }

            foreach (var Heightitem in Enum.GetValues(typeof(HightType)))
            {
                drop_Height.Items.Add(new ListItem { Value = ((WeightType)Heightitem).ToString(), Text = Heightitem.ToString() });
            }

            foreach (var Weightitem in Enum.GetValues(typeof(WeightType)))
            {
                drop_Weight.Items.Add(new ListItem { Value = Convert.ToInt16(Weightitem).ToString(), Text = ((WeightType)Weightitem).ToString() });
            }  
        }
         

        protected void Button1_Click(object sender, EventArgs e)
        {
            BMIRepository returnBMI = new BMIRepository();
            WeightType ChooseWeight = (WeightType)Enum.Parse(typeof(WeightType), drop_Weight.SelectedValue.ToString(), true);
            SexType ChooseSex = (SexType)Enum.Parse(typeof(SexType), drop_Sex.SelectedItem.Text.ToString(), true);
            HightType ChooseHight = (HightType)Enum.Parse(typeof(HightType), drop_Height.SelectedValue.ToString(), true);

            decimal RealHeight = returnBMI.ReturnHight(ChooseHight, Convert.ToDecimal(tx_Height.Text.ToString()));
            decimal RealWeight = returnBMI.ReturnWeight(ChooseWeight, Convert.ToDecimal(tx_Weight.Text.ToString()));
            double YourBMI = returnBMI.CountYourBMI(RealWeight, RealHeight);
            label_1.Text = returnBMI.ComYourBody(YourBMI, ChooseSex);

        }
    }
}