using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _2deg.Models
{
    public class Region
    {
        public string name { get; set; }
       public List<double> properties { get; set; }
 /*       public void GetData() {
            string connectionstring = @"Data Source=SQL5080.site4now.net;Initial Catalog=DB_A683D9_figurehead;User Id=DB_A683D9_figurehead_admin;Password=Figureman1"; ;
            string sql = "select Population,PartProvidedWithGas,UrbanPopulation,ValueAddedServices,ValueAddedAgricultureForestryandFishing,ValueAddedManufacturing,NonDairyCows,DairyCows,Pigs,Sheep,Goats,LightVehicals,Busses,Trucks,Cropland1000ha,Forest1000ha,TotalArea1000ha,GrassLands1000ha from Proportions";
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader reader;
            con.Open();
            reader = com.ExecuteReader();
            while () { 
            
            
            }
          
            
            con.Close();
        }*/
        public int Formatname() {
            string nameb = "";           
            for (int i = 0; i <name.Length;i++) {
                if (name[i]==' '||name[i]=='-') {
                    continue;
            }
                nameb += Convert.ToString(name[i]);
            }
            switch (name)
            {
                case "აფხაზეთი":
                    name = "afxazeti";
                    return 0;
                case "გურია":
                    name = "guria";
                    return 0;
                case "სამეგრელოდაზემოსვანეთი":
                    name = "samegrelodazemosvaneti";
                    return 0;
                case "იმერეთი":
                    name = "imereti";
                    return 0;
                case "სამცხეჯავახეთი":
                    name = "samcxejavaxeti";
                    return 0;
                case "რაჭალეჩხუმიდაქვემოსვანეთი":
                    name = "rachalechxumidaqvemosvaneti";
                    return 0;
                case "კახეთი":
                    name = "kaxeti";
                    return 0;
                case "მცხეთამთიანეთი":
                    name = "mcxetamtianeti";
                    return 0;
                case "აჭარა":
                    name = "achara";
                    return 0;
                case "ოსეთი":
                    name = "oseti";
                    return 0;
                case "ქვემოქართლი":
                    name = "qvemoqartli";
                    return 0;
                case "თბილისი":
                    name = "tbilisi";
                    return 0;
                case "შიდაქართლი":
                    name = "shidaqartli";
                    return 0;
            }
            name = nameb.ToLower();
            return 0;

        }
    }
}
