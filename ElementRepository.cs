using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace navigationteste
{
    public static class ElementsRepository 
    {
        public static List<Element> Elements {get; private set; }

        static ElementsRepository()
        {
            Elements = new List<Element>();
            for (int i = 0; i < 2; i++)
            {
                AddElements();
            }

        }

        private static void AddElements()
        {
            Elements.Add(new Element
            {
                Id = 0,
                Name = "Lucas",
                Telefone= "(16) 981510414"
            }) ;

            Elements.Add(new Element
            {
                Id = 1,
                Name = "George ",
                Telefone = "(16) 981510414"
            });

            Elements.Add(new Element
            {
                Id = 2,
                Name = "Carlos",
                Telefone = "(16) 981510414"

            });

            Elements.Add(new Element
            {
                Id = 3,
                Name = "Lu",
                Telefone = "(16) 981510414"

            });

            Elements.Add(new Element
            {
                Id = 4,
                Name = "Ge",
                Telefone = "(16) 981510414"
            });

            Elements.Add(new Element
            {
                Id = 5,
                Name = "Marte",
                Telefone = "(16) 981510414"
            });
        }
    }
}