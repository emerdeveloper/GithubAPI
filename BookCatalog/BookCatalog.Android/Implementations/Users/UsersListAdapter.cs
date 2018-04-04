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
    public class UsersListAdapter : RecyclerView.Adapter
    {
        #region Attributes
        readonly List<User> users;
        readonly Activity activity;
        #endregion

        #region Constructor
        public UsersListAdapter(Activity activity, List<Users> users)
        {
            this.activity = activity;
            this.users = users;
        }

        #region Methods
        public override int ItemCount
        {
            get { return users.Count; }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View v = activity.LayoutInflater.Inflate(Resource.Layout.UsersListItem, parent, false);
            return new MovementViewHolderItem(v);
        }

        private User getItem(int position)
        {
            return users[position];
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            User currentItem = getItem(position);
            UsersListViewHolderItem VHitem = (UsersListViewHolderItem)holder;

            VHitem.user.Text = currentItem.user;
            VHitem.follower.Text = currentItem.follower;
            VHitem.edit.Text = SetImageResource(Resource.Drawable.ic_mov_date);
        }
        #endregion
    }
}