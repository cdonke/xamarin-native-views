package com.microsoft.premier.AndroidDummyApp.Behaviors;

import android.app.Activity;
import android.content.res.Resources;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import com.microsoft.premier.AndroidDummyAppBehaviors.R;

public class MainActivityBehavior {
    private Activity _activity;

    private Button button_increment;
    private TextView counter_label;

    public MainActivityBehavior(Activity activity) {
        _activity = activity;
        counter_label = _activity.findViewById(R.id.counter_label);
        button_increment = _activity.findViewById(R.id.button_increment_counter);

        button_increment.setOnClickListener(mButtonListener);
    }

    /*public void SetupInterface(TextView label, Button button){
        counter_label = label;
        button.setOnClickListener(mButtonListener);
    }*/

    /*public void SetupInterface(Integer R_id_label, Integer R_id_button){
        counter_label = _activity.findViewById(R_id_label);

        button_increment = _activity.findViewById(R_id_button);
        button_increment.setOnClickListener(mButtonListener);
    }*/

    private View.OnClickListener mButtonListener = new View.OnClickListener() {
        public void onClick(View v) {
            Integer n = Integer.parseInt((String)counter_label.getText());
            ++n;
            counter_label.setText(n.toString());
        }
    };
}

