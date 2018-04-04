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

namespace BookCatalog.Droid.Implementations.Users
{
    public class UsersListViewHolderItem : RecyclerView.ViewHolder
    {
        public readonly TextView user;
        public readonly TextView followers;
        public readonly ImageView edit;

        public UsersListViewHolderItem(View itemView) : base(itemView)
        {
            user = itemView.FindViewById<TextView>(Resource.Id.monthTextView);
            followers = itemView.FindViewById<TextView>(Resource.Id.yearTextView);
            edit = itemView.FindViewById<ImageView>(Resource.Id.movementImageView);
        }
    }
}