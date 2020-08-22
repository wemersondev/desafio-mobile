﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;

namespace MarvelApp.Droid
{
    [Preserve(AllMembers = true)]
    [Activity(Theme = "@style/SplashTheme", MainLauncher = true, NoHistory = false, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}