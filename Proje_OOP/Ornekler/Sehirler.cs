namespace Proje_OOP.Ornekler
{
    public class Sehirler:Bayrak
    {
        //sehirler classı bayrak classından kalıtım alır
        //yani bayrak classını özellikleri alırlar.
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Nufus { get; set; }

        public string Ulke { get; set; }

    }
}
