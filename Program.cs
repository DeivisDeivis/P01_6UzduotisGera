using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P01_6Uzduotis
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //Console.Write("Iveskite 1 sienos ilgi ");
            //double ilgis1 = double.Parse(Console.ReadLine());

            //Console.Write("Iveskite 1 sienos ploti ");
            //double plotis1 = double.Parse(Console.ReadLine());

            //Console.Write("Iveskite 2 sienos ilgi ");
            //double ilgis2 = double.Parse(Console.ReadLine());

            //Console.Write("Iveskite 2 sienos ploti");
            //double plotis2 = double.Parse(Console.ReadLine());

            //Console.Write("Iveskite 3 sienos ilgi");
            //double ilgis3 = double.Parse(Console.ReadLine());

            //Console.Write("Iveskite 3 sienos ploti ");
            //double plotis3 = double.Parse(Console.ReadLine());

            //Console.Write("Iveskite 4 sienos ilgi ");
            //double ilgis4 = double.Parse(Console.ReadLine());

            //Console.Write("Iveskite 4 sienos plotiS ");
            //double plotis4 = double.Parse(Console.ReadLine());


            namas Namas = new namas(8, 4, 7, 6, 5, 6, 7, 9);

            double visosvidinesplytos = ApskaiciuotiVidinesPlytas(Namas) ;
            double visosisorinesplytos = ApskaiciuotiIsorinesPlytas(Namas);

            Console.WriteLine("Visos reikalingos vidines plytos");
            Console.WriteLine();
            Console.WriteLine(visosvidinesplytos);
            Console.WriteLine("Visos reikalingos isorines plytos");
            Console.WriteLine();
            Console.WriteLine(visosisorinesplytos);

      
        }
        public static double ApskaiciuotiIsorinesPlytas(namas Namas)
        {
            double plotas1 = (Namas.getIlgis1() * Namas.getPlotis1()) * 2; 
            double plotas2 = (Namas.getIlgis2() * Namas.getPlotis2()) * 2; 
            double plotas3 = (Namas.getIlgis3() * Namas.getPlotis3()) * 2;  
            double plotas4 = (Namas.getIlgis4() * Namas.getPlotis4()) * 2; 

            double VisasIsorinisPlotas = plotas1 + plotas2 + plotas3 + plotas4;
            double VisosIsorinesPlytos = VisasIsorinisPlotas / (Namas.getPlytos_storis() * Namas.getIsorinesPlytosplotas());

            return VisosIsorinesPlytos;
        }
        public static double ApskaiciuotiVidinesPlytas(namas Namas)
        {
            double VidinisPlotas = (Namas.getIlgis1() - 4) * (Namas.getPlotis1() - 4) + (Namas.getIlgis2() - 4) * (Namas.getPlotis2() - 4) +
            (Namas.getIlgis3() - 4) * (Namas.getPlotis3() - 4) + (Namas.getIlgis4() - 4) * (Namas.getPlotis4() - 4);

            double VisosVidinesPlytos = VidinisPlotas / (Namas.getPlytos_storis() * Namas.getIsorinesPlytosplotas());

            return VisosVidinesPlytos;
        }
    }

    class namas
    {
        private double ilgis1, ilgis2, ilgis3, ilgis4, plotis1, plotis2, plotis3, plotis4;
        private int plytos_storis = 2;
        private double isorinesplytosplotas = 0.5;

        public namas(double len1, double hgt1, double len2, double hgt2, double len3, double hgt3, double len4, double hgt4)
        {
            ilgis1 = len1;
            plotis1 = hgt1;
            ilgis2 = len2;
            plotis2 = hgt2;
            ilgis3 = len3;
            plotis3 = hgt3;
            ilgis4 = len4;
            plotis4 = hgt4;

        }

        /*public double ApskaiciuotiIsorinesPlytas()
        {
            double plotas1 = (ilgis1 * plotis1) * 2; // Two sides of the first wall
            double plotas2 = (ilgis2 * plotis2) * 2; // Two sides of the second wall
            double plotas3 = (ilgis3 * plotis3) * 2; // Two sides of the third wall
            double plotas4 = (ilgis4 * plotis4) * 2; // Two sides of the fourth wall

            double VisasIsorinisPlotas = plotas1 + plotas2 + plotas3 + plotas4;
            double VisosIsorinesPlytos = VisasIsorinisPlotas / (plytos_storis * isorinesplytosplotas);

            return VisosIsorinesPlytos;
        }
        public double ApskaiciuotiVidinesPlytas()
        {

            double VidinisPlotas = (ilgis1 - 4) * (plotis1 - 4) + (ilgis2 - 4) * (plotis2 - 4) +
                              (ilgis3 - 4) * (plotis3 - 4) + (ilgis4 - 4) * (plotis4 - 4);

            double VisosVidinesPlytos = VidinisPlotas / (plytos_storis * isorinesplytosplotas);

            return VisosVidinesPlytos;
        }*/
public int getPlytos_storis() { return plytos_storis; }
public double getIsorinesPlytosplotas() { return isorinesplytosplotas; }
        public double getIlgis1() { return ilgis1; }

            
public double getIlgis2() { return ilgis2;}
public double getIlgis3() {  return ilgis3;}
        public double getIlgis4() {  return ilgis4;}
        public double getPlotis1() { return plotis1; }
        public double getPlotis2() {  return plotis2; }
            public double getPlotis3() {  return plotis3; }
        public double getPlotis4() {  return plotis4; }
    }
}
