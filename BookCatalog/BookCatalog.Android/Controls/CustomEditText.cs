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

namespace BookCatalog.Droid.Controls
{
    public class CustomEditText : LinearLayout
    {
        #region Controls
        TextInputLayout textLayoutCustom;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="T:AppFilialesExterior.Droid.Controls.CustomEditText"/> class.
        /// </summary>
        /// <param name="context">the context activity.</param>
        public CustomEditText(Context context) : base(context)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:AppFilialesExterior.Droid.Controls.CustomEditText"/> class.
        /// </summary>
        /// <param name="context">the context activity.</param>
        /// <param name="attrs">the attributes</param>
        public CustomEditText(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            this.Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:AppFilialesExterior.Droid.Controls.CustomEditText"/> class.
        /// </summary>
        /// <param name="context">the context activity.</param>
        /// <param name="attrs">the attributes</param>
        /// <param name="defStyle">the definition styles</param>
        public CustomEditText(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
        {
            this.Initialize();
        }
        #endregion


        #region Methods
        private void Initialize()
        {
            this.InflateLayout();
        }

        /// <summary>
        /// initialize the controls or widgets, bind them with the view
        /// </summary>
        private void InflateLayout()
        {
            var inflater = LayoutInflater.FromContext(this.Context);
            inflater.Inflate(Resource.Layout.custom_edittext, this);

            this.textLayoutCustom = this.FindViewById<TextInputLayout>(Resource.Id.textLayoutCustom);
        }
        #endregion
    }
}