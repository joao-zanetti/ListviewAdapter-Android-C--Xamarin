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

    //CREATE ONE VIEW POR ELEMENT IN  THE LIST  ELEMENTS
    public class ElementAdapter : BaseAdapter<Element>
    {
        private readonly Activity context;
        private readonly List<Element> Elements;

        //Constructor wich receive List of Elements (ElementRepository.Elements)
        public ElementAdapter(Activity context, List<Element> Elements)
        {
            this.context = context;
            this.Elements = Elements;
        }

        public override Element this[int position]
        {
            get
            {
                return Elements[position];
            }
        }

        public override int Count
        {
            get
            {
                return Elements.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return Elements[position].Id;
        }


//É dentro do método GetView() que vamos transformar o arquivo de layout elements.axml
//em uma view contendo o leiaute do item da lista usando o método inflate da classe LayoutInflater.

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
//Este método cria uma nova view para cada elemento adicionado ao ElementAdapter
            var view = convertView ?? context.LayoutInflater.Inflate(Resource.Layout.elements, parent, false);

            var txtName = view.FindViewById<TextView>(Resource.Id.nameTextView);

            var txtTelefone = view.FindViewById<TextView>(Resource.Id.telefoneTextView);
            //More views

            txtName.Text = Elements[position].Name;
            txtTelefone.Text = Elements[position].Telefone;
            //More views

            return view;
        }
    }
}