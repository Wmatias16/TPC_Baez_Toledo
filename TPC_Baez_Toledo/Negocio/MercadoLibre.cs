using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using MercadoPago.Common;
using MercadoPago.DataStructures.Preference;
using MercadoPago.Resources;

using Dominio;

namespace Negocio
{
    public class MercadoLibre
    {
        private string token = "TEST-6686195133114633-051103-f1562bff4481a254456f7d490a892a90-366415201";

        public void Pagar(Alquiler alquilerPagar)
        {
            var preference = new Preference
            {
                // If you want to use a merchant-specific Access Token for this particular request, you can use this property.
                UserAccessToken = this.token,
                Items =
                {
                    new Item
                    {
                        Id = alquilerPagar.Id.ToString(),
                        Title = alquilerPagar.Cancha.Nombre,
                        Quantity = alquilerPagar.Horas,
                        CurrencyId = CurrencyId.ARS,
                        UnitPrice = alquilerPagar.Costo
                    }
                },
                Payer = new Payer
                {
                    Email = alquilerPagar.Usuario.Email,
                    Name = alquilerPagar.Usuario.Nombre,
                    Surname = alquilerPagar.Usuario.Apellidos
                }
            };

            // Save and posting preference
            preference.Save();
            Process.Start(preference.InitPoint);
        }


    }
}
