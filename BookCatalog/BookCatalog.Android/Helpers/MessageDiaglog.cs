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

namespace BookCatalog.Droid.Helpers
{
    public static class MessageDiaglog
    {
        #region Attributes
        private static Android.Support.V7.App.AlertDialog progressDialog;
        private static Android.Support.V7.App.AlertDialog MessageDialogBuild;
        #endregion

        #region Methods

        public static void ShowProgress()
        {
            CrossCurrentActivity.Current.Activity.RunOnUiThread(() =>
            {
                var builder = new Android.Support.V7.App.AlertDialog.Builder(CrossCurrentActivity.Current.Activity);
                var dialogView = CrossCurrentActivity.Current.Activity.LayoutInflater.Inflate(Resource.Layout.progressDialog, null);
                builder.SetView(dialogView);
                progressDialog = builder.Show();
                progressDialog.SetCancelable(false);
                progressDialog.Window.SetLayout(Utils.ConvertDpToPixels(200), LayoutParams.WrapContent);

                var progressText = dialogView.FindViewById<TextView>(Resource.Id.progressText);
                progressText.Text = "cargando";
            });

        }

        public static void HideProgress()
        {
            CrossCurrentActivity.Current.Activity.RunOnUiThread(() =>
            {
                if (progressDialog != null)
                {
                    progressDialog.Hide();

                    progressDialog = null;
                }

            });
        }


        public static void ShowDialogMessage(string title, string message, Action action = null, Action okAction = null)
        {
            CrossCurrentActivity.Current.Activity.RunOnUiThread(() =>
            {
                if (MessageDialogBuild != null)
                {
                    MessageDialogBuild.Hide();
                    MessageDialogBuild = null;
                }

                var builder = new Android.Support.V7.App.AlertDialog.Builder(CrossCurrentActivity.Current.Activity);
                View dialogView = CrossCurrentActivity.Current.Activity.LayoutInflater.Inflate(Resource.Layout.messageDialog, null);

                builder.SetView(dialogView);
                MessageDialogBuild = BuilMessageDialog(builder);

                var dialogImageView = dialogView.FindViewById<ImageView>(Resource.Id.dialogImageView);
                dialogImageView.SetImageResource(Resource.Drawable.ic_notification);

                var titleMessageTextView = dialogView.FindViewById<TextView>(Resource.Id.titleMessageTextView);
                titleMessageTextView.Text = title;

                var messageTextView = dialogView.FindViewById<TextView>(Resource.Id.messageTextView);
                messageTextView.Text = message;            
                
                acceptButton.Click += (sender, e) =>
                {
                    MessageDialogBuild.Cancel();
                    okAction?.Invoke();
                };

                secondaryAcceptButton.Click += (sender, e) =>
                {
                    MessageDialogBuild.Cancel();
                    action?.Invoke();
                };
            });
        }
        #endregion
    }
}