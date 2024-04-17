namespace JeffersonRuiz_EjercicioCF.Models
{
    public class Promo
    {
        public int PromoID {  get; set; }
        public String? Descripcion { get; set; }
        public DateTime FechaPromo { get; set; }
        public int BurgerID { get; set; }
        public Burger? Burger { get; set; }

    }
}
