using System.Text;

namespace kosar2004
{
    internal class Meccs
    {
        public string Hazai { get; private set; }
        public string Idegen { get; private  set; }
        public int HPont { get; private set; }
        public int IPont { get; private set; }
        public string Hely { get; private set; }
        public string Ido { get; private set; }
        public Meccs(/*string hazai, string idegen, int hpont, int ipont, string hely, string ido*/string sor)
        {
            string[] adatok = sor.Split(';');
            Hazai = adatok[0];
            Idegen = adatok[1];
            HPont = int.Parse(adatok[2]);
            IPont = int.Parse(adatok[3]);
            Hely = adatok[4];
            Ido = adatok[5];
            /*this.Hazai = hazai;
            this.Idegen = idegen;
            this.HPont = hpont;
            this.IPont = ipont;
            this.Hely = hely;
            this.Ido = ido;*/
        }
        public string Kiir()
        {
            //Tau Cerámica -Winterthur F.C.Barcelona(72:79)
            StringBuilder vissza = new StringBuilder();
            vissza.Append($"{Hazai}-{Idegen} ({HPont}:{IPont})");
            return vissza.ToString();
                //$"{Hazai}-{Idegen} ({HPont}:{IPont})";
        }
    }
}