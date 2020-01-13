using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace navigationteste
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button addButton;
        EditText inputElement;
        TextView nameElement;
        ListView elementsListView;
        private ElementAdapter elementsAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            addButton = FindViewById<Button>(Resource.Id.addButton);
            inputElement = FindViewById<EditText>(Resource.Id.inputElement);
            nameElement =FindViewById<TextView>(Resource.Id.nameElement);
            elementsListView = FindViewById<ListView>(Resource.Id.elementsListView);

            elementsListView.FastScrollEnabled = true;
            elementsAdapter = new ElementAdapter(this, ElementsRepository.Elements);
            elementsListView.Adapter = elementsAdapter;

            addButton.Click += AddButton_Click;
            elementsListView.ItemClick += ElementsListView_ItemClick;
        }

        private void ElementsListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, ElementsRepository.Elements[e.Position].Name.ToString(), ToastLength.Long).Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            String inputText= inputElement.Text;
            nameElement.Text = inputText;
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}