using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _2deg.Models;
using System.Data.SqlClient;

namespace _2deg.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        Data t;
        public static List<double> Datagaming1(int j)
        {
            List<double> outp = new List<double>();
            string connectionstring = @"Data Source=SQL5080.site4now.net;Initial Catalog=DB_A683D9_figurehead;User Id=DB_A683D9_figurehead_admin;Password=Figureman1"; ;
            string sql = "select Population,PartProvidedWithGas,UrbanPopulation,ValueAddedServices,ValueAddedAgricultureForestryandFishing,ValueAddedManufacturing,NonDairyCows,DairyCows,Pigs,Sheep,Goats,LightVehicals,Busses,Trucks,Cropland1000ha,Forest1000ha,TotalArea1000ha,GrassLands1000ha from [DB_A683D9_figurehead].[dbo].[Proportions];";
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader reader;
            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {
                double Population = Convert.ToDouble(reader.GetValue(j));
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
        public static List<double> emission1()
        {
            string connectionstring = @"Data Source=SQL5080.site4now.net;Initial Catalog=DB_A683D9_figurehead;User Id=DB_A683D9_figurehead_admin;Password=Figureman1";
            string sql = "select EmitionsCO2Equivalent from [DB_A683D9_figurehead].[dbo].[Emissions];";
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader reader;
            double gg = 0;
            List<double> c = new List<double>();
            con.Open();
            reader = com.ExecuteReader();
            int h = 0;
            while (reader.Read())
            {
                gg = Convert.ToDouble(reader.GetValue(0)) ;
                c.Add(gg);
            }

            con.Close();
            return c;
        }
        List<double> emis = emission1();
        List<string> Viewnames = new List<string>();
        List<double> Population = Datagaming1(0);
        List<double> PartProvidedPartProvidedWithGas = Datagaming1(1);
        List<double> UrbanPopulation = Datagaming1(2);
        List<double> ValueAddedServices = Datagaming1(3);
        List<double> ValueAddedAgricultureForestryandFishing = Datagaming1(4);
        List<double> ValueAddedManufacturing =Datagaming1(5);
        List<double> NonDairyCows = Datagaming1(6);
        List<double> DairyCows = Datagaming1(7);
        List<double> Pigs = Datagaming1(8);
        List<double> Sheep = Datagaming1(9);
        List<double> Goats = Datagaming1(10);
        List<double> LightVehicals = Datagaming1(11);
        List<double> Busses = Datagaming1(12);
        List<double> Trucks = Datagaming1(13);
        List<double> Cropland1000ha = Datagaming1(14);
        List<double> Forest1000ha = Datagaming1(15);
        List<double> TotalArea1000ha = Datagaming1(16);
        List<double> GrassLands1000ha = Datagaming1(17);
     
        double cars(int j,Data x)
        {       double e;
                 e = LightVehicals[12] * LightVehicals[13] * LightVehicals[14]+ Busses[12] * Busses[13] * Busses[14]+ Trucks[14] * Trucks[12] * Trucks[13];
            double a, b, c;
            a = (LightVehicals[13] / LightVehicals[12])* LightVehicals[14]* LightVehicals[13]* LightVehicals[j];
            b= (Busses[13] / Busses[12]) * Busses[12] * Busses[13]* Busses[j];
            c = (Trucks[13] / Trucks[12]) * Trucks[12] * Trucks[13]* Trucks[j];
              return emis[9] * ((a + b + c) / e);
          //  return e;
        }

        double Pipeline(int j, Data x) {
            double f=0;
            int p = 0;
            while (p<11) {
                f += Population[p] * PartProvidedPartProvidedWithGas[p];
                p++;
            }
            return emis[11] * (Population[j]* PartProvidedPartProvidedWithGas[j]/f);
        }
        double Residential(int j, Data x)
        {
            double f = 0;
            int p = 0;
            while (p < 11)
            {
                f += Population[p] * PartProvidedPartProvidedWithGas[p];
                p++;
            }
            return emis[13] * (Population[j] * PartProvidedPartProvidedWithGas[j] / f);
        }
        double oilgas(int j,Data x) {
            double f = 0;
            int p = 0;
            while (p < 11)
            {
                f += Population[p] * PartProvidedPartProvidedWithGas[p];
                p++;
            }
            return emis[19] * (Population[j] * PartProvidedPartProvidedWithGas[j] / f);

        }
        double Forest(int j, Data x) {
            return emis[32]*(Forest1000ha[j]/ Forest1000ha[11]);
        }
        double Crop(int j, Data x)
        {
            return emis[33] * (Cropland1000ha[j] / Cropland1000ha[11]);
        }
        double Grass(int j,Data x) {

            return emis[34] * (GrassLands1000ha[j] / GrassLands1000ha[11]);
        }
        double Enteric(int j, Data x)
        {

            return emis[30] * (((NonDairyCows[j]/ NonDairyCows[15])+ (DairyCows[j] / DairyCows[15])+ (Pigs[j] / Pigs[15])+ (Sheep[j] / Sheep[15])+ (Goats[j] / Goats[15])) / ((NonDairyCows[11]/ NonDairyCows[15])+ (DairyCows[11] / DairyCows[15])+ (Sheep[11] / Sheep[15])+ (Goats[11] / Goats[15])));
        }

        double otherprodman(int j,Data x) {
            return emis[28]*(Population[j]/ Population[11]);
        
        }
        double ods(int j, Data x) {

            return emis[27] * (Population[j]/ Population[11]);
        }
 //       double nonen(int j,Data x) {
 //           return x.emission(27) * (x.Datagaming()[j]/x.Datagaming()[11]);
 //       }
        double agri(int j, Data x) {
            return emis[33] * (Cropland1000ha[j]/ Cropland1000ha[11]);
        }
        double manu(int j,Data x) {
            return emis[7] * (ValueAddedServices[j]/ ValueAddedServices[11]);
        }
        double stat(int j,Data x)
        {
            return emis[15] * (ValueAddedAgricultureForestryandFishing[j] / ValueAddedAgricultureForestryandFishing[11]);

        }
        double services(int j, Data x) {
            return emis[12] * (ValueAddedServices[j]/ ValueAddedServices[11]);
        }
        double solidwaste(int j,Data x) {
            return emis[36] * (x.wasteout(j) / x.wasteout(11));
}
        double waterdom(int j, Data x) {
            return emis[37] * (x.wasteout(j)/x.wasteout(11));
        }
        double waternodom(int j, Data x) {
            return emis[38] * (x.wasteout(j) / x.wasteout(11));
        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            Region m = new Region();
            return View(m);
        }
        [HttpPost]
        public IActionResult Index(Region m)
        { 
    /*     string connectionstring = @"Data Source=SQL5080.site4now.net;Initial Catalog=DB_A683D9_figurehead;User Id=DB_A683D9_figurehead_admin;Password=Figureman1";;
        string sql = "select Population,PartProvidedWithGas,UrbanPopulation,ValueAddedServices,ValueAddedAgricultureForestryandFishing,ValueAddedManufacturing,NonDairyCows,DairyCows,Pigs,Sheep,Goats,LightVehicals,Busses,Trucks,Cropland1000ha,Forest1000ha,TotalArea1000ha,GrassLands1000ha from Proportions";
        SqlConnection con = new SqlConnection(connectionstring);
        SqlCommand com = new SqlCommand(sql,con);
        SqlDataReader reader;
        con.Open();
            int j = 1;
            reader = com.ExecuteReader();
            while (reader.Read()) {
                Samegrelozemosvaneti.Add(Convert.ToDouble(reader.GetValue(j)));
                Imereti.Add(Convert.ToDouble(reader.GetValue(j+1)));
                Samcxejavaxeti.Add(Convert.ToDouble(reader.GetValue(j+2)));
                Shidaqartli.Add(Convert.ToDouble(reader.GetValue(j+3)));
                Qvemoqartli.Add(Convert.ToDouble(reader.GetValue(j+4)));
                Guria.Add(Convert.ToDouble(reader.GetValue(j+5)));
                Kaxeti.Add(Convert.ToDouble(reader.GetValue(j+6)));
                Mcxetamtianeti.Add(Convert.ToDouble(reader.GetValue(j+7)));
                Rachalechxumidaqvemosvani.Add(Convert.ToDouble(reader.GetValue(j+8)));
                Achara.Add(Convert.ToDouble(reader.GetValue(j+9)));
                Tbilisi.Add(Convert.ToDouble(reader.GetValue(j+10)));
                Sum.Add(Convert.ToDouble(reader.GetValue(j+11)));
                j++;
            }*/
            
       /* con.Close();*/
            Viewnames.Add("afxazeti");
            Viewnames.Add("achata");
            Viewnames.Add("guria");
            Viewnames.Add("imereti");
            Viewnames.Add("kaxeti");
            Viewnames.Add("mcxetamtianeti");
            Viewnames.Add("oseti");
            Viewnames.Add("qvemoqartli");
            Viewnames.Add("rachalechxumidaqvemowartli");
            Viewnames.Add("samcxejavaxeti");
            Viewnames.Add("samegrelozemosvaneti");
            Viewnames.Add("shidaqartli");
            Viewnames.Add("tbilisi");
            m.Formatname();

            bool checker=false;
            for (int i = 0; i < Viewnames.Count(); i++) {
                if (m.name == Viewnames[i])
                {
                    checker = true;
                }
            
            
            }
            if(checker)
                return View(m.name);

            return View("Privacy");
            
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Route("/Afxazeti")]
        public IActionResult afxazeti()
        {

            return View();
        }
        [Route("/Samegrelozemosvaneti")]
        public IActionResult samegrelozemosvaneti(Data modeli)
        {
            modeli.output = Menuer(0, modeli);
            modeli.output1 = Forest(0,modeli);
            modeli.output2 = Crop(0,modeli);
            modeli.output3 = Grass(0, modeli);
            modeli.output4 = Enteric(0, modeli);
            modeli.output5 = otherprodman(0,modeli);
            modeli.output6 = ods(0, modeli);
            modeli.output8 = modeli.emission(13)/2;
            modeli.output11 = agri(0,modeli);
            modeli.output12 = manu(0,modeli);
            modeli.output13 = Pipeline(0,modeli);
            modeli.output14 = Residential(0,modeli);
            modeli.output15 = oilgas(0, modeli);
            modeli.output16 = stat(0,modeli);
            modeli.output17 = services(0,modeli);
            modeli.output18 = solidwaste(0, modeli);
            modeli.output19 = waterdom(0, modeli);
            modeli.output20 = waternodom(0, modeli);
            modeli.output21 = cars(0, modeli);
            modeli.Sum= modeli.output+modeli.output1+modeli.output2+modeli.output3+modeli.output4+modeli.output5+modeli.output6+modeli.output8+modeli.output11+modeli.output12+modeli.output13+modeli.output14+modeli.output15+modeli.output16+modeli.output17+modeli.output18+modeli.output19+modeli.output20;
            return View(modeli);

        }

        [Route("/Guria")]
        public IActionResult guria(Data modeli)
        {
            modeli.output = Menuer(5, modeli);
            modeli.output1 = Forest(5, modeli);
            modeli.output2 = Crop(5, modeli);
            modeli.output3 = Grass(5, modeli);
            modeli.output4 = Enteric(5, modeli);
            modeli.output5 = otherprodman(5, modeli);
            modeli.output6 = ods(5, modeli);
            modeli.output11 = agri(5, modeli);
            modeli.output12 = manu(5, modeli);
            modeli.output13 = Pipeline(5, modeli);
            modeli.output14 = Residential(5, modeli);
            modeli.output15 = oilgas(5, modeli);
            modeli.output16 = stat(5, modeli);
            modeli.output17 = services(5, modeli);
            modeli.output18 = solidwaste(5, modeli);
            modeli.output19 = waterdom(5, modeli);
            modeli.output20 = waternodom(5, modeli);
            modeli.output21 = cars(5, modeli);
            modeli.Sum = modeli.output + modeli.output1 + modeli.output2 + modeli.output3 + modeli.output4 + modeli.output5 + modeli.output6 + modeli.output11 + modeli.output21 + modeli.output12 + modeli.output13 + modeli.output14 + modeli.output15 + modeli.output16 + modeli.output17 + modeli.output18 + modeli.output19 + modeli.output20;
            return View(modeli);
        }
        
        /*       public IActionResult achara()
               {
                   Data modeli = new Data();
                   return View(modeli);
               }*/
        double Menuer(int j,Data x) {
            return x.emission(30)*(NonDairyCows[j] + x.Datagaming(7)[j] + x.Datagaming(8)[j] + x.Datagaming(9)[j] + x.Datagaming(10)[j]) / (NonDairyCows[11] + x.Datagaming(7)[11] + x.Datagaming(8)[11] + x.Datagaming(9)[11] + x.Datagaming(10)[11]);
        }
        [Route("/Achara")]
        public IActionResult achara(Data modeli)
        {
            modeli = new Data();
            modeli.output = Menuer(9,modeli);
            modeli.output1 = Forest(9, modeli);
            modeli.output2 = Crop(9, modeli);
            modeli.output3 = Grass(9, modeli);
            modeli.output4 = Enteric(9, modeli);
            modeli.output5 = otherprodman(9, modeli); 
            modeli.output6 = ods(9, modeli);
            modeli.output7 = modeli.emission(11) / 2;
            modeli.output8 = modeli.emission(13) / 2;
            modeli.output11 = agri(9, modeli);
            modeli.output12 = manu(9, modeli);
            modeli.output13 = Pipeline(9, modeli);
            modeli.output14 = Residential(9, modeli);
            modeli.output15 = oilgas(9, modeli);
            modeli.output16 = stat(9, modeli);
            modeli.output17 = services(9, modeli);
            modeli.output18 = solidwaste(9, modeli);
            modeli.output19 = waterdom(9, modeli);
            modeli.output20 = waternodom(9, modeli);
            modeli.output21 = cars(9, modeli);
            modeli.Sum = modeli.output7+modeli.output8+modeli.output + modeli.output1 + modeli.output2 + modeli.output3 + modeli.output4 + modeli.output5 + modeli.output6 + modeli.output11 + modeli.output21 + modeli.output12 + modeli.output13 + modeli.output14 + modeli.output15 + modeli.output16 + modeli.output17 + modeli.output18 + modeli.output19 + modeli.output20;
            return View(modeli);
        }
        [Route("/Rachalechxumidaqvemosvaneti")]
        public IActionResult rachalechxumidaqvemosvaneti(Data modeli)
        {
            modeli.output = Menuer(8, modeli);
            modeli.output1 = Forest(8, modeli);
            modeli.output2 = Crop(8, modeli);
            modeli.output3 = Grass(8, modeli);
            modeli.output4 = Enteric(8, modeli);
            modeli.output5 = otherprodman(8, modeli);
            modeli.output6 = ods(8, modeli);
            modeli.output11 = agri(8, modeli);
            modeli.output12 = manu(8, modeli);
            modeli.output13 = Pipeline(8, modeli);
            modeli.output14 = Residential(8, modeli);
            modeli.output15 = oilgas(8, modeli);
            modeli.output16 = stat(8, modeli);
            modeli.output17 = services(8, modeli);
            modeli.output18 = solidwaste(8, modeli);
            modeli.output19 = waterdom(8, modeli);
            modeli.output20 = waternodom(8, modeli);
            modeli.output21 = cars(8, modeli);
            modeli.Sum = modeli.output + modeli.output1 + modeli.output2 + modeli.output3 + modeli.output4 + modeli.output5 + modeli.output6+modeli.output11 + modeli.output12 + modeli.output13 + modeli.output14 + modeli.output15 + modeli.output16 + modeli.output17 + modeli.output18 + modeli.output19 + modeli.output20 + modeli.output21;
            return View(modeli);

        }
        [Route("/Imereti")]
        public IActionResult imereti(Data modeli)
        {
            modeli.output = Menuer(1, modeli);
            modeli.output1 = Forest(1, modeli);
            modeli.output2 = Crop(1, modeli);
            modeli.output3 = Grass(1,modeli);
            modeli.output4 = Enteric(1, modeli);
            modeli.output5 = otherprodman(1, modeli);
            modeli.output6 = ods(1, modeli);
            modeli.output7 = modeli.emission(7);
            modeli.output10 = modeli.emission(21);
            modeli.output11 = agri(1,modeli);
            modeli.output12 = manu(1, modeli);
            modeli.output13 = Pipeline(1, modeli);
            modeli.output14 = Residential(1, modeli);
            modeli.output15 = oilgas(1, modeli);
            modeli.output16 = stat(1, modeli);
            modeli.output17 = services(1, modeli);
            modeli.output18 = solidwaste(1, modeli);
            modeli.output19 = waterdom(1, modeli);
            modeli.output20 = waternodom(1, modeli);
            modeli.output21 = cars(1, modeli);
            modeli.output22 = emis[21]*0.6;
            modeli.output23 = emis[23] * 0.2;
                        modeli.Sum = modeli.output + modeli.output1 + modeli.output2 + modeli.output3 + modeli.output4 + modeli.output5 + modeli.output6 +modeli.output7+modeli.output10+modeli.output11 + modeli.output12 + modeli.output13 + modeli.output14 + modeli.output15 + modeli.output16 + modeli.output17 + modeli.output18 + modeli.output19 + modeli.output20 + modeli.output21+modeli.output22+modeli.output23;
            return View(modeli);

        }
        [Route("/Samcxejavaxeti")]
        public IActionResult samcxejavaxeti(Data modeli)
        {
            modeli.output = Menuer(2, modeli);
            modeli.output1 = Forest(2, modeli);
            modeli.output2 = Crop(2, modeli);
            modeli.output3 = Grass(2, modeli);
            modeli.output4 = Enteric(2, modeli);
            modeli.output5 = otherprodman(2, modeli);
            modeli.output6 = ods(2, modeli);
            modeli.output11 = agri(2, modeli);
            modeli.output12 = manu(2, modeli);
            modeli.output13 = Pipeline(2, modeli);
            modeli.output14 = Residential(2, modeli);
            modeli.output15 = oilgas(2, modeli);       
            modeli.output16 = stat(2, modeli);
            modeli.output17 = services(2, modeli);
            modeli.output18 = solidwaste(2, modeli);
            modeli.output19 = waterdom(2, modeli);
            modeli.output20 = waternodom(2, modeli);
            modeli.output21 = cars(2, modeli);
            modeli.Sum = modeli.output + modeli.output1 + modeli.output2 + modeli.output3 + modeli.output4 + modeli.output5 + modeli.output6 + modeli.output11 + modeli.output12 + modeli.output13 + modeli.output14 + modeli.output15 + modeli.output16 + modeli.output17 + modeli.output18 + modeli.output19 + modeli.output20 + modeli.output21;
            
            return View(modeli);

        }
        [Route("/Shidaqartli")]
        public IActionResult shidaqartli(Data modeli)
        {
            modeli.output = Menuer(3, modeli);
            modeli.output1 = Forest(3, modeli);
            modeli.output2 = Crop(3, modeli);
            modeli.output3 = Grass(3, modeli);
            modeli.output4 = Enteric(3, modeli);
            modeli.output5 = otherprodman(3, modeli);
            modeli.output6 = ods(3, modeli);
            modeli.output11 = agri(3, modeli);
            modeli.output12 = manu(3, modeli);
            modeli.output13 = Pipeline(3, modeli);
            modeli.output14 = Residential(3, modeli);
            modeli.output15 = oilgas(3, modeli);
            modeli.output16 = stat(3, modeli);
            modeli.output17 = services(3, modeli);
            modeli.output18 = solidwaste(3, modeli);
            modeli.output19 = waterdom(3, modeli);
            modeli.output20 = waternodom(3, modeli);
            modeli.output21 = cars(3, modeli);
             modeli.Sum = modeli.output + modeli.output1 + modeli.output2 + modeli.output3 + modeli.output4 + modeli.output5 + modeli.output6+ modeli.output11 + modeli.output12 + modeli.output13 + modeli.output14 + modeli.output15 + modeli.output16 + modeli.output17 + modeli.output18 + modeli.output19 + modeli.output20 + modeli.output21;
            
            return View(modeli);

        }
        [Route("/Qvemoqartli")]
        public IActionResult qvemoqartli(Data modeli)
        {
            modeli.output = Menuer(4, modeli);
            modeli.output1 = Forest(4, modeli);
            modeli.output2 = Crop(4, modeli);
            modeli.output3 = Grass(4, modeli);
            modeli.output4 = Enteric(4, modeli);
            modeli.outputm = modeli.emission(25);
            modeli.output5 = otherprodman(4, modeli);
            modeli.output6 = ods(4, modeli);
            modeli.output9 = modeli.emission(6);
            modeli.output11 = agri(4, modeli);
            modeli.output12 = manu(4, modeli);
            modeli.output13 = Pipeline(4, modeli);
            modeli.output14 = Residential(4, modeli);
            modeli.output15 = oilgas(4, modeli);
            modeli.output16 = stat(4, modeli);
            modeli.output17 = services(4, modeli);
            modeli.output18 = solidwaste(4, modeli);
            modeli.output19 = waterdom(4, modeli);
            modeli.output20 = waternodom(4, modeli);
            modeli.output21 = cars(4, modeli);
            modeli.output22 = emis[21] * 0.3;
            modeli.output23 = emis[23] * 0.2;
             modeli.Sum = modeli.outputm+modeli.output9+modeli.output + modeli.output1 + modeli.output2 + modeli.output3 + modeli.output4 + modeli.output5 + modeli.output6 + modeli.output11 + modeli.output12 + modeli.output13 + modeli.output14 + modeli.output15 + modeli.output16 + modeli.output17 + modeli.output18 + modeli.output19 + modeli.output20 + modeli.output21 + modeli.output22 + modeli.output23;
            
            return View(modeli);

        }
        [Route("/Tbilisi")]
        public IActionResult tbilisi(Data modeli)
        {
            modeli.output = Menuer(10, modeli);
            modeli.output1 = Forest(10, modeli);
            modeli.output2 = Crop(10, modeli);
            modeli.output3 = Grass(10, modeli);
            modeli.output4 = Enteric(10, modeli);
            modeli.output5 = otherprodman(10, modeli);
            modeli.output6 = ods(10, modeli);
            modeli.output7 = modeli.emission(11) / 2;
            modeli.output11 = agri(10, modeli);
            modeli.output12 = manu(10, modeli);
            modeli.output13 = Pipeline(10, modeli);
            modeli.output14 = Residential(10, modeli);
            modeli.output15 = oilgas(10, modeli);
            modeli.output16 = stat(10, modeli);
            modeli.output17 = services(10, modeli);
            modeli.output18 = solidwaste(10, modeli);
            modeli.output19 = waterdom(10, modeli);
            modeli.output20 = waternodom(10, modeli);
            modeli.output21 = cars(10, modeli);
             modeli.Sum = modeli.output + modeli.output1 + modeli.output2 + modeli.output3 + modeli.output4 + modeli.output5 + modeli.output6 + modeli.output7 + modeli.output11 + modeli.output12 + modeli.output13 + modeli.output14 + modeli.output15 + modeli.output16 + modeli.output17 + modeli.output18 + modeli.output19 + modeli.output20 + modeli.output21;
            
            return View(modeli);

        }
        [Route("/Oseti")]
        public IActionResult oseti()
        {
            
            return View();
        }
        [Route("/Mcxetamtianeti")]
        public IActionResult mcxetamtianeti(Data modeli)
        {
            modeli.output = Menuer(7, modeli);
            modeli.output1 = Forest(7, modeli);
            modeli.output2 = Crop(7, modeli);
            modeli.output3 = Grass(7, modeli);
            modeli.output4 = Enteric(7, modeli);
            modeli.output5 = otherprodman(7, modeli);
            modeli.output6 = ods(7, modeli);
            modeli.output11 = agri(7, modeli);
            modeli.output12 = manu(7, modeli);
            modeli.output13 = Pipeline(7, modeli);
            modeli.output14 = Residential(7, modeli);
            modeli.output15 = oilgas(7, modeli);
            modeli.output16 = stat(7, modeli);
            modeli.output17 = services(7, modeli);
            modeli.output18 = solidwaste(7, modeli);
            modeli.output19 = waterdom(7, modeli);
            modeli.output20 = waternodom(7, modeli);
            modeli.output21 = cars(7, modeli);
            modeli.Sum = modeli.output + modeli.output1 + modeli.output2 + modeli.output3 + modeli.output4 + modeli.output5 + modeli.output6 + modeli.output11 + modeli.output12 + modeli.output13 + modeli.output14 + modeli.output15 + modeli.output16 + modeli.output17 + modeli.output18 + modeli.output19 + modeli.output20 + modeli.output21;
            
            return View(modeli);

        }
        [Route("/Kaxeti")]
        public IActionResult kaxeti(Data modeli)
        {
            modeli.output = Menuer(6, modeli);
            modeli.output1 = Forest(6, modeli);
            modeli.output2 = Crop(6, modeli);
            modeli.output3 = Grass(6, modeli);
            modeli.output4 = Enteric(6, modeli);
            modeli.output5 = otherprodman(6, modeli);
            modeli.output6 = ods(6, modeli);
            modeli.output11 = agri(6, modeli);
            modeli.output12 = manu(6, modeli);
            modeli.output13 = Pipeline(6, modeli);
            modeli.output14 = Residential(6, modeli);
            modeli.output15 = oilgas(6, modeli);
            modeli.output16 = stat(6, modeli);
            modeli.output17 = services(6, modeli);
            modeli.output18 = solidwaste(6, modeli);
            modeli.output19 = waterdom(6, modeli);
            modeli.output20 = waternodom(6, modeli);
            modeli.output21 = cars(6, modeli);
                        modeli.Sum = modeli.output + modeli.output1 + modeli.output2 + modeli.output3 + modeli.output4 + modeli.output5 + modeli.output6+ modeli.output11 + modeli.output12 + modeli.output13 + modeli.output14 + modeli.output15 + modeli.output16 + modeli.output17 + modeli.output18 + modeli.output19 + modeli.output20 + modeli.output21;
            return View(modeli);

        }
    }
}
