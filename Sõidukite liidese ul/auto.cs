namespace Sõidukite_liidese_ul
{
    public class Auto : ISõiduk
    {
        public double KütusekuluLiitrites { get; set; }
        public double VahemaaKm { get; set; }

        public Auto(double kütusekuluLiitrites, double vahemaaKm)
        {
            KütusekuluLiitrites = kütusekuluLiitrites;
            VahemaaKm = vahemaaKm;
        }

        public double ArvutaKulu() => VahemaaKm * KütusekuluLiitrites / 100; // valem arvutab kogu kutusekulu
        public double ArvutaVahemaa() => VahemaaKm; // kui palju km

        public override string ToString()
        {
            return $"Auto – Kulu: {ArvutaKulu():F2} l, Vahemaa: {ArvutaVahemaa()} km";
        }
    }
}