using System;

namespace MyProyecto
{
    
    
    
    public class Fraccion
    {
        private int n, d;

        public int N
        {
            get { return n; }
            set { n = value; }
        }

        public int D
        {
            get { return d; }
            set { d = value; }
        }

        public Fraccion()
        {
            n = 0;
            d = 1;
        }

        public Fraccion(int num)
        {
            n = num;
            d = 1;
        }

        public Fraccion(int num, int den)
        {
            n = num;
            if (den != 0)
            {
                d = den;
            }
            else
            {
                Console.WriteLine("Indeterminacion");
            }
        }


        static int calcularMCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        public static Fraccion operator +(Fraccion a, Fraccion b)
        {
            int naux = (a.n * b.d) + (a.d * b.n);
            int daux = a.d * b.d;
            int mcd = calcularMCD(naux, daux);
            return new Fraccion(naux / mcd, daux / mcd);
        }

        public static Fraccion operator +(Fraccion a, int k)
        {
            int naux = a.n + (a.d * k);
            int daux = a.d;
            int mcd = calcularMCD(naux, daux);
            return new Fraccion(naux / mcd, daux / mcd);
        }

        public static Fraccion operator +(int k, Fraccion a)
        {
            int naux = a.n + (a.d * k);
            int daux = a.d;
            int mcd = calcularMCD(naux, daux);
            return new Fraccion(naux / mcd, daux / mcd);
        }

        public static Fraccion operator ++(Fraccion a)
        {
            int naux = a.n + a.d;
            int daux = a.d;
            int mcd = calcularMCD(naux, daux);
            return new Fraccion(naux / mcd, daux / mcd);
        }

        public static Fraccion operator -(Fraccion a, Fraccion b)
        {
            int naux = (a.n * b.d) - (a.d * b.n);
            int daux = a.d * b.d;
            int mcd = calcularMCD(naux, daux);
            return new Fraccion(naux / mcd, daux / mcd);
        }

        public static Fraccion operator -(Fraccion a, int k)
        {
            int naux = a.n - (a.d * k);
            int daux = a.d;
            int mcd = calcularMCD(naux, daux);
            return new Fraccion(naux / mcd, daux / mcd);
        }

        public static Fraccion operator -(int k, Fraccion a)
        {
            int naux = a.n - (a.d * k);
            int daux = a.d;
            int mcd = calcularMCD(naux, daux);
            return new Fraccion(naux / mcd, daux / mcd);
        }

        public static Fraccion operator --(Fraccion a)
        {
            int naux = a.n - a.d;
            int daux = a.d;
            int mcd = calcularMCD(naux, daux);
            return new Fraccion(naux / mcd, daux / mcd);
        }

        public static Fraccion operator *(Fraccion a, Fraccion b)
        {
            int naux = a.n * b.n;
            int daux = a.d * b.n;
            int mcd = calcularMCD(naux, daux);
            return new Fraccion(naux / mcd, daux / mcd);
        }

        public static Fraccion operator *(Fraccion a, int k)
        {
            int naux = a.n * k;
            int daux = a.d;
            int mcd = calcularMCD(naux, daux);
            return new Fraccion(naux / mcd, daux / mcd);
        }

        public static Fraccion operator *(int k, Fraccion a)
        {
            int naux = a.n * k;
            int daux = a.d;
            int mcd = calcularMCD(naux, daux);
            return new Fraccion(naux / mcd, daux / mcd);
        }

        public static Fraccion operator /(Fraccion a, Fraccion b)
        {
            int naux = a.n * b.d;
            int daux = a.d * b.n;
            int mcd = calcularMCD(naux, daux);
            return new Fraccion(naux / mcd, daux / mcd);
        }

        public static Fraccion operator /(Fraccion a, int k)
        {
            int naux = a.n;
            int daux = a.d * k;
            int mcd = calcularMCD(naux, daux);
            return new Fraccion(naux / mcd, daux / mcd);
        }

        public static Fraccion operator /(int k, Fraccion a)
        {
            int naux = a.n;
            int daux = a.d * k;
            int mcd = calcularMCD(naux, daux);
            return new Fraccion(naux / mcd, daux / mcd);
        }
    }

//Proyecto
    public class Plano
    {
        private Fraccion a, b, c, d, e;
        private string conica;

        public Fraccion A
        {
            get { return a; }
            set { a = value; }
        }

        public Fraccion B
        {
            get { return b; }
            set { b = value; }
        }

        public Fraccion C
        {
            get { return c; }
            set { c = value; }
        }

        public Fraccion D
        {
            get { return d; }
            set { d = value; }
        }

        public Fraccion E
        {
            get { return e; }
            set { e = value; }
        }

        public string Conica
        {
            get { return conica; }
            set { conica = value; }
        }

        //CONSTRUCTORES
        public Plano()
        {
            a = new Fraccion(0);
            b = new Fraccion(0);
            c = new Fraccion(0);
            d = new Fraccion(0);
            e = new Fraccion(0);
            conica = "cero";
        }

        public Plano(int A, int B, int C, int D, int E, string nombre)
        {
            a = new Fraccion(A);
            b = new Fraccion(B);
            c = new Fraccion(C);
            d = new Fraccion(D);
            e = new Fraccion(E);
            conica = nombre;

            DeterminarFigura();
        }

        public Plano(Fraccion A, Fraccion B, Fraccion C, Fraccion D, Fraccion E, string nombre)
        {
            a = A;
            b = B;
            c = C;
            d = D;
            e = E;
            conica = nombre;

            DeterminarFigura();
        }

        //METODOS
        public string  general()
        {
            string CA, CB, CC, CD, CE;
            //A
            if (a.N == 0)
                CA = "";
            else if (a.N != 0 && a.D == 1)
                CA = $"{a.N}X\u00B2 + ";
            else
                CA = $"{a.N}/{a.D}X\u00B2 + ";
            //B
            if (b.N == 0)
                CB = "";
            else if (b.N != 0 && b.D == 1)
                CB = $"{b.N}Y\u00B2 + ";
            else
                CB = $"{b.N}/{b.D}Y\u00B2 + ";
            //C
            if (c.N == 0)
                CC = "";
            else if (c.N != 0 && c.D == 1)
                CC = $"{c.N}X + ";
            else
                CC = $"{c.N}/{c.D}X + ";
            //D
            if (d.N == 0)
                CD = "";
            else if (d.N != 0 && d.D == 1)
                CD = $"{d.N}Y + ";
            else
                CD = $"{d.N}/{d.D}Y + ";
            //E
            if (e.N == 0)
                CE = "";
            else if (e.N != 0 && e.D == 1)
                CE = $"{e.N}";
            else
                CE = $"{e.N}/{e.D}";
            return "Ecuacion General" + ": " + CA + CB + CC + CD + CE + "  = 0";
        }
        
        public static int calcularMCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        public static int CalcularMCM(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            else
            {
                int mcd = calcularMCD(a, b);
                return (a * b) / mcd;
            }
        }

        public static string PSF(Fraccion k)
        {
            if (k.N == 0)
                return "";
            else if (k.N != 0 && k.D == 1 && k.N != k.D)
            {
                return $"{k.N}";
            }
            else if (k.N == k.D)
                return "1";
            else
                return $"{k.N}/{k.D}";
        }

        private void DeterminarFigura()
        {
            if (a.N == 0 && b.N == 0)
            {
                conica = "Recta";
            }
            else if (a.N == b.N && a.N != 0)
            {
                conica = "Circunferencia";
            }
            else if (a.N != 0 && b.N == 0)
            {
                conica = "Parabola Vertical";
            }
            else if (a.N == 0 && B.N != 0)
            {
                conica = "Parabola Horizontal";
            }
            else
                Console.WriteLine("No representa niguna figura en el plano");
        }

        public  virtual Plano CrearFigura()
        {
            switch (conica)
            {
                case "Recta":
                    Console.WriteLine("Recta:");
                    Recta recta = new Recta(this.C, this.D, this.E);
                    return recta.CrearFigura();
                case "Circunferencia":
                    Console.WriteLine("Circunferencia");
                    Circunferencia circunferencia = new Circunferencia(this.A, this.C, this.D, this.E);
                    return circunferencia.CrearFigura();
                case "Parabola Vertical":
                    Console.WriteLine("Parabola Vertical");
                    ParabolaV parabola = new ParabolaV(this.A, this.C, this.D, this.E);
                    return parabola.CrearFigura();
                case "Parabola Horizontal":
                    Console.WriteLine("Parabola Horizontal");
                    ParabaolaH parabola2 = new ParabaolaH(this.B, this.C, this.D, this.E);
                    return parabola2.CrearFigura();
                default:
                    return this;
            }
        }

        public virtual string ToString()
        {
            return general() + "\tNo hay una figura disponible";
        }
    }

//Recta
    class Recta : Plano
    {
        public Recta() : base()
        {
        }

        public Recta(int A, int B, int C) :
            base(new Fraccion(0), new Fraccion(0),
                new Fraccion(A), new Fraccion(B), new Fraccion(C), "Recta")
        {
        }

        public Recta(Fraccion A, Fraccion B, Fraccion C) :
            base(new Fraccion(0), new Fraccion(0), A, B, C, "Recta")
        {
        }

        //Constructores mb
        public Recta(int m, int b) :
            base(new Fraccion(0), new Fraccion(0),
                new Fraccion(m), new Fraccion(-1), new Fraccion(b), "Recta")
        {
        }

        public Recta(Fraccion m, Fraccion b) : base()
        {
            int aux = CalcularMCM(m.D, b.D);
            this.Conica = "Recta";
            Fraccion f1 = new Fraccion(m.N, m.D);
            Fraccion f2 = new Fraccion(-1);
            Fraccion f3 = new Fraccion(b.N, b.D);
            f1 = f1 * aux;
            f2 = f2 * aux;
            f3 = f3 * aux;
            if (f1.N < 0 || f1.D < 0) //Coeficiente de x positivo
            {
                f1 = f1 * -1;
                f2 = f2 * -1;
                f3 = f3 * -1;
            }

            this.C = f1;
            this.D = f2;
            this.E = f3;
        }

        public string canonica()
        {
            Fraccion m = this.C / this.D * -1;
            Fraccion b = this.E / this.D * -1;

            string CM, CB;
            if (m.N == 0)
                CM = "";
            else if (m.N != 0 && m.D == 1)
                CM = $"{m.N}X + ";
            else
                CM = $"{m.N}/{m.D}X + ";

            if (b.N == 0)
                CB = "";
            else if (b.N != 0 && b.D == 1)
                CB = $"{b.N}";
            else
                CB = $"{b.N}/{b.D}";
            return "Ecuacion Ordinaria" + $" : Y = " + CM + CB;
        }

        public string pendiente()
        {
            Fraccion m = this.C / this.D * -1;
            return $"Pendiente: M = {m.N}/{m.D}";
        }

        public string ordenada()
        {
            Fraccion b = this.E / this.D * -1;
            return $"Ordeneda : B = {b.N}/{b.D}";
        }
        
        public override Plano CrearFigura()
        {
            Console.WriteLine("Recta:");
            general();
            canonica();
            pendiente();
            ordenada();
            return this;
        }

        public override string ToString()
        {
            return "Recta:\n" + general() + "\n" + canonica() + "\n" + pendiente() + "\n"+ ordenada();
        }
    }

    class Circunferencia : Plano
    {
        public Circunferencia() : base()
        {
        }

        public Circunferencia(int A, int C, int D, int E) :
            base(new Fraccion(A), new Fraccion(A), new Fraccion(C), new Fraccion(D), new Fraccion(E),
                "Circunferencia")
        {
        }

        public Circunferencia(Fraccion A, Fraccion C, Fraccion D, Fraccion E) :
            base(A, A, C, D, E, "Circunferencia")
        {
        }


        //METODOS
        public string canonica()
        {
            Fraccion h = this.C / this.A / -2;
            Fraccion k = this.D / this.A / -2;
            Fraccion r = (this.C * this.C + this.D * this.D - 4 * this.E * this.A) / (4 * this.A);

            string CH, CK, CR;
            if (h.N == 0)
                CH = "";
            else if (h.N != 0 && h.D == 1)
                CH = $"(X - {h.N})\u00B2 + ";
            else
                CH = $"(X - {h.N}/{h.D})\u00B2 + ";

            if (k.N == 0)
                CK = "";
            else if (k.N != 0 && k.D == 1)
                CK = $"(Y - {k.N})\u00B2 = ";
            else
            {
                CK = $"(Y - {k.N}/{k.D}\u00B2) = ";
            }

            if (r.N == 0)
                CR = "";
            else if (r.N != 0 && r.D == 1)
                CR = $"({r.N})\u00B2";
            else
                CR = $"({r.N}/{r.D})\u00B2";

            return ("Ecuacion Ordinaria" + $" : " + CH + CK + CR+"\n" + "h = " + PSF(h)+"\nk = "+PSF(k)+"\nr = "+PSF(r));
            
        }
        public override Plano CrearFigura()
        {
            Console.WriteLine("Circunferencia");
            general();
            canonica();
            return this;
        }
        

        public override string ToString()
        {
            return "Circunferencia\n"+general() + "\n" + canonica();
        }
    }

    class ParabolaV : Plano
    {
        public ParabolaV() : base()
        {
        }

        public ParabolaV(int A, int C, int D, int E) :
            base(new Fraccion(A), new Fraccion(0), new Fraccion(C), new Fraccion(D), new Fraccion(E),
                "Parabola Vertical")
        {
        }

        public ParabolaV(Fraccion A, Fraccion C, Fraccion D, Fraccion E) :
            base(A, new Fraccion(0), C, D, E, "Parabola Vertical")
        {
        }

        //Metodos
        public string canonica()
        {
            Fraccion h = this.C / this.A * -2;
            Fraccion p = this.D / this.A * -4;
            Fraccion k = (this.C * this.C - 4 * this.A * this.E) / (4 * this.A * this.D);

            string CH, CP, CK;
            if (h.N == 0)
                CH = "";
            else if (h.N != 0 && h.D == 1)
                CH = $"(X - {h.N})\u00B2= ";
            else
                CH = $"(X - {h.N}/{h.D})\u00B2 = ";

            if (p.N == 0)
                CP = "";
            else if (p.N != 0 && p.D == 1)
                CP = $"4({p.N}) ";
            else
                CP = $"4({p.N}/{p.D}) ";

            if (k.N == 0)
                CK = $"Y";
            else if (k.N != 0 && k.D == 1)
                CK = $"(Y - {k.N})";
            else
                CK = $"(Y - {k.N}/{k.D})";

            return ("Ecuacion Ordinaria"+$" : "+CH+CP+CK+"\nh = "+PSF(h)+"\nP = "+PSF(p)+"\nk = "+PSF(k));
            

        }

        public string ladorecto()
        {
            Fraccion p = this.D / (this.A * -4);
            Fraccion lr = (4 * p) / this.A;
            if (lr.D < 0 || lr.N < 0)
                return ("Lado Recto = " + PSF(-1 * lr));
            else
                return ("Lado Recto = " + PSF(lr));
        }
        
        public override Plano CrearFigura()
        {
            Console.WriteLine("Parabola");
            general();
            canonica();
            ladorecto();
            return this;
        }
        

        public override string ToString()
        {
            return "Parabola Vertical\n"+general() + "\n" + canonica() + "\n" + ladorecto();
        }
    }

    class ParabaolaH : Plano
    {
        public ParabaolaH() : base()
        {
        }

        public ParabaolaH(int B, int C, int D, int E) :
            base(new Fraccion(0), new Fraccion(B), new Fraccion(C), new Fraccion(D), new Fraccion(E),
                "Parabola Horizontal")
        {
        }

        public ParabaolaH(Fraccion B, Fraccion C, Fraccion D, Fraccion E) :
            base(new Fraccion(0), B, C, D, E, "Parabola Horizontal")
        {
        }



        public string canonica()
        {
            Fraccion k = this.D / (this.B * -2);
            Fraccion p = this.C / (this.B * -4);
            Fraccion h = ((this.D * this.D) - (4 * this.B * this.E)) / (4 * this.B * this.C);

            string CK, CP, CH;
            if (k.N == 0)
                CK = $"Y\u00B2";
            else if (k.N != 0 && k.D == 1)
                CK = $"(Y - {k.N})\u00B2 = ";
            else
                CK = $"(Y - {k.N}/{k.D})\u00B2 = ";

            if (p.N == 0)
                CP = "";
            else if (p.N != 0 && p.D == 1)
                CP = $"4({p.N}) ";
            else
                CP = $"4({p.N}/{p.D}) ";

            if (h.N == 0)
                CH = $"X";
            else if (h.N != 0 && h.D == 1)
                CH = $"(X - {h.N})";
            else
                CH = $"(X - {h.N}/{h.D})";

            return("Ecuacion Ordinaria"+$" : "+CK+CP+CH+"\nk = "+PSF(k)+"\nP = "+PSF(p)+"\nh = "+PSF(h));
            
        }

        public string ladorecto()
        {
            Fraccion p = this.C / (this.B * -4);
            Fraccion lr = (4 * p) / this.B;
            if (lr.D < 0 || lr.N < 0)
                return ("Lado Recto = " + PSF(-1 * lr));
            else
                return ("Lado Recto = " + PSF(lr));
        }

        public override Plano CrearFigura()
        {
            Console.WriteLine("Parabola");
            general();
            canonica();
            ladorecto();
            return this;
        }

        public override string ToString()
        {
            return "Parabola Horizontal\n"+general() + "\n" + canonica() +"\n" + ladorecto();
        }
    }

    class Program
    {
        static void Main()
        {
            /*Recta r1 = new Recta(10,3,-7);
            r1.general();
            r1.canonica();
            r1.pendiente();
            r1.ordenada();
            Console.WriteLine("///");
            Circunferencia c1 = new Circunferencia(1, 9, 2, -7);
            c1.general();
            c1.canonica();
            Console.WriteLine("////");
            ParabolaV p1 = new ParabolaV(4, 2, 10, -2);
            p1.general();
            p1.canonica();
            p1.ladorecto();
            Console.WriteLine("////");
            ParabaolaH p2 = new ParabaolaH(1, -3, 10, -10);
            p2.general();
            p2.canonica();
            p2.ladorecto();*/
            Plano p1 = new Plano(1, 1, 3, 4, 5, "n");
            Plano nuevo = p1.CrearFigura();
            Console.WriteLine(nuevo);

        }
    }
}


