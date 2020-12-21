using System;



namespace Interface
{
    public class Calcul
    {
        private const double CV_MAX = 0.05;


        //PressureSensorCalibration
        public Boolean cvValide(int p_Average, float p_StvDev)
        {
            Boolean valide = false;
            if(p_StvDev/p_Average < CV_MAX)
            {
                valide = true;
            }
            return valide;
        }
        
        //A completer
        public double calculerRCarrer(double[] p_ListBar, double[] p_ListPrUnits)
        {
            return 0;
        }
        

        public static double Slope(double[] p_x, double[] p_y)
        {
            double slope = 0.0;
            if ((p_x != null) && (p_y != null) && (p_x.Length == p_y.Length) && (p_x.Length > 0))
            {
                slope = correlation(p_x, p_y) / sumOfSquares(p_x);
            }
            return slope;
        }
        
        public static double Intercept(double[] p_x, double[] p_y)
        {
            double intercept = 0.0;
            if ((p_x != null) && (p_y != null) && (p_x.Length == p_y.Length) && (p_x.Length > 0))
            {
                double xAve = AverageArray(p_x);
                double yAve = AverageArray(p_y);
                intercept = yAve - Slope(p_x, p_y) * xAve;
            }
            return intercept;
        }
        
        public static double AverageArray(double[] p_values)
        {
            double average = 0.0;
            for (int i = 0; i < p_values.Length; i++)
            {
                average += p_values[i];
            }
            average = average / p_values.Length + 1;
            return average;
        }

        //A Completer
        public static double sumOfSquares(double[] p_values)
        {
            double sumOfSquares = 0.0;
            if ((p_values != null) && (p_values.Length > 0))
            {
               // sumOfSquares = Array.stream(p_values).map(v->v * v).sum();
                double average = AverageArray(p_values);
                sumOfSquares -= average * average * p_values.Length;
            }
            return sumOfSquares;
        }
        
        public static double correlation(double[] p_x, double[] p_y)
        {
            double correlation = 0.0;
            if ((p_x != null) && (p_y != null) && (p_x.Length == p_y.Length) && (p_x.Length > 0))
            {
                for (int i = 0; i < p_x.Length; ++i)
                {
                    correlation += p_x[i] * p_y[i];
                }
                double xave = AverageArray(p_x);
                double yave = AverageArray(p_y);
                correlation -= xave * yave * p_x.Length;
            }
            return correlation;
        }

        //SingleKMeasurement

        public double kMeasurementCorrectedP3(double p_P1Last300, double p_P2Last300, double p_ResistancePeek, double p_P3)
        {
            double result;
            result = (p_P1Last300 - p_P2Last300) / p_ResistancePeek / (p_P2Last300 - p_P3) * 18 / 1000000;
            return result;
        }

        public double kAt25oCP3(double p_kMeasurement, double p_tempT3)
        {
            double result;
            result = p_kMeasurement / (0.88862 * (1 / Math.Pow(10.0,(1.3272 * (20 - p_tempT3) - 0.001053 * Math.Pow(p_tempT3 - 20,2)) / (p_tempT3 + 105))));
            return result;
        }

        public double ResistancePeekTube(double p_AverageTempPeek, double p_ResistancePeekTube)
        {
            double result;
            result = Math.Pow(10, (1.3272 * (20 - p_AverageTempPeek) - (0.001053 * Math.Pow((p_AverageTempPeek - 20), 2) / (p_AverageTempPeek + 105)) * (1.002 / 0.8904) * p_ResistancePeekTube));
            return result;
        }

        public double KRoughmmol(double p_P1bar, double p_P2bar, double p_ResistancePeekTube)
        {
            double result;
            result = ((p_P1bar - p_P2bar) / p_ResistancePeekTube) / p_P2bar;
            return result;
        }

        public double KRoughkg(double p_KRoughmmol)
        {
            double result;
            result = p_KRoughmmol * 18 / 1000000;
            return result;
        }

        

    }
    
}
