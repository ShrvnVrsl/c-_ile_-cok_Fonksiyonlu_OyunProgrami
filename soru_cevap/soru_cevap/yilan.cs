using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace soru_cevap
{
    class yilan
    {
        yilan_parçalrı[] yilan_Parça;
        int yilan_buyuklugu;
        Yon yonumuz;

        public yilan()
        {
            
            yilan_Parça = new yilan_parçalrı[3];
            yilan_buyuklugu = 3;
            yilan_Parça[0] = new yilan_parçalrı(150, 150);
            yilan_Parça[1] = new yilan_parçalrı(160, 150);
            yilan_Parça[2] = new yilan_parçalrı(170, 150);
        }


        public void ilerle(Yon yon)
        {
            yonumuz = yon;
            if (yon._x == 0 && yon._y == 0)
            {

            }
            else
            {
                for (int i = yilan_Parça.Length - 1; i > 0; i--)
                {
                    yilan_Parça[i] = new yilan_parçalrı(yilan_Parça[i - 1].x_, yilan_Parça[i - 1].y_);

                }
                yilan_Parça[0] = new yilan_parçalrı(yilan_Parça[0].x_ + yon._x, yilan_Parça[0].y_ + yon._y);

            }
        }

        public void Buyu()
        {
            Array.Resize(ref yilan_Parça, yilan_Parça.Length + 1);
            yilan_Parça[yilan_Parça.Length - 1] = new yilan_parçalrı(yilan_Parça[yilan_Parça.Length - 2].x_ - yonumuz._x, yilan_Parça[yilan_Parça.Length - 2].y_ - yonumuz._y);
            yilan_buyuklugu++;
        }

        public Point GetPos(int number)
        {
            return new Point(yilan_Parça[number].x_, yilan_Parça[number].y_);
        }

        public int Yilan_buyuklugu
        {
            get
            {
                return yilan_buyuklugu;
            }
        }
    }



    class yilan_parçalrı
    {

        public int x_;
        public int y_;
        public readonly int size_x;
        public readonly int size_y;
        public yilan_parçalrı(int x, int y)
        {
            x_ = x;
            y_ = y;
            size_x = 10;
            size_y = 10;
        }
    }
    class Yon
    {
        public readonly int _x;
        public readonly int _y;
        
        public Yon(int x, int y)
        {
            _x = x;
            _y = y;
        }
     }
   
}
