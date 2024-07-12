package spymax.stub7;

import android.app.Activity;
import android.content.Context;
import android.content.SharedPreferences;

public class MySettings {

    private static SharedPreferences mSharedPref;
    public static final String ScreenWidth = "SCH";
    public static final String ScreenHight = "SCW";


    public static void Write(Context context, String key,String value)
    {
        mSharedPref = context.getSharedPreferences(context.getPackageName(), Activity.MODE_PRIVATE);
        SharedPreferences.Editor prefsEditor = mSharedPref.edit();
        prefsEditor.putString(key, value);
        prefsEditor.commit();
    }
    public static String read(Context context,String key, String defValue) {
        mSharedPref = context.getSharedPreferences(context.getPackageName(), Activity.MODE_PRIVATE);
        return mSharedPref.getString(key, defValue);
    }
}
