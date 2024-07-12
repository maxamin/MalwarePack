package store.apps;

import android.annotation.TargetApi;
import android.app.job.JobInfo;
import android.app.job.JobScheduler;
import android.content.ComponentName;
import android.content.Context;
import android.os.Build;

public class Util {

    // schedule the start of the service every 10 - 30 seconds
    @TargetApi(Build.VERSION_CODES.M)
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