namespace conversor
{
    public class Conversor
    {
        private static float cotaD = 5.24f;
        private static float cotaE = 6.24f;


        public static float realPaDolar(float ValorEmRs){
            return ValorEmRs / cotaD;
        }
        public static float dolarPaReal(float cashUS){
            return cotaD * cashUS;
        }

        public static float realParaEuro(float valorEmRs){
            return valorEmRs / cotaE;
        }
        public static float realPaeu(float valordeu){
            return cotaE * valordeu;
        }
    }
}