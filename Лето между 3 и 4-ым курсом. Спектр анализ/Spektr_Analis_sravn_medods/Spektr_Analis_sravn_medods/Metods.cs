using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Numerics;

namespace Spektr_Analis_sravn_medods
{
    class Metods
    {
        // использование крипторандома
        //private RNGCryptoServiceProvider random = new RNGCryptoServiceProvider();

        private Random random = new Random();

        // ДПФ
        public double[,] DPF_with_okna(double[,] signal, int _N_one_period, int _n_periods, double _fn, string okno, bool _otsechca, double _zzz)
        {
            if (_otsechca)
            {
                int N = _N_one_period * _n_periods; //определение колличества точек
                int N_garmonic = Convert.ToInt32(N / 2) + 1;
                double[,] spectr = new double[Convert.ToInt32(N / 2) + 1, 3];  // переменная сразу для спектра
                                                                               // иницилизация переменных по осям
                double x = new double();
                double y = new double();
                // операции связанные с окном
                double[,] _signal = signal_okno(signal, N, okno, _zzz);
                double gain = Gain_okno(N, okno, _zzz);

                // сам ДПФ
                for (int i = 0; i < N_garmonic; i++) // номер гармоники
                {
                    x = 0; y = 0;
                    for (int j = 0; j < N; j++)   // перебор по членам масива
                    {
                        x = x + _signal[j, 1] * X_cos(i, j, N);
                        y = y + _signal[j, 1] * Y_sin(i, j, N);
                    }
                    spectr[i, 0] = i * _fn / _n_periods;
                    spectr[i, 1] = Math.Sqrt(x * x + y * y) / gain * 2;
                    spectr[i, 2] = Math.Atan2(y, x) * 180 / Math.PI;
                }
                spectr[0, 1] = spectr[0, 1] / 2;

                return spectr;
            }
            else
            {
                int N = _N_one_period * _n_periods; //определение колличества точек
                int N_garmonic = N;
                double[,] spectr = new double[N, 3];  // переменная сразу для спектра
                                                      // иницилизация переменных по осям
                double x = new double();
                double y = new double();
                // операции связанные с окном
                double[,] _signal = signal_okno(signal, N, okno, _zzz);
                double gain = Gain_okno(N, okno, _zzz);

                // сам ДПФ
                for (int i = 0; i < N_garmonic; i++) // номер гармоники
                {
                    x = 0; y = 0;
                    for (int j = 0; j < N; j++)   // перебор по членам масива
                    {
                        x = x + _signal[j, 1] * X_cos(i, j, N);
                        y = y + _signal[j, 1] * Y_sin(i, j, N);
                    }
                    spectr[i, 0] = i * _fn / _n_periods;
                    spectr[i, 1] = Math.Sqrt(x * x + y * y) / gain * 2;
                    spectr[i, 2] = Math.Atan2(y, x) * 180 / Math.PI;
                }
                spectr[0, 1] = spectr[0, 1] / 2;


                return spectr;
            }
        }


        // ДПФ работающий с одной гармоникой

        public double[,] DPF_with_okna(int nGarmonic, double[,] signal, int _N_one_period, int _n_periods, double _fn, string okno, double _zzz)
        {
            int N = _N_one_period * _n_periods; //определение колличества точек
            double[,] spectr = new double[1, 3];  // переменная сразу для спектра
                                                  // иницилизация переменных по осям
            double x = new double();
            double y = new double();
            // операции связанные с окном
            double[,] _signal = signal_okno(signal, N, okno, _zzz);
            double gain = Gain_okno(N, okno, _zzz);

            // сам ДПФ
            x = 0; y = 0;
            for (int j = 0; j < N; j++)   // перебор по членам масива
            {
                x = x + _signal[j, 1] * X_cos(nGarmonic * _n_periods, j, N);
                y = y + _signal[j, 1] * Y_sin(nGarmonic * _n_periods, j, N);
            }
            spectr[0, 0] = nGarmonic;
            spectr[0, 1] = Math.Sqrt(x * x + y * y) / gain * 2;
            spectr[0, 2] = Math.Atan2(y, x) * 180 / Math.PI;


            return spectr;
        }



        // БПФ по основанию 2
        // вызываемый метод
        public double[,] fft(double[,] signal, int N, double _fn, int _n_periods, string okno, double _zzz,string f_0)
        {
            Complex[] signal_comlex = fft_okno(signal, N, okno, _zzz);
            if (f_0 == "с дополнением 0-ми")
            {
                signal_comlex = fft_0(signal_comlex);
            }
            double[,] spectr = fft_spectr(fft_rasch(signal_comlex), N, _n_periods, _fn, okno, _zzz);
            return spectr;
        }

        private Complex[] fft_0(Complex[] _signal)
        {
            // определяем количество элементов (строк)
            int n_fft = _signal.Length;
            // создаём переменную характеризующую степень
            byte k = 0;
            // определяем при каком k функция степенная функция станет больше колличества
            while (Math.Pow(2, k) < n_fft)
            {
                k++;
            }

            // проверяем, имеет данное количество элементов основание 2
            if (Math.Pow(2, k) == _signal.Length)
            {
                return _signal;
            }
            // если нет, то дополняем 0-ми
            else
            {
                Complex[] new_signal = new Complex[(int)Math.Pow(2, k)];
                // определяем сколько 0-ей нужно добавить
                n_fft = (int)Math.Pow(2, k) - n_fft;
                // поместим исходный сигнал в центр

                // считаем количество нулей добавляемых слева
                int n_fft_left = (int)(n_fft / 2);

                for (int i = 0; i < n_fft_left; i++)
                {
                    new_signal[i] = 0;
                }
                // добавление самого сигнала
                for (int i = 0; i < _signal.Length; i++)
                {
                    new_signal[i + n_fft_left] = _signal[i];
                }
                // добавление нулей справа
                for (int i = _signal.Length + n_fft_left; i < (int)Math.Pow(2, k); i++)
                {
                    new_signal[i] = 0;
                }

                return new_signal;
            }

        }

        // подготовка сигнала к передаче в БПФ + обработка окном
        private Complex[] fft_okno(double[,] signal, int N, string okno, double _zzz)
        {
            // операции связанные с окном
            double[,] _signal = signal_okno(signal, N, okno, _zzz);
            Complex [] Co_signal = new Complex[N];
            for (int i = 0; i < N; i++)
            {
                //Co_signal[i] = new Complex(_signal[i, 1],0);
                Co_signal[i] = _signal[i, 1];
            }

            return Co_signal;
        }

        /// Вычисление поворачивающего модуля e^(-i*2*PI*k/N)
        private static Complex w(int k, int N)
        {
            if (k % N == 0) return 1;
            double arg = - 2 * Math.PI * k / N;
            // return new Complex(Math.Cos(arg), Math.Sin(arg));
            return new Complex(Math.Cos(arg), Math.Sin(arg));
        }
        // Возвращает спектр сигнала
        /// <param name="x">Массив значений сигнала. Количество значений должно быть степенью 2</param>
        /// <returns>Массив со значениями спектра сигнала</returns>
        private static Complex[] fft_rasch(Complex[] x)
        {
            Complex[] X;
            int N = x.Length;
            if (N == 2)
            {
                X = new Complex[2];
                X[0] = x[0] + x[1];
                X[1] = x[0] - x[1];
            }
            else
            {
                Complex[] x_even = new Complex[N / 2];
                Complex[] x_odd = new Complex[N / 2];
                for (int i = 0; i < N / 2; i++)
                {
                    x_even[i] = x[2 * i];
                    x_odd[i] = x[2 * i + 1];
                }
                Complex[] X_even = fft_rasch(x_even);
                Complex[] X_odd = fft_rasch(x_odd);
                X = new Complex[N];
                for (int i = 0; i < N / 2; i++)
                {
                    X[i] = X_even[i] + X_odd[i] * w(i, N);
                    X[i + N / 2] = X_even[i] - X_odd[i] * w(i, N);
                }
            }
            return X;
        }

        // преобразование в 
        private double[,] fft_spectr(Complex[] X,int N, int _n_periods, double _fn, string okno, double _zzz)
        {
            double[,] spectr = new double[X.Length, 3];  // переменная сразу для спектра
            // операции связанные с окном
            double gain = Gain_okno(N, okno, _zzz);
            // вводим коэфициент характеризующий увеличение длины периода за счёт добавление нулей
            double coef_0 = X.Length;
            coef_0 = coef_0 / N;

            for (int i = 0; i < N; i++)
            {
                spectr[i, 0] = i * _fn / _n_periods/ coef_0;
                spectr[i, 1] = X[i].Magnitude / gain * 2;
                spectr[i, 2] = X[i].Phase * 180 / Math.PI + 90;  // +90, так как он поворачивает все углы на 90
            }
            spectr[0, 1] = spectr[0, 1] / 2;
            return spectr;
        }
        // Центровка массива значений полученных в fft (спектральная составляющая при нулевой частоте будет в центре массива)
        // <param name="X">Массив значений полученный в fft</param>
        private static Complex[] nfft(Complex[] X)
        {
            int N = X.Length;
            Complex[] X_n = new Complex[N];
            for (int i = 0; i < N / 2; i++)
            {
                X_n[i] = X[N / 2 + i];
                X_n[N / 2 + i] = X[i];
            }
            return X_n;
        }

        // штучки для расчёта ДПФ с окнами

        // умножение сигнала на окно

        private double[,] signal_okno(double[,] _signal, int _N, string okno, double _zzz)
        {
            double[,] x_signal = new double [_N,2];
            if (okno == "Прямоугольное окно")
            {
                x_signal = _signal;
            }
            if (okno == "Треугольное окно")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_triangle(_N, i);
                }
            }
            if (okno == "Окно Бартлетта")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Bartlett(_N, i);
                }
            }
            if (okno == "Синус-окно")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_sin(_N, i);
                }
            }
            if (okno == "Окно Ланцоша")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Lanczos(_N, i);
                }
            }
            if (okno == "Окно Ханна")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Hann(_N, i);
                }
            }
            if (okno == "Окно Бартлетта-Ханна")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Bartlett_Hann(_N, i);
                }
            }
            if (okno == "Окно Хэмминга")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Hemming(_N, i);
                }
            }
            if (okno == "Окно Блэкмена")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Blackman(_N, i);
                }
            }
            if (okno == "Окно Блэкмана-Харриса")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Blackman_Harris(_N, i);
                }
            }
            if (okno == "Окно Наталла")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Nuttall(_N, i);
                }
            }
            if (okno == "Окно Блэкмена-Наталла")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Blackman_Nuttall(_N, i);
                }
            }
            if (okno == "Окно с плоской вершиной")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Flat_Top(_N, i);
                }
            }
            if (okno == "Окно Бомена")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Bohman(_N, i);
                }
            }
            if (okno == "Окно Парзена")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Parzen(_N, i);
                }
            }
            if (okno == "Окно Тьюки")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Tukey(_N, i, _zzz);
                }
            }
            if (okno == "Окно Кайзера")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Kaiser(_N, i, _zzz);
                }
            }
            if (okno == "Окно Гаусса")
            {
                for (int i = 0; i < _N; i++)
                {
                    x_signal[i, 1] = _signal[i, 1] * w_Gauss(_N, i, _zzz);
                }
            }

            return x_signal;
        }

        // возврат нужного весового коэффициента
        private double Gain_okno(int _N, string okno, double _zzz)
        {
            double gain_okno = 1;

            if (okno == "Прямоугольное окно")
            {
                gain_okno = gain_w_rect(_N);
            }
            if (okno == "Треугольное окно")
            {
                gain_okno = gain_w_triangle(_N);                
            }
            if (okno == "Окно Бартлетта")
            {
                gain_okno = gain_w_Bartlett(_N);
            }
            if (okno == "Синус-окно")
            {
                gain_okno = gain_w_sin(_N);                
            }
            if (okno == "Окно Ланцоша")
            {
                gain_okno = gain_w_Lanczos(_N);
            }
            if (okno == "Окно Ханна")
            {
                gain_okno = gain_w_Hann(_N);
            }
            if (okno == "Окно Бартлетта-Ханна")
            {
                gain_okno = gain_w_Bartlett_Hann(_N);
            }
            if (okno == "Окно Хэмминга")
            {
                gain_okno = gain_w_Hemming(_N);
            }
            if (okno == "Окно Блэкмена")
            {
                gain_okno = gain_w_Blackman(_N);
            }
            if (okno == "Окно Блэкмана-Харриса")
            {
                gain_okno = gain_w_Blackman_Harris(_N);
            }
            if (okno == "Окно Наталла")
            {
                gain_okno = gain_w_Nuttall(_N);
            }
            if (okno == "Окно Блэкмена-Наталла")
            {
                gain_okno = gain_w_Blackman_Nuttall(_N);
            }
            if (okno == "Окно с плоской вершиной")
            {
                gain_okno = gain_w_Flat_Top(_N);
            }
            if (okno == "Окно Бомена")
            {
                gain_okno = gain_w_Bohman(_N);
            }
            if (okno == "Окно Парзена")
            {
                gain_okno = gain_w_Parzen(_N);
            }
            if (okno == "Окно Тьюки")
            {
                gain_okno = gain_w_Tukey(_N, _zzz);
            }
            if (okno == "Окно Кайзера")
            {
                gain_okno = gain_w_Kaiser(_N, _zzz);
            }
            if (okno == "Окно Гаусса")
            {
                gain_okno = gain_w_Gauss(_N, _zzz);
            }

            return gain_okno;
        }


        // Определение коэффициентов ДПФ (нецентрированные)
        private double X_cos(int _i, int _j,int _N)
        {            
            return Math.Sin(2 * Math.PI * _i * _j / _N);
        }
        private double Y_sin(int _i, int _j, int _N)
        {            
            return Math.Cos(2 * Math.PI * _i * _j / _N); ;
        }




        //Задание окон(нецентрированные)
        // Прямоугольное окно
        public byte w_rect = 1;  // коэфициент прибавления
        private int gain_w_rect(int _N)    // коэфициент на который делим для получения амплитуды
        {
            return _N;
        }

        // треугольное окно
        public double w_triangle(int _N, int _j)    // коэфициент на который делим для получения амплитуды
        {
            double x = 0;
            if (_N % 2 == 0)
            {
                // ((2 * (_j + 1) -_N - 1) / _N);   - преобразуем это выражение
                //x = 2 * _j - _N + 1;
                //x = x / _N;
                //x = Math.Abs(x);
                //x = 1 - x;
                //return x;

                if (_j <= (_N / 2 - 1))        //так как с 0, а не с 1
                {
                    //вариант в учебнике
                    x = 2 * _j + 1;
                    x = x / _N;
                    return x;      // преобразованная ((2 * (_j + 1) - 1) / _N); - так как с 0, а не с 1
                }
                else
                {
                    // вероятно верный вариант
                    //x = 2 * (_N - _j);     
                    //x = x - 1;            // преобразованная ( (2 * (_N - (_j + 1) ) + 1 )/ _N); - так как с 0, а не с 1

                    x = 2 * (_N - _j);
                    x = x / _N;
                    return x;  // преобразованная (2 * (_N - (_j + 1) + 1) / _N); - так как с 0, а не с 1
                }
            }
            else
            {
                if (_j <= ((_N + 1) / 2 - 1))        //так как с 0, а не с 1
                {
                    x = 2 * _j + 2;
                    x = x / (_N + 1);
                    return x;      // преобразованная ((2 * (_j + 1)) / (_N + 1)); - так как с 0, а не с 1
                }
                else
                {
                    x = 2 * (_N - _j);
                    x = x / (_N + 1);
                    return x;  // преобразованная (2 * (_N - (_j + 1) + 1) / (_N + 1); - так как с 0, а не с 1
                }
            }
        }
        private double gain_w_triangle(int _N)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_triangle(_N, i);
            }
            return gain;
        }

        // Окно Бартлетта
        public double w_Bartlett(int _N, int _j)    // коэфициент на который делим для получения амплитуды
        {
            double x = 0;
            if (_N % 2 == 0)
            {
                //1 - Math.Abs( (_j )/ ((_N -1 )/2) ) ;   - преобразуем это выражение
                x = (_N - 1);
                x = x / 2;
                x = _j / x;
                x = x - 1;
                x = Math.Abs(x);
                x = 1 - x;
                return x;

                //if (_j <= (_N / 2 - 1))        //так как с 0, а не с 1
                //{
                //    x = 2 * _j;
                //    x = x / (_N - 1);
                //    return x;      // преобразованная (2 * ((_j + 1) - 1) / (_N - 1) ); - так как с 0, а не с 1
                //}
                //else
                //{
                //    x = 2 * (_N - _j - 1);
                //    x = x / (_N - 1);
                //    return x;  // преобразованная (2 * (_N - (_j + 1)) / (_N - 1) ); - так как с 0, а не с 1
                //}
            }
            else
            {
                if (_j <= ((_N + 1) / 2 - 1))        //так как с 0, а не с 1
                {
                    x = 2 * _j;
                    x = x / (_N - 1);
                    return x;      // преобразованная (2 * ((_j + 1) - 1) / (_N - 1) ); - так как с 0, а не с 1
                }
                else
                {
                    x = 2 * (_N - _j - 1);
                    x = x / (_N - 1);
                    return x;  // преобразованная (2 * (_N - (_j + 1)) / (_N - 1) ); - так как с 0, а не с 1
                }
            }
        }
        private double gain_w_Bartlett(int _N)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Bartlett(_N, i);
            }
            return gain;
        }
        
        // синус-окно
        public double w_sin(int _N, int _j)    // коэфициент на который делим для получения амплитуды
        {
            double x = 0;
            // Math.Sin( (Math.PI*_j )/ (_N -1 ) ) ;   - преобразуем это выражение
            x = Math.PI*_j;
            x = x / (_N - 1);
            x = Math.Sin(x);
            return x;

        }
        private double gain_w_sin(int _N)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_sin(_N, i);
            }
            return gain;
        }

        // Окно Ланцоша
        public double w_Lanczos(int _N, int _j)    // коэфициент на который делим для получения амплитуды
        {
            double x = 0;
            // Sinc( (2 *_j )/ (_N -1 ) -1) ;   - преобразуем это выражение
            x = 2 * _j;
            x = x / (_N - 1);
            x = x - 1;
            x = Math.Sin(x * Math.PI) / (Math.PI*x);
            return x;

        }
        private double gain_w_Lanczos(int _N)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Lanczos(_N, i);
            }
            return gain;
        }

        // Окно Ханна
        public double w_Hann(int _N, int _j)    // коэфициент на который делим для получения амплитуды
        {
            double x = 0;
            // 0.5 - 0.5*Cos( (2 *_j * Math.PI)/ (_N -1 ) ) ;   - преобразуем это выражение
            x = 2 * _j * Math.PI;
            x = x / (_N - 1);
            x = Math.Cos(x);
            x = 0.5 - (0.5 * x);
            return x;

        }
        private double gain_w_Hann(int _N)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Hann(_N, i);
            }
            return gain;
        }

        // Окно Бартлетта-Ханна
        public double w_Bartlett_Hann(int _N, int _j)    // коэфициент на который делим для получения амплитуды
        {
             double x = 0;
            double y = 0;
            // 0,62 - 0.48*|_j/(_N-1)-0.5| - 0.38*Cos( (2 *_j * Math.PI)/ (_N -1 ) ) ;   - преобразуем это выражение
            x = 2 * _j * Math.PI;  y = _j;
            x = x / (_N - 1);      y = y / (_N - 1);
            x = Math.Cos(x);       y = 0.48 * Math.Abs(y - 0.5);
            x = 0.38 * x;
            x = 0.62 - y - x;
            return x;

        }
        private double gain_w_Bartlett_Hann(int _N)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Bartlett_Hann(_N, i);
            }
            return gain;
        }

        // Окно Хэмминга
        public double w_Hemming(int _N, int _j)    // коэфициент на который делим для получения амплитуды
        {
            double x = 0;
            // 0.54 - 0.46*Cos( (2 *_j * Math.PI)/ (_N -1 ) ) ;   - преобразуем это выражение
            x = 2 * _j * Math.PI;
            x = x / (_N - 1);
            x = Math.Cos(x);
            x = 0.54 - 0.46 * x;
            return x;

        }
        private double gain_w_Hemming(int _N)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Hemming(_N, i);
            }
            return gain;
        }

        // Окно Блэкмена
        public double w_Blackman(int _N, int _j)    // коэфициент на который делим для получения амплитуды
        {
            double x = 0;
            double y = 0;
            // 0.42 - 0.5*Cos( (2 *_j * Math.PI)/ (_N -1 ) ) + 0.08*Cos( (4 *_j * Math.PI)/ (_N -1 ) ) ;   - преобразуем это выражение
            x = 2 * _j * Math.PI;
            x = x / (_N - 1); y = 2 * x;
            x = Math.Cos(x);  y = Math.Cos(y);
            x = 0.42 - 0.5 * x + 0.08 * y;
            return x;

        }
        private double gain_w_Blackman(int _N)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Blackman(_N, i);
            }
            return gain;
        }

        // Окно Блэкмана-Харриса
        public double w_Blackman_Harris(int _N, int _j)    // коэфициент на который делим для получения амплитуды
        {
            double x = 0;
            double y = 0;
            double z = 0;
            // 0.42 - 0.5*Cos( (2 *_j * Math.PI)/ (_N -1 ) ) + 0.08*Cos( (4 *_j * Math.PI)/ (_N -1 ) )  + ...6...;   - преобразуем это выражение
            x = 2 * _j * Math.PI;
            x = x / (_N - 1); y = 2 * x;       z = 3 * x;
            x = Math.Cos(x); y = Math.Cos(y);  z = Math.Cos(z);
            x = 0.48829 * x; y = 0.14128 * y;  z = 0.01168 * z;
            x = 0.35875 - x + y - z;
            return x;

        }
        private double gain_w_Blackman_Harris(int _N)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Blackman_Harris(_N, i);
            }
            return gain;
        }

        // Окно Наталла
        public double w_Nuttall(int _N, int _j)    // коэфициент на который делим для получения амплитуды
        {
            double x = 0;
            double y = 0;
            double z = 0;
            // 0.355768 - 0.487396*Cos( (2 *_j * Math.PI)/ (_N -1 ) ) + 0.144232*Cos( (4 *_j * Math.PI)/ (_N -1 ) )  - ...6...;   - преобразуем это выражение
            x = 2 * _j * Math.PI;
            x = x / (_N - 1); y = 2 * x; z = 3 * x;
            x = Math.Cos(x); y = Math.Cos(y); z = Math.Cos(z);
            x = 0.487396 * x; y = 0.144232 * y; z = 0.012604 * z;
            x = 0.355768 - x + y - z;
            return x;

        }
        private double gain_w_Nuttall(int _N)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Nuttall(_N, i);
            }
            return gain;
        }

        // Окно Блэкмена-Наталла
        public double w_Blackman_Nuttall(int _N, int _j)    // коэфициент на который делим для получения амплитуды
        {
            double x = 0;
            double y = 0;
            double z = 0;
            // 0.355768 - 0.487396*Cos( (2 *_j * Math.PI)/ (_N -1 ) ) + 0.144232*Cos( (4 *_j * Math.PI)/ (_N -1 ) )  - ...6...;   - преобразуем это выражение
            x = 2 * _j * Math.PI;
            x = x / (_N - 1); y = 2 * x; z = 3 * x;
            x = Math.Cos(x); y = Math.Cos(y); z = Math.Cos(z);
            x = 0.4891775 * x; y = 0.1365995 * y; z = 0.0106411 * z;
            x = 0.3635819 - x + y - z;
            return x;

        }
        private double gain_w_Blackman_Nuttall(int _N)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Blackman_Nuttall(_N, i);
            }
            return gain;
        }

        // Окно с плоской вершиной
        public double w_Flat_Top(int _N, int _j)    // коэфициент на который делим для получения амплитуды
        {
            double x = 0;
            double y = 0;
            double z = 0;
            double d = 0;
            // 0.355768 - 0.487396*Cos( (2 *_j * Math.PI)/ (_N -1 ) ) + 0.144232*Cos( (4 *_j * Math.PI)/ (_N -1 ) )  - ...6...;   - преобразуем это выражение
            x = 2 * _j * Math.PI;
            x = x / (_N - 1); y = 2 * x; z = 3 * x; d = 4 * x;
            x = Math.Cos(x); y = Math.Cos(y); z = Math.Cos(z);       d = Math.Cos(d);
            x = 1.93 * x; y = 1.29 * y; z = 0.388 * z; d = 0.032 * d;
            x = 1 - x + y - z + d;
            return x;

        }
        private double gain_w_Flat_Top(int _N)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Flat_Top(_N, i);
            }
            return gain;
        }

        // Окно Бомена
        public double w_Bohman(int _N, int _j)    // коэфициент на который делим для получения амплитуды
        {
            double x = 0;
            double y = 0;
            double z = 0;
            // (1-abs( (n-N/2)/(N/2) ) )*cos(pi* (n-N/2)/(N/2) ) +sin( pi*abs( (n-N/2)/(N/2) ) )/pi   - преобразуем это выражение
            x = _j; y = _N / 2;
            x = (x - y) / y;                  y = Math.PI * x;         z = Math.Abs(y);
            x = 1 - Math.Abs(x);              y = Math.Cos(y);         z = Math.Sin(z);
            x = x * y;                                                 z = z / Math.PI;
            x = x + z;
            return x;

        }
        private double gain_w_Bohman(int _N)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Bohman(_N, i);
            }
            return gain;
        }

        // Окно Бомена
        public double w_Parzen(int _N, int _j)    // коэфициент на который делим для получения амплитуды
        {
            double x = 0;
            double y = 0;
            // if ((n+1>=1)&&  (n+1<=( (N+2)/4)) )    ||    ((n+1>=(3*N+2)/4)&&(n+1<=N))
            // w_Parzen(n + 1) = 2 * (1 - abs(n + 1 - (N + 1) / 2) / (N / 2)) ^ 3;
            //else 
            //w_Parzen(n + 1) = 1 - 6 * (((n + 1 - (N + 1) / 2) / (N / 2)) ^ 2) * (1 - abs(n + 1 - (N + 1) / 2) / (N / 2));
            //end                                          - преобразуем это выражение
            if (((_j + 1) >= 1) & ((_j + 1) <= ((_N + 2) / 4)) || ((_j + 1 >= (3 * _N + 2) / 4) && (_j + 1 <= _N)))
            {
                x = _N + 1; x = x / 2; x = 1 - x; x = x + _j;   // (n + 1 - (N + 1) / 2)
                x = Math.Abs(x); y = _N / 2;
                x = x / y; x = 1 - x; x = Math.Pow(x, 3); x = x * 2;
            }
            else
            {
                x = _N + 1; x = x / 2; x = 1 - x; x = x + _j;   // (n + 1 - (N + 1) / 2)
                y = _N / 2;
                x = x / y;    y = x;   y = Math.Abs(y);   y = 1 - y;
                x = Math.Pow(x, 2); x = x * 6;
                x = x * y;
                x = 1 - x;
            }
            return x;

        }
        private double gain_w_Parzen(int _N)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Parzen(_N, i);
            }
            return gain;
        }

        // Окно Тьюки
        public double w_Tukey(int _N, int _j,double _zzz)    // коэфициент на который делим для получения амплитуды
        {
            double _N_ = _N;
            double _j_ = _j;
            double x = 0;

            //    if (n+1>=1)&&(n+1<=((N-1)*r/2+1))
            //w_Tukey(n + 1) = 1 / 2 * (1 - cos( (2 * pi * n) / ((N - 1) * r) ) );
            //else if (n + 1 >= ((N - 1) * r / 2 + 1))&& (n + 1 <= (N - (N - 1) * r / 2))
            //w_Tukey(n + 1) = 1;
            //else w_Tukey(n + 1) = 1 / 2 * (1 - cos((2 * pi * (n + 1 - N)) / ((N - 1) * r)));
            //end                                                                            - преобразуем это выражение
            if ( ( (_j_ + 1) >= 1) && ( (_j_ + 1) <= ( ( ( (_N_ - 1)*_zzz) / 2) + 1)) )
            {
                x = 2 * Math.PI * _j_;
                x = x / (_N_ - 1)/_zzz;
                x = Math.Cos(x);
                x = 1 - x;
                x = x / 2;
            }
            else if (( (_j_ + 1) >= ( (((_N_ - 1) * _zzz) / 2) + 1)) && ( (_j_ + 1) <= (_N - ( (_N_ - 1) * (_zzz / 2) ) ) ) )
            {
                x = 1;
            }
            else
            {
                x = _j_ + 1 - _N_;
                x = 2 * Math.PI * x;
                x = x / (_N_ - 1) / _zzz;
                x = Math.Cos(x);
                x = 1 - x;
                x = x / 2;
            }
            return x;

        }
        private double gain_w_Tukey(int _N, double _zzz)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Tukey(_N, i,_zzz);
            }
            return gain;
        }

        // Окно Кайзера
        public double w_Kaiser(int _N, int _j, double _zzz)    // коэфициент на который делим для получения амплитуды
        {
            double _N_ = _N;
            double _j_ = _j;
            double x = 0;
            double y = 0;
            //   abs(besseli(1,beta*sqrt( 1-( (2*(n+1)-N-1 )/(N-1) )^2) ) )  /   abs(besseli(1,beta));   - преобразуем это выражение
            x = alglib.bessel.besselj0(_zzz);
            y = _zzz * Math.Sqrt(1 - Math.Pow((2 * (_j_ + 1) - _N_ - 1) / (_N_ - 1), 2));
            y=alglib.bessel.besselj0(y);
            x = Math.Abs(x) / Math.Abs(y);
            return x;

        }
        private double gain_w_Kaiser(int _N, double _zzz)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Kaiser(_N, i, _zzz);
            }
            return gain;
        }

        // Окно Гаусса
        public double w_Gauss(int _N, int _j, double _zzz)    // коэфициент на который делим для получения амплитуды
        {

            double x = 0;
            double y = 0;
            //     - преобразуем это выражение
            y = (_N - 1); y = y / 2;
            x = _j - y;
            y = y * _zzz;
            x = x / y;
            x = Math.Pow(x, 2);
            x = x / 2; x = 0 - x;
            x = Math.Exp(x);
            return x;

        }
        private double gain_w_Gauss(int _N, double _zzz)    // коэфициент на который делим для получения амплитуды
        {
            double gain = 0;
            for (int i = 0; i < _N; i++)      // перебор по членам масива
            {
                gain = gain + w_Gauss(_N, i, _zzz);
            }
            return gain;
        }


        // прочие методы


        // создание сигнала из гармоник
        public double[,] Made_Signal_garmon(double [,] _paramets_table, int _N_one_period, int _n_periods, double _fn, double _f_fact, double _f_inter, double _A_inter)
        {

            int nGarmon = _paramets_table.GetLength(0);            // определяется количество гармоник
            double [,] _signal_table = new double[_N_one_period * _n_periods, 2];   // сразу иницилизируется матрица сигнала

            if (_paramets_table[0, 0] == 0)
            {
                for (int i = 0; i < _N_one_period * _n_periods; i++)
                {
                    _signal_table[i, 0] = 0; //принудительное обнуление, на всякий случай

                    _signal_table[i, 0] = i / _fn / _N_one_period;
                    _signal_table[i, 1] = _paramets_table[0, 1];
                    for (int j = 1; j < nGarmon; j++)
                    {
                        _signal_table[i, 1] = _signal_table[i, 1] + _paramets_table[j, 1] * Math.Sin(2 * Math.PI * _f_fact * _paramets_table[j, 0] * _signal_table[i, 0] + _paramets_table[j, 2] * Math.PI / 180);
                        //в этой формуле                                   амплитуда   *   sin (   2*pi         *f_fact * ngarmon               *  t                 + fi0)
                    }
                    _signal_table[i, 1] = _signal_table[i, 1]+ _A_inter * Math.Sin(2 * Math.PI * _f_inter * _signal_table[i, 0]);

                }
            }
            else
            {
                for (int i = 0; i < _N_one_period * _n_periods; i++)
                {
                    _signal_table[i, 0] = 0; //принудительное обнуление, на всякий случай
                    _signal_table[i, 1] = 0; //принудительное обнуление, на всякий случай

                    _signal_table[i, 0] = i / _fn / _N_one_period;
                    for (int j = 0; j < nGarmon; j++)
                    {
                        _signal_table[i, 1] = _signal_table[i, 1] + _paramets_table[j, 1] * Math.Sin(2 * Math.PI * _f_fact * _paramets_table[j, 0] * _signal_table[i, 0] + _paramets_table[j, 2] * Math.PI / 180);
                        //в этой формуле                                   амплитуда   *   sin (   2*pi           *f_fact * ngarmon               *  t                 + fi0)
                    }
                    _signal_table[i, 1] = _signal_table[i, 1] + _A_inter * Math.Sin(2 * Math.PI * _f_inter * _signal_table[i, 0]);
                }
            }
            return _signal_table;
        }

        // создание белого шума
        public double[,] Add_shum_Wite(double[,] _signal_table, int _N_one_period, int _n_periods, double _A_shum_White)
        {
            for (int i = 0; i < _N_one_period * _n_periods - 1; i++)
            {
                // код для крипторандома
                // byte[] bytes = new byte[4];
                // random.GetBytes(bytes); // генерируем набор из 4-ёх байтов
                // int ra = BitConverter.ToInt32(bytes, 0);  // преобразуем в целочисленное значение
                // double tipoRando = ra;
                // tipoRando = tipoRando / 2147483647;
                // _signal_table[i, 1] = _signal_table[i, 1] + _A_shum_White * (tipoRando);

        // для обычного рандома
        _signal_table[i, 1] = _signal_table[i, 1] + _A_shum_White * (random.NextDouble() - 0.5)*2;
            }
           
            return _signal_table;
        }



    }
}
