using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace _2deg.Models
{
    public  class Data
    {
        public double Sum { get; set; }
        public double output1 { get; set; }
        public double output2 { get; set; }
        public double output3 { get; set; }
        public double output4 { get; set; }
        public double output5 { get; set; }
        public double output { get; set; }
         public double output6 { get; set; }
        public double output7 { get; set; }

        public double output8 { get; set; }

        public double output9 { get; set; }

        public double output10 { get; set; }
        public double output11 { get; set; }
        public double output12 { get; set; }
        public double output13 { get; set; }
        public double output14 { get; set; }
        public double output15 { get; set; }
        public double output16 { get; set; }
        public double output17 { get; set; }
        public double output18 { get; set; }
        public double output19 { get; set; }
        public double output20 { get; set; }
        public double output21 { get; set; }
        public double output22 { get; set; }
        public double output23 { get; set; }
        public double output24 { get; set; }
        public double output25 { get; set; }


        public double outputm { get; set; }
        public List<double> samegrelozemosvaneti { get; set; }
        public List<double>  imereti{ get; set; }
        public List<double>  samcxe{ get; set; }
        public List<double>  shidaqartli{ get; set; }
        public List<double>  qvemoqartli{ get; set; }
        public List<double>  guria{ get; set; }
        public List<double>  kaxeti{ get; set; }
        public List<double>  mcxeta{ get; set; }
        public List<double>  racha{ get; set; }
        public List<double> achara { get; set; }
        public List<double> tbilisi { get; set; }
        //    public List<double>  sum{ get; set; }
        /*        public List<List<double>> OUTPUT() {
                    string connectionstring = @"Data Source=SQL5080.site4now.net;Initial Catalog=DB_A683D9_figurehead;User Id=DB_A683D9_figurehead_admin;Password=Figureman1"; ;
                    string sql = "select Population,PartProvidedWithGas,UrbanPopulation,ValueAddedServices,ValueAddedAgricultureForestryandFishing,ValueAddedManufacturing,NonDairyCows,DairyCows,Pigs,Sheep,Goats,LightVehicals,Busses,Trucks,Cropland1000ha,Forest1000ha,TotalArea1000ha,GrassLands1000ha from [DB_A683D9_figurehead].[dbo].[Proportions];";
                    SqlConnection con = new SqlConnection(connectionstring);
                    SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader reader;
                    con.Open();
                    reader = com.ExecuteReader();
                    List<List<double>> a=new List<List<double>>();
                    while (reader.Read()) { 
                        double c=

                    }


                }*/
       
        public List<double> Datagaming(int j)
        {
            List<double> outp= new List<double>();
            string connectionstring = @"Data Source=SQL5080.site4now.net;Initial Catalog=DB_A683D9_figurehead;User Id=DB_A683D9_figurehead_admin;Password=Figureman1"; ;
            string sql = "select Population,PartProvidedWithGas,UrbanPopulation,ValueAddedServices,ValueAddedAgricultureForestryandFishing,ValueAddedManufacturing,NonDairyCows,DairyCows,Pigs,Sheep,Goats,LightVehicals,Busses,Trucks,Cropland1000ha,Forest1000ha,TotalArea1000ha,GrassLands1000ha from [DB_A683D9_figurehead].[dbo].[Proportions];";
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader reader;
            con.Open();
            
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                double Population=Convert.ToDouble(reader.GetValue(j));
              /*  double PartProvidedWithGas=Convert.ToDouble(reader.GetValue(1));
                double UrbanPOpulation=Convert.ToDouble(reader.GetValue(2));
                double valueAddedservices=Convert.ToDouble(reader.GetValue(3));
                double ValueAddedAgricultureForestryandFishing=Convert.ToDouble(reader.GetValue(4));
                double ValueAddedManufacturing = Convert.ToDouble(reader.GetValue(5));
                double NonDairyCows = Convert.ToDouble(reader.GetValue(6));
                double DairyCows = Convert.ToDouble(reader.GetValue(7));
                double Pigs = Convert.ToDouble(reader.GetValue(8));
                double Sheep = Convert.ToDouble(reader.GetValue(9));
                double Goats = Convert.ToDouble(reader.GetValue(10));
                double LightVehicals = Convert.ToDouble(reader.GetValue(11));*/
                /*                samegrelozemosvaneti.Add(samegrelozemosvanetiv);
                                imereti.Add(imeretiv);
                                samcxe.Add(samcxev);
                                shidaqartli.Add(shidaqartliv);
                                qvemoqartli.Add(qvemoqartliv);
                                guria.Add(guriav);
                                kaxeti.Add(kaxetiv);
                                mcxeta.Add(mcxetav);
                                racha.Add(rachav);
                                achara.Add(acharav);
                                tbilisi.Add(tbilisiv);
                                sum.Add(sumv);
                                j++;*/
                outp.Add(Population);
/*                outp.Add(imeretiv);
                outp.Add(samcxev);
                outp.Add(shidaqartliv); 
                outp.Add(qvemoqartliv);
                outp.Add(guriav);
                outp.Add(kaxetiv);
                outp.Add(mcxetav);
                outp.Add(rachav);
                outp.Add(acharav);
                outp.Add(tbilisiv);
                outp.Add(sumv);*/

            }
            con.Close();
            return outp;
        }
        public double emission(int x) {
            string connectionstring = @"Data Source=SQL5080.site4now.net;Initial Catalog=DB_A683D9_figurehead;User Id=DB_A683D9_figurehead_admin;Password=Figureman1";
            string sql = "select EmitionsCO2Equivalent from [DB_A683D9_figurehead].[dbo].[Emissions];";
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader reader;
            double gg=0;
            con.Open();
            reader = com.ExecuteReader();
            int h = 0;
            while (reader.Read())
            {
                if (h == x) {
                    return gg;
                }
                gg = Convert.ToDouble(reader.GetValue(0));
                h++;
            }
            
            con.Close();
            return 0;
        }
        public double wasteout(int s) { 
        string connectionstring= @"Data Source=SQL5080.site4now.net;Initial Catalog=DB_A683D9_figurehead;User Id=DB_A683D9_figurehead_admin;Password=Figureman1";
            string sql = "select wastearea from [DB_A683D9_figurehead].[dbo].[Waste];";
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader reader;
            int y=0;
            double x=0;
            con.Open();
            reader = com.ExecuteReader();
            while (reader.Read()) {
                x=Convert.ToDouble(reader.GetValue(0));
                if (y == s) {
                    con.Close();
                    return x;
                }
                
                y++;
            }
            con.Close();
            return 0;
            
        }
}
}
