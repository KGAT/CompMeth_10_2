using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMethodsTask10_2
{
    class InfoTable
    {
        public int iter;
        public double integr_step;
        public Point point;
        public Point half_V;
        public double dV;
        public double dV2;

        public double S;
        public double err_loc;
        public double corr_V;
        public double corr_V2;
        public int plus_corr_Step;
        public int minus_corr_Step;

        public InfoTable(int _iter, double _integr_step, Point _point, Point _half_V,double _err_loc,
            double _dV, double _dV2, double _S, double _corr_V, double _corr_V2,  int _plus_corr_Step, int _minus_corr_Step)
        {
            iter = _iter;
            integr_step = _integr_step;
            point = _point;
            half_V = _half_V;
            dV = _dV;
            dV2 = _dV2;
            S = _S;
            err_loc = _err_loc;
            corr_V = _corr_V;
            corr_V2 = _corr_V2;
            plus_corr_Step = _plus_corr_Step;
            minus_corr_Step = _minus_corr_Step;
        }
    }
}
