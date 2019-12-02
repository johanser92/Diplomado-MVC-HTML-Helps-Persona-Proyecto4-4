using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diplomado_MVC_HTML_Helps_Persona.Models
{
    public class MantenimientoPersona
    {
        List<Persona> ListaPersonas = new List<Persona>()
        {
            new Persona()
            {
                Codigo=1,
                Nombre="Johanser Lemos",
                Peso=63.3f,
                Trabaja=false,
                FechaNacimiento=new DateTime(1992,10,05)
            },
            new Persona()
            {
                Codigo=2,
                Nombre="Pedro Lemos",
                Peso=70.3f,
                Trabaja=false,
                FechaNacimiento=new DateTime(1982,10,05)
            },
            new Persona()
            {
                Codigo=3,
                Nombre="Nathalie Lemos",
                Peso=62.3f,
                Trabaja=true,
                FechaNacimiento=new DateTime(1992,11,05)
            }

        };
        public Persona Retornar(int cod)
        {
            foreach (var per in ListaPersonas)
            {
                if (per.Codigo==cod)
                {
                    return per;
                }
            }
            return null;
        }
    }
}