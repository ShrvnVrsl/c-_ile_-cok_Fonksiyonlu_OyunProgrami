using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru_cevap
{
    class Araba
    {
        private int _hiz;
        Motor cl_mt;
        public Araba(Motor mt)
        {
            cl_mt = mt;
            hiz = 15;
           
        }

        public int hiz
        {
            get
            {
                return _hiz;
            }
            set
            {
                if (value<=0)
                {
                    _hiz = 0;
                }
                else
                {
                    if (_hiz < cl_mt._max_hiz)
                    {
                        _hiz = value;
                    }
                    else
                    {
                        _hiz = cl_mt._max_hiz - 1;
                    }
                }

               
            }

        }

        public int ivme
        {
            get
            {
                return cl_mt._ivme;
            }
        }

        public int max_hiz
        {
            get
            {
                return cl_mt._max_hiz;
            }
        }

        public int yavaslama
        {
            get
            {
                return cl_mt._yavaslama;
            }
        }
    }
    class Motor
    {
        private int max_hiz;
        private int ivme;
        private int yavaslama;

        public int _max_hiz
        {
            get
            {
                return max_hiz;
            }
            set
            {
                max_hiz = value;
            }
        }

        public int _ivme
        {
            get
            {
                return ivme;
            }
            set
            {
                ivme = value;
            }
        }

        public int _yavaslama
        {
            get
            {
                return yavaslama;
            }
            set
            {
                yavaslama = value;
            }
        }
    }

    class m1 : Motor
    {
        public m1()
        {
            _max_hiz = 130;
            _ivme = 2;
            _yavaslama = 1;
        }
    }

    class m2:Motor
    {
        public m2()
        {
            _max_hiz = 170;
            _ivme = 3;
            _yavaslama = 2;
        }
    }
}
