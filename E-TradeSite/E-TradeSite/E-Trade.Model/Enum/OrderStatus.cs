using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Trade.Model.Enum
{
    public enum OrderStatus
    {
        Silindi = 0,
        Onay_Bekliyor = 1,
        Onaylandı = 2,
        Kargoya_Verildi = 3,
        İptal_Edildi = 4,
        Teslim_Edildi = 5,
        Tedarik_Sürecinde = 6,
        Ödeme_Bekleniyor = 7,
        Hazırlanıyor = 8,
        İade_Edildi = 9,
        Kişisel_Sipariş_Durumu_1 = 10,
        Kişisel_Sipariş_Durumu_2 = 11,
        Kişisel_Sipariş_Durumu_3 = 12
    }
}
