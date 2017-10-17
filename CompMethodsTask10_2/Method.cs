using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMethodsTask10_2
{
    class Method
    {
        Point currP;
        private double a; //параметр пропорциональности а
        private double b;
        private int maxsteps;//максимальное количество шагов
        
        private double h; //шаг
        private double eps; //контроль шага
        private double eBorder; //контроль выхода на границу
        private double XBorder;
        
        private List<Point> points= new List<Point>(); //массив точек для отрисовки графика
        private List<InfoTable> table_data= new List<InfoTable>(); //массив данных таблицы
        private int step_counter; // Подсчёт шагов
        private int pluscorr_Step;
        private int minuscorr_Step;
       


        public void Init(Point _currP, double _a,double _b, int _maxsteps, double _h, double _eps, double _eBorder,
            double _XBorder,
            int _plus_corr_Step, int _minus_corr_Step) //Сделано
        {
            currP = _currP;
            a = _a;
            b = _b;
            maxsteps = _maxsteps;
            h = _h;
            eps = _eps;
            eBorder = _eBorder;
            XBorder = _XBorder;
            pluscorr_Step = _plus_corr_Step;
            minuscorr_Step = _minus_corr_Step;
            points.Add(currP);
            table_data.Add(new InfoTable(step_counter,h,currP,new CompMethodsTask10_2.Point(0,0,0),0,0,0,0,0,0,0,0));
            step_counter++;
        }

        public void Start()
        {
            while (!NeedStop())
            {
                pluscorr_Step = 0;
                minuscorr_Step = 0;
                double _h = h; // тот h, который нужен для получения новой точки
                Point newpoint = MakeStep(currP, h);
                Point halfpoint = HalfPointM(currP, h);
                double s = Math.Abs(GetS(newpoint, halfpoint));
                double s2 = Math.Abs(GetS2(newpoint, halfpoint));
                double ST = (s < s2) ? s2 : s;
                double err_l = Math.Abs(Math.Pow(2, 2) * ST);
                double corr_v = GetVCorrect(newpoint, ST);
                double corr_v2 = GetV2Correct(newpoint, ST);
                
                if (ST <= eps / (Math.Pow(2, 2)))
                {
                    currP = newpoint;
                    h = 2 * h;
                    pluscorr_Step++;
                    points.Add(newpoint);
                }
                else if( ST > eps )
                {
                    h = h / 2;
                    minuscorr_Step++;
                }
                else
                {
                    currP = newpoint;
                    points.Add(newpoint);
                }
                table_data.Add(new InfoTable(step_counter, _h, currP, halfpoint,err_l, currP.V1 - halfpoint.V1, 
                    currP.V2 - halfpoint.V2,
                    ST, corr_v, corr_v2,  pluscorr_Step, minuscorr_Step));
                step_counter++;
            }
        }

        private double GetVCorrect(Point p, double s) 
        {
            return p.V1 + Math.Pow(2, 2) * s; 
        }

        private double GetV2Correct(Point p, double s)
        {
            return p.V2 + Math.Pow(2, 2) * s;
        }

        private double GetS(Point p1, Point p2)  
        {
            return (p2.V1-p1.V1)/(2.0*2.0-1.0);
        }

        private double GetS2(Point p1, Point p2)  
        {
            return (p2.V2 - p1.V2) / (2.0 * 2.0 - 1.0);
        }

        private Point HalfPointM(Point p, double h) 
        {
            Point _p = MakeStep(p, h / 2.0);
            return MakeStep(_p,h/2.0);
        }

        public bool NeedStop() 
        {
            bool stop = false;
            if (step_counter >= maxsteps || (currP.X + eBorder >= XBorder)) 
                stop = !stop;
            return stop;
        }

        private Point MakeStep(Point p, double h) 
        {
            double pX = GetNextX(p.X, h);
            double pV = GetNextV(p.X,p.V1,p.V2, h);
            double pV2 = GetNextV2(p.X, p.V1,p.V2, h);
            return new Point(pX, pV, pV2);
        }
        private double GetNextX(double x, double h) 
        {
            return (x+h);
        }
        public void Clear()
        {
            points.Clear();
            table_data.Clear();
        }
        private double GetNextV(double x, double v,double v2, double h)
        {
            
            double F = f(x + h / 2.0, v2 + (h / 2.0) * f2(x, v,v2));
            return v + h * F;
        }

        private double GetNextV2(double x, double v, double v2, double h) 
        {

            double F = f2(x + h / 2.0, v + (h / 2.0) * f(x,v2), v2 + (h / 2.0) * f2(x, v, v2));
            return v2 + h * F;
        }

        private double f(double x, double u2) 
        {
            
            return u2; 
        }

        private double f2(double x, double u,double u2)  
        {
            return (-a*u2*u2 - b*u); 
        }

        public List<InfoTable> GetMetodInfos() 
        {
            return table_data;
        }
        public List<Point> GetPoints() 
        {
            return points;
        }

    }
}
