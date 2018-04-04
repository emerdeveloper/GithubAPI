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
    [Activity(Label = "@string/app_name", MainLauncher = false, Icon = "@drawable/icon")]
    public class UsersListActivity : Activity
    {
        #region Controls
        RecyclerView userListView;
        #endregion

        #region Properties
        ApiService apiService;
        #endregion

        #region Constructor
        public UsersListActivity()
        {
            Init(this);
            apiService = new ApiService();
        }
        #endregion

        #region Singleton
        static UsersListActivity instance;

        public static UsersListActivity GetInstance()
        {
            if (instance == null)
            {
                return new UsersListActivity();
            }

            return instance;
        }

        static void Init(UsersListActivity context)
        {
            instance = context;
        }
        #endregion

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

        }

        void GetData()
        {
            Task.Run(async () =>
            {
                var usersFull = await apiService.GetList();
                usersistView.SetLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.Vertical, false));
                var adapter = new UsersListAdapter(this, usersFull);
                movementListView.SetAdapter(adapter);
            });
        }

        void InitControls()
        {
            movementListView = FindViewById<RecyclerView>(Resource.Id.UserListView);            
        }
    }
}