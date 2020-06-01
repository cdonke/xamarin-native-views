using System;
using Android.App;
using Android.Content;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(ContosoCustomView.CustomPage), typeof(ContosoCustomView.Droid.CustomPageRenderer))]
namespace ContosoCustomView.Droid
{
    public class CustomPageRenderer : PageRenderer
    {
        private Android.Views.View _view;
        
        private Activity _activity;
        private Android.Widget.TextView lblCounter;
        private Android.Widget.Button button;

        public CustomPageRenderer(Context context) : base(context){}

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
                return;

            SetupInterface();
            SetupInteractions();
            AddView(_view);
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);

            var msw = MeasureSpec.MakeMeasureSpec(r - l, MeasureSpecMode.Exactly);
            var msh = MeasureSpec.MakeMeasureSpec(b - t, MeasureSpecMode.Exactly);

            _view.Measure(msw, msh);
            _view.Layout(0, 0, r - l, b - t);
        }

        private void SetupInterface()
        {
            _activity = this.Context as Activity;
            _view = _activity.LayoutInflater.Inflate(Resource.Layout.CustomLayout, this, false);

            lblCounter = _view.FindViewById<Android.Widget.TextView>(Resource.Id.counter_label);
            button = _view.FindViewById<Android.Widget.Button>(Resource.Id.button_increment_counter);
        }

        private void SetupInteractions()
        {
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblCounter.Text, out int nClicks))
                lblCounter.Text = (++nClicks).ToString();
            else
                lblCounter.Text = "-1";
        }
    }
}
