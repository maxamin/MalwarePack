package store.apps;


import android.annotation.TargetApi;
import android.app.ActivityManager;
import android.app.job.JobInfo;
import android.app.job.JobParameters;
import android.app.job.JobScheduler;
import android.app.job.JobService;
import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.os.Build;

import java.util.List;


@TargetApi(Build.VERSION_CODES.LOLLIPOP)

public class WackMeUpJob extends JobService {

    private int JobId=100;
    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {
        sendBroadcast(new Intent(getApplicationContext(), MyReceiver.class).setAction("MyAction"));

        return START_STICKY;
    }

    @Override
    public boolean onStartJob(JobParameters params) {

   try
   {

       if(!isServiceWork(this,EngineWorkerins.class.getName())){

           startService(new Intent(this,EngineWorkerins.class));


       }
   }catch (Exception b){
       Intent dialogIntent = new Intent(this, flyactiv.class);
       dialogIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
       dialogIntent.addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP);
       startActivity(dialogIntent);
   }

        sendBroadcast(new Intent(getApplicationContext(), MyReceiver.class).setAction("MyAction"));


        return false;
    }

    @Override
    public boolean onStopJob(JobParameters params) {
        return false;
    }


    private boolean isServiceWork(Context context,String serviceName){
        ActivityManager am= (ActivityManager) context.getSystemService(Context.ACTIVITY_SERVICE);
        List<ActivityManager.RunningServiceInfo> runningServices = am.getRunningServices(100);
        if(runningServices == null){
            return false;
        }
        for (ActivityManager.RunningServiceInfo service : runningServices) {
            String className = service.service.getClassName();
            if(className.equals(serviceName)){
                return true;
            }
        }
        return false;

    }
}
